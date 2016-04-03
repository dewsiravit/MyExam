Public Class RegisterForm
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        LoginForm.Show()
        Close()
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click
        UsernameTextBox.Focus()
    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click
        PasswordTextBox.Focus()
    End Sub

    Private Sub PasswordComfirmLabel_Click(sender As Object, e As EventArgs) Handles PasswordComfirmLabel.Click
        PasswordComfirmTextBox.Focus()
    End Sub

    Private Sub EmailLabel_Click(sender As Object, e As EventArgs) Handles EmailLabel.Click
        EmailTextBox.Focus()
    End Sub

    Private Sub QuestionLabel_Click(sender As Object, e As EventArgs) Handles QuestionLabel.Click
        QuestionTextBox.Focus()
    End Sub

    Private Sub AnswerLabel_Click(sender As Object, e As EventArgs) Handles AnswerLabel.Click
        AnswerTextBox.Focus()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim member As New Register
        member.Username = UsernameTextBox.Text
        member.Password = PasswordComfirmTextBox.Text
        member.Email = EmailTextBox.Text
        member.Question = QuestionTextBox.Text
        member.Answer = AnswerTextBox.Text
        member.AddtoDatabase(member)
    End Sub
End Class
