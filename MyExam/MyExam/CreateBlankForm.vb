Public Class CreateBlankForm
    Private Sub CreateBlankForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumberComboBox.Items.Add(1)
        NumberComboBox.SelectedIndex = 0
    End Sub
End Class
