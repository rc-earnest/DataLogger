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
        Me.RightClickMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SampleRateRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StopButton.Location = New System.Drawing.Point(93, 402)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 1
        Me.StopButton.Text = "St&op"
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
        Me.StartTopMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.StartTopMenuStrip.Text = "Start"
        '
        'StopTopMenuStrip
        '
        Me.StopTopMenuStrip.Name = "StopTopMenuStrip"
        Me.StopTopMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.StopTopMenuStrip.Text = "Stop"
        '
        'SaveTopMenuStrip
        '
        Me.SaveTopMenuStrip.Name = "SaveTopMenuStrip"
        Me.SaveTopMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.SaveTopMenuStrip.Text = "Save"
        '
        'OpenTopMenuStrip
        '
        Me.OpenTopMenuStrip.Name = "OpenTopMenuStrip"
        Me.OpenTopMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.OpenTopMenuStrip.Text = "Open"
        '
        'SettingsTopMenuStrip
        '
        Me.SettingsTopMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleTopMenuStrip})
        Me.SettingsTopMenuStrip.Name = "SettingsTopMenuStrip"
        Me.SettingsTopMenuStrip.Size = New System.Drawing.Size(61, 20)
        Me.SettingsTopMenuStrip.Text = "Settings"
        '
        'SampleTopMenuStrip
        '
        Me.SampleTopMenuStrip.Name = "SampleTopMenuStrip"
        Me.SampleTopMenuStrip.Size = New System.Drawing.Size(139, 22)
        Me.SampleTopMenuStrip.Text = "Sample Rate"
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
        Me.SettingsRightClickMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleRateRightClickMenuStrip})
        Me.SettingsRightClickMenuStrip.Name = "SettingsRightClickMenuStrip"
        Me.SettingsRightClickMenuStrip.Size = New System.Drawing.Size(116, 22)
        Me.SettingsRightClickMenuStrip.Text = "Settings"
        '
        'SampleRateRightClickMenuStrip
        '
        Me.SampleRateRightClickMenuStrip.Name = "SampleRateRightClickMenuStrip"
        Me.SampleRateRightClickMenuStrip.Size = New System.Drawing.Size(139, 22)
        Me.SampleRateRightClickMenuStrip.Text = "Sample Rate"
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
        Me.DataDisplayPictureBox.Location = New System.Drawing.Point(12, 39)
        Me.DataDisplayPictureBox.Name = "DataDisplayPictureBox"
        Me.DataDisplayPictureBox.Size = New System.Drawing.Size(776, 357)
        Me.DataDisplayPictureBox.TabIndex = 6
        Me.DataDisplayPictureBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(713, 402)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SampleRateComboBox
        '
        Me.SampleRateComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SampleRateComboBox.FormattingEnabled = True
        Me.SampleRateComboBox.Location = New System.Drawing.Point(338, 402)
        Me.SampleRateComboBox.Name = "SampleRateComboBox"
        Me.SampleRateComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SampleRateComboBox.TabIndex = 8
        '
        'SampleRateLabel
        '
        Me.SampleRateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SampleRateLabel.AutoSize = True
        Me.SampleRateLabel.Location = New System.Drawing.Point(264, 407)
        Me.SampleRateLabel.Name = "SampleRateLabel"
        Me.SampleRateLabel.Size = New System.Drawing.Size(68, 13)
        Me.SampleRateLabel.TabIndex = 9
        Me.SampleRateLabel.Text = "Sample Rate"
        '
        'SampleRateTimer
        '
        '
        'FullDataRadioButton
        '
        Me.FullDataRadioButton.AutoSize = True
        Me.FullDataRadioButton.Location = New System.Drawing.Point(474, 405)
        Me.FullDataRadioButton.Name = "FullDataRadioButton"
        Me.FullDataRadioButton.Size = New System.Drawing.Size(104, 17)
        Me.FullDataRadioButton.TabIndex = 10
        Me.FullDataRadioButton.TabStop = True
        Me.FullDataRadioButton.Text = "Display Full Data"
        Me.FullDataRadioButton.UseVisualStyleBackColor = True
        '
        'Last30sRadioButton
        '
        Me.Last30sRadioButton.AutoSize = True
        Me.Last30sRadioButton.Location = New System.Drawing.Point(584, 405)
        Me.Last30sRadioButton.Name = "Last30sRadioButton"
        Me.Last30sRadioButton.Size = New System.Drawing.Size(102, 17)
        Me.Last30sRadioButton.TabIndex = 11
        Me.Last30sRadioButton.TabStop = True
        Me.Last30sRadioButton.Text = "Display Last 30s"
        Me.Last30sRadioButton.UseVisualStyleBackColor = True
        '
        'OpenLogFileDialog
        '
        Me.OpenLogFileDialog.FileName = "OpenFileDialog1"
        '
        'DataLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.RightClickMenuStrip
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
End Class
