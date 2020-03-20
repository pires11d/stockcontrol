

Public Class Chopeira

    Public Enum Kind
        _1Torneira
        _1TorneiraComGelo
        _2Torneiras
    End Enum

    Private p_ID As String
    Public Property ID() As String
        Get
            Return p_ID
        End Get
        Set(ByVal value As String)
            p_ID = value
        End Set
    End Property

    Private p_State As Boolean
    Public Property State() As Boolean
        Get
            Return p_State
        End Get
        Set(ByVal value As Boolean)
            p_State = value
        End Set
    End Property


End Class
