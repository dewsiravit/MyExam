<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
    Inherits MyExam.BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordComfirmLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordComfirmTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.QuestionTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RegisterGroupBox = New System.Windows.Forms.GroupBox()
        Me.RegisterGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(161, 56)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(55, 20)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "ชื่อผู้ใช้:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(154, 88)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(62, 20)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "รหัสผ่าน:"
        '
        'PasswordComfirmLabel
        '
        Me.PasswordComfirmLabel.AutoSize = True
        Me.PasswordComfirmLabel.Location = New System.Drawing.Point(116, 120)
        Me.PasswordComfirmLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordComfirmLabel.Name = "PasswordComfirmLabel"
        Me.PasswordComfirmLabel.Size = New System.Drawing.Size(100, 20)
        Me.PasswordComfirmLabel.TabIndex = 2
        Me.PasswordComfirmLabel.Text = "ยืนยัน รหัสผ่าน:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(171, 152)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(45, 20)
        Me.EmailLabel.TabIndex = 3
        Me.EmailLabel.Text = "อีเมล์:"
        '
        'QuestionLabel
        '
        Me.QuestionLabel.AutoSize = True
        Me.QuestionLabel.Location = New System.Drawing.Point(66, 184)
        Me.QuestionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(150, 20)
        Me.QuestionLabel.TabIndex = 4
        Me.QuestionLabel.Text = "คำถาม เมื่อลืมรหัสผ่าน:"
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(66, 216)
        Me.AnswerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(150, 20)
        Me.AnswerLabel.TabIndex = 5
        Me.AnswerLabel.Text = "คำตอบ เมื่อลืมรหัสผ่าน:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(268, 53)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(142, 26)
        Me.UsernameTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(268, 85)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(142, 26)
        Me.PasswordTextBox.TabIndex = 7
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'PasswordComfirmTextBox
        '
        Me.PasswordComfirmTextBox.Location = New System.Drawing.Point(268, 117)
        Me.PasswordComfirmTextBox.Name = "PasswordComfirmTextBox"
        Me.PasswordComfirmTextBox.Size = New System.Drawing.Size(142, 26)
        Me.PasswordComfirmTextBox.TabIndex = 8
        Me.PasswordComfirmTextBox.UseSystemPasswordChar = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(268, 149)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(142, 26)
        Me.EmailTextBox.TabIndex = 9
        '
        'QuestionTextBox
        '
        Me.QuestionTextBox.Location = New System.Drawing.Point(268, 181)
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.Size = New System.Drawing.Size(187, 26)
        Me.QuestionTextBox.TabIndex = 10
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(268, 213)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(187, 26)
        Me.AnswerTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 56)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "สมัครสมาชิก"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(339, 327)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(146, 56)
        Me.CancelButton.TabIndex = 13
        Me.CancelButton.Text = "ยกเลิก"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(416, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(416, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(416, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(416, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(461, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(461, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "*"
        '
        'RegisterGroupBox
        '
        Me.RegisterGroupBox.Controls.Add(Me.Label12)
        Me.RegisterGroupBox.Controls.Add(Me.CancelButton)
        Me.RegisterGroupBox.Controls.Add(Me.Label11)
        Me.RegisterGroupBox.Controls.Add(Me.Button1)
        Me.RegisterGroupBox.Controls.Add(Me.Label10)
        Me.RegisterGroupBox.Controls.Add(Me.Label9)
        Me.RegisterGroupBox.Controls.Add(Me.Label8)
        Me.RegisterGroupBox.Controls.Add(Me.Label7)
        Me.RegisterGroupBox.Controls.Add(Me.AnswerTextBox)
        Me.RegisterGroupBox.Controls.Add(Me.QuestionTextBox)
        Me.RegisterGroupBox.Controls.Add(Me.EmailTextBox)
        Me.RegisterGroupBox.Controls.Add(Me.PasswordComfirmTextBox)
        Me.RegisterGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.RegisterGroupBox.Controls.Add(Me.UsernameTextBox)
        Me.RegisterGroupBox.Controls.Add(Me.AnswerLabel)
        Me.RegisterGroupBox.Controls.Add(Me.QuestionLabel)
        Me.RegisterGroupBox.Controls.Add(Me.EmailLabel)
        Me.RegisterGroupBox.Controls.Add(Me.PasswordComfirmLabel)
        Me.RegisterGroupBox.Controls.Add(Me.PasswordLabel)
        Me.RegisterGroupBox.Controls.Add(Me.UsernameLabel)
        Me.RegisterGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.RegisterGroupBox.Name = "RegisterGroupBox"
        Me.RegisterGroupBox.Size = New System.Drawing.Size(660, 437)
        Me.RegisterGroupBox.TabIndex = 20
        Me.RegisterGroupBox.TabStop = False
        '
        'RegisterForm
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.RegisterGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.Name = "RegisterForm"
        Me.Text = "สมัครสมาชิก - MyExam"
        Me.RegisterGroupBox.ResumeLayout(False)
        Me.RegisterGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordComfirmLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents QuestionLabel As Label
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordComfirmTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents QuestionTextBox As TextBox
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RegisterGroupBox As GroupBox
End Class
