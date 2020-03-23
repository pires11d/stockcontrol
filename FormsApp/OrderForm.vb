Imports StockLib


''' <summary>
''' Form used in the addition/edition of Orders and Purchases
''' </summary>
Public Class OrderForm

    Public Enum FormTypes
        Order
        Purchase
    End Enum

    Public FormType As FormTypes
    Public selectedProduct As Product
    Public currentOrder As Order
    Public currentPurchase As Purchase
    Public itemTable As New DataTable

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Main.LoadProducts()
        LoadControls()

        Select Case FormType
            Case FormTypes.Order
                cbbClient.Enabled = True
                lblID.Text = "ID do Pedido:"
                Width = 1024
            Case FormTypes.Purchase
                cbbClient.Enabled = False
                lblID.Text = "N° da NF:"
                'Width = 512
        End Select

    End Sub

    Public Sub LoadControls()

        'LOADS CLIENTS INTO THE COMBOBOX
        cbbClient.Items.Clear()
        For Each client In clients.Values
            cbbClient.Items.Add(client.Name)
        Next
        cbbClient.SelectedIndex = 0

        'LOADS PRODUCTS INTO THE TREEVIEW
        tvItems.Nodes.Clear()
        For Each k In Product.Kinds
            tvItems.Nodes.Add(k, k)
            tvItems.Nodes(k).NodeFont = New Font(tvItems.Font, FontStyle.Bold)
        Next
        For Each p In products.Values
            tvItems.Nodes(p.Kind).Nodes.Add(p.Name, p.Name)
        Next
        For Each node As TreeNode In tvItems.Nodes
            If IsNothing(node.Parent) Then
                If node.Nodes.Count = 0 Then
                    node.NodeFont = New Font(node.NodeFont, FontStyle.Bold + FontStyle.Strikeout)
                    node.ForeColor = Color.DimGray
                Else
                    node.NodeFont = New Font(node.NodeFont, FontStyle.Bold)
                    node.ForeColor = Color.Black
                End If
                For Each nn As TreeNode In node.Nodes
                    Dim kind As String = nn.Parent.Text
                    Dim name As String = nn.Text
                    If products(kind + "-" + name).Stock = 0 Then
                        nn.NodeFont = New Font(node.NodeFont, FontStyle.Bold + FontStyle.Strikeout)
                        nn.ForeColor = Color.DimGray
                    Else
                        nn.NodeFont = New Font(node.NodeFont, FontStyle.Bold)
                        nn.ForeColor = Color.Black
                    End If
                Next nn
            End If
        Next

    End Sub

    Private Sub tvItems_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvItems.AfterSelect

        If Not IsNothing(e.Node.Parent) Then
            Dim kind As String = e.Node.Parent.Text
            Dim name As String = e.Node.Text
            selectedProduct = Main.products(kind + "-" + name)

            With selectedProduct
                Select Case FormType
                    Case FormTypes.Order
                        If Main.orders.ContainsKey(tbID.Text) Then
                            currentOrder = Main.orders(tbID.Text)
                            If currentOrder.Items.ContainsKey(selectedProduct.Code) Then
                                .Quantity = currentOrder.Items(.Code).Quantity
                                .Value = currentOrder.Items(.Code).Value
                            Else
                                .Quantity = 0
                                .Value = .Price
                            End If
                        End If
                    Case FormTypes.Purchase
                        If Main.purchases.ContainsKey(tbID.Text) Then
                            currentPurchase = Main.purchases(tbID.Text)
                            If currentPurchase.Items.ContainsKey(selectedProduct.Code) Then
                                .Quantity = currentPurchase.Items(.Code).Quantity
                                .Value = currentPurchase.Items(.Code).Value
                            Else
                                .Quantity = 0
                                .Value = .Cost
                            End If
                        End If

                End Select

                lblKind.Text = .Kind
                lblName.Text = .Name
                lblBrand.Text = .Brand
                lblStock.Text = .Stock.ToString.ToZero
                lblQttyUnit.Text = .Unit
                lblStockUnit.Text = .Unit
                lblPriceUnit.Text = "R$/" + .Size

                tbQtty.Text = .Quantity.ToString.ToZero
                tbPrice.Text = .Value.ToString("0.00")

                Select Case FormType
                    Case FormTypes.Order
                        lblOrder.Text = "Itens do Pedido:"
                        lblPrice.Text = "Preço:"
                    Case FormTypes.Purchase
                        lblOrder.Text = "Itens da Compra:"
                        lblPrice.Text = "Custo:"
                End Select

            End With

        End If

    End Sub

    Private Sub tvItems_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvItems.NodeMouseClick
        If Not e.Node.IsExpanded Then
            e.Node.Expand()
        Else
            e.Node.Collapse()
        End If
        If Not IsNothing(e.Node.Parent) Then
            Dim kind As String = e.Node.Parent.Text
            Dim name As String = e.Node.Text
            selectedProduct = Main.products(kind + "-" + name)
        Else
            lblKind.Text = "TIPO"
            lblName.Text = "PRODUTO"
            lblBrand.Text = "MARCA"
            lblQttyUnit.Text = "-"
            lblStock.Text = "-"
            lblStockUnit.Text = "-"
            lblPriceUnit.Text = "R$/-"
            tbQtty.Text = 0
            tbPrice.Text = "0.00"
        End If
    End Sub

    Private Sub tbQtty_TextChanged(sender As Object, e As EventArgs) Handles tbQtty.TextChanged

        Try
            Dim test = Convert.ToDouble(tbQtty.Text)
        Catch ex As Exception
            Exit Sub
        End Try

        Try
            With selectedProduct
                If .Quantity > 0 Or CDbl(tbQtty.Text.ToString.ToZero) > 0 Then
                    tvItems.Nodes(.Kind).Nodes(.Name).Checked = True
                    tvItems.Nodes(.Kind).Nodes(.Name).ForeColor = Color.Red
                Else
                    tvItems.Nodes(.Kind).Nodes(.Name).Checked = False
                    If .Stock > 0 Then
                        tvItems.Nodes(.Kind).Nodes(.Name).ForeColor = Color.Black
                    Else
                        tvItems.Nodes(.Kind).Nodes(.Name).ForeColor = Color.DimGray
                    End If
                End If
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tbNF_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged

        For Each n As TreeNode In tvItems.Nodes
            n.Checked = False
            For Each nn As TreeNode In n.Nodes
                nn.Checked = False
            Next
        Next
        lblTotal.Text = "R$"

        itemTable = New DataTable
        itemTable.Columns.Add("Item")
        itemTable.Columns.Add("Preço")

        Select Case FormType

            Case FormTypes.Order
                If Main.orders.ContainsKey(tbID.Text) Then
                    currentOrder = Main.orders(tbID.Text)
                    For Each p In currentOrder.Items.Values
                        With p
                            If .Quantity > 0 Then
                                tvItems.Nodes(.Kind).Nodes(.Name).Checked = True
                                tvItems.Nodes(.Kind).Nodes(.Name).ForeColor = Color.Red
                                Dim row = {p.Quantity.ToString + " x " + p.Code, p.Value.ToString("R$ 0.00")}
                                itemTable.Rows.Add(row)
                            Else
                                tvItems.Nodes(.Kind).Nodes(.Name).Checked = False
                                If .Stock > 0 Then
                                    tvItems.Nodes(.Kind).Nodes(.Name).ForeColor = Color.Black
                                Else
                                    tvItems.Nodes(.Kind).Nodes(.Name).ForeColor = Color.DimGray
                                End If
                            End If
                        End With
                    Next
                    cbbClient.Text = currentOrder.Client.Name
                    lblTotal.Text = currentOrder.Total.ToString("R$ 0.00")
                End If

            Case FormTypes.Purchase
                If Main.purchases.ContainsKey(tbID.Text) Then
                    currentPurchase = Main.purchases(tbID.Text)
                    For Each p In currentPurchase.Items.Values
                        With p
                            If .Quantity > 0 Then
                                tvItems.Nodes(.Kind).Nodes(.Name).Checked = True
                                tvItems.Nodes(.Kind).Nodes(.Name).ForeColor = Color.Red
                                Dim row = {p.Quantity.ToString + " x " + p.Code, p.Value.ToString("R$ 0.00")}
                                itemTable.Rows.Add(row)
                            Else
                                tvItems.Nodes(.Kind).Nodes(.Name).Checked = False
                                If .Stock > 0 Then
                                    tvItems.Nodes(.Kind).Nodes(.Name).ForeColor = Color.Black
                                Else
                                    tvItems.Nodes(.Kind).Nodes(.Name).ForeColor = Color.DimGray
                                End If
                            End If
                        End With
                    Next
                    lblTotal.Text = currentPurchase.Total.ToString("R$ 0.00")
                End If

        End Select

        lvItems.Rows.Clear()
        lvItems.Columns(1).Width = 100
        With itemTable
            For r = 0 To .Rows.Count - 1
                lvItems.Rows.Add()
                lvItems.Item(0, r).Value = .Rows(r).Item(0)
                lvItems.Item(1, r).Value = .Rows(r).Item(1)
            Next
        End With

    End Sub

    Private Sub tvItems_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvItems.AfterCheck
        If Not IsNothing(e.Node.Parent) Then
            e.Node.Parent.Checked = e.Node.Checked
        End If
        If e.Node.Checked Then
            e.Node.ForeColor = Color.Red
        Else
            e.Node.ForeColor = Color.Black
            If Not IsNothing(e.Node.Parent) Then
                If products(e.Node.Parent.Text + "-" + e.Node.Text).Stock = 0 Then
                    e.Node.ForeColor = Color.DimGray
                End If
            End If
        End If
    End Sub

End Class