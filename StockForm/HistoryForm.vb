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
            For Each o In i.Sales
                OrderHistorySchema.OrderTable.AddOrderTableRow(o.ID,
                                                                   o.Client.Name,
                                                                   Join(o.ItemList.ToArray, " "),
                                                                   o.SellingDate.ToShortDateString,
                                                                   o.SellingResponsible.NotNull,
                                                                   o.RetrievingDate.ToShortDateString,
                                                                   o.RetrievingResponsible.NotNull,
                                                                   StringFromBoolean(o.Retrieved),
                                                                   Join(o.ProductList.ToArray, "; "),
                                                                   Join(o.ValueList.ToArray, "; "),
                                                                   o.SubTotal,
                                                                   o.Observation)

            Next
        ElseIf TypeOf CurrentElement Is Client Then
            Dim c = TryCast(CurrentElement, Client)
            For Each o In c.Sales
                OrderHistorySchema.OrderTable.AddOrderTableRow(o.ID,
                                                                   o.Client.Name,
                                                                   Join(o.ItemList.ToArray, " "),
                                                                   o.SellingDate.ToShortDateString,
                                                                   o.SellingResponsible.NotNull,
                                                                   o.RetrievingDate.ToShortDateString,
                                                                   o.RetrievingResponsible.NotNull,
                                                                   StringFromBoolean(o.Retrieved),
                                                                   Join(o.ProductList.ToArray, "; "),
                                                                   Join(o.ValueList.ToArray, "; "),
                                                                   o.SubTotal,
                                                                   o.Observation)

            Next
        End If


        With lvHistory
            .Columns(10).DefaultCellStyle.Format = "R$ 0.00"
            .ColumnHeadersDefaultCellStyle.Font = New Font(Main.fontName, 10, FontStyle.Bold)
        End With

    End Sub

End Class