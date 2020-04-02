
''' <summary>
''' Class representing any identifiable Item of all inventory objects
''' </summary>
Public MustInherit Class Item

    Public Enum Kinds
        Barril
        Chopeira
        Cilindro
        Válvula
    End Enum

    Public Sub New(id As String)
        Me.ID = id
    End Sub

    Private p_ID As String
    Public Property ID() As String
        Get
            Return p_ID
        End Get
        Set(ByVal value As String)
            p_ID = value
        End Set
    End Property

    Private p_Kind As Kinds
    Public Property Kind() As Kinds
        Get
            Return p_Kind
        End Get
        Set(ByVal value As Kinds)
            p_Kind = value
        End Set
    End Property

    Private p_Type As String
    Public Property Type() As String
        Get
            Return p_Type
        End Get
        Set(ByVal value As String)
            p_Type = value
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

    Private p_Sales As New List(Of Sale)
    Public Property Sales() As List(Of Sale)
        Get
            Return p_Sales
        End Get
        Set(ByVal value As List(Of Sale))
            p_Sales = value
        End Set
    End Property

End Class
