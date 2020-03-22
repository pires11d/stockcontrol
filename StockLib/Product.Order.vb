

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

        Private p_Description As String
        Public Property Description() As String
            Get
                Return p_Description
            End Get
            Set(ByVal value As String)
                p_Description = value
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

        Private p_Value As Double
        Public Property Value() As Double
            Get
                Return p_Value
            End Get
            Set(ByVal value As Double)
                p_Value = value
            End Set
        End Property

        Public ReadOnly Property Price() As Double
            Get
                Return Me.Value / Me.Quantity
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

    End Class

End Class
