

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

        Private p_Value As Double
        Public Property Value() As Double
            Get
                Return p_Value
            End Get
            Set(ByVal value As Double)
                p_Value = value
            End Set
        End Property

        Public ReadOnly Property Cost() As Double
            Get
                Return Me.Value / Me.Quantity
            End Get
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
