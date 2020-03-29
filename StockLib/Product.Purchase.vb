

Partial Public Class Product

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

        Private p_Row As Integer
        Public Property Row() As Integer
            Get
                Return p_Row
            End Get
            Set(ByVal value As Integer)
                p_Row = value
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

        Private p_Quantity As Double
        Public Property Quantity() As Double
            Get
                Return p_Quantity
            End Get
            Set(ByVal value As Double)
                p_Quantity = value
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

        Public Property Value() As Double
            Get
                Return Me.Cost * Me.Quantity
            End Get
            Set(value As Double)
                Me.Cost = value / Me.Quantity
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

        Private p_Balance As Double
        Public Property Balance() As Double
            Get
                Return p_Balance
            End Get
            Set(ByVal value As Double)
                p_Balance = value
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

        Public Property Description() As String
            Get
                Return CStr(Me.Vendor.Name + " " + Observation).Replace("  ", " ")
            End Get
            Set(value As String)
                Me.Vendor = Main.vendors(Main.GetVendorName(value))
                Me.Observation = value.Replace(Vendor.Name, "")
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

End Class
