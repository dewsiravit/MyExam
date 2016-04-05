Public Class BaseMainForm
    Protected member As New Member
    Private Sub LogoutLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogoutLinkLabel.LinkClicked
        LoginForm.Show()
        Close()
    End Sub

    Private Sub MainLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MainLinkLabel.LinkClicked
        Dim main As New MainForm(member)
        main.Show()
        Close()
    End Sub

    Private Sub ProfileLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProfileLinkLabel.LinkClicked
        For Each form As Form In Application.OpenForms
            If form.Name.Equals("ProfileForm") Then
                Exit Sub
            End If
        Next
        Dim profile As New ProfileForm(member)
        profile.Show()
        Close()
    End Sub

    Private Sub BaseMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainLinkLabel.Hide()
        WelcomeLabel.Text = "ยินดีต้อนรับ " & member.Username
    End Sub
End Class
