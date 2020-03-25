
''' <summary>
''' Class representing the Order of any bought products (Saída)
''' </summary>
Public Class Order

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

    Private p_SellingDate As Date
    Public Property SellingDate() As Date
        Get
            Return p_SellingDate
        End Get
        Set(ByVal value As Date)
            p_SellingDate = value
        End Set
    End Property

    Private p_RetrievingDate As Date
    Public Property RetrievingDate() As Date
        Get
            Return p_RetrievingDate
        End Get
        Set(ByVal value As Date)
            p_RetrievingDate = value
        End Set
    End Property

    Private p_SellingResponsible As String
    Public Property SellingResponsible() As String
        Get
            Return p_SellingResponsible
        End Get
        Set(ByVal value As String)
            p_SellingResponsible = value
        End Set
    End Property

    Private p_RetrievingResponsible As String
    Public Property RetrievingResponsible() As String
        Get
            Return p_RetrievingResponsible
        End Get
        Set(ByVal value As String)
            p_RetrievingResponsible = value
        End Set
    End Property

    Private p_ItemList As List(Of String)
    Public Property ItemList() As List(Of String)
        Get
            Return p_ItemList
        End Get
        Set(ByVal value As List(Of String))
            p_ItemList = value
        End Set
    End Property

    Public ReadOnly Property OrderList() As List(Of String)
        Get
            Return Items.Values.Select(Function(x) x.Quantity.ToString + " x " + x.Code).ToList
        End Get
    End Property

    Public ReadOnly Property PriceList() As List(Of String)
        Get
            Return Items.Values.Select(Function(x) x.Value.ToString("$0.00")).ToList
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

    Private p_Client As Client
    Public Property Client() As Client
        Get
            Return p_Client
        End Get
        Set(ByVal value As Client)
            p_Client = value
        End Set
    End Property

    Private p_Retrieved As Boolean
    Public Property Retrieved() As Boolean
        Get
            Return p_Retrieved
        End Get
        Set(ByVal value As Boolean)
            p_Retrieved = value
        End Set
    End Property

    Public ReadOnly Property IncludesCooler() As Boolean
        Get
            Return CoolerList.Count > 0
        End Get
    End Property

    Private p_BarrelList As New List(Of Barrel)
    Public Property BarrelList() As List(Of Barrel)
        Get
            Return p_BarrelList
        End Get
        Set(ByVal value As List(Of Barrel))
            p_BarrelList = value
        End Set
    End Property

    Private p_CoolerList As New List(Of Cooler)
    Public Property CoolerList() As List(Of Cooler)
        Get
            Return p_CoolerList
        End Get
        Set(ByVal value As List(Of Cooler))
            p_CoolerList = value
        End Set
    End Property

    Private p_ValveList As New List(Of Valve)
    Public Property ValveList() As List(Of Valve)
        Get
            Return p_ValveList
        End Get
        Set(ByVal value As List(Of Valve))
            p_ValveList = value
        End Set
    End Property

    Private p_GasList As New List(Of Gas)
    Public Property GasList() As List(Of Gas)
        Get
            Return p_GasList
        End Get
        Set(ByVal value As List(Of Gas))
            p_GasList = value
        End Set
    End Property


End Class
