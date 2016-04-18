Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class ShowTest
    Private m_ID As String
    Private m_MemberName As String
    Private m_Name As String
    Private m_Type As String
    Private m_Access As String
    Private m_Time As Double
    Private m_Information As New ArrayList
    Private m_CreateDate As String
    Private m_EditDate As String

    Public Property ID As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return m_Type
        End Get
        Set(value As String)
            m_Type = value
        End Set
    End Property

    Public Property Access As String
        Get
            Return m_Access
        End Get
        Set(value As String)
            m_Access = value
        End Set
    End Property

    Public Property Time As String
        Get
            Return m_Time
        End Get
        Set(value As String)
            m_Time = value
        End Set
    End Property

    Public Property Information As ArrayList
        Get
            Return m_Information
        End Get
        Set(value As ArrayList)
            m_Information = value
        End Set
    End Property

    Public Property CreateDate As String
        Get
            Return m_CreateDate
        End Get
        Set(value As String)
            m_CreateDate = value
        End Set
    End Property

    Public Property EditDate As String
        Get
            Return m_EditDate
        End Get
        Set(value As String)
            m_EditDate = value
        End Set
    End Property

    Public Property MemberName As String
        Get
            Return m_MemberName
        End Get
        Set(value As String)
            m_MemberName = value
        End Set
    End Property

    Public Function ShowAll() As ArrayList
        Dim cmd As New MySqlCommand("SELECT * FROM myexam_test", New MySqlConnection(CONNECTSTRING))
        cmd.Connection.Open()
        Dim result As MySqlDataReader = cmd.ExecuteReader()
        Dim data As New ArrayList
        While (result.Read)
            Dim test As New ShowTest
            test.ID = result.Item("id_test")
            test.Name = result.Item("name_test")
            Select Case result.Item("type_test")
                Case "choice" : test.Type = "เลือกตอบ"
                Case "blank" : test.Type = "เติมคำตอบ"
                Case "write" : test.Type = "เขียนคำตอบ"
                Case "match" : test.Type = "จับคู่"
                Case "truefalse" : test.Type = "ถูกผิด"
            End Select
            If result.Item("time_test") = 0 Then
                test.Time = "ไม่จำกัด"
            Else
                test.Time = result.Item("time_test")
            End If
            If result.Item("access_test") Is Nothing Then
                test.Access = "สาธาระณะ"
            Else
                test.Access = "จำกัด"
            End If
            test.MemberName = FindUsername(result.Item("id_member"))
            Dim myDate As Date
            myDate = result.Item("createdate_test")
            test.CreateDate = myDate.ToString("dd-MM-yyyy")
            If Not IsDBNull(result.Item("editdate_test")) Then
                myDate = result.Item("editdate_test")
                test.EditDate = myDate.ToString("dd-MM-yyyy")
            Else
                test.EditDate = "-"
            End If
            data.Add(test)
        End While
        Return data
    End Function

    Private Function FindUsername(id As Integer) As String
        Dim stm As String = "SELECT id_member, username_member FROM myexam_member WHERE id_member = @id"
        Dim cmd As New MySqlCommand(stm, New MySqlConnection(CONNECTSTRING))
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Connection.Open()
        Dim result As MySqlDataReader = cmd.ExecuteReader()
        Dim username As String = Nothing
        If result.Read() Then
            username = result.Item("username_member")
        End If
        cmd.Connection.Close()
        Return username
    End Function
End Class
