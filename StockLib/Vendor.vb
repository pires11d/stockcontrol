

''' <summary>
''' Class representing the Vendors and all their associated information
''' </summary>
Public Class Vendor

    Public Sub New(name)
        Me.Name = name
    End Sub

    Private p_Name As String
    Public Property Name() As String
        Get
            Return p_Name
        End Get
        Set(ByVal value As String)
            p_Name = value
        End Set
    End Property

    Public ReadOnly Property Code() As String
        Get
            Return Name.Substring(0, 2).ToLower
        End Get
    End Property

    Private p_Purchases As New List(Of Purchase)
    Public Property Purchases() As List(Of Purchase)
        Get
            Return p_Purchases
        End Get
        Set(ByVal value As List(Of Purchase))
            p_Purchases = value
        End Set
    End Property

End Class
