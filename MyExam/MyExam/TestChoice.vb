Public Class TestChoice
    Private m_Id As Integer
    Private m_TestID As Integer
    Private m_Answer As Choice
    Private m_Question As String
    Private m_ChoiceA As String
    Private m_ChoiceB As String
    Private m_ChoiceC As String
    Private m_CHoiceD As String
    Enum Choice
        A = 0
        B = 1
        C = 2
        D = 3
    End Enum

    Public Property Id As Integer
        Get
            Return m_Id
        End Get
        Set(value As Integer)
            m_Id = value
        End Set
    End Property

    Public Property TestID As Integer
        Get
            Return m_TestID
        End Get
        Set(value As Integer)
            m_TestID = value
        End Set
    End Property

    Public Property Answer As Choice
        Get
            Return m_Answer
        End Get
        Set(value As Choice)
            m_Answer = value
        End Set
    End Property

    Public Property ChoiceA As String
        Get
            Return m_ChoiceA
        End Get
        Set(value As String)
            m_ChoiceA = value
        End Set
    End Property

    Public Property ChoiceB As String
        Get
            Return m_ChoiceB
        End Get
        Set(value As String)
            m_ChoiceB = value
        End Set
    End Property

    Public Property ChoiceC As String
        Get
            Return m_ChoiceC
        End Get
        Set(value As String)
            m_ChoiceC = value
        End Set
    End Property

    Public Property CHoiceD As String
        Get
            Return m_CHoiceD
        End Get
        Set(value As String)
            m_CHoiceD = value
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
End Class
