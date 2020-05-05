
''' <summary>
''' Class representing the Order type, which can either be a <see cref="Sale"/> or a <see cref="Purchase"/>
''' </summary>
Public MustInherit Class Order

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

    Private p_Products As New Dictionary(Of String, Product)
    Public Property Products() As Dictionary(Of String, Product)
        Get
            Return p_Products
        End Get
        Set(ByVal value As Dictionary(Of String, Product))
            p_Products = value
        End Set
    End Property

    Public ReadOnly Property ProductList() As List(Of String)
        Get
            Return Products.Values.Select(Function(p) p.Quantity.ToString + " x " + p.Code).ToList
        End Get
    End Property

    Public ReadOnly Property ValueList() As List(Of String)
        Get
            Return Products.Values.Select(Function(p) p.ValueWithDiscount.ToString("$0.00")).ToList
        End Get
    End Property

    Private p_Observation As String
    Public Property Observation() As String
        Get
            Return p_Observation
        End Get
        Set(ByVal value As String)
            p_Observation = value
        End Set
    End Property

    Private p_TotalDiscount As Double
    Public Property TotalDiscount() As Double
        Get
            Return p_TotalDiscount
        End Get
        Set(ByVal value As Double)
            p_TotalDiscount = value
        End Set
    End Property

    Public ReadOnly Property PercentDiscount() As Double
        Get
            Return TotalDiscount / SubTotal
        End Get
    End Property

    Public ReadOnly Property SubTotal() As Double
        Get
            Dim value As Double
            value = 0
            For Each item In Products.Values
                value += item.Quantity * item.Value
            Next
            Return value
        End Get
    End Property

    Public ReadOnly Property Total() As Double
        Get
            Return SubTotal - TotalDiscount
        End Get
    End Property

    Private p_Paid As Boolean = False
    Public Property Paid() As Boolean
        Get
            Return p_Paid
        End Get
        Set(ByVal value As Boolean)
            p_Paid = value
        End Set
    End Property

End Class
