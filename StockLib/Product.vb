
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
            Return Me.Kind + "_" + Me.Name
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

    Private p_Price2 As Double
    Public Property Price2() As Double
        Get
            Return p_Price2
        End Get
        Set(ByVal value As Double)
            p_Price2 = value
        End Set
    End Property

    Private p_HasDiscount As Boolean = False
    Public Property HasDiscount() As Boolean
        Get
            Return p_HasDiscount
        End Get
        Set(ByVal value As Boolean)
            p_HasDiscount = value
        End Set
    End Property

    Private p_Discount As Double = 0
    Public Property Discount() As Double
        Get
            Return p_Discount
        End Get
        Set(ByVal value As Double)
            p_Discount = value
        End Set
    End Property

    Public ReadOnly Property ValueWithDiscount() As Double
        Get
            Return Value - Discount
        End Get
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

    Private p_Sales As New Dictionary(Of String, Product.Sale)
    Public Property Sales() As Dictionary(Of String, Product.Sale)
        Get
            Return p_Sales
        End Get
        Set(ByVal value As Dictionary(Of String, Product.Sale))
            p_Sales = value
        End Set
    End Property

    Private p_Orders As New List(Of Product.Order)
    Public Property Orders() As List(Of Product.Order)
        Get
            Return p_Orders
        End Get
        Set(ByVal value As List(Of Product.Order))
            p_Orders = value
        End Set
    End Property

    Public ReadOnly Property LastBalance As Double
        Get
            If Me.Orders.Count > 0 Then
                Dim lastID = Me.Orders.Last.ID
                If Me.Sales.ContainsKey(lastID) Then
                    Return Me.Sales(lastID).Balance
                ElseIf Purchases.ContainsKey(lastID) Then
                    Return Me.Purchases(lastID).Balance
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property LastStock As Double
        Get
            If Me.Orders.Count > 0 Then
                Dim lastID = Me.Orders.Last.ID
                If Me.Sales.ContainsKey(lastID) Then
                    Return Me.Sales(lastID).Stock
                ElseIf Purchases.ContainsKey(lastID) Then
                    Return Me.Purchases(lastID).Stock
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        End Get
    End Property

    Private p_Table As New DataTable
    Public Property Table() As DataTable
        Get
            Return p_Table
        End Get
        Set(ByVal value As DataTable)
            p_Table = value
        End Set
    End Property

End Class
