
''' <summary>
''' Class representing the Sale of any bought products (Saída)
''' </summary>
Public Class Sale

    Inherits Order

    Public Sub New(id As String)
        MyBase.New(id)
    End Sub

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

    Public ReadOnly Property Items() As List(Of Item)
        Get
            Dim result As New List(Of Item)
            result.AddRange(Barrels.Values.ToList)
            result.AddRange(Coolers.Values.ToList)
            result.AddRange(Cylinders.Values.ToList)
            result.AddRange(Valves.Values.ToList)
            Return result
        End Get
    End Property

    Public ReadOnly Property ItemList() As List(Of String)
        Get
            Return Items.Select(Function(i) i.ID + " ").ToList
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
            Return Coolers.Count > 0
        End Get
    End Property

    Private p_Barrels As New Dictionary(Of String, Barrel)
    Public Property Barrels() As Dictionary(Of String, Barrel)
        Get
            Return p_Barrels
        End Get
        Set(ByVal value As Dictionary(Of String, Barrel))
            p_Barrels = value
        End Set
    End Property

    Private p_Coolers As New Dictionary(Of String, Cooler)
    Public Property Coolers() As Dictionary(Of String, Cooler)
        Get
            Return p_Coolers
        End Get
        Set(ByVal value As Dictionary(Of String, Cooler))
            p_Coolers = value
        End Set
    End Property

    Private p_Cylinders As New Dictionary(Of String, Cylinder)
    Public Property Cylinders() As Dictionary(Of String, Cylinder)
        Get
            Return p_Cylinders
        End Get
        Set(ByVal value As Dictionary(Of String, Cylinder))
            p_Cylinders = value
        End Set
    End Property

    Private p_Valves As New Dictionary(Of String, Valve)
    Public Property Valves() As Dictionary(Of String, Valve)
        Get
            Return p_Valves
        End Get
        Set(ByVal value As Dictionary(Of String, Valve))
            p_Valves = value
        End Set
    End Property

End Class
