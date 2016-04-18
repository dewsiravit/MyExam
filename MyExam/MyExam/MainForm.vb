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
        ShowData(result)
        cmd.Connection.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchTextBox.Focus()
        ListView.Items.Clear()
        Dim stm As String
        Dim str As String = SearchTextBox.Text
        If NameRadioButton.Checked Then
            stm = "SELECT * FROM myexam_test WHERE name_test LIKE @str"
            str += "%"
        Else
            stm = "SELECT * FROM myexam_test WHERE id_member = @str"
            str = FindID(str)
        End If
        Dim cmd As New MySqlCommand(stm, New MySqlConnection(CONNECTSTRING))
        cmd.Parameters.AddWithValue("@str", str)
        cmd.Connection.Open()
        Dim result As MySqlDataReader = cmd.ExecuteReader()
        ShowData(result)
        cmd.Connection.Close()
    End Sub

    Private Function FindUsername(id As Integer) As String
        Dim stm As String = "SELECT id_member, username_member FROM myexam_member WHERE id_member = @id"
        Dim cmd As New MySqlCommand(stm, New MySqlConnection(CONNECTSTRING))
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Connection.Open()
        Dim result As MySqlDataReader = cmd.ExecuteReader()
        Dim username As String
        If result.Read() Then
            username = result.Item("username_member")
        End If
        cmd.Connection.Close()
        Return username
    End Function

    Private Function FindID(name As String) As Integer
        Dim stm As String = "SELECT id_member, username_member FROM myexam_member WHERE username_member = @name"
        Dim cmd As New MySqlCommand(stm, New MySqlConnection(CONNECTSTRING))
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Connection.Open()
        Dim result As MySqlDataReader = cmd.ExecuteReader()
        Dim id As Integer
        If result.Read() Then
            id = result.Item("id_member")
        End If
        cmd.Connection.Close()
        Return id
    End Function

    Private Sub ShowData(result As MySqlDataReader)
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
            ListView.Items(i).SubItems.Add(FindUsername(result.Item("id_member")))
            Dim myDate As Date
            myDate = result.Item("createdate_test")
            ListView.Items(i).SubItems.Add(myDate.ToString("dd-MM-yyyy"))
            If Not IsDBNull(result.Item("editdate_test")) Then
                myDate = result.Item("editdate_test")
                ListView.Items(i).SubItems.Add(myDate.ToString("dd-MM-yyyy"))
            End If
            i += 1
        End While
    End Sub
End Class
