

Partial Public Class Product

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

        Private p_Quantity As Double
        Public Property Quantity() As Double
            Get
                Return p_Quantity
            End Get
            Set(ByVal value As Double)
                p_Quantity = value
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
                Return Me.Client.Name + " " + Me.Observation
            End Get
            Set(value As String)
                If Main.clients.ContainsKey(value) Then
                    Me.Client = Main.clients(value)
                    Me.Observation = ""
                Else
                    Me.Client = Main.clients(value.Split(" ").First)
                    Me.Observation = value.Replace(CStr(Client.Name + " "), "")
                End If
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
