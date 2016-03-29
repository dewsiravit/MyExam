Public Class ForgotPasswordForm
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
End Class
