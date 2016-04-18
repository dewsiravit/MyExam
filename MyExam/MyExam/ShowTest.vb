Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class ShowTest
    Private m_ID As Integer
    Private m_Name As String
    Private m_Type As String
    Private m_time As String
    Private m_Access As String
    Public Function ShowAll() As ArrayList
        Dim cmd As New MySqlCommand(CONNECTSTRING)
        cmd.CommandText = "SELECT * myexam_test"
        cmd.ExecuteReader()
        cmd.Connection.Open()
        Dim result As MySqlDataReader = cmd.ExecuteReader()
        Dim test As New Test
        Dim data As New ArrayList
        While (result.Read)
            test.ID = result.Item("id_test")
            test.Name = result.Item("name_test")
            Select Case result.Item("type_test")
                Case "choice" : test.TypeTH = "เลือกตอบ"
                Case "blank" : test.TypeTH = "เติมคำตอบ"
                Case "write" : test.TypeTH = "เขียนคำตอบ"
                Case "match" : test.TypeTH = "จับคู่"
                Case "truefalse" : test.TypeTH = "ถูกผิด"
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
        End While
    End Function
End Class
