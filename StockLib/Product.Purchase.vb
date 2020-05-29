

Partial Public Class Product

    ''' <summary>
    ''' Class representing a single <see cref="Purchase"/> of the chosen <see cref="Product"/>
    ''' </summary>
    Public Class Purchase

        Inherits Product.Order

        Public Sub New(id As String)
            MyBase.New(id)
        End Sub

        Private p_BuyingDate As Date
        Public Property BuyingDate() As Date
            Get
                Return p_BuyingDate
            End Get
            Set(ByVal value As Date)
                p_BuyingDate = value
            End Set
        End Property

        Private p_Stock As Double
        Public Property Stock() As Double
            Get
                If Me.Index < 1 Then
                    Return +Me.Quantity
                Else
                    Dim lastID = Me.Parent.Orders.Item(Me.Index - 1).ID
                    If Me.Parent.Sales.ContainsKey(lastID) Then
                        Return Me.Parent.Sales(lastID).Stock + Me.Quantity
                    ElseIf Me.Parent.Purchases.ContainsKey(lastID) Then
                        Return Me.Parent.Purchases(lastID).Stock + Me.Quantity
                    Else
                        Return +Me.Quantity
                    End If
                End If
            End Get
            Set(value As Double)
                p_Stock = value
            End Set
        End Property

        Private p_Balance As Double
        Public Property Balance() As Double
            Get
                If Me.Index < 1 Then
                    Return -Me.Value
                Else
                    Dim lastID = Me.Parent.Orders.Item(Me.Index - 1).ID
                    If Me.Parent.Sales.ContainsKey(lastID) Then
                        Return Me.Parent.Sales(lastID).Balance - Me.Value
                    ElseIf Me.Parent.Purchases.ContainsKey(lastID) Then
                        Return Me.Parent.Purchases(lastID).Balance - Me.Value
                    Else
                        Return -Me.Value
                    End If
                End If
            End Get
            Set(ByVal value As Double)
                p_Balance = value
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

        Public Property Description() As String
            Get
                If Me.Observation = "" Then
                    Return Me.Vendor.Name
                Else
                    Return CStr(Me.Vendor.Name + ": " + Me.Observation).Replace("  ", " ")
                End If
            End Get
            Set(value As String)
                'Me.Observation = value.Replace(Vendor.Name, "")
                If value.Contains(": ") Then
                    Me.Observation = value.Split(": ").LastOrDefault
                    Me.Vendor = Main.vendors(Main.GetVendorName(value.Split(": ").FirstOrDefault))
                Else
                    Me.Observation = ""
                    Me.Vendor = Main.vendors(Main.GetVendorName(value))
                End If
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
