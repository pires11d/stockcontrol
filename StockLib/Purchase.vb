
''' <summary>
''' Class representing the Purchase of any products (Entrada)
''' </summary>
Public Class Purchase

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

    Private p_Vendor As Vendor
    Public Property Vendor() As Vendor
        Get
            Return p_Vendor
        End Get
        Set(ByVal value As Vendor)
            p_Vendor = value
        End Set
    End Property


End Class
