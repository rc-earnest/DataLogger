<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectComPortForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SelectComPortComboBox = New System.Windows.Forms.ComboBox()
        Me.AvalableComPortLabel = New System.Windows.Forms.Label()
        Me.OkayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SelectComPortComboBox
        '
        Me.SelectComPortComboBox.FormattingEnabled = True
        Me.SelectComPortComboBox.Location = New System.Drawing.Point(98, 71)
        Me.SelectComPortComboBox.Name = "SelectComPortComboBox"
        Me.SelectComPortComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SelectComPortComboBox.TabIndex = 0
        '
        'AvalableComPortLabel
        '
        Me.AvalableComPortLabel.AutoSize = True
        Me.AvalableComPortLabel.Location = New System.Drawing.Point(95, 55)
        Me.AvalableComPortLabel.Name = "AvalableComPortLabel"
        Me.AvalableComPortLabel.Size = New System.Drawing.Size(101, 13)
        Me.AvalableComPortLabel.TabIndex = 1
        Me.AvalableComPortLabel.Text = "Available Com Ports"
        '
        'OkayButton
        '
        Me.OkayButton.Location = New System.Drawing.Point(121, 132)
        Me.OkayButton.Name = "OkayButton"
        Me.OkayButton.Size = New System.Drawing.Size(75, 23)
        Me.OkayButton.TabIndex = 2
        Me.OkayButton.Text = "&Okay"
        Me.OkayButton.UseVisualStyleBackColor = True
        '
        'SelectComPortForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 167)
        Me.Controls.Add(Me.OkayButton)
        Me.Controls.Add(Me.AvalableComPortLabel)
        Me.Controls.Add(Me.SelectComPortComboBox)
        Me.Name = "SelectComPortForm"
        Me.Text = "SelectComPortForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectComPortComboBox As ComboBox
    Friend WithEvents AvalableComPortLabel As Label
    Friend WithEvents OkayButton As Button
End Class
