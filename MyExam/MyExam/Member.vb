Imports System.Security.Cryptography
Imports System.Text

Public Class Member
    Private m_ID As Integer
    Private m_Username As String
    Private m_Email As String
    Private m_Password As String
    Private m_Question As String
    Private m_Answer As String

    Public Property ID As Integer
        Get
            Return m_ID
        End Get
        Set(value As Integer)
            m_ID = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return m_Username
        End Get
        Set(value As String)
            m_Username = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return m_Email
        End Get
        Set(value As String)
            m_Email = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return m_Password
        End Get
        Set(value As String)
            m_Password = SHA256(value)
        End Set
    End Property

    Public Property Question As String
        Get
            Return m_Question
        End Get
        Set(value As String)
            m_Question = value
        End Set
    End Property

    Public Property Answer As String
        Get
            Return m_Answer
        End Get
        Set(value As String)
            m_Answer = SHA256(value)
        End Set
    End Property

    Private Function SHA256(str As String) As String
        Dim mySHA256 As SHA256 = Security.Cryptography.SHA256.Create()
        Dim encText As New UTF8Encoding()
        Dim hashValue() As Byte
        hashValue = mySHA256.ComputeHash(encText.GetBytes(str))
        Dim strB As New StringBuilder()
        For i As Integer = 0 To hashValue.Length - 1
            strB.Append(String.Format("{0:x2}", hashValue(i)))
        Next
        Return strB.ToString()
    End Function
End Class
