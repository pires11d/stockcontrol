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
                lblKind.Text = .Kind
                lblName.Text = .Name
                lblBrand.Text = .Brand
                tbQtty.Text = .Quantity.ToString.ToZero
                lblStock.Text = .Stock.ToString.ToZero
                lblQttyUnit.Text = .Unit
                lblStockUnit.Text = .Unit
                lblPriceUnit.Text = "R$/" + .Size
                Select Case FormType
                    Case FormTypes.Order
                        lblOrder.Text = "Itens do Pedido:"
                        lblPrice.Text = "Preço:"
                        tbPrice.Text = .Price.ToString("0.00")
                    Case FormTypes.Purchase
                        lblOrder.Text = "Itens da Compra:"
                        lblPrice.Text = "Custo:"
                        tbPrice.Text = .Cost.ToString("0.00")
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
        End If
    End Sub

    Private Sub tbQtty_TextChanged(sender As Object, e As EventArgs) Handles tbQtty.TextChanged

        With selectedProduct
            If .Quantity > 0 Then
                tvItems.Nodes(.Kind).Nodes(.Name).Checked = True
            Else
                tvItems.Nodes(.Kind).Nodes(.Name).Checked = False
            End If
        End With

    End Sub

    Private Sub tbNF_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged

        Try
            currentOrder = Main.orders(tbID.Text)
            For Each p In currentOrder.Items
                With p
                    If .Quantity > 0 Then
                        tvItems.Nodes(.Kind).Nodes(.Name).Checked = True
                    Else
                        tvItems.Nodes(.Kind).Nodes(.Name).Checked = False
                    End If
                End With
            Next
        Catch ex As Exception

        End Try


    End Sub


End Class