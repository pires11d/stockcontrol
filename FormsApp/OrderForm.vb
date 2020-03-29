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
    Public NewEntry As Boolean = False
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

    End Sub

    Public Sub ChangeInputColors(color As Color)
        tbID.BackColor = color
        tbQtty.BackColor = color
        tbPrice.BackColor = color
        tbObs.BackColor = color

        cbbClient.BackColor = color
        cbbResp1.BackColor = color
        cbbResp2.BackColor = color

        tvItems.BackColor = color
    End Sub

    Public Sub LoadControls()

        Me.AcceptButton = btnOK

        'RESETS SPECIFIC CONTROLS ACCORDING TO FORMTYPE
        Select Case FormType
            Case FormTypes.Order
                cbbClient.Enabled = True
                lblID.Text = "ID do Pedido:"
                lblOrder.Text = "Itens do Pedido:"
                datePicker2.Enabled = True
                cbbResp1.Enabled = True
                cbbResp2.Enabled = True
                Me.Text = "Pedido"
                tbID.BackColor = SystemColors.Info
            Case FormTypes.Purchase
                cbbClient.Enabled = False
                lblID.Text = "N° da NF:"
                lblOrder.Text = "Itens da Compra:"
                datePicker2.Enabled = False
                cbbResp1.Enabled = False
                cbbResp2.Enabled = False
                Me.Text = "Compra"
                tbID.BackColor = SystemColors.GradientInactiveCaption
        End Select

        'RESETS OTHER CONTROLS    
        datePicker1.Value = Date.Today
        datePicker2.Value = Date.Today
        cbbClient.Text = ""

        'LOADS CLIENTS INTO THE COMBOBOX
        cbbClient.Items.Clear()
        For Each client In Main.clients.Values
            cbbClient.Items.Add(client.Name)
        Next
        cbbClient.SelectedIndex = 0

        'LOADS RESPONSIBLES LIST INTO THE COMBOBOX
        cbbResp1.Items.Clear()
        cbbResp2.Items.Clear()
        For r = 0 To tableResp.Rows.Count - 1
            cbbResp1.Items.Add(tableResp.Rows(r).Item(0))
            cbbResp2.Items.Add(tableResp.Rows(r).Item(0))
        Next

        'LOADS PRODUCTS INTO THE TREEVIEW
        tvItems.Nodes.Clear()
        For Each k In Product.Kinds
            tvItems.Nodes.Add(k, k)
            tvItems.Nodes(k).NodeFont = New Font(tvItems.Font, FontStyle.Bold)
        Next
        For Each p In products.Values
            tvItems.Nodes(p.Kind).Nodes.Add(p.Name, p.Name)
        Next

        'CUSTOMIZES FONT COLOR FOR EACH NODE
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

    Private Sub tbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged

        If NewEntry Then
            If tbID.Text = "" Then
                AddToolStripMenuItem.Enabled = False
            Else
                AddToolStripMenuItem.Enabled = True
            End If

            Select Case FormType
                Case FormTypes.Order
                    currentOrder.ID = tbID.Text
                Case FormTypes.Purchase
                    currentPurchase.ID = tbID.Text
            End Select

            ChangeInputColors(SystemColors.Window)

            Exit Sub
        End If

        'RESETS THE CONTROL VALUES TO THEIR DEFAULTS   
        cbbResp1.Text = ""
        cbbResp2.Text = ""
        cbbClient.Text = ""
        datePicker1.Value = Date.Today
        datePicker2.Value = Date.Today
        lblTotal.Text = "R$"
        lvItems.Rows.Clear()
        lvItems.Columns(1).Width = 100
        RemoveToolStripMenuItem.Enabled = False
        For Each n As TreeNode In tvItems.Nodes
            n.Checked = False
            For Each nn As TreeNode In n.Nodes
                nn.Checked = False
            Next
        Next
        ChangeInputColors(SystemColors.Control)

        'CREATES A NEW DATATABLE OBJECT TO LIST THE ITEMS
        itemTable = New DataTable
        itemTable.Columns.Add("Item")
        itemTable.Columns.Add("Preço")

        Select Case FormType

            Case FormTypes.Order
                If Main.orders.ContainsKey(tbID.Text) Then
                    ChangeInputColors(SystemColors.Info)

                    currentOrder = Main.orders(tbID.Text)
                    RemoveToolStripMenuItem.Enabled = True
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
                    datePicker1.Value = currentOrder.SellingDate.ToString.ToDateNotNull
                    datePicker2.Value = currentOrder.RetrievingDate.ToString.ToDateNotNull
                    cbbResp1.Text = currentOrder.SellingResponsible
                    cbbResp2.Text = currentOrder.RetrievingResponsible
                    lblTotal.Text = currentOrder.Total.ToString("R$ 0.00")
                    tbObs.Text = currentOrder.Observation
                End If

            Case FormTypes.Purchase
                If Main.purchases.ContainsKey(tbID.Text) Then
                    ChangeInputColors(SystemColors.GradientInactiveCaption)

                    currentPurchase = Main.purchases(tbID.Text)
                    RemoveToolStripMenuItem.Enabled = True
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

                    datePicker1.Value = currentPurchase.BuyingDate.ToString.ToDateNotNull
                    cbbResp1.Text = ""
                    cbbResp2.Text = ""
                    lblTotal.Text = currentPurchase.Total.ToString("R$ 0.00")
                    tbObs.Text = currentPurchase.Observation
                End If

        End Select

        'ADDS ITEMS TO THE ITEM LISTVIEW
        For r = 0 To itemTable.Rows.Count - 1
            lvItems.Rows.Add()
            lvItems.Item(0, r).Value = itemTable.Rows(r).Item(0)
            lvItems.Item(1, r).Value = itemTable.Rows(r).Item(1)
        Next

    End Sub

    Private Sub tbQtty_TextChanged(sender As Object, e As EventArgs) Handles tbQtty.TextChanged

        Try
            Dim test = Convert.ToDouble(tbQtty.Text.ToZero)
        Catch ex As Exception
            Exit Sub
        End Try

        Try

            selectedProduct.Quantity = CDbl(tbQtty.Text.ToZero)

            If selectedProduct.Quantity > 0 Or CDbl(tbQtty.Text.ToZero) > 0 Then
                tvItems.Nodes(selectedProduct.Kind).Nodes(selectedProduct.Name).Checked = True
                tvItems.Nodes(selectedProduct.Kind).Nodes(selectedProduct.Name).ForeColor = Color.Red
            Else
                tvItems.Nodes(selectedProduct.Kind).Nodes(selectedProduct.Name).Checked = False
                If selectedProduct.Stock > 0 Then
                    tvItems.Nodes(selectedProduct.Kind).Nodes(selectedProduct.Name).ForeColor = Color.Black
                Else
                    tvItems.Nodes(selectedProduct.Kind).Nodes(selectedProduct.Name).ForeColor = Color.DimGray
                End If
            End If

            Select Case FormType
                Case FormTypes.Order

                    If selectedProduct.Quantity > 0 Then
                        If Not currentOrder.Items.ContainsKey(selectedProduct.Code) Then
                            currentOrder.Items.Add(selectedProduct.Code, selectedProduct)
                        End If
                        currentOrder.Items(selectedProduct.Code).Quantity = selectedProduct.Quantity
                        lvItems.Rows.Clear()
                        For i = 0 To currentOrder.Items.Count - 1
                            lvItems.Rows.Add()
                            lvItems.Item(0, i).Value = currentOrder.OrderList(i)
                            lvItems.Item(1, i).Value = currentOrder.PriceList(i)
                        Next
                    Else
                        If currentOrder.Items.ContainsKey(selectedProduct.Code) Then
                            currentOrder.Items.Remove(selectedProduct.Code)
                            For ii = 0 To lvItems.Rows.Count - 1
                                If lvItems.Item(0, ii).Value.ToString.Split(" x ").Last = selectedProduct.Code Then lvItems.Rows.RemoveAt(ii)
                            Next
                        End If
                    End If
                    lblTotal.Text = currentOrder.Total.ToString("R$ 0.00")

                Case FormTypes.Purchase

                    If selectedProduct.Quantity > 0 Then
                        If Not currentPurchase.Items.ContainsKey(selectedProduct.Code) Then
                            currentPurchase.Items.Add(selectedProduct.Code, selectedProduct)
                        End If
                        currentPurchase.Items(selectedProduct.Code).Quantity = selectedProduct.Quantity
                        lvItems.Rows.Clear()
                        For i = 0 To currentPurchase.Items.Count - 1
                            lvItems.Rows.Add()
                            lvItems.Item(0, i).Value = currentPurchase.PurchaseList(i)
                            lvItems.Item(1, i).Value = currentPurchase.CostList(i)
                        Next
                    Else
                        If currentPurchase.Items.ContainsKey(selectedProduct.Code) Then
                            currentPurchase.Items.Remove(selectedProduct.Code)
                            For ii = 0 To lvItems.Rows.Count - 1
                                If lvItems.Item(0, ii).Value.ToString.Split(" x ").Last = selectedProduct.Code Then lvItems.Rows.RemoveAt(ii)
                            Next
                        End If
                    End If
                    lblTotal.Text = currentPurchase.Total.ToString("R$ 0.00")

            End Select

        Catch ex As Exception
        End Try

        If lvItems.Rows.Count > 0 Then
            If NewEntry Then
                AddToolStripMenuItem.Enabled = True
            Else
                AddToolStripMenuItem.Enabled = False
            End If
        Else
            AddToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub tbPrice_TextChanged(sender As Object, e As EventArgs) Handles tbPrice.TextChanged

        Try
            Dim test = Convert.ToDouble(tbPrice.Text)
        Catch ex As Exception
            Exit Sub
        End Try

        Try

            selectedProduct.Value = CDbl(tbPrice.Text)

            Select Case FormType

                Case FormTypes.Order
                    currentOrder.Items(selectedProduct.Code).Value = selectedProduct.Value
                    lvItems.Rows.Clear()
                    For i = 0 To currentOrder.Items.Count - 1
                        lvItems.Rows.Add()
                        lvItems.Item(0, i).Value = currentOrder.OrderList(i)
                        lvItems.Item(1, i).Value = currentOrder.PriceList(i)
                    Next
                    lblTotal.Text = currentOrder.Total.ToString("R$ 0.00")

                Case FormTypes.Purchase
                    currentPurchase.Items(selectedProduct.Code).Value = selectedProduct.Value
                    lvItems.Rows.Clear()
                    For i = 0 To currentPurchase.Items.Count - 1
                        lvItems.Rows.Add()
                        lvItems.Item(0, i).Value = currentPurchase.PurchaseList(i)
                        lvItems.Item(1, i).Value = currentPurchase.CostList(i)
                    Next
                    lblTotal.Text = currentPurchase.Total.ToString("R$ 0.00")

            End Select

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Date1_TextChanged(sender As Object, e As EventArgs) Handles datePicker1.TextChanged

        Try
            Select Case FormType

                Case FormTypes.Order
                    currentOrder.SellingDate = datePicker1.Value

                Case FormTypes.Purchase
                    currentPurchase.BuyingDate = datePicker1.Value

            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Date2_TextChanged(sender As Object, e As EventArgs) Handles datePicker2.TextChanged

        Try
            Select Case FormType

                Case FormTypes.Order
                    currentOrder.RetrievingDate = datePicker2.Value

            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbbResp1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbResp1.SelectedIndexChanged
        If cbbResp1.Text = "" Then
            datePicker1.Enabled = False
            Exit Sub
        Else
            datePicker1.Enabled = True
        End If

        Try
            Select Case FormType
                Case FormTypes.Order
                    currentOrder.SellingResponsible = DateValue(cbbResp1.Text)
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbbResp2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbResp2.SelectedIndexChanged
        If cbbResp2.Text = "" Then
            datePicker2.Enabled = False
            Exit Sub
        Else
            datePicker2.Enabled = True
        End If

        Try
            Select Case FormType
                Case FormTypes.Order
                    currentOrder.RetrievingResponsible = DateValue(cbbResp2.Text)
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbbClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbClient.SelectedIndexChanged
        If cbbClient.Text = "" Then Exit Sub

        Try
            Select Case FormType
                Case FormTypes.Order
                    currentOrder.Client = Main.clients(cbbClient.Text)
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Main.UpdateTables()
        Main.GetTables()
        MainForm.LoadTables()

        Select Case FormType

            Case FormTypes.Order
                MainForm.tabs.SelectedIndex = 2

            Case FormTypes.Purchase
                MainForm.tabs.SelectedIndex = 1

        End Select

        Me.Close()
    End Sub

    Private Sub OrderStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderStripMenuItem.Click
        FormType = FormTypes.Order
        NewEntry = True
        currentOrder = New Order(tbID.Text)
        LoadControls()
        ChangeInputColors(SystemColors.Window)
        tbID.Text = CStr(CDbl(Main.orders.Keys.Last) + 1)
        cbbResp1.SelectedIndex = 0

        btnOK.Enabled = False
        'AddToolStripMenuItem.Enabled = True
        RemoveToolStripMenuItem.Enabled = False
        Me.AcceptButton = AddToolStripMenuItem
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        FormType = FormTypes.Purchase
        NewEntry = True
        currentPurchase = New Purchase("")
        LoadControls()
        ChangeInputColors(SystemColors.Window)
        tbID.Text = ""

        btnOK.Enabled = False
        'AddToolStripMenuItem.Enabled = True
        RemoveToolStripMenuItem.Enabled = False
        Me.AcceptButton = AddToolStripMenuItem
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click

        Select Case FormType

            Case FormTypes.Order
                currentOrder.SellingDate = datePicker1.Value
                currentOrder.SellingResponsible = cbbResp1.Text
                currentOrder.RetrievingDate = datePicker2.Value
                currentOrder.RetrievingResponsible = cbbResp2.Text
                currentOrder.Observation = tbObs.Text
                currentOrder.Client = Main.clients(cbbClient.Text)
                'currentOrder.BarrelList =
                'currentOrder.CoolerList =
                'currentOrder.GasList =
                'currentOrder.ValveList =

                AddToOrdersTable()

            Case FormTypes.Purchase
                currentPurchase.BuyingDate = datePicker1.Value
                currentPurchase.Observation = tbObs.Text

                AddToPurchasesTable()

        End Select

        AddToProductTables()
        Main.UpdateTables()
        LoadControls()

        btnOK.Enabled = True
        AddToolStripMenuItem.Enabled = False
        RemoveToolStripMenuItem.Enabled = True
        NewEntry = False
        tbID.Text = ""

    End Sub

    Public Sub AddToOrdersTable()

        If Main.orders.ContainsKey(currentOrder.ID) Then
            MsgBox("O pedido de n° " + currentOrder.ID + " já existe!" + vbNewLine + "Por favor altere o n° deste pedido.", MsgBoxStyle.Exclamation, "Erro!")
            Exit Sub
        End If
        Main.orders.Add(currentOrder.ID, currentOrder)
        tableOrders.Rows.Add(currentOrder.ID,
                            currentOrder.Client.Name,
                            "",
                            currentOrder.SellingDate.ToShortDateString(),
                            currentOrder.SellingResponsible,
                            currentOrder.RetrievingDate.ToShortDateString(),
                            currentOrder.RetrievingResponsible,
                            currentOrder.Retrieved,
                            currentOrder.IncludesCooler,
                            Join(currentOrder.OrderList.ToArray, "; "),
                            Join(currentOrder.PriceList.ToArray, "; "),
                            currentOrder.Total,
                            currentOrder.Observation)

    End Sub

    Public Sub AddToPurchasesTable()

        If Main.purchases.ContainsKey(currentPurchase.ID) Then
            MsgBox("A compra com NF de n° " + currentPurchase.ID + " já existe!" + vbNewLine + "Por favor altere o n° da NF desta compra.", MsgBoxStyle.Exclamation, "Erro!")
            Exit Sub
        End If
        Main.purchases.Add(currentPurchase.ID, currentPurchase)
        tablePurchases.Rows.Add(currentPurchase.ID,
                                currentPurchase.BuyingDate.ToShortDateString,
                                Join(currentPurchase.PurchaseList.ToArray, "; "),
                                Join(currentPurchase.CostList.ToArray, "; "),
                                currentPurchase.Total,
                                currentPurchase.Observation)

    End Sub

    Public Sub AddToProductTables()

        Select Case FormType

            Case FormTypes.Order
                For Each item In currentOrder.Items.Values
                    Dim newOrder As New Product.Order(tbID.Text)
                    newOrder.SellingDate = currentOrder.SellingDate
                    newOrder.Client = Main.clients(currentOrder.Client.Name)
                    newOrder.Observation = currentOrder.Observation
                    newOrder.Quantity = currentOrder.Items(item.Code).Quantity
                    newOrder.Price = currentOrder.Items(item.Code).Value
                    newOrder.Stock = item.Stock - newOrder.Quantity
                    item.Stock = newOrder.Stock
                    newOrder.Balance = item.LastBalance + newOrder.Value

                    Main.products(item.Code).Orders.Add(newOrder.ID, newOrder)
                    Main.products(item.Code).Stock = item.Stock

                    With Main.productTables(item)
                        .Rows.Add(newOrder.SellingDate.ToShortDateString,
                                  newOrder.ID,
                                  newOrder.Description,
                                  0,
                                  newOrder.Quantity,
                                  newOrder.Stock,
                                  0,
                                  newOrder.Value,
                                  newOrder.Balance)
                    End With
                Next

            Case FormTypes.Purchase
                For Each item In currentPurchase.Items.Values
                    Dim newPurchase As New Product.Purchase(tbID.Text)
                    newPurchase.BuyingDate = currentPurchase.BuyingDate
                    newPurchase.Vendor = currentPurchase.Vendor
                    newPurchase.Observation = currentPurchase.Observation
                    newPurchase.Quantity = currentPurchase.Items(item.Code).Quantity
                    newPurchase.Cost = currentPurchase.Items(item.Code).Value
                    newPurchase.Stock = item.Stock + newPurchase.Quantity
                    item.Stock = newPurchase.Stock
                    newPurchase.Balance = item.LastBalance - newPurchase.Value

                    Main.products(item.Code).Purchases.Add(newPurchase.ID, newPurchase)
                    Main.products(item.Code).Stock = item.Stock

                    With Main.productTables(item)
                        .Rows.Add(newPurchase.BuyingDate.ToShortDateString,
                                  newPurchase.ID,
                                  newPurchase.Description,
                                  newPurchase.Quantity,
                                  0,
                                  newPurchase.Stock,
                                  newPurchase.Value,
                                  0,
                                  newPurchase.Balance)
                    End With
                Next

        End Select

    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click

        Select Case FormType

            Case FormTypes.Order
                Main.orders.Remove(tbID.Text)
                For i = 0 To tableOrders.Rows.Count - 1
                    If tableOrders.Rows(i).Item("ID") = tbID.Text Then tableOrders.Rows(i).Delete()
                Next

            Case FormTypes.Purchase
                Main.purchases.Remove(tbID.Text)
                For j = 0 To tablePurchases.Rows.Count - 1
                    If tablePurchases.Rows(j).Item("ID") = tbID.Text Then tablePurchases.Rows(j).Delete()
                Next
        End Select

        RemoveFromProductTables()
        Main.UpdateTables()
        tbID.Text = ""
        LoadControls()

        btnOK.Enabled = True
        AddToolStripMenuItem.Enabled = False
        RemoveToolStripMenuItem.Enabled = False

    End Sub

    Public Sub RemoveFromProductTables()

        Select Case FormType

            Case FormTypes.Order
                For Each item In currentOrder.Items.Values

                    Dim pTable = Main.productTables.Where(Function(x) x.Key.Code = item.Code).First.Value
                    For i = 0 To pTable.Rows.Count - 1
                        If pTable.Rows(i).Item("ID") = currentOrder.ID Then
                            Main.products(item.Code).Orders.Remove(currentOrder.ID)
                            Main.products(item.Code).Stock += item.Quantity
                            Exit For
                        End If
                    Next

                Next

            Case FormTypes.Purchase
                For Each item In currentPurchase.Items.Values

                    Dim pTable = Main.productTables.Where(Function(x) x.Key.Code = item.Code).First.Value
                    For i = 0 To pTable.Rows.Count - 1
                        If pTable.Rows(i).Item("ID") = currentPurchase.ID Then
                            Main.products(item.Code).Purchases.Remove(currentPurchase.ID)
                            Main.products(item.Code).Stock -= item.Quantity
                            Exit For
                        End If
                    Next

                Next

        End Select

    End Sub

    Private Sub tvItems_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvItems.AfterSelect

        If Not IsNothing(e.Node.Parent) Then
            Dim kind As String = e.Node.Parent.Text
            Dim name As String = e.Node.Text
            selectedProduct = Main.products(kind + "-" + name)

            'With selectedProduct
            Select Case FormType
                    Case FormTypes.Order
                        If Main.orders.ContainsKey(tbID.Text) Then
                            currentOrder = Main.orders(tbID.Text)
                        If currentOrder.Items.ContainsKey(selectedProduct.Code) Then
                            selectedProduct.Quantity = currentOrder.Items(selectedProduct.Code).Quantity
                            selectedProduct.Value = currentOrder.Items(selectedProduct.Code).Value
                        Else
                            selectedProduct.Quantity = 0
                            selectedProduct.Value = selectedProduct.Price
                        End If
                        Else
                        selectedProduct.Quantity = 0
                        selectedProduct.Value = selectedProduct.Price
                    End If

                    Case FormTypes.Purchase
                        If Main.purchases.ContainsKey(tbID.Text) Then
                            currentPurchase = Main.purchases(tbID.Text)
                        If currentPurchase.Items.ContainsKey(selectedProduct.Code) Then
                            selectedProduct.Quantity = currentPurchase.Items(selectedProduct.Code).Quantity
                            selectedProduct.Value = currentPurchase.Items(selectedProduct.Code).Value
                        Else
                            selectedProduct.Quantity = 0
                            selectedProduct.Value = selectedProduct.Cost
                        End If
                        Else
                        selectedProduct.Quantity = 0
                        selectedProduct.Value = selectedProduct.Cost
                    End If

                End Select

            lblKind.Text = selectedProduct.Kind
            lblName.Text = selectedProduct.Name
            lblBrand.Text = selectedProduct.Brand
            lblStock.Text = selectedProduct.Stock.ToString.ToZero
            lblQttyUnit.Text = selectedProduct.Unit
            lblStockUnit.Text = selectedProduct.Unit
            lblPriceUnit.Text = "R$/" + selectedProduct.Size
            tbQtty.Text = selectedProduct.Quantity.ToString.ToZero
            tbPrice.Text = selectedProduct.Value.ToString("0.00")

            Select Case FormType

                Case FormTypes.Order
                    lblOrder.Text = "Itens do Pedido:"
                    lblPrice.Text = "Preço:"

                Case FormTypes.Purchase
                    lblOrder.Text = "Itens da Compra:"
                    lblPrice.Text = "Custo:"

            End Select
            'End With

        End If

    End Sub

    Private Sub tvItems_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvItems.NodeMouseDoubleClick

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

    Private Sub tvItems_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvItems.AfterCheck

        If Not IsNothing(e.Node.Parent) Then
            If e.Node.Checked Then
                e.Node.Parent.Checked = True
            End If
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