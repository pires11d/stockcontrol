Imports StockLib


''' <summary>
''' Form used to display of the information of all <see cref="Item"/> objects present in the inventory
''' </summary>
Public Class InventoryForm

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTreeViews()

    End Sub

    Public Sub LoadTreeViews()

        tvB.Nodes.Clear()
        For Each bb In Barrel.Types
            tvB.Nodes.Add(bb, bb)
        Next
        For Each b In barrels.Values
            tvB.Nodes.Item(b.Type).Nodes.Add(b.ID, b.ID)
        Next

        tvC.Nodes.Clear()
        For Each cc In Cooler.Types
            tvC.Nodes.Add(cc, cc)
        Next
        For Each c In coolers.Values
            tvC.Nodes.Item(c.Type).Nodes.Add(c.ID, c.ID)
        Next

    End Sub


End Class