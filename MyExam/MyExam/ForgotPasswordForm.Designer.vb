<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPasswordForm
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SendAnswerButton = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.VerifyGroupBox = New System.Windows.Forms.GroupBox()
        Me.ErrorAnswerLabel = New System.Windows.Forms.Label()
        Me.ErrorNameLabel = New System.Windows.Forms.Label()
        Me.NewPasswordLabel = New System.Windows.Forms.Label()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.NewPasswordComfirmLabel = New System.Windows.Forms.Label()
        Me.NewPasswordConfirmTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ChangePasswordGroupBox = New System.Windows.Forms.GroupBox()
        Me.ErrorNewPasswordConfirmLabel = New System.Windows.Forms.Label()
        Me.ErrorNewPasswordLabel = New System.Windows.Forms.Label()
        Me.ChangePasswordButton = New System.Windows.Forms.Button()
        Me.VerifyGroupBox.SuspendLayout()
        Me.ChangePasswordGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(112, 26)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(119, 20)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "ชื่อผู้ใช้ หรือ อีเมล์:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(229, 23)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(142, 26)
        Me.NameTextBox.TabIndex = 7
        '
        'QuestionLabel
        '
        Me.QuestionLabel.AutoSize = True
        Me.QuestionLabel.Location = New System.Drawing.Point(112, 64)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(142, 20)
        Me.QuestionLabel.TabIndex = 9
        Me.QuestionLabel.Text = "คำถามเมื่อลืมรหัสผ่าน"
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Enabled = False
        Me.AnswerTextBox.Location = New System.Drawing.Point(116, 100)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(326, 26)
        Me.AnswerTextBox.TabIndex = 10
        '
        'SendAnswerButton
        '
        Me.SendAnswerButton.AutoSize = True
        Me.SendAnswerButton.Location = New System.Drawing.Point(468, 98)
        Me.SendAnswerButton.Name = "SendAnswerButton"
        Me.SendAnswerButton.Size = New System.Drawing.Size(76, 30)
        Me.SendAnswerButton.TabIndex = 11
        Me.SendAnswerButton.Text = "ส่งคำตอบ"
        Me.SendAnswerButton.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(377, 26)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(65, 20)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ตรวจสอบ"
        '
        'VerifyGroupBox
        '
        Me.VerifyGroupBox.Controls.Add(Me.ErrorAnswerLabel)
        Me.VerifyGroupBox.Controls.Add(Me.ErrorNameLabel)
        Me.VerifyGroupBox.Controls.Add(Me.LinkLabel1)
        Me.VerifyGroupBox.Controls.Add(Me.SendAnswerButton)
        Me.VerifyGroupBox.Controls.Add(Me.AnswerTextBox)
        Me.VerifyGroupBox.Controls.Add(Me.QuestionLabel)
        Me.VerifyGroupBox.Controls.Add(Me.NameTextBox)
        Me.VerifyGroupBox.Controls.Add(Me.NameLabel)
        Me.VerifyGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.VerifyGroupBox.Name = "VerifyGroupBox"
        Me.VerifyGroupBox.Size = New System.Drawing.Size(660, 174)
        Me.VerifyGroupBox.TabIndex = 13
        Me.VerifyGroupBox.TabStop = False
        Me.VerifyGroupBox.Text = "ยืนยันตัวตน"
        '
        'ErrorAnswerLabel
        '
        Me.ErrorAnswerLabel.AutoSize = True
        Me.ErrorAnswerLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorAnswerLabel.Location = New System.Drawing.Point(112, 139)
        Me.ErrorAnswerLabel.Name = "ErrorAnswerLabel"
        Me.ErrorAnswerLabel.Size = New System.Drawing.Size(57, 20)
        Me.ErrorAnswerLabel.TabIndex = 14
        Me.ErrorAnswerLabel.Text = "Label1"
        '
        'ErrorNameLabel
        '
        Me.ErrorNameLabel.AutoSize = True
        Me.ErrorNameLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorNameLabel.Location = New System.Drawing.Point(448, 26)
        Me.ErrorNameLabel.Name = "ErrorNameLabel"
        Me.ErrorNameLabel.Size = New System.Drawing.Size(57, 20)
        Me.ErrorNameLabel.TabIndex = 13
        Me.ErrorNameLabel.Text = "Label1"
        '
        'NewPasswordLabel
        '
        Me.NewPasswordLabel.AutoSize = True
        Me.NewPasswordLabel.Location = New System.Drawing.Point(143, 46)
        Me.NewPasswordLabel.Name = "NewPasswordLabel"
        Me.NewPasswordLabel.Size = New System.Drawing.Size(88, 20)
        Me.NewPasswordLabel.TabIndex = 14
        Me.NewPasswordLabel.Text = "รหัสผ่านใหม่:"
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(246, 40)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(192, 26)
        Me.NewPasswordTextBox.TabIndex = 15
        Me.NewPasswordTextBox.UseSystemPasswordChar = True
        '
        'NewPasswordComfirmLabel
        '
        Me.NewPasswordComfirmLabel.AutoSize = True
        Me.NewPasswordComfirmLabel.Location = New System.Drawing.Point(105, 91)
        Me.NewPasswordComfirmLabel.Name = "NewPasswordComfirmLabel"
        Me.NewPasswordComfirmLabel.Size = New System.Drawing.Size(126, 20)
        Me.NewPasswordComfirmLabel.TabIndex = 16
        Me.NewPasswordComfirmLabel.Text = "ยืนยัน รหัสผ่านใหม่:"
        '
        'NewPasswordConfirmTextBox
        '
        Me.NewPasswordConfirmTextBox.Location = New System.Drawing.Point(246, 88)
        Me.NewPasswordConfirmTextBox.Name = "NewPasswordConfirmTextBox"
        Me.NewPasswordConfirmTextBox.Size = New System.Drawing.Size(192, 26)
        Me.NewPasswordConfirmTextBox.TabIndex = 17
        Me.NewPasswordConfirmTextBox.UseSystemPasswordChar = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(278, 413)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(91, 36)
        Me.CancelButton.TabIndex = 19
        Me.CancelButton.Text = "ยกเลิก"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ChangePasswordGroupBox
        '
        Me.ChangePasswordGroupBox.Controls.Add(Me.ErrorNewPasswordConfirmLabel)
        Me.ChangePasswordGroupBox.Controls.Add(Me.ErrorNewPasswordLabel)
        Me.ChangePasswordGroupBox.Controls.Add(Me.ChangePasswordButton)
        Me.ChangePasswordGroupBox.Controls.Add(Me.NewPasswordConfirmTextBox)
        Me.ChangePasswordGroupBox.Controls.Add(Me.NewPasswordComfirmLabel)
        Me.ChangePasswordGroupBox.Controls.Add(Me.NewPasswordTextBox)
        Me.ChangePasswordGroupBox.Controls.Add(Me.NewPasswordLabel)
        Me.ChangePasswordGroupBox.Location = New System.Drawing.Point(12, 192)
        Me.ChangePasswordGroupBox.Name = "ChangePasswordGroupBox"
        Me.ChangePasswordGroupBox.Size = New System.Drawing.Size(660, 215)
        Me.ChangePasswordGroupBox.TabIndex = 20
        Me.ChangePasswordGroupBox.TabStop = False
        Me.ChangePasswordGroupBox.Text = "เปลี่ยนรหัสผ่าน"
        '
        'ErrorNewPasswordConfirmLabel
        '
        Me.ErrorNewPasswordConfirmLabel.AutoSize = True
        Me.ErrorNewPasswordConfirmLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorNewPasswordConfirmLabel.Location = New System.Drawing.Point(444, 91)
        Me.ErrorNewPasswordConfirmLabel.Name = "ErrorNewPasswordConfirmLabel"
        Me.ErrorNewPasswordConfirmLabel.Size = New System.Drawing.Size(57, 20)
        Me.ErrorNewPasswordConfirmLabel.TabIndex = 20
        Me.ErrorNewPasswordConfirmLabel.Text = "Label3"
        '
        'ErrorNewPasswordLabel
        '
        Me.ErrorNewPasswordLabel.AutoSize = True
        Me.ErrorNewPasswordLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorNewPasswordLabel.Location = New System.Drawing.Point(444, 43)
        Me.ErrorNewPasswordLabel.Name = "ErrorNewPasswordLabel"
        Me.ErrorNewPasswordLabel.Size = New System.Drawing.Size(57, 20)
        Me.ErrorNewPasswordLabel.TabIndex = 19
        Me.ErrorNewPasswordLabel.Text = "Label2"
        '
        'ChangePasswordButton
        '
        Me.ChangePasswordButton.AutoSize = True
        Me.ChangePasswordButton.Location = New System.Drawing.Point(246, 150)
        Me.ChangePasswordButton.Name = "ChangePasswordButton"
        Me.ChangePasswordButton.Size = New System.Drawing.Size(108, 30)
        Me.ChangePasswordButton.TabIndex = 18
        Me.ChangePasswordButton.Text = "เปลี่ยนรหัสผ่าน"
        Me.ChangePasswordButton.UseVisualStyleBackColor = True
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ChangePasswordGroupBox)
        Me.Controls.Add(Me.VerifyGroupBox)
        Me.Name = "ForgotPasswordForm"
        Me.Text = "ลืมรหัสผ่าน"
        Me.VerifyGroupBox.ResumeLayout(False)
        Me.VerifyGroupBox.PerformLayout()
        Me.ChangePasswordGroupBox.ResumeLayout(False)
        Me.ChangePasswordGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents QuestionLabel As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents SendAnswerButton As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents VerifyGroupBox As GroupBox
    Friend WithEvents NewPasswordLabel As Label
    Friend WithEvents NewPasswordTextBox As TextBox
    Friend WithEvents NewPasswordComfirmLabel As Label
    Friend WithEvents NewPasswordConfirmTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents ChangePasswordGroupBox As GroupBox
    Friend WithEvents ChangePasswordButton As Button
    Friend WithEvents ErrorAnswerLabel As Label
    Friend WithEvents ErrorNameLabel As Label
    Friend WithEvents ErrorNewPasswordConfirmLabel As Label
    Friend WithEvents ErrorNewPasswordLabel As Label
End Class
