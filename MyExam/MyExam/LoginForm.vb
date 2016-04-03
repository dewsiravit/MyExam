Public Class LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim member As New Login
        member.Username = UsernameTextBox.Text
        member.Password = PasswordTextBox.Text
        If member.CheckUsername() Then
            ErrorUsernameLabel.ResetText()
        Else
            ErrorUsernameLabel.Text = "*ไม่พบชื่อผู้ใช้นี้ในระบบ"
            ErrorPasswordLabel.ResetText()
            PasswordTextBox.Clear()
            Exit Sub
        End If
        If member.CheckLogin() Then
            Dim main As New MainForm(member)
            main.Show()
            Close()
        Else
            ErrorPasswordLabel.Text = "*รหัสผ่านไม่ถูกต้อง"
            PasswordTextBox.Clear()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub ErrorUsernameLabel_Click(sender As Object, e As EventArgs) Handles ErrorUsernameLabel.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorUsernameLabel.ResetText()
        ErrorPasswordLabel.ResetText()
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
