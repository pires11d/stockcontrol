

Partial Public Class Product

    Public Class Order

        Inherits Product.Entry

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

        Private p_Stock As Double
        Public Property Stock() As Double
            Get
                If Me.Index < 1 Then
                    Return -Me.Quantity
                Else
                    Dim lastID = Me.Parent.Entries.Item(Me.Index - 1).ID
                    If Me.Parent.Orders.ContainsKey(lastID) Then
                        Return Me.Parent.Orders(lastID).Stock - Me.Quantity
                    ElseIf Me.Parent.Purchases.ContainsKey(lastID) Then
                        Return Me.Parent.Purchases(lastID).Stock - Me.Quantity
                    Else
                        Return -Me.Quantity
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
                    Return +Me.Value
                Else
                    Dim lastID = Me.Parent.Entries.Item(Me.Index - 1).ID
                    If Me.Parent.Orders.ContainsKey(lastID) Then
                        Return Me.Parent.Orders(lastID).Balance + Me.Value
                    ElseIf Me.Parent.Purchases.ContainsKey(lastID) Then
                        Return Me.Parent.Purchases(lastID).Balance + Me.Value
                    Else
                        Return +Me.Value
                    End If
                End If
            End Get
            Set(ByVal value As Double)
                p_Balance = value
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

        Public Property Value() As Double
            Get
                Return Me.Price * Me.Quantity
            End Get
            Set(ByVal value As Double)
                Me.Price = value / Me.Quantity
            End Set
        End Property

        Public Property Description() As String
            Get
                Return (Me.Client.Name + " " + Me.Observation).Replace("  ", " ")
            End Get
            Set(value As String)
                Me.Client = Main.clients(Main.GetClientName(value))
                Me.Observation = value.Replace(Client.Name, "")
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

    End Class

End Class
