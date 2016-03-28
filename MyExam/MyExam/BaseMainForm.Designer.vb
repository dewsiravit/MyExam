<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseMainForm
    Inherits MyExam.BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LogoutLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ProfileLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LogoutLinkLabel
        '
        Me.LogoutLinkLabel.AutoSize = True
        Me.LogoutLinkLabel.Location = New System.Drawing.Point(582, 9)
        Me.LogoutLinkLabel.Name = "LogoutLinkLabel"
        Me.LogoutLinkLabel.Size = New System.Drawing.Size(90, 20)
        Me.LogoutLinkLabel.TabIndex = 5
        Me.LogoutLinkLabel.TabStop = True
        Me.LogoutLinkLabel.Text = "ออกจากระบบ"
        '
        'ProfileLinkLabel
        '
        Me.ProfileLinkLabel.AutoSize = True
        Me.ProfileLinkLabel.Location = New System.Drawing.Point(492, 9)
        Me.ProfileLinkLabel.Name = "ProfileLinkLabel"
        Me.ProfileLinkLabel.Size = New System.Drawing.Size(84, 20)
        Me.ProfileLinkLabel.TabIndex = 4
        Me.ProfileLinkLabel.TabStop = True
        Me.ProfileLinkLabel.Text = "ข้อมูลส่วนตัว"
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Location = New System.Drawing.Point(12, 9)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(109, 20)
        Me.WelcomeLabel.TabIndex = 3
        Me.WelcomeLabel.Text = "ยินดีต้อนรับ xxxx"
        '
        'BaseMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.LogoutLinkLabel)
        Me.Controls.Add(Me.ProfileLinkLabel)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Name = "BaseMainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoutLinkLabel As LinkLabel
    Friend WithEvents ProfileLinkLabel As LinkLabel
    Friend WithEvents WelcomeLabel As Label
End Class
