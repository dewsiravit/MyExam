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
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ErrorUsernameLabel = New System.Windows.Forms.Label()
        Me.ErrorPasswordLabel = New System.Windows.Forms.Label()
        Me.ErrorConfirmPasswordLabel = New System.Windows.Forms.Label()
        Me.ErrorEmailLabel = New System.Windows.Forms.Label()
        Me.ErrorQuestionLabel = New System.Windows.Forms.Label()
        Me.ErrorAnswerLabel = New System.Windows.Forms.Label()
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
        Me.UsernameTextBox.Size = New System.Drawing.Size(187, 26)
        Me.UsernameTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(268, 85)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(187, 26)
        Me.PasswordTextBox.TabIndex = 7
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'PasswordComfirmTextBox
        '
        Me.PasswordComfirmTextBox.Location = New System.Drawing.Point(268, 117)
        Me.PasswordComfirmTextBox.Name = "PasswordComfirmTextBox"
        Me.PasswordComfirmTextBox.Size = New System.Drawing.Size(187, 26)
        Me.PasswordComfirmTextBox.TabIndex = 8
        Me.PasswordComfirmTextBox.UseSystemPasswordChar = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(268, 149)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(187, 26)
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
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(165, 327)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(146, 56)
        Me.RegisterButton.TabIndex = 12
        Me.RegisterButton.Text = "สมัครสมาชิก"
        Me.RegisterButton.UseVisualStyleBackColor = True
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
        'ErrorUsernameLabel
        '
        Me.ErrorUsernameLabel.AutoSize = True
        Me.ErrorUsernameLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorUsernameLabel.Location = New System.Drawing.Point(461, 56)
        Me.ErrorUsernameLabel.Name = "ErrorUsernameLabel"
        Me.ErrorUsernameLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorUsernameLabel.TabIndex = 14
        Me.ErrorUsernameLabel.Text = "*"
        '
        'ErrorPasswordLabel
        '
        Me.ErrorPasswordLabel.AutoSize = True
        Me.ErrorPasswordLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorPasswordLabel.Location = New System.Drawing.Point(461, 88)
        Me.ErrorPasswordLabel.Name = "ErrorPasswordLabel"
        Me.ErrorPasswordLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorPasswordLabel.TabIndex = 15
        Me.ErrorPasswordLabel.Text = "*"
        '
        'ErrorConfirmPasswordLabel
        '
        Me.ErrorConfirmPasswordLabel.AutoSize = True
        Me.ErrorConfirmPasswordLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorConfirmPasswordLabel.Location = New System.Drawing.Point(461, 120)
        Me.ErrorConfirmPasswordLabel.Name = "ErrorConfirmPasswordLabel"
        Me.ErrorConfirmPasswordLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorConfirmPasswordLabel.TabIndex = 16
        Me.ErrorConfirmPasswordLabel.Text = "*"
        '
        'ErrorEmailLabel
        '
        Me.ErrorEmailLabel.AutoSize = True
        Me.ErrorEmailLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorEmailLabel.Location = New System.Drawing.Point(461, 155)
        Me.ErrorEmailLabel.Name = "ErrorEmailLabel"
        Me.ErrorEmailLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorEmailLabel.TabIndex = 17
        Me.ErrorEmailLabel.Text = "*"
        '
        'ErrorQuestionLabel
        '
        Me.ErrorQuestionLabel.AutoSize = True
        Me.ErrorQuestionLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorQuestionLabel.Location = New System.Drawing.Point(461, 184)
        Me.ErrorQuestionLabel.Name = "ErrorQuestionLabel"
        Me.ErrorQuestionLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorQuestionLabel.TabIndex = 18
        Me.ErrorQuestionLabel.Text = "*"
        '
        'ErrorAnswerLabel
        '
        Me.ErrorAnswerLabel.AutoSize = True
        Me.ErrorAnswerLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorAnswerLabel.Location = New System.Drawing.Point(461, 216)
        Me.ErrorAnswerLabel.Name = "ErrorAnswerLabel"
        Me.ErrorAnswerLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorAnswerLabel.TabIndex = 19
        Me.ErrorAnswerLabel.Text = "*"
        '
        'RegisterGroupBox
        '
        Me.RegisterGroupBox.Controls.Add(Me.ErrorAnswerLabel)
        Me.RegisterGroupBox.Controls.Add(Me.CancelButton)
        Me.RegisterGroupBox.Controls.Add(Me.ErrorQuestionLabel)
        Me.RegisterGroupBox.Controls.Add(Me.RegisterButton)
        Me.RegisterGroupBox.Controls.Add(Me.ErrorEmailLabel)
        Me.RegisterGroupBox.Controls.Add(Me.ErrorConfirmPasswordLabel)
        Me.RegisterGroupBox.Controls.Add(Me.ErrorPasswordLabel)
        Me.RegisterGroupBox.Controls.Add(Me.ErrorUsernameLabel)
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
        Me.AcceptButton = Me.RegisterButton
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
    Friend WithEvents RegisterButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents ErrorUsernameLabel As Label
    Friend WithEvents ErrorPasswordLabel As Label
    Friend WithEvents ErrorConfirmPasswordLabel As Label
    Friend WithEvents ErrorEmailLabel As Label
    Friend WithEvents ErrorQuestionLabel As Label
    Friend WithEvents ErrorAnswerLabel As Label
    Friend WithEvents RegisterGroupBox As GroupBox
End Class
