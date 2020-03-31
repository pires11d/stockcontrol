﻿Imports StockLib


''' <summary>
''' Form used to display all information of the <see cref="Item"/> objects present in the inventory
''' </summary>
Public Class InventoryForm

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTreeViews()

    End Sub

    Public Sub LoadTreeViews()

        'LOADS BARREL TREEVIEW
        tvB.Nodes.Clear()
        For Each bb In Barrel.Types
            tvB.Nodes.Add(bb, bb)
        Next
        For Each b In barrels.Values
            tvB.Nodes.Item(b.Type).Nodes.Add(b.ID, b.ID)
            tvB.Nodes.Item(b.Type).Nodes.Item(b.ID).ForeColor = ColorFromBoolean(b.State)
        Next
        For Each n As TreeNode In tvB.Nodes
            If n.Nodes.Count > 0 Then
                n.NodeFont = New Font(n.TreeView.Font, FontStyle.Bold)
                n.ForeColor = Color.Black
            Else
                n.NodeFont = New Font(n.TreeView.Font, FontStyle.Bold + FontStyle.Strikeout)
                n.ForeColor = Color.DimGray
            End If
        Next
        tvB.Nodes.Item(0).Expand()

        'LOADS COOLER TREEVIEW
        tvC.Nodes.Clear()
        For Each cc In Cooler.Types
            tvC.Nodes.Add(cc, cc)
        Next
        For Each c In coolers.Values
            tvC.Nodes.Item(c.Type).Nodes.Add(c.ID, c.ID)
            tvC.Nodes.Item(c.Type).Nodes.Item(c.ID).ForeColor = ColorFromBoolean(c.State)
        Next
        For Each n As TreeNode In tvC.Nodes
            If n.Nodes.Count > 0 Then
                n.NodeFont = New Font(n.TreeView.Font, FontStyle.Bold)
                n.ForeColor = Color.Black
            Else
                n.NodeFont = New Font(n.TreeView.Font, FontStyle.Bold + FontStyle.Strikeout)
                n.ForeColor = Color.DimGray
            End If
        Next
        tvC.Nodes.Item(0).Expand()

    End Sub

    Private Sub tvB_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvB.AfterSelect

        If IsNothing(e.Node.Parent) Then
            lblKind.Text = "BARRIL"
            lblType.Text = e.Node.Text
            lblID.Text = "-"
            lblState.Text = "-"
            lblState.ForeColor = Color.Black
            Exit Sub
        End If

        Dim b = barrels(e.Node.Text)

        UpdateLabels(b)

    End Sub

    Private Sub tvC_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvC.AfterSelect

        If IsNothing(e.Node.Parent) Then
            lblKind.Text = "CHOPEIRA"
            lblType.Text = e.Node.Text
            lblID.Text = "-"
            lblState.Text = "-"
            lblState.ForeColor = Color.Black
            Exit Sub
        End If

        Dim c = coolers(e.Node.Text)

        UpdateLabels(c)

    End Sub

    Public Sub UpdateLabels(i As Item)

        lblKind.Text = i.Kind.ToString.ToUpper
        lblType.Text = i.Type
        lblID.Text = i.ID
        lblState.Text = StringFromBoolean(i.State)
        lblState.ForeColor = ColorFromBoolean(i.State)

        If i.Orders.Count > 0 Then
            lblLastOrder.Text = i.Orders.Last.ID
            lblLastClient.Text = i.Orders.Last.Client.Name
            lblLastAddress.Text = i.Orders.Last.Client.FullAddress
        End If

    End Sub

End Class