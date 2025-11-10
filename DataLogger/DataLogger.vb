Option Strict On
Option Explicit On
Option Compare Text
'Rudy Earnest
'RCET 3371
'Fall 2025
'Data Logger Application
'https://github.com/rc-earnest/DataLogger.git
Imports System.IO.Ports

Public Class DataLogger
    Dim dataQueue As New Queue(Of Integer)
    Dim dateQueue As New Queue(Of DateTime)
    Dim highQueue As New Queue(Of Integer)
    Dim lowQueue As New Queue(Of Integer)
    Dim high As Integer
    Dim low As Integer

    'Subs---------------------------------------------------------------------------------------------------------------
    'sub to open the serial com port
    Sub OpenComPort()
        Try
            If Not DataLoggerComPort.IsOpen Then
                DataLoggerComPort.BaudRate = 19200
                DataLoggerComPort.Parity = Parity.None
                DataLoggerComPort.DataBits = 8
                DataLoggerComPort.StopBits = StopBits.One
                DataLoggerComPort.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error opening COM port: " & ex.Message, "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'sub to connect to the serial com port
    Sub SetPortName()
        Dim portNames() As String
        'get available com ports
        Try
            portNames = SerialPort.GetPortNames()
            If portNames.Length = 1 Then
                DataLoggerComPort.PortName = portNames(0)
            ElseIf portNames.Length > 1 Then
                'prompt user to select a com port
                For Each port In portNames
                    SelectComPortForm.SelectComPortComboBox.Items.Add(port)
                Next
                SelectComPortForm.SelectComPortComboBox.SelectedIndex = 0
                SelectComPortForm.ShowDialog()
                If SelectComPortForm.DialogResult = DialogResult.OK Then
                    DataLoggerComPort.PortName = SelectComPortForm.SelectComPortComboBox.SelectedItem.ToString()
                End If
            Else
                MessageBox.Show("No COM ports available. Please connect a device and try again.", "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error accessing COM ports: " & ex.Message, "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub SetTimerRate()
        Dim sampleRate As Integer
        sampleRate = SampleRateComboBox.SelectedIndex
        Select Case sampleRate
            Case 0
                SampleRateTimer.Interval = 600000 '10 minutes
            Case 1
                SampleRateTimer.Interval = 300000 '5 minutes
            Case 2
                SampleRateTimer.Interval = 60000 '1 minute
            Case 3
                SampleRateTimer.Interval = 30000 '30 seconds
            Case 4
                SampleRateTimer.Interval = 10000 '10 seconds
            Case 5
                SampleRateTimer.Interval = 5000 '5 seconds
            Case 6
                SampleRateTimer.Interval = 1000 '1 second
            Case 7
                SampleRateTimer.Interval = 500 '500 milliseconds
            Case 8
                SampleRateTimer.Interval = 200 '200 milliseconds
            Case 9
                SampleRateTimer.Interval = 100 '100 milliseconds
        End Select
    End Sub


    Sub GetData()
        Dim data(0) As Byte
        Dim readData As Integer
        data(0) = &H51
        DataLoggerComPort.Write(data, 0, 1)
        high = DataLoggerComPort.ReadByte()
        low = DataLoggerComPort.ReadByte()
        DataLoggerComPort.DiscardInBuffer()
        Me.dateQueue.Enqueue(DateTime.Now)
        Me.highQueue.Enqueue(high)
        Me.lowQueue.Enqueue(low)
        If Me.dataQueue.Count >= 100 Then
            Me.dataQueue.Dequeue()
        End If
        high = high << 2
        low = low >> 6
        readData = CType(high + low, Integer)
        Me.dataQueue.Enqueue(readData)
    End Sub

    Sub GraphData()
        Dim g As Graphics = DataDisplayPictureBox.CreateGraphics()
        Dim pen As New Pen(Color.Lime)
        Dim eraser As New Pen(Color.Black)
        Dim totalPoints% = Math.Max(1, Me.dataQueue.Count)
        Dim scaleX! = CType(DataDisplayPictureBox.Width / totalPoints, Single)
        Dim scaleY! = CType((DataDisplayPictureBox.Height / 1023) * -1, Single)
        g.TranslateTransform(0, DataDisplayPictureBox.Height)
        g.ScaleTransform(scaleX, scaleY)
        pen.Width = 0.25
        Dim oldY% = 0
        Dim x = 0
        DataDisplayPictureBox.Refresh()
        If FullDataRadioButton.Checked Then
            ' Full data: iterate oldest->newest left-to-right.
            Dim dataArray() As Integer = Me.dataQueue.ToArray()
            If dataArray.Length > 0 Then
                ' Initialize previous point from the first sample so we do not draw from origin.
                oldY = dataArray(0)
                x = 0
                ' Draw segments between consecutive points (start at second sample).
                For i% = 1 To dataArray.Length - 1
                    x += 1
                    g.DrawLine(eraser, x, 0, x, 1023)
                    g.DrawLine(pen, x - 1, oldY, x, dataArray(i))
                    oldY = dataArray(i)
                Next
            End If
        ElseIf Last30sRadioButton.Checked Then
            ' Show only the most recent points, plotted left-to-right (oldest->newest).
            Dim pointsToShow% = CInt(30000 / SampleRateTimer.Interval)
            Dim dataArray() As Integer = Me.dataQueue.ToArray()
            Dim startIndex% = Math.Max(0, (dataArray.Length - pointsToShow) - 1)
            Dim sliceLength% = Math.Max(1, dataArray.Length - startIndex)

            ' Recompute horizontal scale to match number of shown points.
            g.ResetTransform()
            g.TranslateTransform(0, DataDisplayPictureBox.Height)
            g.ScaleTransform(CType(DataDisplayPictureBox.Width / sliceLength, Single), scaleY)

            If sliceLength > 0 Then
                ' Initialize previous point from the first shown sample so we do not draw from origin.
                oldY = dataArray(startIndex)
                x = 0
                ' Draw segments starting at the second shown sample.
                For i% = 1 To sliceLength - 1
                    Dim value% = dataArray(startIndex + i)
                    x += 1
                    g.DrawLine(eraser, x, 0, x, 1023)
                    g.DrawLine(pen, x - 1, oldY, x, value)
                    oldY = value
                Next
            End If
        End If
        g.Dispose()
        pen.Dispose()
        eraser.Dispose()
    End Sub

    Sub LogData(high%, low%)
        Dim filePath As String = $"..\..\VBDataLog_{DateTime.Now.ToString("yyMMddhh")}.log"
        FilePathStatusLabel.Text = $"File Path Status: ..\..\VBDataLog_{DateTime.Now.ToString("yyMMddhh")}.log"
        FileOpen(1, filePath, OpenMode.Append)
        Do Until highQueue.Count = 0
            Write(1, "$$AN1")
            Write(1, highQueue.Dequeue)
            Write(1, lowQueue.Dequeue)
            Write(1, dateQueue.Dequeue.ToString("yy/MM/dd HH:mm:ss:fff"))
        Loop
        FileClose(1)
    End Sub

    Sub DisposeOfQueues()
        dataQueue.Clear()
        dateQueue.Clear()
        highQueue.Clear()
        lowQueue.Clear()
    End Sub

    Sub SelectFileThenDisplay()
        Dim userChoice As DialogResult
        Dim fileNumber% = FreeFile()
        Dim currentRecord$
        Dim temp() As String
        Dim highAdd As Integer = 1
        Dim lowAdd As Integer = 2
        Dim dateAdd As Integer = 3
        OpenLogFileDialog.FileName = ""
        OpenLogFileDialog.Filter = "logfile (*.log)|*.log"
        userChoice = OpenLogFileDialog.ShowDialog()
        If userChoice = DialogResult.OK Then
            Try
                FileOpen(fileNumber, OpenLogFileDialog.FileName, OpenMode.Input)
                DataDisplayPictureBox.Refresh()
                Do Until EOF(fileNumber)
                    currentRecord = LineInput(fileNumber)
                    temp = Split(currentRecord, ",")
                    'Assuming the log file format is consistent and valid
                    Do Until lowAdd >= temp.Length
                        Dim loggedHigh% = CInt(temp(highAdd))
                        Dim loggedLow% = CInt(temp(lowAdd))
                        'Process loggedHigh and loggedLow as needed for display
                        loggedHigh = loggedHigh << 2
                        loggedLow = loggedLow >> 6
                        Me.dataQueue.Enqueue(CType(loggedHigh + loggedLow, Integer))
                        highAdd += 4
                        lowAdd += 4
                        dateAdd += 4
                    Loop
                Loop
                FileClose(fileNumber)
            Catch ex As Exception
                MessageBox.Show("Error reading log file: " & ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    'Functions----------------------------------------------------------------------------------------------------------

    'Event Handlers-----------------------------------------------------------------------------------------------------

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click, StartRightClickMenuStrip.Click, StartTopMenuStrip.Click
        Try
            DisposeOfQueues()
            SetPortName()
            OpenComPort()
            SetTimerRate()
            ComPortStatusLabel.Text = "Com Port Status: Connected"
            SampleRateTimer.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error connecting to COM port: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataLogger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub SampleRateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SampleRateComboBox.SelectedIndexChanged
        'Update sampling rate status label
        SamplingRateStatusLabel.Text = $"Sampling Rate: {SampleRateComboBox.SelectedItem.ToString()}"
    End Sub

    Private Sub SampleRateTimer_Tick(sender As Object, e As EventArgs) Handles SampleRateTimer.Tick
        GetData()
        GraphData()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click, StopRightClickMenuStrip.Click, StopTopMenuStrip.Click
        SampleRateTimer.Enabled = False
        DataLoggerComPort.Close()
        ComPortStatusLabel.Text = "Com Port Status: Disconnected"
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click, SaveRightClickMenuStrip.Click, SaveTopMenuStrip.Click
        LogData(high, low)
        DataDisplayPictureBox.Refresh()
    End Sub

    Private Sub OpenTopMenuStrip_Click(sender As Object, e As EventArgs) Handles OpenTopMenuStrip.Click, OpenRightClickMenuStrip.Click
        'open file dialog to select a log file
        DisposeOfQueues()
        FullDataRadioButton.Checked = True
        SelectFileThenDisplay()
        GraphData()
    End Sub

    Private Sub FullDataRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FullDataRadioButton.CheckedChanged, Last30sRadioButton.CheckedChanged
        GraphData()
    End Sub
End Class
