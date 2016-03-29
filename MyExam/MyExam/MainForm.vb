Public Class MainForm
    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        CreateForm.Show()
        Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainLinkLabel.Hide()
        ActiveControl = SearchTextBox
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchTextBox.Focus()
    End Sub
End Class
