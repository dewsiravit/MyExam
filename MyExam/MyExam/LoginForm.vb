Public Class LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ErrorUsernameLabel_Click(sender As Object, e As EventArgs) Handles ErrorUsernameLabel.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorUsernameLabel.Text = ""
        ErrorPasswordLabel.Text = ""
    End Sub
End Class
