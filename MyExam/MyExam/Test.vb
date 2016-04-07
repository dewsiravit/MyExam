Public Class Test
    Private m_ID As Integer
    Private m_Name As String
    Public Enum Type
        เลือกคำตอบ
        เติมคำตอบ
        เขียนคำตอบ
        จับคู่
        ถูกผิด
    End Enum
    Private m_Access As String
    Private m_Time As Double
    Private m_Information As New ArrayList

    Public Property ID As Integer
        Get
            Return m_ID
        End Get
        Set(value As Integer)
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

    Public Property Access As String
        Get
            Return m_Access
        End Get
        Set(value As String)
            m_Access = value
        End Set
    End Property

    Public Property Time As Double
        Get
            Return m_Time
        End Get
        Set(value As Double)
            m_Time = value
        End Set
    End Property
    'test
    Public Property Information As ArrayList
        Get
            Return m_Information
        End Get
        Set(value As ArrayList)
            m_Information = value
        End Set
    End Property
End Class
