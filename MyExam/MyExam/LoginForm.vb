Public Class LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        MainForm.Show()
        Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub ErrorUsernameLabel_Click(sender As Object, e As EventArgs) Handles ErrorUsernameLabel.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorUsernameLabel.Text = ""
        ErrorPasswordLabel.Text = ""
    End Sub

    Private Sub RegisterLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterLinkLabel.LinkClicked
        RegisterForm.Show()
        Close()
    End Sub

    Private Sub ForgotPasswordLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLinkLabel.LinkClicked
        ForgotPasswordForm.Show()
        Close()
    End Sub
End Class
