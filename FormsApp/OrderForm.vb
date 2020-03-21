Imports StockLib.Main


''' <summary>
''' Form used in the addition/edition of Orders and Purchases
''' </summary>
Public Class OrderForm

    Public Sub New()

        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbClient.Items.Clear()
        For Each client In clientList
            cbbClient.Items.Add(client.Name)
        Next
        cbbClient.SelectedIndex = 0

    End Sub

End Class