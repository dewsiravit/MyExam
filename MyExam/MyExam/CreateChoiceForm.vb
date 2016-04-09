Public Class CreateChoiceForm
    Private myTest As Test
    Sub New(member As Member, myTest As Test)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.member = member
        Me.myTest = myTest
    End Sub
    Private Sub CreateChoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumberComboBox.Items.Add(1)
        NumberComboBox.SelectedIndex = 0
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim creat As New CreateForm(member, myTest)
        creat.Show()
        Close()
    End Sub
End Class
