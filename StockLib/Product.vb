
''' <summary>
''' Class representing all products (chopp in barrels, bottled beer, beer cans, etc.)
''' </summary>
Public Class Product

    Public Sub New(code As String)
        Me.Code = code
    End Sub

    Public Shared Kinds As New List(Of String) From {
       "Chope",
       "PET",
       "G500",
       "G600",
       "GLong",
       "Lata",
       "Outros"
       }

    Public Shared Units As New List(Of String) From {
        "L",
        "garrafas",
        "garrafas",
        "garrafas",
        "garrafas",
        "latas",
        "unidades"
    }

    Public Shared Sizes As New List(Of String) From {
        "L",
        "1,5L",
        "500mL",
        "600mL",
        "355mL",
        "350mL",
        "unid."
    }

    Private p_Code As String
    Public Property Code() As String
        Get
            Return p_Code
        End Get
        Set(ByVal value As String)
            p_Code = value
        End Set
    End Property

    Public ReadOnly Property Kind() As String
        Get
            Return Split(Code, "-").First
        End Get
    End Property
    Public ReadOnly Property Name() As String
        Get
            Return Split(Code, "-").Last
        End Get
    End Property
    Public ReadOnly Property Unit() As String
        Get
            Return Units(Kinds.IndexOf(Kind))
        End Get
    End Property
    Public ReadOnly Property Size() As String
        Get
            Return Sizes(Kinds.IndexOf(Kind))
        End Get
    End Property

    Private p_Brand As String
    Public Property Brand() As String
        Get
            Return p_Brand
        End Get
        Set(ByVal value As String)
            p_Brand = value
        End Set
    End Property

    Public ReadOnly Property TableName() As String
        Get
            Return "table" + Me.Kind.First + "_" + Me.Name
        End Get
    End Property

    Private p_Quantity As Double
    Public Property Quantity() As Double
        Get
            Return p_Quantity
        End Get
        Set(ByVal value As Double)
            p_Quantity = value
        End Set
    End Property

    Private p_Stock As Double
    Public Property Stock() As Double
        Get
            Return p_Stock
        End Get
        Set(ByVal value As Double)
            p_Stock = value
        End Set
    End Property

    Private p_Value As Double
    Public Property Value() As Double
        Get
            Return p_Value
        End Get
        Set(ByVal value As Double)
            p_Value = value
        End Set
    End Property

    Private p_Cost As Double
    Public Property Cost() As Double
        Get
            Return p_Cost
        End Get
        Set(ByVal value As Double)
            p_Cost = value
        End Set
    End Property

    Private p_Price As Double
    Public Property Price() As Double
        Get
            Return p_Price
        End Get
        Set(ByVal value As Double)
            p_Price = value
        End Set
    End Property

    Private p_Purchases As New Dictionary(Of String, Product.Purchase)
    Public Property Purchases() As Dictionary(Of String, Product.Purchase)
        Get
            Return p_Purchases
        End Get
        Set(ByVal value As Dictionary(Of String, Product.Purchase))
            p_Purchases = value
        End Set
    End Property

    Private p_Orders As New Dictionary(Of String, Product.Order)
    Public Property Orders() As Dictionary(Of String, Product.Order)
        Get
            Return p_Orders
        End Get
        Set(ByVal value As Dictionary(Of String, Product.Order))
            p_Orders = value
        End Set
    End Property

    Private p_Entries As New List(Of Product.Entry)
    Public Property Entries() As List(Of Product.Entry)
        Get
            Return p_Entries
        End Get
        Set(ByVal value As List(Of Product.Entry))
            p_Entries = value
        End Set
    End Property

    Public ReadOnly Property LastBalance As Double
        Get
            Dim lastID = Me.Entries.Last.ID
            If Orders.ContainsKey(lastID) Then
                Return Orders(lastID).Balance
            ElseIf Purchases.ContainsKey(lastID) Then
                Return Purchases(lastID).Balance
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property LastStock As Double
        Get
            Dim lastID = Me.Entries.Last.ID
            If Orders.ContainsKey(lastID) Then
                Return Orders(lastID).Stock
            ElseIf Purchases.ContainsKey(lastID) Then
                Return Purchases(lastID).Stock
            Else
                Return 0
            End If
        End Get
    End Property

End Class
