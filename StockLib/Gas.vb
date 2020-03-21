
''' <summary>
''' Class representing the CO2 Gas Cylinder objects
''' </summary>
Public Class Gas

    Public Enum Kind
        _4kg
        _6kg
        _9kg
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
