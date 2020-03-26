Imports StockLib.Extensions


''' <summary>
''' Main Module, where the program events are located
''' </summary>
Public Module Main

    Public companyName As String = "ChoppExpress"
    Public appDataFolder As String
    Public tableStock As New DataTable
    Public tableProducts As New DataTable
    Public tableOrders As New DataTable
    Public tablePurchases As New DataTable
    Public tableClients As New DataTable
    Public tableVendors As New DataTable
    Public tableResp As New DataTable
    Public clients As New Dictionary(Of String, Client)
    Public vendors As New Dictionary(Of String, Vendor)
    Public products As New Dictionary(Of String, Product)
    Public orders As New Dictionary(Of String, Order)
    Public purchases As New Dictionary(Of String, Purchase)
    Public productTables As New Dictionary(Of Product, DataTable)
    Public selectedTable As New DataTable

    ''' <summary>
    ''' Sub responsible for loading all necessary information for the StockControl app
    ''' </summary>
    Public Sub Start()

        appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        "\StockControl\" + companyName + "\"

        GetTables()

        'FIXES STOCK TABLE
        With tableStock
            For i = 0 To .Rows.Count - 1
                Select Case Len(.Rows(i).Item(2))
                    Case 1
                        .Rows(i).Item(2) = "00" + .Rows(i).Item(2)
                    Case 2
                        .Rows(i).Item(2) = "0" + .Rows(i).Item(2)
                End Select
            Next
        End With

    End Sub

    ''' <summary>
    ''' Sub responsible for getting data from each CSV file and load it into its respective DataTable object
    ''' </summary>
    Public Sub GetTables()
        On Error Resume Next

        tableVendors = DataTableFromCSV(appDataFolder + "tableVendor.csv", True, "|")
        LoadVendors()

        tableClients = DataTableFromCSV(appDataFolder + "tableClients.csv", True, "|")
        LoadClients()

        tableResp = DataTableFromCSV(appDataFolder + "tableResp.csv", True, "|")

        tableOrders = DataTableFromCSV(appDataFolder + "tableOrders.csv", True, "|")
        LoadOrders()

        tablePurchases = DataTableFromCSV(appDataFolder + "tablePurchases.csv", True, "|")
        LoadPurchases()

        tableProducts = DataTableFromCSV(appDataFolder + "tableProducts.csv", True, "|")
        LoadProducts()

    End Sub

    ''' <summary>
    ''' Loads all product information into a list of Product objects
    ''' </summary>
    Public Sub LoadProducts()

        products.Clear()

        'ADDS MAIN INFORMATION OF ALL PRODUCTS
        With tableProducts
            For i = 0 To .Rows.Count - 1
                Dim p As New Product(.Rows(i).Item("PRODUTO"))
                p.Brand = .Rows(i).Item("MARCA")
                p.Stock = .Rows(i).Item("ESTOQUE")
                p.Quantity = 0  '.Rows(i).Item("QTD")
                p.Value = 0     '.Rows(i).Item("VALOR")
                p.Cost = .Rows(i).Item("CUSTO")
                p.Price = .Rows(i).Item("PREÇO")
                products.Add(p.Code, p)
            Next i
        End With

        'ADDS ALL PRODUCT TABLES TO A LIST
        productTables.Clear()

        For Each p In products.Values
            Try
                Dim table As New DataTable
                table = DataTableFromCSV(appDataFolder + p.TableName + ".csv", True, "|")
                productTables.Add(p, table)
            Catch ex As Exception
                'MsgBox("Failed to load table " + p.TableName)
            End Try
        Next

        'ADDS ORDER AND PURCHASE INFORMATION FOR EACH PRODUCT
        For Each p In products.Values
            With productTables(p)
                For i = 0 To .Rows.Count - 1
                    If CDbl(.Rows(i).Item("ENTRADA").ToString.ToZero) > 0 Then
                        Dim purchase As New Product.Purchase(.Rows(i).Item("ID"))
                        purchase.BuyingDate = DateValue(.Rows(i).Item("DATA"))
                        purchase.Description = .Rows(i).Item("HISTÓRICO")
                        purchase.Quantity = .Rows(i).Item("ENTRADA")
                        purchase.Stock = .Rows(i).Item("SALDO")
                        purchase.Value = .Rows(i).Item("ENTRADA ($)")
                        purchase.Balance = .Rows(i).Item("BALANÇO")

                        p.Purchases.Add(purchase.ID, purchase)
                    End If
                    If CDbl(.Rows(i).Item("SAÍDA").ToString.ToZero) > 0 Then
                        Dim order As New Product.Order(.Rows(i).Item("ID"))
                        order.SellingDate = DateValue(.Rows(i).Item("DATA"))
                        order.Description = .Rows(i).Item("HISTÓRICO")
                        order.Quantity = .Rows(i).Item("SAÍDA")
                        order.Stock = .Rows(i).Item("SALDO")
                        order.Value = .Rows(i).Item("SAÍDA ($)")
                        order.Balance = .Rows(i).Item("BALANÇO")

                        p.Orders.Add(order.ID, order)
                    End If
                Next
            End With
        Next

    End Sub

    ''' <summary>
    ''' Loads all client information into a dictionary of Client objects
    ''' </summary>
    Public Sub LoadClients()

        clients.Clear()

        With tableClients
            For i = 0 To .Rows.Count - 1
                Dim c As New Client(.Rows(i).Item("CLIENTE"))
                c.Phone = .Rows(i).Item("TELEFONE")
                c.Address = .Rows(i).Item("RUA")
                c.Neighborhood = .Rows(i).Item("BAIRRO")
                c.Location = .Rows(i).Item("LOCALIDADE")

                clients.Add(c.Name, c)
            Next
        End With

    End Sub

    ''' <summary>
    ''' Loads all vendor information into a dictionary of Vendor objects
    ''' </summary>
    Public Sub LoadVendors()

        vendors.Clear()

        With tableVendors
            For i = 0 To .Rows.Count - 1
                Dim v As New Vendor(.Rows(i).Item("FORNECEDOR"))

                vendors.Add(v.Name, v)
            Next
        End With

    End Sub

    ''' <summary>
    ''' Loads all order information into a dictionary of Order objects
    ''' </summary>
    Public Sub LoadOrders()

        Try
            tableOrders.Columns.Remove("ENDERECO")
        Catch ex As Exception
        End Try

        orders.Clear()

        With tableOrders
            For i = 0 To .Rows.Count - 1
                Dim o As New Order(.Rows(i).Item("ID"))
                o.SellingDate = DateValue(.Rows(i).Item("DATA1").ToString.ToDateNotNull)
                o.RetrievingDate = DateValue(.Rows(i).Item("DATA2").ToString.ToDateNotNull)
                o.SellingResponsible = .Rows(i).Item("RESP1")
                o.RetrievingResponsible = .Rows(i).Item("RESP2")
                o.Items.Clear()
                Dim items = Split(.Rows(i).Item("PEDIDO"), ";").ToList
                Dim prices = Split(.Rows(i).Item("PREÇOS"), ";").ToList
                For Each item In items.Except({""})
                    Dim code As String = Split(item, " x ").Last
                    Dim qtty As Double = CDbl(Split(item, " x ").First)
                    Dim pp = New Product(code)
                    With pp
                        pp.Value = CDbl(prices(items.IndexOf(item)).Replace("$ ", ""))
                        pp.Quantity = qtty
                    End With

                    o.Items.Add(pp.Code, pp)
                Next
                o.Observation = .Rows(i).Item("OBS")
                o.Client = clients(.Rows(i).Item("CLIENTE"))

                orders.Add(o.ID, o)
                Next
        End With

    End Sub

    ''' <summary>
    ''' Loads all order information into a dictionary of Purchase objects
    ''' </summary>
    Public Sub LoadPurchases()

        purchases.Clear()

        With tablePurchases
            For i = 0 To .Rows.Count - 1
                Dim p As New Purchase(.Rows(i).Item("ID"))
                p.BuyingDate = DateValue(.Rows(i).Item("DATA").ToString.ToZero)
                p.Items.Clear()
                Dim items = Split(.Rows(i).Item("COMPRA"), ";").ToList
                Dim prices = Split(.Rows(i).Item("PREÇOS"), ";").ToList
                For Each item In items.Except({""})
                    Dim code As String = Split(item, " x ").Last
                    Dim qtty As Double = CDbl(Split(item, " x ").First)
                    Dim pp = New Product(code)
                    With pp
                        pp.Value = CDbl(prices(items.IndexOf(item)).Replace("$ ", ""))
                        pp.Quantity = qtty
                    End With

                    p.Items.Add(pp.Code, pp)
                Next
                p.Observation = .Rows(i).Item("OBS")
                purchases.Add(p.ID, p)
            Next
        End With

    End Sub

    Public Function GetClientName(words As String)

        If Main.clients.ContainsKey(words) Then
            Return words
        Else
            Dim result As String = ""
            For Each word In words.Split(" ")
                result += word
                If Main.clients.ContainsKey(result) Then
                    Return result
                    Exit Function
                End If
                result += " "
            Next
        End If

    End Function

    Public Function GetVendorName(words As String)

        If Main.vendors.ContainsKey(words) Then
            Return words
        Else
            Dim result As String = ""
            For Each word In words.Split(" ")
                result += word
                If Main.vendors.ContainsKey(result) Then
                    Return result
                    Exit Function
                End If
                result += " "
            Next
        End If

    End Function

    Public Sub UpdateTables()

        'UPDATES THE PRODUCTS TABLE (STOCK)
        With tableProducts
            For p = 0 To .Rows.Count - 1
                .Rows(p).Item("ESTOQUE") = products(.Rows(p).Item("PRODUTO")).Stock
            Next
        End With
        Try
            WriteCSV(tableProducts, NameOf(tableProducts), "|", True)
        Catch ex As Exception
        End Try

        'UPDATES THE ORDERS DATATABLE
        With tableOrders
            For i = 0 To .Rows.Count - 1
                Dim order = orders(.Rows(i).Item("ID"))
                .Rows(i).Item("CLIENTE") = order.Client.Name
                '.Rows(i).Item("ITENS") = 
                .Rows(i).Item("RESP1") = order.SellingResponsible
                .Rows(i).Item("DATA1") = order.SellingDate.ToShortDateString
                .Rows(i).Item("RESP2") = order.RetrievingResponsible
                If order.RetrievingResponsible = "" Then
                    .Rows(i).Item("DATA2") = ""
                Else
                    .Rows(i).Item("DATA2") = order.RetrievingDate.ToShortDateString
                End If
                .Rows(i).Item("RECOLHIDO") = order.Retrieved
                .Rows(i).Item("CHOPEIRA") = order.IncludesCooler
                .Rows(i).Item("PEDIDO") = Join(order.OrderList.ToArray, "; ")
                .Rows(i).Item("PREÇOS") = Join(order.PriceList.ToArray, "; ")
                .Rows(i).Item("TOTAL") = order.Total
                .Rows(i).Item("OBS") = order.Observation
            Next
        End With
        Try
            WriteCSV(tableOrders, NameOf(tableOrders), "|", True)
        Catch ex As Exception
        End Try

        'UPDATES THE PURCHASES DATATABLE
        With tablePurchases
            For j = 0 To .Rows.Count - 1
                Dim purchase = purchases(.Rows(j).Item("ID"))
                .Rows(j).Item("DATA") = purchase.BuyingDate.ToShortDateString
                .Rows(j).Item("COMPRA") = Join(purchase.PurchaseList.ToArray, "; ")
                .Rows(j).Item("PREÇOS") = Join(purchase.CostList.ToArray, "; ")
                .Rows(j).Item("TOTAL") = purchase.Total
                .Rows(j).Item("OBS") = purchase.Observation
            Next
        End With
        Try
            WriteCSV(tablePurchases, NameOf(tablePurchases), "|", True)
        Catch ex As Exception
        End Try

        'UPDATES EACH PRODUCT DATATABLE
        For Each pTable In productTables
            pTable.Value.Rows.Clear()

            For Each purchase In pTable.Key.Purchases.Values
                pTable.Value.Rows.Add(purchase.BuyingDate.ToShortDateString,
                          purchase.ID,
                          purchase.Description,
                          purchase.Quantity,
                          0,
                          purchase.Stock,
                          purchase.Quantity,
                          0,
                          purchase.Balance)
            Next
            For Each order In pTable.Key.Orders.Values
                pTable.Value.Rows.Add(order.SellingDate.ToShortDateString,
                          order.ID,
                          order.Description,
                          0,
                          order.Quantity,
                          order.Stock,
                          0,
                          order.Value,
                          order.Balance)
            Next

            Dim dv As New DataView(pTable.Value)
            dv.Sort = "DATA ASC"
            Dim dt = dv.ToTable

            Try
                WriteCSV(dt, pTable.Key.TableName, "|", True)
            Catch ex As Exception
            End Try

        Next

    End Sub

End Module
