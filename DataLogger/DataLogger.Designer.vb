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
        Me.RightClickMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FileTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SampleRateRightClickMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SampleTopMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenuStrip.SuspendLayout()
        Me.RightClickMenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(12, 402)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "&Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(93, 402)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 1
        Me.StopButton.Text = "St&op"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
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
        'RightClickMenuStrip
        '
        Me.RightClickMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileRightClickMenuStrip, Me.SettingsRightClickMenuStrip})
        Me.RightClickMenuStrip.Name = "ContextMenuStrip1"
        Me.RightClickMenuStrip.Size = New System.Drawing.Size(117, 48)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(776, 357)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(713, 402)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FileTopMenuStrip
        '
        Me.FileTopMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartTopMenuStrip, Me.StopTopMenuStrip, Me.SaveTopMenuStrip, Me.OpenTopMenuStrip})
        Me.FileTopMenuStrip.Name = "FileTopMenuStrip"
        Me.FileTopMenuStrip.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuStrip.Text = "File"
        '
        'SettingsTopMenuStrip
        '
        Me.SettingsTopMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleTopMenuStrip})
        Me.SettingsTopMenuStrip.Name = "SettingsTopMenuStrip"
        Me.SettingsTopMenuStrip.Size = New System.Drawing.Size(61, 20)
        Me.SettingsTopMenuStrip.Text = "Settings"
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
        'FileRightClickMenuStrip
        '
        Me.FileRightClickMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartRightClickMenuStrip, Me.StopRightClickMenuStrip, Me.SaveRightClickMenuStrip, Me.OpenRightClickMenuStrip})
        Me.FileRightClickMenuStrip.Name = "FileRightClickMenuStrip"
        Me.FileRightClickMenuStrip.Size = New System.Drawing.Size(116, 22)
        Me.FileRightClickMenuStrip.Text = "File"
        '
        'SettingsRightClickMenuStrip
        '
        Me.SettingsRightClickMenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleRateRightClickMenuStrip})
        Me.SettingsRightClickMenuStrip.Name = "SettingsRightClickMenuStrip"
        Me.SettingsRightClickMenuStrip.Size = New System.Drawing.Size(116, 22)
        Me.SettingsRightClickMenuStrip.Text = "Settings"
        '
        'StartRightClickMenuStrip
        '
        Me.StartRightClickMenuStrip.Name = "StartRightClickMenuStrip"
        Me.StartRightClickMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.StartRightClickMenuStrip.Text = "Start"
        '
        'StopRightClickMenuStrip
        '
        Me.StopRightClickMenuStrip.Name = "StopRightClickMenuStrip"
        Me.StopRightClickMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.StopRightClickMenuStrip.Text = "Stop"
        '
        'SaveRightClickMenuStrip
        '
        Me.SaveRightClickMenuStrip.Name = "SaveRightClickMenuStrip"
        Me.SaveRightClickMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.SaveRightClickMenuStrip.Text = "Save"
        '
        'OpenRightClickMenuStrip
        '
        Me.OpenRightClickMenuStrip.Name = "OpenRightClickMenuStrip"
        Me.OpenRightClickMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.OpenRightClickMenuStrip.Text = "Open"
        '
        'SampleRateRightClickMenuStrip
        '
        Me.SampleRateRightClickMenuStrip.Name = "SampleRateRightClickMenuStrip"
        Me.SampleRateRightClickMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.SampleRateRightClickMenuStrip.Text = "Sample Rate"
        '
        'SampleTopMenuStrip
        '
        Me.SampleTopMenuStrip.Name = "SampleTopMenuStrip"
        Me.SampleTopMenuStrip.Size = New System.Drawing.Size(180, 22)
        Me.SampleTopMenuStrip.Text = "Sample Rate"
        '
        'DataLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents RightClickMenuStrip As ContextMenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents PictureBox1 As PictureBox
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
End Class
