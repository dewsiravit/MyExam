Public Class CreateBlankForm
    Sub New(member As Member)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.member = member
    End Sub
    Private Sub CreateBlankForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumberComboBox.Items.Add(1)
        NumberComboBox.SelectedIndex = 0
    End Sub
End Class
