
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

    Private p_BuyingDate As Date
    Public Property BuyingDate() As Date
        Get
            Return p_BuyingDate
        End Get
        Set(ByVal value As Date)
            p_BuyingDate = value
        End Set
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

    Private p_Items As New Dictionary(Of String, Product)
    Public Property Items() As Dictionary(Of String, Product)
        Get
            Return p_Items
        End Get
        Set(ByVal value As Dictionary(Of String, Product))
            p_Items = value
        End Set
    End Property

    Public ReadOnly Property Total() As Double
        Get
            Dim value As Double
            value = 0
            For Each item In Items.Values
                value += item.Quantity * item.Value
            Next
            Return value
        End Get
    End Property

    Public ReadOnly Property Vendor() As Vendor
        Get
            Dim mostFrequent As String
            Dim vList As New List(Of String)
            For Each item In Items.Values
                vList.Add(item.Brand)
            Next
            mostFrequent = vList.OrderByDescending(Function(x) x.Count()).First
            Return New Vendor(mostFrequent)
        End Get
    End Property

End Class
