Imports StockLib


''' <summary>
''' Form used in the addition/edition/removal of <see cref="Sale"/> and <see cref="Purchase"/> objects
''' </summary>
Public Class OrderForm

    Public Enum FormTypes
        Sale
        Purchase
    End Enum

    Public FormType As FormTypes
    Public NewEntry As Boolean = False
    Public selectedProduct As Product
    Public currentSale As Sale
    Public currentPurchase As Purchase
    Public itemTable As New DataTable

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Main.LoadProducts()

        LoadControls()

        Me.AcceptButton = btnOK

    End Sub

    Public Sub DisableGenericControls()

        cbbClient.Enabled = False
        cbbResp1.Enabled = False
        cbbResp2.Enabled = False
        datePicker1.Enabled = False
        datePicker2.Enabled = False
        tvItems.Enabled = False
        tbQtty.Enabled = False
        tbPrice.Enabled = False
        tbObs.Enabled = False

    End Sub

    Public Sub EnableSaleControls()

        cbbClient.Enabled = True
        cbbResp1.Enabled = True
        datePicker1.Enabled = True
        tvItems.Enabled = True
        tbQtty.Enabled = True
        tbPrice.Enabled = True
        tbObs.Enabled = True

    End Sub

    Public Sub EnablePurchaseControls()

        datePicker1.Enabled = True
        tvItems.Enabled = True
        tbQtty.Enabled = True
        tbPrice.Enabled = True
        tbObs.Enabled = True

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

        DisableGenericControls()

        'RESETS SPECIFIC CONTROLS ACCORDING TO FORMTYPE   
        Select Case FormType
            Case FormTypes.Sale
                Me.Text = "Pedido"
                lblID.Text = "ID do Pedido:"
                lblOrder.Text = "Itens do Pedido:"
                lblPrice.Text = "Preço:"
                tbID.BackColor = SystemColors.Info

                lblClient.Visible = True
                lblResp1.Visible = True
                lblResp2.Visible = True
                lblDate2.Visible = True
                cbbClient.Visible = True
                cbbResp1.Visible = True
                cbbResp2.Visible = True
                datePicker2.Visible = True

            Case FormTypes.Purchase
                Me.Text = "Compra"
                lblID.Text = "N° da NF:"
                lblOrder.Text = "Itens da Compra:"
                lblPrice.Text = "Custo:"
                tbID.BackColor = SystemColors.GradientInactiveCaption

                lblClient.Visible = False
                lblResp1.Visible = False
                lblResp2.Visible = False
                lblDate2.Visible = False
                cbbClient.Visible = False
                cbbResp1.Visible = False
                cbbResp2.Visible = False
                datePicker2.Visible = False

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
        For r = 0 To tableOwners.Rows.Count - 1
            cbbResp1.Items.Add(tableOwners.Rows(r).Item(0))
            cbbResp2.Items.Add(tableOwners.Rows(r).Item(0))
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

        DisableGenericControls()

        If NewEntry Then
            If tbID.Text = "" Then
                AddToolStripMenuItem.Enabled = False
                InventoryToolStripMenuItem.Enabled = False
            Else
                AddToolStripMenuItem.Enabled = True
                InventoryToolStripMenuItem.Enabled = True
                Select Case FormType
                    Case FormTypes.Sale
                        EnableSaleControls()
                    Case FormTypes.Purchase
                        EnablePurchaseControls()
                End Select
            End If

            Select Case FormType
                Case FormTypes.Sale
                    currentSale.ID = tbID.Text
                Case FormTypes.Purchase
                    currentPurchase.ID = tbID.Text
            End Select

            ChangeInputColors(SystemColors.Window)
            RemoveToolStripMenuItem.Enabled = False

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

            Case FormTypes.Sale
                If Main.sales.ContainsKey(tbID.Text) Then
                    currentSale = Main.sales(tbID.Text)

                    ChangeInputColors(SystemColors.Info)
                    EnableSaleControls()
                    RemoveToolStripMenuItem.Enabled = True
                    InventoryToolStripMenuItem.Enabled = True

                    cbbResp2.Enabled = currentSale.Retrieved
                    datePicker2.Enabled = currentSale.Retrieved
                    For Each p In currentSale.Products.Values
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

                    cbbClient.Text = currentSale.Client.Name
                    datePicker1.Value = currentSale.SellingDate.ToString.ToDateNotNull
                    datePicker2.Value = currentSale.RetrievingDate.ToString.ToDateNotNull
                    cbbResp1.Text = currentSale.SellingResponsible
                    cbbResp2.Text = currentSale.RetrievingResponsible
                    lblTotal.Text = currentSale.Total.ToString("R$ 0.00")
                    tbObs.Text = currentSale.Observation
                End If

            Case FormTypes.Purchase
                InventoryToolStripMenuItem.Enabled = False
                If Main.purchases.ContainsKey(tbID.Text) Then
                    currentPurchase = Main.purchases(tbID.Text)

                    ChangeInputColors(SystemColors.GradientInactiveCaption)
                    EnablePurchaseControls()
                    RemoveToolStripMenuItem.Enabled = True

                    For Each p In currentPurchase.Products.Values
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
                Case FormTypes.Sale

                    If selectedProduct.Quantity > 0 Then
                        If Not currentSale.Products.ContainsKey(selectedProduct.Code) Then
                            currentSale.Products.Add(selectedProduct.Code, selectedProduct)
                        End If
                        currentSale.Products(selectedProduct.Code).Quantity = selectedProduct.Quantity
                        lvItems.Rows.Clear()
                        For i = 0 To currentSale.Products.Count - 1
                            lvItems.Rows.Add()
                            lvItems.Item(0, i).Value = currentSale.OrderList(i)
                            lvItems.Item(1, i).Value = currentSale.PriceList(i)
                        Next
                    Else
                        If currentSale.Products.ContainsKey(selectedProduct.Code) Then
                            currentSale.Products.Remove(selectedProduct.Code)
                            For ii = 0 To lvItems.Rows.Count - 1
                                If lvItems.Item(0, ii).Value.ToString.Split(" x ").Last = selectedProduct.Code Then lvItems.Rows.RemoveAt(ii)
                            Next
                        End If
                    End If
                    lblTotal.Text = currentSale.Total.ToString("R$ 0.00")

                Case FormTypes.Purchase

                    If selectedProduct.Quantity > 0 Then
                        If Not currentPurchase.Products.ContainsKey(selectedProduct.Code) Then
                            currentPurchase.Products.Add(selectedProduct.Code, selectedProduct)
                        End If
                        currentPurchase.Products(selectedProduct.Code).Quantity = selectedProduct.Quantity
                        lvItems.Rows.Clear()
                        For i = 0 To currentPurchase.Products.Count - 1
                            lvItems.Rows.Add()
                            lvItems.Item(0, i).Value = currentPurchase.PurchaseList(i)
                            lvItems.Item(1, i).Value = currentPurchase.CostList(i)
                        Next
                    Else
                        If currentPurchase.Products.ContainsKey(selectedProduct.Code) Then
                            currentPurchase.Products.Remove(selectedProduct.Code)
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

                Case FormTypes.Sale
                    currentSale.Products(selectedProduct.Code).Value = selectedProduct.Value
                    lvItems.Rows.Clear()
                    For i = 0 To currentSale.Products.Count - 1
                        lvItems.Rows.Add()
                        lvItems.Item(0, i).Value = currentSale.OrderList(i)
                        lvItems.Item(1, i).Value = currentSale.PriceList(i)
                    Next
                    lblTotal.Text = currentSale.Total.ToString("R$ 0.00")

                Case FormTypes.Purchase
                    currentPurchase.Products(selectedProduct.Code).Value = selectedProduct.Value
                    lvItems.Rows.Clear()
                    For i = 0 To currentPurchase.Products.Count - 1
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

                Case FormTypes.Sale
                    currentSale.SellingDate = datePicker1.Value

                Case FormTypes.Purchase
                    currentPurchase.BuyingDate = datePicker1.Value

            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Date2_TextChanged(sender As Object, e As EventArgs) Handles datePicker2.TextChanged

        Try
            Select Case FormType

                Case FormTypes.Sale
                    currentSale.RetrievingDate = datePicker2.Value

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
                Case FormTypes.Sale
                    currentSale.SellingResponsible = DateValue(cbbResp1.Text)
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
                Case FormTypes.Sale
                    currentSale.RetrievingResponsible = DateValue(cbbResp2.Text)
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbbClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbClient.SelectedIndexChanged
        If cbbClient.Text = "" Then Exit Sub

        Try
            Select Case FormType
                Case FormTypes.Sale
                    currentSale.Client = Main.clients(cbbClient.Text)
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Main.UpdateTables()
        Main.GetTables()
        MainForm.LoadTables()

        Select Case FormType

            Case FormTypes.Sale
                MainForm.tabs.SelectedIndex = 2

            Case FormTypes.Purchase
                MainForm.tabs.SelectedIndex = 1

        End Select

        Me.Close()
    End Sub

    Private Sub OrderStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderStripMenuItem.Click
        FormType = FormTypes.Sale
        NewEntry = True
        currentSale = New Sale(tbID.Text)
        tbID.Text = CStr(CDbl(Main.sales.Keys.Last) + 1)
        cbbResp1.SelectedIndex = 0

        LoadControls()
        ChangeInputColors(SystemColors.Window)
        EnableSaleControls()

        btnOK.Enabled = False
        'AddToolStripMenuItem.Enabled = True
        RemoveToolStripMenuItem.Enabled = False
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        FormType = FormTypes.Purchase
        NewEntry = True
        currentPurchase = New Purchase("")
        tbID.Text = ""

        LoadControls()
        ChangeInputColors(SystemColors.Window)
        EnablePurchaseControls()

        btnOK.Enabled = False
        'AddToolStripMenuItem.Enabled = True
        RemoveToolStripMenuItem.Enabled = False
        InventoryToolStripMenuItem.Enabled = False
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click

        Select Case FormType

            Case FormTypes.Sale
                currentSale.SellingDate = datePicker1.Value
                currentSale.SellingResponsible = cbbResp1.Text
                currentSale.RetrievingDate = datePicker2.Value
                currentSale.RetrievingResponsible = cbbResp2.Text
                currentSale.Observation = tbObs.Text
                currentSale.Client = Main.clients(cbbClient.Text)

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
        InventoryToolStripMenuItem.Enabled = False
        NewEntry = False
        tbID.Text = ""

    End Sub

    Public Sub AddToOrdersTable()

        If Main.sales.ContainsKey(currentSale.ID) Then
            MsgBox("O pedido de n° " + currentSale.ID + " já existe!" + vbNewLine + "Por favor altere o n° deste pedido.", MsgBoxStyle.Exclamation, "Erro!")
            Exit Sub
        End If
        Main.sales.Add(currentSale.ID, currentSale)
        tableOrders.Rows.Add(currentSale.ID,
                            currentSale.Client.Name,
                            "",
                            currentSale.SellingDate.ToShortDateString(),
                            currentSale.SellingResponsible,
                            currentSale.RetrievingDate.ToShortDateString(),
                            currentSale.RetrievingResponsible,
                            currentSale.Retrieved,
                            currentSale.IncludesCooler,
                            Join(currentSale.OrderList.ToArray, "; "),
                            Join(currentSale.PriceList.ToArray, "; "),
                            currentSale.Total,
                            currentSale.Observation)

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

            Case FormTypes.Sale
                For Each item In currentSale.Products.Values
                    Dim newOrder As New Product.Sale(tbID.Text)
                    newOrder.Parent = item
                    newOrder.Index = item.Orders.Count
                    newOrder.SellingDate = currentSale.SellingDate
                    newOrder.Client = Main.clients(currentSale.Client.Name)
                    newOrder.Observation = currentSale.Observation
                    newOrder.Quantity = currentSale.Products(item.Code).Quantity
                    newOrder.Price = currentSale.Products(item.Code).Value
                    newOrder.Stock = item.Stock - newOrder.Quantity
                    item.Stock = newOrder.Stock
                    newOrder.Balance = item.LastBalance + newOrder.Value

                    Main.products(item.Code).Sales.Add(newOrder.ID, newOrder)
                    Main.products(item.Code).Orders.Add(newOrder)
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
                For Each item In currentPurchase.Products.Values
                    Try
                        Dim test = CDbl(tbID.Text)
                        tbID.Text = currentPurchase.Vendor.Code + tbID.Text
                    Catch ex As Exception
                    End Try
                    Dim newPurchase As New Product.Purchase(tbID.Text)
                    newPurchase.Parent = item
                    newPurchase.Index = item.Orders.Count
                    newPurchase.BuyingDate = currentPurchase.BuyingDate
                    newPurchase.Vendor = currentPurchase.Vendor
                    newPurchase.Observation = currentPurchase.Observation
                    newPurchase.Quantity = currentPurchase.Products(item.Code).Quantity
                    newPurchase.Cost = currentPurchase.Products(item.Code).Value
                    newPurchase.Stock = item.Stock + newPurchase.Quantity
                    item.Stock = newPurchase.Stock
                    newPurchase.Balance = item.LastBalance - newPurchase.Value

                    Main.products(item.Code).Purchases.Add(newPurchase.ID, newPurchase)
                    Main.products(item.Code).Orders.Add(newPurchase)
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

            Case FormTypes.Sale
                Dim client = Main.clients(Main.sales(tbID.Text).Client.Name)
                Dim sale = client.Sales.Where(Function(x) x.ID = tbID.Text).FirstOrDefault
                client.Sales.Remove(sale)

                Main.sales.Remove(tbID.Text)
                For i = 0 To tableOrders.Rows.Count - 1
                    If tableOrders.Rows(i).Item("ID") = tbID.Text Then tableOrders.Rows(i).Delete()
                Next

            Case FormTypes.Purchase
                Dim vendor = Main.vendors(Main.purchases(tbID.Text).Vendor.Name)
                Dim purchase = vendor.Purchases.Where(Function(y) y.ID = tbID.Text).FirstOrDefault
                vendor.Purchases.Remove(purchase)

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
        InventoryToolStripMenuItem.Enabled = False

    End Sub

    Public Sub RemoveFromProductTables()

        Select Case FormType

            Case FormTypes.Sale
                For Each item In currentSale.Products.Values

                    Dim pTable = Main.productTables.Where(Function(x) x.Key.Code = item.Code).First.Value
                    For i = 0 To pTable.Rows.Count - 1
                        If pTable.Rows(i).Item("ID") = currentSale.ID Then
                            Main.products(item.Code).Sales.Remove(currentSale.ID)
                            Main.products(item.Code).Stock += item.Quantity
                            Exit For
                        End If
                    Next

                Next

            Case FormTypes.Purchase
                For Each item In currentPurchase.Products.Values

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

            Select Case FormType
                Case FormTypes.Sale
                    If Main.sales.ContainsKey(tbID.Text) Then
                        currentSale = Main.sales(tbID.Text)
                        If currentSale.Products.ContainsKey(selectedProduct.Code) Then
                            selectedProduct.Quantity = currentSale.Products(selectedProduct.Code).Quantity
                            selectedProduct.Value = currentSale.Products(selectedProduct.Code).Value
                        Else
                            If Main.owners.Contains(cbbClient.Text) Then
                                selectedProduct.Value = selectedProduct.Price2
                            Else
                                selectedProduct.Value = selectedProduct.Price
                            End If
                            selectedProduct.Quantity = 0
                        End If
                    Else
                        If Main.owners.Contains(cbbClient.Text) Then
                            selectedProduct.Value = selectedProduct.Price2
                        Else
                            selectedProduct.Value = selectedProduct.Price
                        End If
                        If Not NewEntry Then
                            selectedProduct.Quantity = 0
                        End If
                    End If

                Case FormTypes.Purchase
                    If Main.purchases.ContainsKey(tbID.Text) Then
                        currentPurchase = Main.purchases(tbID.Text)
                        If currentPurchase.Products.ContainsKey(selectedProduct.Code) Then
                            selectedProduct.Quantity = currentPurchase.Products(selectedProduct.Code).Quantity
                            selectedProduct.Value = currentPurchase.Products(selectedProduct.Code).Value
                        Else
                            selectedProduct.Quantity = 0
                            selectedProduct.Value = selectedProduct.Cost
                        End If
                    Else
                        selectedProduct.Value = selectedProduct.Cost
                        If Not NewEntry Then
                            selectedProduct.Quantity = 0
                        End If
                    End If

            End Select

            UpdateProductLabels()
            tbQtty.Text = selectedProduct.Quantity.ToString.ToZero
            tbPrice.Text = selectedProduct.Value.ToString("0.00")

        End If

    End Sub

    Public Sub UpdateProductLabels()

        lblKind.Text = selectedProduct.Kind
        lblName.Text = selectedProduct.Name
        lblBrand.Text = selectedProduct.Brand
        lblStock.Text = selectedProduct.Stock.ToString.ToZero
        lblQttyUnit.Text = selectedProduct.Unit
        lblStockUnit.Text = selectedProduct.Unit
        lblPriceUnit.Text = "R$/" + selectedProduct.Size

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

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Dim orderInventoryForm As New OrderInventoryForm(currentSale)
        orderInventoryForm.Show()
    End Sub

    Private Sub lvItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lvItems.CellContentClick
        Dim entry = lvItems.Item(0, e.RowIndex).Value.ToString.NotNull
        If entry = "" Then Exit Sub

        Dim pCode = entry.Split(" x ").Last
        Dim pKind = pCode.Split("-").First
        Dim pName = pCode.Split("-").Last

        selectedProduct = Main.products(pKind + "-" + pName)

        UpdateProductLabels()

    End Sub

End Class