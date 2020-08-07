
''' <summary>
''' Class representing all Fridges, an object that can hold a certain quantity of items for sale
''' </summary>
Public Class Fridge

    Private p_ID As Integer
    Public Property ID() As Integer
        Get
            Return p_ID
        End Get
        Set(ByVal value As Integer)
            p_ID = value
        End Set
    End Property

    Private p_Products As List(Of Product)
    Public Property Products() As List(Of Product)
        Get
            Return p_Products
        End Get
        Set(ByVal value As List(Of Product))
            p_Products = value
        End Set
    End Property

    Private p_InstallationDate As Date
    Public Property InstallationDate() As Date
        Get
            Return p_InstallationDate
        End Get
        Set(ByVal value As Date)
            p_InstallationDate = value
        End Set
    End Property

    Private p_RemovalDate As Date
    Public Property RemovalDate() As Date
        Get
            Return p_RemovalDate
        End Get
        Set(ByVal value As Date)
            p_RemovalDate = value
        End Set
    End Property

    Private p_Client As Client
    Public Property Client() As Client
        Get
            Return p_Client
        End Get
        Set(ByVal value As Client)
            p_Client = value
        End Set
    End Property

    Public Function GetProductsByCode(code As String) As List(Of Product)
        Return Me.Products.Where(Function(p) p.Code = code).ToList
    End Function

    Public Function GetExpiringProducts() As List(Of Product)
        Return Me.Products.Where(Function(x) x.ExpirationDate <= Today.AddDays(7)).ToList
    End Function



End Class
