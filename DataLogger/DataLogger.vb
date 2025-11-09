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
    'Subs---------------------------------------------------------------------------------------------------------------
    'sub to open the serial com port
    Sub OpenComPort()
        Try
            If Not DataLoggerComPort.IsOpen Then
                DataLoggerComPort.BaudRate = 9600
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


    'Functions----------------------------------------------------------------------------------------------------------



    'Event Handlers-----------------------------------------------------------------------------------------------------

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Try
            SetPortName()
            OpenComPort()
            ComPortStatusLabel.Text = "Com Port Status: Connected"
        Catch ex As Exception
            MessageBox.Show("Error connecting to COM port: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataLogger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComPortStatusLabel.Text = "Com Port Status: Disconnected"
        FilePathStatusLabel.Text = "File Path Status: Not Set"
        SamplingRateStatusLabel.Text = "Sampling Rate: Not Set"
    End Sub
End Class
