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
    Public NewOrder As Boolean = False
    Public selectedProduct As Product
    Public currentSale As Sale = Nothing
    Public currentPurchase As Purchase = Nothing
    Public itemTable As New DataTable

    Public Sub New()

        InitializeComponent()
        menu.RenderMode = ToolStripRenderMode.ManagerRenderMode
        menu.Renderer = New MyRenderer

    End Sub

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadControls()

        Me.AcceptButton = btnOK

    End Sub

    Public Sub DisableGenericControls()

        tbID.Enabled = True

        cbbClient.Enabled = False
        cbbResp1.Enabled = False
        cbbResp2.Enabled = False
        datePicker1.Enabled = False
        datePicker2.Enabled = False
        tvItems.Enabled = False
        tbQtty.Enabled = False
        tbPrice.Enabled = False
        tbObs.Enabled = False
        tbDiscount.Enabled = False
        cbDiscount.Enabled = False

        OrderToolStripMenuItem.Visible = False
        PurchaseToolStripMenuItem.Visible = False
        InventoryToolStripMenuItem.Enabled = False
        RemoveToolStripMenuItem.Enabled = False

    End Sub

    Public Sub EnableSaleControls()

        cbbClient.Enabled = True
        cbbResp1.Enabled = True
        datePicker1.Enabled = True
        tvItems.Enabled = True
        tbQtty.Enabled = True
        tbPrice.Enabled = True
        tbObs.Enabled = True
        tbDiscount.Enabled = True
        cbDiscount.Enabled = True

        OrderToolStripMenuItem.Visible = True

    End Sub

    Public Sub EnablePurchaseControls()

        datePicker1.Enabled = True
        tvItems.Enabled = True
        tbQtty.Enabled = True
        tbPrice.Enabled = True
        tbObs.Enabled = True
        tbDiscount.Enabled = True
        cbDiscount.Enabled = True

        PurchaseToolStripMenuItem.Visible = True

    End Sub

    Public Sub ChangeInputColors(color As Color)

        tbID.BackColor = color
        tbQtty.BackColor = color
        tbPrice.BackColor = color
        tbObs.BackColor = color
        tbDiscount.BackColor = color

        cbbClient.BackColor = color
        cbbResp1.BackColor = color
        cbbResp2.BackColor = color

        datePicker1.BackColor = color
        datePicker2.BackColor = color

        tvItems.BackColor = color
        lvItems.BackgroundColor = color
        lvItems.ColumnHeadersDefaultCellStyle.BackColor = color

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
                tbID.BackColor = MainForm.orangeColor

                lblClient.Visible = True
                lblResp1.Visible = True
                lblResp2.Visible = True
                lblDate2.Visible = True
                cbbClient.Visible = True
                cbbResp1.Visible = True
                cbbResp2.Visible = True
                datePicker2.Visible = True

                InventoryToolStripMenuItem.Enabled = True

                OrderToolStripMenuItem.Visible = True
                OrderToolStripMenuItem.Enabled = True

            Case FormTypes.Purchase
                Me.Text = "Compra"
                lblID.Text = "N° da NF:"
                lblOrder.Text = "Itens da Compra:"
                lblPrice.Text = "Custo:"
                tbID.BackColor = MainForm.blueColor

                lblClient.Visible = False
                lblResp1.Visible = False
                lblResp2.Visible = False
                lblDate2.Visible = False
                cbbClient.Visible = False
                cbbResp1.Visible = False
                cbbResp2.Visible = False
                datePicker2.Visible = False

                PurchaseToolStripMenuItem.Visible = True
                PurchaseToolStripMenuItem.Enabled = True

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
        If Main.companyName = "ChoppExpress" Then
            cbbResp1.Text = "Kaninha"
            cbbResp2.Text = "Kaninha"
        End If

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

        If NewOrder Then
            If tbID.Text = "" Then
                AddToolStripMenuItem.Enabled = False
            Else
                AddToolStripMenuItem.Enabled = True

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

            'ChangeInputColors(SystemColors.Window)

            Exit Sub
        Else

            Select Case FormType
                Case FormTypes.Sale
                    OrderToolStripMenuItem.Visible = True
                Case FormTypes.Purchase
                    PurchaseToolStripMenuItem.Visible = True
            End Select

        End If

        'RESETS THE CONTROL VALUES TO THEIR DEFAULTS   
        cbbResp1.Text = ""
        cbbResp2.Text = ""
        cbbClient.Text = ""
        datePicker1.Value = Date.Today
        datePicker2.Value = Date.Today
        lblSubTotal.Text = "R$"
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

                    ChangeInputColors(MainForm.orangeColor)
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
                    lblSubTotal.Text = currentSale.SubTotal.ToString("R$ 0.00")
                    tbObs.Text = currentSale.Observation
                Else
                    InventoryToolStripMenuItem.Enabled = False
                End If

            Case FormTypes.Purchase
                InventoryToolStripMenuItem.Enabled = False
                If Main.purchases.ContainsKey(tbID.Text) Then
                    currentPurchase = Main.purchases(tbID.Text)

                    ChangeInputColors(MainForm.blueColor)
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
                    lblSubTotal.Text = currentPurchase.SubTotal.ToString("R$ 0.00")
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
                            lvItems.Item(0, i).Value = currentSale.ProductList(i)
                            lvItems.Item(1, i).Value = currentSale.ValueList(i)
                        Next
                    Else
                        If currentSale.Products.ContainsKey(selectedProduct.Code) Then
                            currentSale.Products.Remove(selectedProduct.Code)
                            For ii = 0 To lvItems.Rows.Count - 1
                                If lvItems.Item(0, ii).Value.ToString.Split(" x ").Last = selectedProduct.Code Then lvItems.Rows.RemoveAt(ii)
                            Next
                        End If
                    End If
                    lblSubTotal.Text = currentSale.SubTotal.ToString("R$ 0.00")

                Case FormTypes.Purchase

                    If selectedProduct.Quantity > 0 Then
                        If Not currentPurchase.Products.ContainsKey(selectedProduct.Code) Then
                            currentPurchase.Products.Add(selectedProduct.Code, selectedProduct)
                        End If
                        currentPurchase.Products(selectedProduct.Code).Quantity = selectedProduct.Quantity
                        lvItems.Rows.Clear()
                        For i = 0 To currentPurchase.Products.Count - 1
                            lvItems.Rows.Add()
                            lvItems.Item(0, i).Value = currentPurchase.ProductList(i)
                            lvItems.Item(1, i).Value = currentPurchase.ValueList(i)
                        Next
                    Else
                        If currentPurchase.Products.ContainsKey(selectedProduct.Code) Then
                            currentPurchase.Products.Remove(selectedProduct.Code)
                            For ii = 0 To lvItems.Rows.Count - 1
                                If lvItems.Item(0, ii).Value.ToString.Split(" x ").Last = selectedProduct.Code Then lvItems.Rows.RemoveAt(ii)
                            Next
                        End If
                    End If
                    lblSubTotal.Text = currentPurchase.SubTotal.ToString("R$ 0.00")

            End Select

        Catch ex As Exception
        End Try

        If lvItems.Rows.Count > 0 Then
            If NewOrder Then
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
            Extensions.Stringify(tbPrice)
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
                        lvItems.Item(0, i).Value = currentSale.ProductList(i)
                        lvItems.Item(1, i).Value = currentSale.ValueList(i)
                    Next
                    lblSubTotal.Text = currentSale.SubTotal.ToString("R$ 0.00")

                Case FormTypes.Purchase
                    currentPurchase.Products(selectedProduct.Code).Value = selectedProduct.Value
                    lvItems.Rows.Clear()
                    For i = 0 To currentPurchase.Products.Count - 1
                        lvItems.Rows.Add()
                        lvItems.Item(0, i).Value = currentPurchase.ProductList(i)
                        lvItems.Item(1, i).Value = currentPurchase.ValueList(i)
                    Next
                    lblSubTotal.Text = currentPurchase.SubTotal.ToString("R$ 0.00")

            End Select

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Date1_TextChanged(sender As Object, e As EventArgs) Handles datePicker1.TextChanged

        If datePicker1.Value = Date.Today Then Exit Sub

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

        If datePicker2.Value = Date.Today Then Exit Sub

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

    ''' <summary>
    ''' Handles the events that happen when the OK button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Try
            Select Case FormType
                Case FormTypes.Sale
                    If Not IsNothing(currentSale) Then

                        If currentSale.Retrieved Then
                            currentSale.RetrievingDate = datePicker2.Value
                            currentSale.RetrievingResponsible = cbbResp2.Text
                        Else
                            currentSale.RetrievingDate = Date.Today
                            currentSale.RetrievingResponsible = ""
                        End If

                        Main.sales(currentSale.ID) = currentSale
                        RemoveFromSalesTable()
                        AddToSalesTable()
                        UpdateProductTables()
                    End If

                Case FormTypes.Purchase
                    If Not IsNothing(currentPurchase) Then
                        Main.purchases(currentPurchase.ID) = currentPurchase
                        RemoveFromPurchasesTable()
                        AddToPurchasesTable()
                        UpdateProductTables()
                    End If

            End Select
        Catch ex As Exception
        End Try

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

    ''' <summary>
    ''' Updates every <see cref="Product.Table"/> of the current <see cref="Sale"/> or <see cref="Purchase"/>
    ''' </summary>
    Public Sub UpdateProductTables()
        Dim ecsiste As Boolean

        Select Case FormType
            Case FormTypes.Sale
                For Each p In currentSale.Products.Values
                    ecsiste = False
                    With Main.products(p.Code).Table
                        For i = 0 To .Rows.Count() - 1
                            If currentSale.ID = .Rows(i).Item("ID") Then
                                .Rows(i).Item("DATA") = currentSale.SellingDate.ToString("yyyy/MM/dd")
                                .Rows(i).Item("HISTÓRICO") = Main.products(p.Code).Sales(currentSale.ID).Description
                                .Rows(i).Item("ENTRADA") = 0
                                .Rows(i).Item("SAÍDA") = Main.products(p.Code).Sales(currentSale.ID).Quantity
                                .Rows(i).Item("SALDO") = Main.products(p.Code).Sales(currentSale.ID).Stock
                                .Rows(i).Item("ENTRADA ($)") = 0
                                .Rows(i).Item("SAÍDA ($)") = Main.products(p.Code).Sales(currentSale.ID).Value
                                .Rows(i).Item("BALANÇO") = Main.products(p.Code).Sales(currentSale.ID).Balance
                                ecsiste = True
                                Exit For
                            End If
                        Next
                        If Not ecsiste Then
                            AddProductSale(p)
                        End If
                    End With
                Next
            Case FormTypes.Purchase
                For Each p In currentPurchase.Products.Values
                    ecsiste = False
                    With Main.products(p.Code).Table
                        For i = 0 To .Rows.Count() - 1
                            If currentPurchase.ID = .Rows(i).Item("ID") Then
                                .Rows(i).Item("DATA") = currentPurchase.BuyingDate.ToString("yyyy/MM/dd")
                                .Rows(i).Item("HISTÓRICO") = Main.products(p.Code).Purchases(currentPurchase.ID).Description
                                .Rows(i).Item("ENTRADA") = Main.products(p.Code).Purchases(currentPurchase.ID).Quantity
                                .Rows(i).Item("SAÍDA") = 0
                                .Rows(i).Item("SALDO") = Main.products(p.Code).Purchases(currentPurchase.ID).Stock
                                .Rows(i).Item("ENTRADA ($)") = Main.products(p.Code).Purchases(currentPurchase.ID).Value
                                .Rows(i).Item("SAÍDA ($)") = 0
                                .Rows(i).Item("BALANÇO") = Main.products(p.Code).Purchases(currentPurchase.ID).Balance
                                ecsiste = True
                                Exit For
                            End If
                        Next
                        If Not ecsiste Then
                            AddProductPurchase(p)
                        End If
                    End With
                Next
        End Select
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        FormType = FormTypes.Sale
        NewOrder = True
        currentSale = New Sale(tbID.Text)
        tbID.Text = Main.sales.Values.Select(Function(s) CInt(s.ID)).Max + 1
        cbbResp1.SelectedIndex = 0

        LoadControls()
        ChangeInputColors(MainForm.orangeColor)
        EnableSaleControls()

        tbID.Enabled = False
        btnOK.Enabled = False
        'AddToolStripMenuItem.Enabled = True
        RemoveToolStripMenuItem.Enabled = False
        OrderToolStripMenuItem.Enabled = False
        datePicker2.Enabled = False

    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click

        FormType = FormTypes.Purchase
        NewOrder = True
        currentPurchase = New Purchase("")
        tbID.Text = ""

        LoadControls()
        ChangeInputColors(MainForm.blueColor)
        EnablePurchaseControls()

        btnOK.Enabled = False
        'AddToolStripMenuItem.Enabled = True
        RemoveToolStripMenuItem.Enabled = False
        InventoryToolStripMenuItem.Enabled = False
        PurchaseToolStripMenuItem.Enabled = False

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click

        Select Case FormType

            Case FormTypes.Sale
                currentSale.SellingDate = datePicker1.Value
                currentSale.SellingResponsible = cbbResp1.Text
                If currentSale.Retrieved Then
                    currentSale.RetrievingDate = datePicker2.Value
                    currentSale.RetrievingResponsible = cbbResp2.Text
                Else
                    currentSale.RetrievingDate = Date.Today
                    currentSale.RetrievingResponsible = ""
                End If
                currentSale.Observation = tbObs.Text
                currentSale.Client = Main.clients(cbbClient.Text)

                If Main.sales.ContainsKey(currentSale.ID) Then
                    MsgBox("O pedido de n° " + currentSale.ID + " já existe!" + vbNewLine + "Por favor altere o n° deste pedido.", MsgBoxStyle.Exclamation, "Erro!")
                    Exit Sub
                End If

                AddToSalesTable()

            Case FormTypes.Purchase
                Dim id As String = tbID.Text
                Try
                    Dim aux = CDbl(id)
                    id = currentPurchase.Vendor.Code + aux.ToString
                Catch ex As Exception
                End Try
                currentPurchase.ID = id
                currentPurchase.BuyingDate = datePicker1.Value
                currentPurchase.Observation = tbObs.Text

                If currentPurchase.Products.Count = 0 Then
                    Exit Sub
                End If

                If Main.purchases.ContainsKey(currentPurchase.ID) Then
                    MsgBox("A compra com NF de n° " + currentPurchase.ID + " já existe!" + vbNewLine + "Por favor altere o n° da NF desta compra.", MsgBoxStyle.Exclamation, "Erro!")
                    Exit Sub
                End If

                AddToPurchasesTable()

        End Select

        AddToProductTables()
        Main.UpdateTables()
        Main.GetTables()
        MainForm.LoadTables()

        currentSale = Nothing
        currentPurchase = Nothing

        LoadControls()

        btnOK.Enabled = True
        AddToolStripMenuItem.Enabled = False
        RemoveToolStripMenuItem.Enabled = True
        InventoryToolStripMenuItem.Enabled = False
        NewOrder = False
        tbID.Text = ""

    End Sub

    Public Sub AddToSalesTable()

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
                            Join(currentSale.ProductList.ToArray, "; "),
                            Join(currentSale.ValueList.ToArray, "; "),
                            currentSale.Total,
                            currentSale.Observation)

    End Sub

    Public Sub AddToPurchasesTable()

        Main.purchases.Add(currentPurchase.ID, currentPurchase)
        tablePurchases.Rows.Add(currentPurchase.ID,
                                currentPurchase.BuyingDate.ToShortDateString,
                                Join(currentPurchase.ProductList.ToArray, "; "),
                                Join(currentPurchase.ValueList.ToArray, "; "),
                                currentPurchase.Total,
                                currentPurchase.Observation)

    End Sub

    Public Sub AddToProductTables()

        Select Case FormType

            Case FormTypes.Sale
                For Each p In currentSale.Products.Values
                    AddProductSale(p)
                Next

            Case FormTypes.Purchase
                For Each p In currentPurchase.Products.Values
                    AddProductPurchase(p)
                Next

        End Select

    End Sub

    Public Sub AddProductSale(p As Product)

        Dim newSale As New Product.Sale(currentSale.ID)
        newSale.Parent = p
        newSale.Index = p.Table.Rows.Count + 1
        newSale.SellingDate = currentSale.SellingDate
        newSale.Client = Main.clients(currentSale.Client.Name)
        newSale.Observation = currentSale.Observation
        newSale.Quantity = currentSale.Products(p.Code).Quantity
        newSale.Price = currentSale.Products(p.Code).ValueWithDiscount
        p.Stock -= newSale.Quantity
        'newOrder.Balance = item.LastBalance + newOrder.Value

        Main.products(p.Code).Sales.Add(newSale.ID, newSale)
        Main.products(p.Code).Orders.Add(newSale)
        Main.products(p.Code).Stock = p.Stock

        With Main.products(p.Code).Table
            .Rows.Add(newSale.Index,
                      newSale.SellingDate.ToString("yyyy/MM/dd"),
                      newSale.ID,
                      newSale.Description,
                      0,
                      newSale.Quantity,
                      newSale.Stock,
                      0,
                      newSale.Value,
                      newSale.Balance)
        End With

    End Sub

    Public Sub AddProductPurchase(p As Product)

        Dim newPurchase As New Product.Purchase(currentPurchase.ID)
        newPurchase.Parent = p
        newPurchase.Index = p.Table.Rows.Count + 1
        newPurchase.BuyingDate = currentPurchase.BuyingDate
        newPurchase.Vendor = currentPurchase.Vendor
        newPurchase.Observation = currentPurchase.Observation
        newPurchase.Quantity = currentPurchase.Products(p.Code).Quantity
        newPurchase.Cost = currentPurchase.Products(p.Code).ValueWithDiscount
        p.Stock += newPurchase.Quantity
        'newPurchase.Balance = item.LastBalance - newPurchase.Value

        Main.products(p.Code).Purchases.Add(newPurchase.ID, newPurchase)
        Main.products(p.Code).Orders.Add(newPurchase)
        Main.products(p.Code).Stock = p.Stock

        With Main.products(p.Code).Table
            .Rows.Add(newPurchase.Index,
                      newPurchase.BuyingDate.ToString("yyyy/MM/dd"),
                      newPurchase.ID,
                      newPurchase.Description,
                      newPurchase.Quantity,
                      0,
                      newPurchase.Stock,
                      newPurchase.Value,
                      0,
                      newPurchase.Balance)
        End With

    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click

        Select Case FormType

            Case FormTypes.Sale

                RemoveFromSalesTable()

            Case FormTypes.Purchase

                RemoveFromPurchasesTable()

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

    Public Sub RemoveFromSalesTable()

        Dim id = currentSale.ID
        Dim client = Main.clients(currentSale.Client.Name)
        Dim sale = client.Sales.Where(Function(x) x.ID = id).FirstOrDefault
        client.Sales.Remove(sale)

        Main.sales.Remove(id)
        For i = 0 To tableOrders.Rows.Count - 1
            If tableOrders.Rows(i).Item("ID") = id Then
                tableOrders.Rows(i).Delete()
                Exit Sub
            End If
        Next

    End Sub

    Public Sub RemoveFromPurchasesTable()

        Dim id = currentPurchase.ID
        Dim vendor = Main.vendors(currentPurchase.Vendor.Name)
        Dim purchase = vendor.Purchases.Where(Function(y) y.ID = id).FirstOrDefault
        vendor.Purchases.Remove(purchase)

        Main.purchases.Remove(id)
        For j = 0 To tablePurchases.Rows.Count - 1
            If tablePurchases.Rows(j).Item("ID") = id Then
                tablePurchases.Rows(j).Delete()
                Exit Sub
            End If
        Next

    End Sub

    Public Sub RemoveFromProductTables()

        Select Case FormType

            Case FormTypes.Sale
                For Each item In currentSale.Products.Values

                    'Dim pTable = Main.productTables.Where(Function(x) x.Key.Code = item.Code).First.Value
                    Dim pTable = Main.products(item.Code).Table
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

                    'Dim pTable = Main.productTables.Where(Function(x) x.Key.Code = item.Code).First.Value
                    Dim pTable = Main.products(item.Code).Table
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
                        If NewOrder Then
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
                        If NewOrder Then
                            selectedProduct.Quantity = 0
                        End If
                    End If

            End Select

            UpdateProductLabels()
            tbQtty.Text = selectedProduct.Quantity.ToString.ToZero
            tbPrice.Text = selectedProduct.Value.ToString("0.00")
            cbDiscount.Checked = selectedProduct.HasDiscount

        End If

    End Sub

    Public Sub UpdateProductLabels()

        lblKind.Text = selectedProduct.Kind
        lblName.Text = selectedProduct.Name
        lblBrand.Text = selectedProduct.Brand
        lblStock.Text = selectedProduct.Stock.ToString.ToZero
        tbQtty.Text = selectedProduct.Quantity.ToString.ToZero
        tbPrice.Text = selectedProduct.Value.ToString("0.00")
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

        If e.Action = TreeViewAction.ByMouse Then
            e.Node.Checked = Not e.Node.Checked
            Exit Sub
        End If

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

    Private Sub lvItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 'Handles lvItems.CellContentClick
        Dim entry = lvItems.Item(0, e.RowIndex).Value.ToString.NotNull
        If entry = "" Then Exit Sub

        Dim pCode = entry.Split(" x ").Last
        Dim pKind = pCode.Split("-").First
        Dim pName = pCode.Split("-").Last

        selectedProduct = Main.products(pKind + "-" + pName)

        UpdateProductLabels()

    End Sub

    Private Sub AddToolStripMenuItem_EnabledChanged(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.EnabledChanged
        With AddToolStripMenuItem
            If .Enabled Then
                .BackColor = MainForm.greenColor
            Else
                .BackColor = Me.BackColor
            End If
        End With
    End Sub

    Private Sub RemoveToolStripMenuItem_EnabledChanged(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.EnabledChanged
        With RemoveToolStripMenuItem
            If .Enabled Then
                .BackColor = MainForm.redColor
            Else
                .BackColor = Me.BackColor
            End If
        End With
    End Sub

    Private Sub InventoryToolStripMenuItem_EnabledChanged(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.EnabledChanged
        With InventoryToolStripMenuItem
            If .Enabled Then
                .BackColor = MainForm.yellowColor
            Else
                .BackColor = Me.BackColor
            End If
        End With
    End Sub
    Private Sub cbDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles cbDiscount.CheckedChanged

        Try
            Select Case FormType
                Case FormTypes.Sale
                    currentSale.Products(selectedProduct.Code).HasDiscount = cbDiscount.Checked

                    GetProportionalDiscounts(currentSale)

                    Dim i = 0
                    For Each p In currentSale.Products.Values
                        lvItems.Item(1, i).Value = p.ValueWithDiscount.ToString("R$ 0.00")
                        i += 1
                    Next
                Case FormTypes.Purchase
                    currentPurchase.Products(selectedProduct.Code).HasDiscount = cbDiscount.Checked

                    GetProportionalDiscounts(currentPurchase)

                    Dim i = 0
                    For Each p In currentPurchase.Products.Values
                        lvItems.Item(1, i).Value = p.ValueWithDiscount.ToString("R$ 0.00")
                        i += 1
                    Next
            End Select


        Catch ex As Exception
            Exit Sub
        End Try

        tbPrice.Enabled = Not cbDiscount.Checked
        If tbPrice.Enabled Then
            tbPrice.Text = selectedProduct.Value.ToString("0.00")
        Else
            tbPrice.Text = selectedProduct.Value.ToString("0.00")
        End If

    End Sub

    Private Sub tbDiscount_TextChanged(sender As Object, e As EventArgs) Handles tbDiscount.TextChanged
        Dim discount As Double = 0
        Dim percentage As Double = 0
        Dim subtotal As Double = 0

        Try
            discount = CDbl(tbDiscount.Text)
        Catch ex As Exception
        End Try

        Try
            subtotal = CDbl(lblSubTotal.Text.Replace("R$ ", ""))
        Catch ex As Exception
            Exit Sub
        End Try

        percentage = discount / subtotal
        lblDiscount.Text = percentage.ErrorsToZero.ToString("(0%)")

        Select Case FormType
            Case FormTypes.Sale
                currentSale.TotalDiscount = discount
                cbDiscount_CheckedChanged(sender, e)
                lblTotal.Text = currentSale.Total.ToString("R$ 0.00")
            Case FormTypes.Purchase
                currentPurchase.TotalDiscount = discount
                cbDiscount_CheckedChanged(sender, e)
                lblTotal.Text = currentPurchase.Total.ToString("R$ 0.00")
        End Select

        Extensions.Stringify(tbDiscount)

    End Sub

    Private Sub lblSubTotal_TextChanged(sender As Object, e As EventArgs) Handles lblSubTotal.TextChanged
        tbDiscount_TextChanged(sender, e)
    End Sub

    Private Class MyRenderer : Inherits ToolStripProfessionalRenderer
        Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
            Dim rc As New Rectangle(Point.Empty, e.Item.Size)
            If e.Item.Enabled Then
                If e.Item.Selected Then
                    e.Graphics.FillRectangle(New SolidBrush(ChooseItemColor(e.Item)), rc)
                    e.Graphics.DrawRectangle(New Pen(ChooseItemColor(e.Item, True)), 1, 0, rc.Width - 2, rc.Height - 1)

                    e.Item.ForeColor = ChooseItemColor(e.Item, True)
                Else
                    e.Graphics.FillRectangle(New SolidBrush(ChooseItemColor(e.Item)), rc)

                    e.Item.ForeColor = Color.Black
                End If
            End If
        End Sub

        Public Function ChooseItemColor(item As ToolStripMenuItem, Optional strong As Boolean = False) As Color

            If strong Then
                Select Case item.Text
                    Case "Adicionar"
                        Return Color.DarkGreen
                    Case "Remover"
                        Return Color.DarkRed
                    Case "Itens do Inventário"
                        Return Color.DarkOrange
                    Case "Novo Pedido"
                        Return Color.Maroon
                    Case "Nova Compra"
                        Return Color.Navy
                    Case Else
                        Return SystemColors.ControlText
                End Select
            Else
                Select Case item.Text
                    Case "Adicionar"
                        Return MainForm.greenColor
                    Case "Remover"
                        Return MainForm.redColor
                    Case "Itens do Inventário"
                        Return MainForm.yellowColor
                    Case "Novo Pedido"
                        Return MainForm.orangeColor
                    Case "Nova Compra"
                        Return MainForm.blueColor
                    Case Else
                        Return SystemColors.Control
                End Select
            End If

        End Function

    End Class

    Private Sub FormClosingEvent(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
        MainForm.BringToFront()
    End Sub

End Class