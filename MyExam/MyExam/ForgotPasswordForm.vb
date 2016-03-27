Public Class ForgotPasswordForm
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        LoginForm.Show()
        Close()
    End Sub
End Class
