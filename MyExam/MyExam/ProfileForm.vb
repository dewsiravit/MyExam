Public Class ProfileForm
    Sub New(member As Member)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.member = member
    End Sub

    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = member.Username
        EmailTextBox.Text = member.Email
        QuestionTextBox.Text = member.Question
    End Sub
End Class
