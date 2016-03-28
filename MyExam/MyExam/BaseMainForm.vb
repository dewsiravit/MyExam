Public Class BaseMainForm
    Private Sub LogoutLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogoutLinkLabel.LinkClicked
        LoginForm.Show()
        Close()
    End Sub
End Class
