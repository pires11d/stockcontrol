Imports StockLib


''' <summary>
''' Form used to display a history of information for a certain <see cref="Item"/> or <see cref="Client"/>
''' </summary>
Public Class HistoryForm

    Public CurrentElement As Object

    Public Sub New(element As Object)

        InitializeComponent()

        Me.CurrentElement = element

    End Sub

    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OrderHistorySchema.OrderTable.Rows.Clear()
        If TypeOf CurrentElement Is Item Then
            Dim i = TryCast(CurrentElement, Item)
            For Each o In i.Orders
                OrderHistorySchema.OrderTable.AddOrderTableRow(o.ID,
                                                               o.Client.Name,
                                                               Join(o.ItemList.ToArray, " "),
                                                               o.SellingDate.ToShortDateString,
                                                               o.SellingResponsible.NotNull,
                                                               o.RetrievingDate.ToShortDateString,
                                                               o.RetrievingResponsible.NotNull,
                                                               StringFromBoolean(o.Retrieved),
                                                               Join(o.OrderList.ToArray, "; "),
                                                               Join(o.PriceList.ToArray, "; "),
                                                               o.Total,
                                                               o.Observation)

            Next
        ElseIf TypeOf CurrentElement Is Client Then

        End If

        With lvHistory
            .Columns(10).DefaultCellStyle.Format = "R$ 0.00"
            .ColumnHeadersDefaultCellStyle.Font = New Font(.DefaultCellStyle.Font, FontStyle.Bold)
        End With

    End Sub

End Class