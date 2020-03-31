Imports StockLib


''' <summary>
''' Form used to display the availability of <see cref="Item"/> objects present in the inventory to an <see cref="Order"/>
''' </summary>
Public Class OrderInventoryForm

    Public Sub New(currentOrder As Order)

        InitializeComponent()

        Me.CurrentOrder = currentOrder

    End Sub

    Public CurrentOrder As Order

    Private Sub OrderInventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTreeViews()

        Me.AcceptButton = btnOK

    End Sub

    Private Sub LoadTreeViews()

        'LOADS BARREL TREEVIEW
        tvB.Nodes.Clear()
        For Each bb In Barrel.Types
            tvB.Nodes.Add(bb, bb)
        Next
        For Each b In barrels.Values
            If b.State Or CurrentOrder.Barrels.Values.Contains(b) Then
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
                If CurrentOrder.Barrels.ContainsKey(nn.Text) Then
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
            If c.State Or CurrentOrder.Coolers.Values.Contains(c) Then
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
                If CurrentOrder.Coolers.ContainsKey(nn.Text) Then
                    nn.Checked = True
                    nn.Parent.Checked = nn.Checked
                End If
            Next
        Next

        'tvB.Nodes.Item(0).Expand()
        'tvC.Nodes.Item(0).Expand()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Main.UpdateTables()
        Me.Close()
    End Sub

    Private Sub tvB_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvB.AfterCheck
        If e.Node.Checked Then e.Node.ForeColor = ColorFromBoolean(Not e.Node.Checked)
        If IsNothing(e.Node.Parent) Then Exit Sub

        If e.Action = TreeViewAction.ByMouse Then
            Dim bID = e.Node.Text
            If e.Node.Checked Then
                CurrentOrder.Barrels.Add(bID, Main.barrels(bID))
                e.Node.ForeColor = ColorFromBoolean(False)
            Else
                CurrentOrder.Barrels.Remove(bID)
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
                CurrentOrder.Coolers.Add(cID, Main.coolers(cID))
                e.Node.ForeColor = ColorFromBoolean(False)
            Else
                CurrentOrder.Coolers.Remove(cID)
                e.Node.ForeColor = Color.Black
            End If
        End If

    End Sub

    'Private Sub tvB_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvB.NodeMouseClick
    '    If e.Node.IsExpanded Then
    '        e.Node.Collapse()
    '    Else
    '        e.Node.Expand()
    '    End If
    'End Sub

    'Private Sub tvC_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvC.NodeMouseClick
    '    If e.Node.IsExpanded Then
    '        e.Node.Collapse()
    '    Else
    '        e.Node.Expand()
    '    End If
    'End Sub

End Class