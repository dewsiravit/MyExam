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
        ActiveControl = SearchTextBox
        Dim stm As String = "SELECT * FROM myexam_test"
        Dim cmd As New MySqlCommand(stm, New MySqlConnection(CONNECTSTRING))
        cmd.Connection.Open()
        Dim result As MySqlDataReader = cmd.ExecuteReader()
        Dim i As Integer = 0
        While result.Read
            ListView.Items.Add(result.Item("id_test"))
            ListView.Items(i).SubItems.Add(result.Item("name_test"))
            Select Case result.Item("type_test")
                Case "choice" : ListView.Items(i).SubItems.Add("เลือกตอบ")
                Case "blank" : ListView.Items(i).SubItems.Add("เติมคำตอบ")
                Case "write" : ListView.Items(i).SubItems.Add("เขียนคำตอบ")
                Case "match" : ListView.Items(i).SubItems.Add("จับคู่")
                Case "truefalse" : ListView.Items(i).SubItems.Add("ถูกผิด")
            End Select
            If result.Item("time_test") = 0 Then
                ListView.Items(i).SubItems.Add("ไม่จำกัด")
            Else
                ListView.Items(i).SubItems.Add(result.Item("time_test"))
            End If
            If result.Item("access_test") Is Nothing Then
                ListView.Items(i).SubItems.Add("สาธาระณะ")
            Else
                ListView.Items(i).SubItems.Add("จำกัด")
            End If
            ListView.Items(i).SubItems.Add(result.Item("createdate_test"))
            ListView.Items(i).SubItems.Add(result.Item("editdate_test").ToString)
            i += 1
        End While
        cmd.Connection.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchTextBox.Focus()
    End Sub
End Class
