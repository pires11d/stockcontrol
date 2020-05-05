

Partial Public Class Product

    ''' <summary>
    ''' Class representing a single Order (<see cref="Purchase"/> or <see cref="Sale"/>) of the chosen <see cref="Product"/>
    ''' </summary>
    Public MustInherit Class Order

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

        Private p_Index As Integer
        Public Property Index() As Integer
            Get
                Try
                    Return Parent.Orders.IndexOf(Me)
                Catch ex As Exception
                    Return p_Index
                End Try
            End Get
            Set(ByVal value As Integer)
                p_Index = value
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

        Private p_Observation As String
        Public Property Observation() As String
            Get
                Return p_Observation
            End Get
            Set(ByVal value As String)
                p_Observation = value
            End Set
        End Property

        Private p_Parent As Product
        Public Property Parent() As Product
            Get
                Return p_Parent
            End Get
            Set(ByVal value As Product)
                p_Parent = value
            End Set
        End Property

        Private p_Paid As Boolean = False
        Public Property Paid() As Boolean
            Get
                Return p_Paid
            End Get
            Set(ByVal value As Boolean)
                p_Paid = value
            End Set
        End Property

    End Class


End Class