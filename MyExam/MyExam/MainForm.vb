Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class MainForm

    Sub New(member As Member)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.member = member
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim create As New CreateForm(member)
        create.Show()
        Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim st As New ShowTest
        ShowData(st.ShowAll())
    End Sub

    Private Sub ShowData(result As ArrayList)
        For i As Integer = 0 To result.Count - 1
            Dim s As ShowTest = result.Item(i)
            ListView.Items.Add(s.ID)
            ListView.Items(i).SubItems.Add(s.Name)
            ListView.Items(i).SubItems.Add(s.Type)
            ListView.Items(i).SubItems.Add(s.Time)
            ListView.Items(i).SubItems.Add(s.Access)
            ListView.Items(i).SubItems.Add(s.MemberName)
            ListView.Items(i).SubItems.Add(s.CreateDate)
            ListView.Items(i).SubItems.Add(s.EditDate)
        Next
    End Sub
End Class
