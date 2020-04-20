
''' <summary>
''' Class representing the Purchase of any products (Entrada)
''' </summary>
Public Class Purchase

    Inherits Order

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

    Public ReadOnly Property Vendor() As Vendor
        Get
            Try
                Dim mostFrequent As String
                Dim vList As New List(Of String)
                For Each item In Products.Values
                    vList.Add(item.Brand)
                Next
                mostFrequent = vList.OrderByDescending(Function(x) x.Count()).First
                Return New Vendor(mostFrequent)
            Catch ex As Exception
                Try
                    Return Main.vendors.Values.Where(Function(v) v.Code = Me.ID.Substring(0, 2)).First
                Catch ex2 As Exception
                    Return New Vendor("")
                End Try
            End Try
        End Get
    End Property

End Class
