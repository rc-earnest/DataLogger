<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataLogger
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SampleTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Min10TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Min5TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Min1TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sec30TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sec10TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sec5TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sec1TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms500TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms200TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms100TopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayDataTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayFullDataTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayLast30sTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightClickMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SampleRateRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Min10RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Min5RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Min1RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sec30RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sec10RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sec5RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sec1RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms500RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms200RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms100RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayDataRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayFullDataRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayLast30RightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.FilePathStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SamplingRateStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ComPortStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataDisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DataLoggerComPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SampleRateComboBox = New System.Windows.Forms.ComboBox()
        Me.SampleRateLabel = New System.Windows.Forms.Label()
        Me.SampleRateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FullDataRadioButton = New System.Windows.Forms.RadioButton()
        Me.Last30sRadioButton = New System.Windows.Forms.RadioButton()
        Me.OpenLogFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopMenuStrip.SuspendLayout()
        Me.RightClickMenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.DataDisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartButton.Location = New System.Drawing.Point(12, 402)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "&Start"
        Me.ToolTip.SetToolTip(Me.StartButton, "Starts communication and timer on selected sample rate")
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StopButton.Location = New System.Drawing.Point(93, 402)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 1
        Me.StopButton.Text = "Sto&p"
        Me.ToolTip.SetToolTip(Me.StopButton, "Stops timer and disconnects")
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(174, 402)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "S&ave"
        Me.ToolTip.SetToolTip(Me.SaveButton, "Saves current data points to a file")
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuStrip, Me.SettingsTopMenuStrip})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.TopMenuStrip.TabIndex = 3
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuStrip
        '
        Me.FileTopMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartTopMenuStrip, Me.StopTopMenuStrip, Me.SaveTopMenuStrip, Me.OpenTopMenuStrip})
        Me.FileTopMenuStrip.Name = "FileTopMenuStrip"
        Me.FileTopMenuStrip.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuStrip.Text = "File"
        '
        'StartTopMenuStrip
        '
        Me.StartTopMenuStrip.Name = "StartTopMenuStrip"
        Me.StartTopMenuStrip.Size = New System.Drawing.Size(103, 22)
        Me.StartTopMenuStrip.Text = "Start"
        '
        'StopTopMenuStrip
        '
        Me.StopTopMenuStrip.Name = "StopTopMenuStrip"
        Me.StopTopMenuStrip.Size = New System.Drawing.Size(103, 22)
        Me.StopTopMenuStrip.Text = "Stop"
        '
        'SaveTopMenuStrip
        '
        Me.SaveTopMenuStrip.Name = "SaveTopMenuStrip"
        Me.SaveTopMenuStrip.Size = New System.Drawing.Size(103, 22)
        Me.SaveTopMenuStrip.Text = "Save"
        '
        'OpenTopMenuStrip
        '
        Me.OpenTopMenuStrip.Name = "OpenTopMenuStrip"
        Me.OpenTopMenuStrip.Size = New System.Drawing.Size(103, 22)
        Me.OpenTopMenuStrip.Text = "Open"
        '
        'SettingsTopMenuStrip
        '
        Me.SettingsTopMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleTopMenuStrip, Me.DisplayDataTopMenuStrip})
        Me.SettingsTopMenuStrip.Name = "SettingsTopMenuStrip"
        Me.SettingsTopMenuStrip.Size = New System.Drawing.Size(61, 20)
        Me.SettingsTopMenuStrip.Text = "Settings"
        '
        'SampleTopMenuStrip
        '
        Me.SampleTopMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Min10TopMenuStrip, Me.Min5TopMenuStrip, Me.Min1TopMenuStrip, Me.Sec30TopMenuStrip, Me.Sec10TopMenuStrip, Me.Sec5TopMenuStrip, Me.Sec1TopMenuStrip, Me.Ms500TopMenuStrip, Me.Ms200TopMenuStrip, Me.Ms100TopMenuStrip})
        Me.SampleTopMenuStrip.Name = "SampleTopMenuStrip"
        Me.SampleTopMenuStrip.Size = New System.Drawing.Size(139, 22)
        Me.SampleTopMenuStrip.Text = "Sample Rate"
        '
        'Min10TopMenuStrip
        '
        Me.Min10TopMenuStrip.Name = "Min10TopMenuStrip"
        Me.Min10TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Min10TopMenuStrip.Text = "10 min"
        '
        'Min5TopMenuStrip
        '
        Me.Min5TopMenuStrip.Name = "Min5TopMenuStrip"
        Me.Min5TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Min5TopMenuStrip.Text = "5 min"
        '
        'Min1TopMenuStrip
        '
        Me.Min1TopMenuStrip.Name = "Min1TopMenuStrip"
        Me.Min1TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Min1TopMenuStrip.Text = "1 min"
        '
        'Sec30TopMenuStrip
        '
        Me.Sec30TopMenuStrip.Name = "Sec30TopMenuStrip"
        Me.Sec30TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Sec30TopMenuStrip.Text = "30 sec"
        '
        'Sec10TopMenuStrip
        '
        Me.Sec10TopMenuStrip.Name = "Sec10TopMenuStrip"
        Me.Sec10TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Sec10TopMenuStrip.Text = "10 sec"
        '
        'Sec5TopMenuStrip
        '
        Me.Sec5TopMenuStrip.Name = "Sec5TopMenuStrip"
        Me.Sec5TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Sec5TopMenuStrip.Text = "5 sec"
        '
        'Sec1TopMenuStrip
        '
        Me.Sec1TopMenuStrip.Name = "Sec1TopMenuStrip"
        Me.Sec1TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Sec1TopMenuStrip.Text = "1 sec"
        '
        'Ms500TopMenuStrip
        '
        Me.Ms500TopMenuStrip.Name = "Ms500TopMenuStrip"
        Me.Ms500TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Ms500TopMenuStrip.Text = "500 ms"
        '
        'Ms200TopMenuStrip
        '
        Me.Ms200TopMenuStrip.Name = "Ms200TopMenuStrip"
        Me.Ms200TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Ms200TopMenuStrip.Text = "200 ms"
        '
        'Ms100TopMenuStrip
        '
        Me.Ms100TopMenuStrip.Name = "Ms100TopMenuStrip"
        Me.Ms100TopMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Ms100TopMenuStrip.Text = "100 ms"
        '
        'DisplayDataTopMenuStrip
        '
        Me.DisplayDataTopMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayFullDataTopMenuStrip, Me.DisplayLast30sTopMenuStrip})
        Me.DisplayDataTopMenuStrip.Name = "DisplayDataTopMenuStrip"
        Me.DisplayDataTopMenuStrip.Size = New System.Drawing.Size(139, 22)
        Me.DisplayDataTopMenuStrip.Text = "Display Data"
        '
        'DisplayFullDataTopMenuStrip
        '
        Me.DisplayFullDataTopMenuStrip.Name = "DisplayFullDataTopMenuStrip"
        Me.DisplayFullDataTopMenuStrip.Size = New System.Drawing.Size(161, 22)
        Me.DisplayFullDataTopMenuStrip.Text = "Display Full Data"
        '
        'DisplayLast30sTopMenuStrip
        '
        Me.DisplayLast30sTopMenuStrip.Name = "DisplayLast30sTopMenuStrip"
        Me.DisplayLast30sTopMenuStrip.Size = New System.Drawing.Size(161, 22)
        Me.DisplayLast30sTopMenuStrip.Text = "Display Last 30s"
        '
        'RightClickMenuStrip
        '
        Me.RightClickMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileRightClickMenuStrip, Me.SettingsRightClickMenuStrip})
        Me.RightClickMenuStrip.Name = "ContextMenuStrip1"
        Me.RightClickMenuStrip.Size = New System.Drawing.Size(117, 48)
        '
        'FileRightClickMenuStrip
        '
        Me.FileRightClickMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartRightClickMenuStrip, Me.StopRightClickMenuStrip, Me.SaveRightClickMenuStrip, Me.OpenRightClickMenuStrip})
        Me.FileRightClickMenuStrip.Name = "FileRightClickMenuStrip"
        Me.FileRightClickMenuStrip.Size = New System.Drawing.Size(116, 22)
        Me.FileRightClickMenuStrip.Text = "File"
        '
        'StartRightClickMenuStrip
        '
        Me.StartRightClickMenuStrip.Name = "StartRightClickMenuStrip"
        Me.StartRightClickMenuStrip.Size = New System.Drawing.Size(103, 22)
        Me.StartRightClickMenuStrip.Text = "Start"
        '
        'StopRightClickMenuStrip
        '
        Me.StopRightClickMenuStrip.Name = "StopRightClickMenuStrip"
        Me.StopRightClickMenuStrip.Size = New System.Drawing.Size(103, 22)
        Me.StopRightClickMenuStrip.Text = "Stop"
        '
        'SaveRightClickMenuStrip
        '
        Me.SaveRightClickMenuStrip.Name = "SaveRightClickMenuStrip"
        Me.SaveRightClickMenuStrip.Size = New System.Drawing.Size(103, 22)
        Me.SaveRightClickMenuStrip.Text = "Save"
        '
        'OpenRightClickMenuStrip
        '
        Me.OpenRightClickMenuStrip.Name = "OpenRightClickMenuStrip"
        Me.OpenRightClickMenuStrip.Size = New System.Drawing.Size(103, 22)
        Me.OpenRightClickMenuStrip.Text = "Open"
        '
        'SettingsRightClickMenuStrip
        '
        Me.SettingsRightClickMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleRateRightClickMenuStrip, Me.DisplayDataRightClickMenuStrip})
        Me.SettingsRightClickMenuStrip.Name = "SettingsRightClickMenuStrip"
        Me.SettingsRightClickMenuStrip.Size = New System.Drawing.Size(116, 22)
        Me.SettingsRightClickMenuStrip.Text = "Settings"
        '
        'SampleRateRightClickMenuStrip
        '
        Me.SampleRateRightClickMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Min10RightClickMenuStrip, Me.Min5RightClickMenuStrip, Me.Min1RightClickMenuStrip, Me.Sec30RightClickMenuStrip, Me.Sec10RightClickMenuStrip, Me.Sec5RightClickMenuStrip, Me.Sec1RightClickMenuStrip, Me.Ms500RightClickMenuStrip, Me.Ms200RightClickMenuStrip, Me.Ms100RightClickMenuStrip})
        Me.SampleRateRightClickMenuStrip.Name = "SampleRateRightClickMenuStrip"
        Me.SampleRateRightClickMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.SampleRateRightClickMenuStrip.Text = "Sample Rate"
        '
        'Min10RightClickMenuStrip
        '
        Me.Min10RightClickMenuStrip.Name = "Min10RightClickMenuStrip"
        Me.Min10RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Min10RightClickMenuStrip.Text = "10 min"
        '
        'Min5RightClickMenuStrip
        '
        Me.Min5RightClickMenuStrip.Name = "Min5RightClickMenuStrip"
        Me.Min5RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Min5RightClickMenuStrip.Text = "5 min"
        '
        'Min1RightClickMenuStrip
        '
        Me.Min1RightClickMenuStrip.Name = "Min1RightClickMenuStrip"
        Me.Min1RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Min1RightClickMenuStrip.Text = "1 min"
        '
        'Sec30RightClickMenuStrip
        '
        Me.Sec30RightClickMenuStrip.Name = "Sec30RightClickMenuStrip"
        Me.Sec30RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Sec30RightClickMenuStrip.Text = "30 sec"
        '
        'Sec10RightClickMenuStrip
        '
        Me.Sec10RightClickMenuStrip.Name = "Sec10RightClickMenuStrip"
        Me.Sec10RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Sec10RightClickMenuStrip.Text = "10 sec"
        '
        'Sec5RightClickMenuStrip
        '
        Me.Sec5RightClickMenuStrip.Name = "Sec5RightClickMenuStrip"
        Me.Sec5RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Sec5RightClickMenuStrip.Text = "5 sec"
        '
        'Sec1RightClickMenuStrip
        '
        Me.Sec1RightClickMenuStrip.Name = "Sec1RightClickMenuStrip"
        Me.Sec1RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Sec1RightClickMenuStrip.Text = "1 sec"
        '
        'Ms500RightClickMenuStrip
        '
        Me.Ms500RightClickMenuStrip.Name = "Ms500RightClickMenuStrip"
        Me.Ms500RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Ms500RightClickMenuStrip.Text = "500 ms"
        '
        'Ms200RightClickMenuStrip
        '
        Me.Ms200RightClickMenuStrip.Name = "Ms200RightClickMenuStrip"
        Me.Ms200RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Ms200RightClickMenuStrip.Text = "200 ms"
        '
        'Ms100RightClickMenuStrip
        '
        Me.Ms100RightClickMenuStrip.Name = "Ms100RightClickMenuStrip"
        Me.Ms100RightClickMenuStrip.Size = New System.Drawing.Size(111, 22)
        Me.Ms100RightClickMenuStrip.Text = "100 ms"
        '
        'DisplayDataRightClickMenuStrip
        '
        Me.DisplayDataRightClickMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayFullDataRightClickMenuStrip, Me.DisplayLast30RightClickMenuStrip})
        Me.DisplayDataRightClickMenuStrip.Name = "DisplayDataRightClickMenuStrip"
        Me.DisplayDataRightClickMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.DisplayDataRightClickMenuStrip.Text = "Display Data"
        '
        'DisplayFullDataRightClickMenuStrip
        '
        Me.DisplayFullDataRightClickMenuStrip.Name = "DisplayFullDataRightClickMenuStrip"
        Me.DisplayFullDataRightClickMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.DisplayFullDataRightClickMenuStrip.Text = "Display Full Data"
        '
        'DisplayLast30RightClickMenuStrip
        '
        Me.DisplayLast30RightClickMenuStrip.Name = "DisplayLast30RightClickMenuStrip"
        Me.DisplayLast30RightClickMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.DisplayLast30RightClickMenuStrip.Text = "Display Last 30s"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilePathStatusLabel, Me.SamplingRateStatusLabel, Me.ComPortStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip.TabIndex = 5
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'FilePathStatusLabel
        '
        Me.FilePathStatusLabel.Name = "FilePathStatusLabel"
        Me.FilePathStatusLabel.Size = New System.Drawing.Size(52, 17)
        Me.FilePathStatusLabel.Text = "File Path"
        '
        'SamplingRateStatusLabel
        '
        Me.SamplingRateStatusLabel.Name = "SamplingRateStatusLabel"
        Me.SamplingRateStatusLabel.Size = New System.Drawing.Size(83, 17)
        Me.SamplingRateStatusLabel.Text = "Sampling Rate"
        '
        'ComPortStatusLabel
        '
        Me.ComPortStatusLabel.Name = "ComPortStatusLabel"
        Me.ComPortStatusLabel.Size = New System.Drawing.Size(93, 17)
        Me.ComPortStatusLabel.Text = "Com Port Status"
        '
        'DataDisplayPictureBox
        '
        Me.DataDisplayPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataDisplayPictureBox.Location = New System.Drawing.Point(12, 27)
        Me.DataDisplayPictureBox.Name = "DataDisplayPictureBox"
        Me.DataDisplayPictureBox.Size = New System.Drawing.Size(776, 353)
        Me.DataDisplayPictureBox.TabIndex = 6
        Me.DataDisplayPictureBox.TabStop = False
        Me.ToolTip.SetToolTip(Me.DataDisplayPictureBox, "Displays recorded data or data from a file")
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(713, 402)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exits the form")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SampleRateComboBox
        '
        Me.SampleRateComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleRateComboBox.FormattingEnabled = True
        Me.SampleRateComboBox.Location = New System.Drawing.Point(359, 402)
        Me.SampleRateComboBox.Name = "SampleRateComboBox"
        Me.SampleRateComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SampleRateComboBox.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.SampleRateComboBox, "Selects sample rate")
        '
        'SampleRateLabel
        '
        Me.SampleRateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleRateLabel.AutoSize = True
        Me.SampleRateLabel.Location = New System.Drawing.Point(356, 386)
        Me.SampleRateLabel.Name = "SampleRateLabel"
        Me.SampleRateLabel.Size = New System.Drawing.Size(68, 13)
        Me.SampleRateLabel.TabIndex = 8
        Me.SampleRateLabel.Text = "Sample Rate"
        '
        'SampleRateTimer
        '
        '
        'FullDataRadioButton
        '
        Me.FullDataRadioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullDataRadioButton.AutoSize = True
        Me.FullDataRadioButton.Location = New System.Drawing.Point(495, 405)
        Me.FullDataRadioButton.Name = "FullDataRadioButton"
        Me.FullDataRadioButton.Size = New System.Drawing.Size(104, 17)
        Me.FullDataRadioButton.TabIndex = 5
        Me.FullDataRadioButton.TabStop = True
        Me.FullDataRadioButton.Text = "Display Full Data"
        Me.ToolTip.SetToolTip(Me.FullDataRadioButton, "displays all data recorded")
        Me.FullDataRadioButton.UseVisualStyleBackColor = True
        '
        'Last30sRadioButton
        '
        Me.Last30sRadioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Last30sRadioButton.AutoSize = True
        Me.Last30sRadioButton.Location = New System.Drawing.Point(605, 405)
        Me.Last30sRadioButton.Name = "Last30sRadioButton"
        Me.Last30sRadioButton.Size = New System.Drawing.Size(102, 17)
        Me.Last30sRadioButton.TabIndex = 6
        Me.Last30sRadioButton.TabStop = True
        Me.Last30sRadioButton.Text = "Display Last 30s"
        Me.ToolTip.SetToolTip(Me.Last30sRadioButton, "displays the last 30 seconds of data")
        Me.Last30sRadioButton.UseVisualStyleBackColor = True
        '
        'OpenLogFileDialog
        '
        Me.OpenLogFileDialog.FileName = "OpenFileDialog1"
        '
        'OpenButton
        '
        Me.OpenButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OpenButton.Location = New System.Drawing.Point(255, 402)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenButton.TabIndex = 3
        Me.OpenButton.Text = "&Open"
        Me.ToolTip.SetToolTip(Me.OpenButton, "Prompts to open a .log file")
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'DataLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.RightClickMenuStrip
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.Last30sRadioButton)
        Me.Controls.Add(Me.FullDataRadioButton)
        Me.Controls.Add(Me.SampleRateLabel)
        Me.Controls.Add(Me.SampleRateComboBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DataDisplayPictureBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "DataLogger"
        Me.Text = "DataLogger"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.RightClickMenuStrip.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.DataDisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents RightClickMenuStrip As ContextMenuStrip
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents DataDisplayPictureBox As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents FileTopMenuStrip As ToolStripMenuItem
    Friend WithEvents StartTopMenuStrip As ToolStripMenuItem
    Friend WithEvents StopTopMenuStrip As ToolStripMenuItem
    Friend WithEvents SaveTopMenuStrip As ToolStripMenuItem
    Friend WithEvents OpenTopMenuStrip As ToolStripMenuItem
    Friend WithEvents SettingsTopMenuStrip As ToolStripMenuItem
    Friend WithEvents FileRightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents SettingsRightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents SampleTopMenuStrip As ToolStripMenuItem
    Friend WithEvents StartRightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents StopRightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents SaveRightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents OpenRightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents SampleRateRightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents DataLoggerComPort As IO.Ports.SerialPort
    Friend WithEvents FilePathStatusLabel As ToolStripStatusLabel
    Friend WithEvents SamplingRateStatusLabel As ToolStripStatusLabel
    Friend WithEvents ComPortStatusLabel As ToolStripStatusLabel
    Friend WithEvents SampleRateComboBox As ComboBox
    Friend WithEvents SampleRateLabel As Label
    Friend WithEvents SampleRateTimer As Timer
    Friend WithEvents FullDataRadioButton As RadioButton
    Friend WithEvents Last30sRadioButton As RadioButton
    Friend WithEvents OpenLogFileDialog As OpenFileDialog
    Friend WithEvents OpenButton As Button
    Friend WithEvents Min10TopMenuStrip As ToolStripMenuItem
    Friend WithEvents Min5TopMenuStrip As ToolStripMenuItem
    Friend WithEvents Min1TopMenuStrip As ToolStripMenuItem
    Friend WithEvents Sec30TopMenuStrip As ToolStripMenuItem
    Friend WithEvents Sec10TopMenuStrip As ToolStripMenuItem
    Friend WithEvents Sec5TopMenuStrip As ToolStripMenuItem
    Friend WithEvents Sec1TopMenuStrip As ToolStripMenuItem
    Friend WithEvents Ms500TopMenuStrip As ToolStripMenuItem
    Friend WithEvents Ms200TopMenuStrip As ToolStripMenuItem
    Friend WithEvents Ms100TopMenuStrip As ToolStripMenuItem
    Friend WithEvents DisplayDataTopMenuStrip As ToolStripMenuItem
    Friend WithEvents DisplayFullDataTopMenuStrip As ToolStripMenuItem
    Friend WithEvents DisplayLast30sTopMenuStrip As ToolStripMenuItem
    Friend WithEvents Min10RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents Min5RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents Min1RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents Sec30RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents Sec10RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents Sec5RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents Sec1RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents Ms500RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents Ms200RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents Ms100RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents DisplayDataRightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents DisplayFullDataRightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents DisplayLast30RightClickMenuStrip As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
End Class
