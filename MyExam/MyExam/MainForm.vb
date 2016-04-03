Public Class MainForm
    Private member As New Login
    Sub New(member As Login)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.member = member
    End Sub
    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        CreateForm.Show()
        Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainLinkLabel.Hide()
        WelcomeLabel.Text = "ยินดีต้อนรับ " & member.Username
        ActiveControl = SearchTextBox
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchTextBox.Focus()
    End Sub
End Class
