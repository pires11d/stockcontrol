

Partial Public Class Product

    Public MustInherit Class Entry

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
                    Return Parent.Entries.IndexOf(Me)
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

        'Private p_Stock As Double
        'Public Property Stock() As Double
        '    Get
        '        If Me.Parent.Orders.ContainsKey(Me.ID) Then
        '            If Me.Index < 1 Then
        '                Return -Me.Quantity
        '            Else
        '                Return Me.Parent.Entries.Item(Me.Index - 1).Stock - Me.Quantity
        '            End If
        '        ElseIf Me.Parent.Purchases.ContainsKey(Me.ID) Then
        '            If Me.Index < 1 Then
        '                Return +Me.Quantity
        '            Else
        '                Return Me.Parent.Entries.Item(Me.Index - 1).Stock + Me.Quantity
        '            End If
        '        Else
        '            Return p_Stock
        '        End If
        '    End Get
        '    Set(ByVal value As Double)
        '        p_Stock = value
        '    End Set
        'End Property

        'Private p_Balance As Double
        'Public Property Balance() As Double
        '    Get
        '        If Me.Parent.Orders.ContainsKey(Me.ID) Then
        '            If Me.Index <= 1 Then
        '                Return +Me.Value
        '            Else
        '                Return Me.Parent.Entries.Item(Me.Index - 1).Balance + Me.Value
        '            End If
        '        ElseIf Me.Parent.Purchases.ContainsKey(Me.ID) Then
        '            If Me.Index <= 1 Then
        '                Return -Me.Value
        '            Else
        '                Return Me.Parent.Entries.Item(Me.Index - 1).Balance - Me.Value
        '            End If
        '        End If
        '    End Get
        '    Set(ByVal value As Double)
        '        p_Balance = value
        '    End Set
        'End Property

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


    End Class


End Class