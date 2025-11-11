Option Strict On
Option Explicit On
Option Compare Text
' Rudy Earnest
' RCET 3371
' Fall 2025
' Data Logger Application
' https://github.com/rc-earnest/DataLogger.git
Imports System.IO.Ports

Public Class DataLogger
    ' Circular buffers / queues that hold the most recent samples and metadata.
    ' Keep DateTime values in a queue so selection by timestamp is possible.
    Dim dataQueue As New Queue(Of Integer)        ' ADC / computed sample values
    Dim dateQueue As New Queue(Of DateTime)      ' Capture timestamps for each sample
    Dim highQueue As New Queue(Of Integer)       ' Raw "high" bytes for logging
    Dim lowQueue As New Queue(Of Integer)        ' Raw "low" bytes for logging
    Dim high As Integer                          ' temporary storage for incoming "high" byte
    Dim low As Integer                           ' temporary storage for incoming "low" byte

    ' Subs ---------------------------------------------------------------------------------------------------------------
    ' OpenComPort: configure and open the serial port safely
    Sub OpenComPort()
        Try
            If Not DataLoggerComPort.IsOpen Then
                ' Standard serial settings for the external device
                DataLoggerComPort.BaudRate = 19200
                DataLoggerComPort.Parity = Parity.None
                DataLoggerComPort.DataBits = 8
                DataLoggerComPort.StopBits = StopBits.One
                DataLoggerComPort.Open()
            End If
        Catch ex As Exception
            ' Show a user-facing error; do not throw from UI handler
            MessageBox.Show("Error opening COM port: " & ex.Message, "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' SetPortName: choose or prompt for a COM port if multiple are present
    Sub SetPortName()
        Try
            ' Get current snapshot of system COM ports
            Dim portNames() As String = SerialPort.GetPortNames()

            ' Clear the UI list so we don't accumulate duplicates
            SelectComPortForm.SelectComPortComboBox.Items.Clear()

            If portNames.Length = 0 Then
                MessageBox.Show("No COM ports available. Please connect a device and try again.", "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Sort and add each port once
            Array.Sort(portNames)
            For Each port In portNames
                If Not SelectComPortForm.SelectComPortComboBox.Items.Contains(port) Then
                    SelectComPortForm.SelectComPortComboBox.Items.Add(port)
                End If
            Next

            ' If only one port, set it immediately; otherwise prompt selection
            If SelectComPortForm.SelectComPortComboBox.Items.Count = 1 Then
                DataLoggerComPort.PortName = SelectComPortForm.SelectComPortComboBox.Items(0).ToString()
            Else
                SelectComPortForm.SelectComPortComboBox.SelectedIndex = 0
                SelectComPortForm.ShowDialog()
                If SelectComPortForm.DialogResult = DialogResult.OK AndAlso SelectComPortForm.SelectComPortComboBox.SelectedItem IsNot Nothing Then
                    DataLoggerComPort.PortName = SelectComPortForm.SelectComPortComboBox.SelectedItem.ToString()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error accessing COM ports: " & ex.Message, "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' SetTimerRate: map UI selection to the Timer Interval (milliseconds)
    Sub SetTimerRate()
        Dim sampleRate As Integer
        sampleRate = SampleRateComboBox.SelectedIndex
        Select Case sampleRate
            Case 0
                SampleRateTimer.Interval = 600000 ' 10 minutes
            Case 1
                SampleRateTimer.Interval = 300000 ' 5 minutes
            Case 2
                SampleRateTimer.Interval = 60000  ' 1 minute
            Case 3
                SampleRateTimer.Interval = 30000  ' 30 seconds
            Case 4
                SampleRateTimer.Interval = 10000  ' 10 seconds
            Case 5
                SampleRateTimer.Interval = 5000   ' 5 seconds
            Case 6
                SampleRateTimer.Interval = 1000   ' 1 second
            Case 7
                SampleRateTimer.Interval = 500    ' 500 milliseconds
            Case 8
                SampleRateTimer.Interval = 200    ' 200 milliseconds
            Case 9
                SampleRateTimer.Interval = 100    ' 100 milliseconds
        End Select
    End Sub


    ' GetData: poll the serial device and enqueue a timestamped sample
    Sub GetData()
        ' Send request and read two bytes back from the device
        Dim data(0) As Byte
        Dim readData As Integer
        data(0) = &H51
        DataLoggerComPort.Write(data, 0, 1)
        high = DataLoggerComPort.ReadByte()
        low = DataLoggerComPort.ReadByte()
        DataLoggerComPort.DiscardInBuffer()

        ' Enqueue timestamp and raw bytes for later logging / display
        Me.dateQueue.Enqueue(DateTime.Now)
        Me.highQueue.Enqueue(high)
        Me.lowQueue.Enqueue(low)

        ' Convert raw bytes into one integer sample value (device-specific bit packing)
        high = high << 2
        low = low >> 6
        readData = CType(high + low, Integer)

        ' Enqueue the computed sample
        Me.dataQueue.Enqueue(readData)
    End Sub

    ' GraphData: primary rendering routine for the picture box.
    ' - FullDataRadioButton: plot every stored point in dataQueue (chronological left->right)
    ' - Last30sRadioButton: prefer selecting samples by timestamp from dateQueue (robust to missed ticks).
    ' This method always computes horizontal scaling from the actual number of plotted points
    ' and initializes the previous Y value from the first shown sample to avoid drawing from the origin.
    Sub GraphData()
        Dim g As Graphics = DataDisplayPictureBox.CreateGraphics()
        Dim pen As New Pen(Color.Lime)
        Dim eraser As New Pen(Color.Black)

        ' Refresh the control background before drawing
        DataDisplayPictureBox.Refresh()

        ' Convert queues to arrays so we can index and compute slice lengths easily
        Dim dataArray() As Integer = Me.dataQueue.ToArray()
        Dim dateArray() As DateTime = Me.dateQueue.ToArray()

        ' Nothing to draw
        If dataArray.Length = 0 Then
            g.Dispose()
            pen.Dispose()
            eraser.Dispose()
            Return
        End If

        Dim startIndex As Integer = 0
        Dim sliceLength As Integer = dataArray.Length

        If Last30sRadioButton.Checked Then
            ' Determine the "last" timestamp (use file playback or live capture last sample)
            Dim lastTimestamp As DateTime = dateArray(dateArray.Length - 1)

            ' Infer the sampling interval from recent timestamps (use up to last 10 deltas)
            Dim intervalMs As Double = CDbl(SampleRateTimer.Interval) ' fallback
            If dateArray.Length >= 2 Then
                Dim deltasSum As Double = 0.0
                Dim deltasCount As Integer = 0
                Dim maxDeltas As Integer = Math.Min(10, dateArray.Length - 1)
                For i As Integer = dateArray.Length - 1 To dateArray.Length - maxDeltas Step -1
                    Dim prev = dateArray(i - 1)
                    Dim d = (dateArray(i) - prev).TotalMilliseconds
                    If d > 0 Then
                        deltasSum += d
                        deltasCount += 1
                    End If
                Next
                If deltasCount > 0 Then
                    intervalMs = deltasSum / deltasCount
                End If
            End If

            ' Compute how many points approximate 30 seconds given the inferred interval
            Dim pointsToShow As Integer = Math.Max(1, CInt(Math.Ceiling(30000.0 / intervalMs)))

            ' Prefer exact timestamp selection relative to the last captured sample:
            Dim windowStart As DateTime = lastTimestamp.AddMilliseconds(-30000)
            Dim foundTimestampIndex As Integer = -1
            For i As Integer = 0 To dateArray.Length - 1
                If dateArray(i) >= windowStart Then
                    foundTimestampIndex = i
                    Exit For
                End If
            Next

            If foundTimestampIndex <> -1 Then
                ' Use the first sample inside the 30s window based on the last timestamp
                startIndex = foundTimestampIndex
                sliceLength = dataArray.Length - startIndex
            Else
                ' Fallback: use the interval-derived count (last N samples)
                startIndex = Math.Max(0, dataArray.Length - pointsToShow)
                sliceLength = dataArray.Length - startIndex
            End If
        Else
            ' Full-data mode: show entire queue
            startIndex = 0
            sliceLength = dataArray.Length
        End If

        ' Ensure at least one sample shown
        sliceLength = Math.Max(1, sliceLength)

        ' Compute scales based on the actual number of points being shown.
        Dim scaleX! = CType(DataDisplayPictureBox.Width / sliceLength, Single)
        Dim scaleY! = CType((DataDisplayPictureBox.Height / 1023) * -1, Single) ' invert Y

        ' Reset and apply transforms so x spans 0..sliceLength-1 across the control
        g.ResetTransform()
        g.TranslateTransform(0, DataDisplayPictureBox.Height)
        g.ScaleTransform(scaleX, scaleY)

        pen.Width = 0.25

        ' Initialize drawing from the first shown sample so we don't draw from origin
        Dim oldY% = dataArray(startIndex)
        Dim x% = 0

        ' Erase the first vertical column to keep background clean
        g.DrawLine(eraser, x, 0, x, 1023)

        ' Draw line segments between consecutive shown samples
        For i% = 1 To sliceLength - 1
            Dim value% = dataArray(startIndex + i)
            x += 1
            g.DrawLine(eraser, x, 0, x, 1023)
            g.DrawLine(pen, x - 1, oldY, x, value)
            oldY = value
        Next

        g.Dispose()
        pen.Dispose()
        eraser.Dispose()
    End Sub

    ' LogData: append queued raw bytes and timestamps to a log file.
    ' Note: VB 'Write' encloses strings in quotes; the file format must be parsed accordingly.
    Sub LogData(high%, low%)
        Dim filePath As String = $"..\..\VBDataLog_{DateTime.Now.ToString("yyMMddhh")}.log"
        FilePathStatusLabel.Text = $"File Path Status: ..\..\VBDataLog_{DateTime.Now.ToString("yyMMddhh")}.log"
        FileOpen(1, filePath, OpenMode.Append)
        Do Until highQueue.Count = 0
            ' We write a record marker and then raw bytes and timestamp
            Write(1, "$$AN1")
            Write(1, highQueue.Dequeue)
            Write(1, lowQueue.Dequeue)
            Write(1, dateQueue.Dequeue.ToString("yy/MM/dd HH:mm:ss:fff"))
        Loop
        FileClose(1)
    End Sub

    ' DisposeOfQueues: clear all queues to start fresh (used before playback or starting new capture)
    Sub DisposeOfQueues()
        dataQueue.Clear()
        dateQueue.Clear()
        highQueue.Clear()
        lowQueue.Clear()
    End Sub

    ' SelectFileThenDisplay:
    ' - Show an OpenFileDialog filtered to .log files.
    ' - Read each line from the selected log file and parse the records.
    ' - Enqueue parsed samples into dataQueue/dateQueue so GraphData can render them.
    ' Important notes:
    ' - The file was written using VB 'Write', which surrounds strings in quotes.
    ' - We carefully trim and unquote parsed tokens and use TryParse or ParseExact with a specific format.
    Sub SelectFileThenDisplay()
        Dim userChoice As DialogResult
        Dim fileNumber% = FreeFile()
        Dim currentRecord$
        Dim temp() As String
        Dim lowAdd% = 2
        Dim highAdd% = 1
        Dim dateAdd% = 3

        ' The indexes into each line where Write wrote the fields:
        ' Write(1, "$$AN1") -> token 0
        ' Write(1, high)   -> token 1
        ' Write(1, low)    -> token 2
        ' Write(1, date)   -> token 3  (note: may be quoted)
        OpenLogFileDialog.FileName = ""
        OpenLogFileDialog.Filter = "logfile (*.log)|*.log"
        userChoice = OpenLogFileDialog.ShowDialog()
        If userChoice = DialogResult.OK Then
            Try
                ' Open legacy-style file for reading line-by-line
                FileOpen(fileNumber, OpenLogFileDialog.FileName, OpenMode.Input)
                DataDisplayPictureBox.Refresh()

                ' For each line, split on commas (consistent with VB Write output)
                Do Until EOF(fileNumber)
                    currentRecord = LineInput(fileNumber)
                    temp = Split(currentRecord, ",")

                    ' Defensive: ensure there are at least four tokens for a record marker + 3 fields
                    If temp.Length < 4 Then
                        Continue Do
                    End If
                    Do Until dateAdd >= temp.Length
                        ' Parse the logged fields; trim whitespace and surrounding quotes (Write adds quotes for strings)
                        Dim rawHigh As String = temp(highAdd).Trim()
                        Dim rawLow As String = temp(lowAdd).Trim()
                        Dim rawDate As String = temp(dateAdd).Trim()

                        ' Remove leading/trailing quotes if present (e.g. """25/11/09 08:36:00:461""")
                        If rawDate.Length >= 2 AndAlso rawDate.StartsWith("""") AndAlso rawDate.EndsWith("""") Then
                            rawDate = rawDate.Substring(1, rawDate.Length - 2)
                        End If
                        rawDate = rawDate.Trim()

                        ' Safely parse numeric fields; skip this line if parsing fails
                        Dim loggedHigh% = 0
                        Dim loggedLow% = 0
                        If Not Integer.TryParse(rawHigh, loggedHigh) Then
                            Continue Do
                        End If
                        If Not Integer.TryParse(rawLow, loggedLow) Then
                            Continue Do
                        End If

                        ' Parse timestamp using the exact format used when writing the file.
                        Dim loggedDate As DateTime
                        Dim format As String = "yy/MM/dd HH:mm:ss:fff"
                        Dim culture = System.Globalization.CultureInfo.InvariantCulture
                        If Not DateTime.TryParseExact(rawDate, format, culture, Globalization.DateTimeStyles.None, loggedDate) Then
                            ' If parsing fails, skip this entry. This avoids throwing on malformed lines.
                            Continue Do
                        End If

                        ' Convert the raw high/low bytes into the same sample value the live code uses
                        loggedHigh = loggedHigh << 2
                        loggedLow = loggedLow >> 6
                        Me.dataQueue.Enqueue(CType(loggedHigh + loggedLow, Integer))
                        Me.dateQueue.Enqueue(loggedDate)
                        lowAdd += 4
                        highAdd += 4
                        dateAdd += 4
                    Loop
                Loop

                FileClose(fileNumber)
            Catch ex As Exception
                MessageBox.Show("Error reading log file: " & ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    ' Functions ----------------------------------------------------------------------------------------------------------

    ' Event Handlers -----------------------------------------------------------------------------------------------------

    ' Exit the application
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    ' Start capture: clear previous data, set COM port and timer and enable sampling
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click, StartRightClickMenuStrip.Click, StartTopMenuStrip.Click
        Try
            DisposeOfQueues()   ' start fresh each time user starts
            SetPortName()
            OpenComPort()
            SetTimerRate()
            ComPortStatusLabel.Text = "Com Port Status: Connected"
            SampleRateTimer.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error connecting to COM port: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Initialize UI values on form load
    Private Sub DataLogger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartButton.Focus()
        DataDisplayPictureBox.BackColor = Color.Black
        Dim sampleRate(9) As String
        sampleRate(0) = "10 minutes"
        sampleRate(1) = "5 minutes"
        sampleRate(2) = "1 minute"
        sampleRate(3) = "30 seconds"
        sampleRate(4) = "10 seconds"
        sampleRate(5) = "5 seconds"
        sampleRate(6) = "1 second"
        sampleRate(7) = "500 milliseconds"
        sampleRate(8) = "200 milliseconds"
        sampleRate(9) = "100 milliseconds"
        ComPortStatusLabel.Text = "Com Port Status: Disconnected"
        FilePathStatusLabel.Text = "File Path Status: Not Set"
        For Each sample In sampleRate
            SampleRateComboBox.Items.Add(sample)
        Next
        SampleRateComboBox.SelectedIndex = 7
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString}"
        FullDataRadioButton.Checked = True
    End Sub

    ' Update label when the sample rate selection changes
    Private Sub SampleRateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SampleRateComboBox.SelectedIndexChanged
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
        SetTimerRate()
    End Sub

    ' Periodic timer tick: capture and redraw
    Private Sub SampleRateTimer_Tick(sender As Object, e As EventArgs) Handles SampleRateTimer.Tick
        If DataLoggerComPort.IsOpen = True Then
            GetData()
            GraphData()
        Else
            SampleRateTimer.Enabled = False
            ComPortStatusLabel.Text = "Com Port Status: Disconnected"
            MessageBox.Show("COM port disconnected. Stopping data capture.", "COM Port Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Stop capture and close COM port
    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click, StopRightClickMenuStrip.Click, StopTopMenuStrip.Click
        SampleRateTimer.Enabled = False
        DataLoggerComPort.Close()
        ComPortStatusLabel.Text = "Com Port Status: Disconnected"
    End Sub

    ' Save currently queued samples to disk
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click, SaveRightClickMenuStrip.Click, SaveTopMenuStrip.Click
        LogData(high, low)
        DataDisplayPictureBox.Refresh()
    End Sub

    ' Open menu handler: clear queues and load file for display, then draw
    Private Sub OpenTopMenuStrip_Click(sender As Object, e As EventArgs) Handles OpenTopMenuStrip.Click, OpenRightClickMenuStrip.Click
        DisposeOfQueues()
        FullDataRadioButton.Checked = True
        SelectFileThenDisplay()
        GraphData()
    End Sub

    ' When radio buttons change, redraw with the selected mode
    Private Sub FullDataRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FullDataRadioButton.CheckedChanged, Last30sRadioButton.CheckedChanged
        GraphData()
    End Sub

    ' Menu handlers: set the sample rate top-menu items and sync the combo box + timer.
    ' Each handler sets the ComboBox selected index, updates the timer, and refreshes the status label.

    Private Sub SampleRate10MinutesTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Min10TopMenuStrip.Click, Min10RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 0
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRate5MinutesTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Min5TopMenuStrip.Click, Min5RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 1
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRate1MinuteTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Min1TopMenuStrip.Click, Min1RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 2
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRate30SecondsTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Sec30TopMenuStrip.Click, Sec30RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 3
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRate10SecondsTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Sec10TopMenuStrip.Click, Sec10RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 4
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRate5SecondsTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Sec5TopMenuStrip.Click, Sec5RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 5
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRate1SecondTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Sec1TopMenuStrip.Click, Sec1RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 6
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRate500MsTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Ms500TopMenuStrip.Click, Ms500RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 7
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRate200MsTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Ms200TopMenuStrip.Click, Ms200RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 8
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRate100MsTopMenuStrip_Click(sender As Object, e As EventArgs) Handles Ms100TopMenuStrip.Click, Ms100RightClickMenuStrip.Click
        SampleRateComboBox.SelectedIndex = 9
        SetTimerRate()
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub DisplayFullDataTopMenuStrip_Click(sender As Object, e As EventArgs) Handles DisplayFullDataTopMenuStrip.Click, DisplayFullDataRightClickMenuStrip.Click
        FullDataRadioButton.Checked = True
    End Sub

    Private Sub DisplayLast30sTopMenuStrip_Click(sender As Object, e As EventArgs) Handles DisplayLast30sTopMenuStrip.Click, DisplayLast30RightClickMenuStrip.Click
        Last30sRadioButton.Checked = True
    End Sub

End Class
