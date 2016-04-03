Public Class ForgotPasswordForm
    Private member As New ForgotPassword
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        LoginForm.Show()
        Close()
    End Sub

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click
        NameTextBox.Focus()
    End Sub

    Private Sub NewPasswordComfirmLabel_Click(sender As Object, e As EventArgs) Handles NewPasswordComfirmLabel.Click
        NewPasswordConfirmTextBox.Focus()
    End Sub

    Private Sub NewPasswordLabel_Click(sender As Object, e As EventArgs) Handles NewPasswordLabel.Click
        NewPasswordTextBox.Focus()
    End Sub

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorNameLabel.ResetText()
        ErrorAnswerLabel.ResetText()
        ErrorNewPasswordLabel.ResetText()
        ErrorNewPasswordConfirmLabel.ResetText()
        ChangePasswordGroupBox.Visible = False
    End Sub

    Private Sub QuestionLabel_Click(sender As Object, e As EventArgs) Handles QuestionLabel.Click
        AnswerTextBox.Focus()
    End Sub

    Private Sub CheckNameLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CheckNameLinkLabel.LinkClicked
        If member.CheckUser(NameTextBox.Text.Trim) Then
            QuestionLabel.Text = member.Question
            ErrorNameLabel.ResetText()
            NameTextBox.Enabled = False
            CheckNameLinkLabel.Enabled = False
            QuestionLabel.Enabled = True
            AnswerTextBox.Enabled = True
            SendAnswerButton.Enabled = True
        Else
            NameTextBox.Clear()
            NameTextBox.Focus()
            ErrorNameLabel.Text = "*ไม่พบชื่อผู้ใช้ หรืออีเมลนี้ในระบบ"
        End If
    End Sub

    Private Sub SendAnswerButton_Click(sender As Object, e As EventArgs) Handles SendAnswerButton.Click
        If member.CheckAnsewr(AnswerTextBox.Text) Then
            ErrorAnswerLabel.ResetText()
        Else
            ErrorAnswerLabel.Text = "*คำตอบไม่ถูกต้อง"
            AnswerTextBox.Clear()
            AnswerTextBox.Focus()
        End If
    End Sub
End Class
