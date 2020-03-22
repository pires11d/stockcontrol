
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

    Private p_Client As Client
    Public Property Client() As Client
        Get
            Return p_Client
        End Get
        Set(ByVal value As Client)
            p_Client = value
        End Set
    End Property

    Private p_Items As New List(Of Product)
    Public Property Items() As List(Of Product)
        Get
            Return p_Items
        End Get
        Set(ByVal value As List(Of Product))
            p_Items = value
        End Set
    End Property

    Private p_Prices As New List(Of Double)
    Public Property Prices() As List(Of Double)
        Get
            Return p_Prices
        End Get
        Set(ByVal value As List(Of Double))
            p_Prices = value
        End Set
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
