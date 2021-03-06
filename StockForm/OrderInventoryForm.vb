﻿Imports StockLib


''' <summary>
''' Form used to display the availability of <see cref="Item"/> objects present in the inventory to an <see cref="Sale"/>
''' </summary>
Public Class OrderInventoryForm

    Public CurrentSale As Sale
    Public Sub New(currentSale As Sale)

        InitializeComponent()

        Me.CurrentSale = currentSale

    End Sub

    Private Sub OrderInventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTreeViews()

        cbbState.Checked = CurrentSale.Retrieved

        Me.AcceptButton = btnOK

    End Sub

    Private Sub LoadTreeViews()

        'LOADS BARREL TREEVIEW
        tvB.Nodes.Clear()
        For Each bb In Barrel.Types
            tvB.Nodes.Add(bb, bb)
        Next
        For Each b In barrels.Values
            If b.State Or CurrentSale.Barrels.Values.Contains(b) Then
                tvB.Nodes.Item(b.Type).Nodes.Add(b.ID, b.ID)
            End If
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
        For Each n As TreeNode In tvB.Nodes
            n.Checked = False
            For Each nn As TreeNode In n.Nodes
                If CurrentSale.Barrels.ContainsKey(nn.Text) Then
                    nn.Checked = True
                    nn.Parent.Checked = nn.Checked
                End If
            Next
        Next

        'LOADS COOLER TREEVIEW
        tvC.Nodes.Clear()
        For Each cc In Cooler.Types
            tvC.Nodes.Add(cc, cc)
        Next
        For Each c In coolers.Values
            If c.State Or CurrentSale.Coolers.Values.Contains(c) Then
                tvC.Nodes.Item(c.Type).Nodes.Add(c.ID, c.ID)
            End If
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
        For Each n As TreeNode In tvC.Nodes
            n.Checked = False
            For Each nn As TreeNode In n.Nodes
                If CurrentSale.Coolers.ContainsKey(nn.Text) Then
                    nn.Checked = True
                    nn.Parent.Checked = nn.Checked
                End If
            Next
        Next

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        For Each item In CurrentSale.Items
            If Main.barrels.ContainsKey(item.ID) Then Main.barrels(item.ID).State = cbbState.Checked
            If Main.coolers.ContainsKey(item.ID) Then Main.coolers(item.ID).State = cbbState.Checked
        Next

        Main.UpdateTables()
        Main.GetTables()
        MainForm.LoadTables()
        OrderForm.cbbResp2.Enabled = CurrentSale.Retrieved
        OrderForm.datePicker2.Enabled = CurrentSale.Retrieved
        Me.Close()
    End Sub

    Private Sub tvB_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvB.AfterCheck
        If e.Node.Checked Then e.Node.ForeColor = ColorFromBoolean(Not e.Node.Checked)
        If IsNothing(e.Node.Parent) Then Exit Sub

        If e.Action = TreeViewAction.ByMouse Then
            Dim bID = e.Node.Text
            If e.Node.Checked Then
                CurrentSale.Barrels.Add(bID, Main.barrels(bID))
                e.Node.ForeColor = ColorFromBoolean(False)
            Else
                CurrentSale.Barrels.Remove(bID)
                e.Node.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub tvC_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvC.AfterCheck
        If e.Node.Checked Then e.Node.ForeColor = ColorFromBoolean(Not e.Node.Checked)
        If IsNothing(e.Node.Parent) Then Exit Sub

        If e.Action = TreeViewAction.ByMouse Then
            Dim cID = e.Node.Text
            If e.Node.Checked Then
                CurrentSale.Coolers.Add(cID, Main.coolers(cID))
                e.Node.ForeColor = ColorFromBoolean(False)
            Else
                CurrentSale.Coolers.Remove(cID)
                e.Node.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub cbbState_CheckedChanged(sender As Object, e As EventArgs) Handles cbbState.CheckedChanged

        CurrentSale.Retrieved = cbbState.Checked

        For Each item In CurrentSale.Items
            item.State = cbbState.Checked
            If Main.barrels.ContainsKey(item.ID) Then Main.barrels(item.ID).State = cbbState.Checked
            If Main.coolers.ContainsKey(item.ID) Then Main.coolers(item.ID).State = cbbState.Checked
            'If Main.cylinders.Values.Contains(item) Then Main.cylinders(item.ID).State = cbbState.Checked
            'If Main.valves.Values.Contains(item) Then Main.valves(item.ID).State = cbbState.Checked
        Next

    End Sub

End Class