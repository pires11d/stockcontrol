Imports StockLib.Extensions


''' <summary>
''' Main Module, where the program events are located
''' </summary>
Public Module Main

    Public fontName As String = "Consolas"
    Public companyName As String = "L'jaica"
    Public appDataFolder As String
    Public downloadDataFolder As String
    Public uploadDataFolder As String
    Private user As String = "pires11d"
    Private pass As String = "calculera"
    Public passwordLJ As String = "positividade"
    Public passwordCE As String = "pires223"
    Public localList As New List(Of String)
    Public remoteList As New List(Of String)
    Public currentSync As String = ""
    Public isSyncing As Boolean = True
    Public tableStock As New DataTable
    Public tableProducts As New DataTable
    Public tableOrders As New DataTable
    Public tablePurchases As New DataTable
    Public tableClients As New DataTable
    Public tableVendors As New DataTable
    Public tableOwners As New DataTable
    Public tableBarrels As New DataTable
    Public tableCoolers As New DataTable
    Public tableCylinders As New DataTable
    Public tableValves As New DataTable
    Public owners As New List(Of String)
    Public clients As New Dictionary(Of String, Client)
    Public vendors As New Dictionary(Of String, Vendor)
    Public products As New Dictionary(Of String, Product)
    Public sales As New Dictionary(Of String, Sale)
    Public purchases As New Dictionary(Of String, Purchase)
    Public barrels As New Dictionary(Of String, Barrel)
    Public coolers As New Dictionary(Of String, Cooler)
    Public cylinders As New Dictionary(Of String, Cylinder)
    Public valves As New Dictionary(Of String, Valve)
    Public selectedTable As New DataTable

    ''' <summary>
    ''' Sub responsible for loading all necessary information for the StockControl app
    ''' </summary>
    Public Sub Start()

        appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        "\StockControl\" + companyName + "\"
        downloadDataFolder = "http://pires11d.com/apps/StockControl/" +
                             companyName + "/"
        uploadDataFolder = "ftp://files.000webhost.com:21/public_html/apps/StockControl/" +
                            companyName + "/"
        '/storage/ssd2/571/6126571

        GetTables()

    End Sub

    ''' <summary>
    ''' Sub responsible for getting data from each CSV file and load it into its respective DataTable object
    ''' </summary>
    Public Sub GetTables()
        'On Error Resume Next

        tableClients = ReadCSV(appDataFolder + "tableClients.csv", "|")
        LoadClients()

        tableOwners = ReadCSV(appDataFolder + "tableResp.csv", "|")
        LoadOwners()

        tableVendors = ReadCSV(appDataFolder + "tableVendors.csv", "|")
        LoadVendors()

        tableBarrels = ReadCSV(appDataFolder + "tableB.csv", "|")
        tableCoolers = ReadCSV(appDataFolder + "tableC.csv", "|")
        LoadItems()

        tableProducts = ReadCSV(appDataFolder + "tableProducts.csv", "|")
        LoadProducts()

        tableOrders = ReadCSV(appDataFolder + "tableOrders.csv", "|")
        LoadSales()

        tablePurchases = ReadCSV(appDataFolder + "tablePurchases.csv", "|")
        LoadPurchases()

        LoadProductTables()

    End Sub

    ''' <summary>
    ''' Loads all items (<see cref="Barrel"/>, <see cref="Cooler"/>, <see cref="Cylinder"/>) information into their respective object dictionaries
    ''' </summary>
    Public Sub LoadItems()

        barrels.Clear()
        With tableBarrels
            For i = 0 To .Rows.Count - 1
                Dim b As New Barrel(.Rows(i).Item("BARRIL"))
                b.Type = .Rows(i).Item("TIPO")
                b.State = .Rows(i).Item("RECOLHIDO")
                barrels.Add(b.ID, b)
            Next
        End With

        coolers.Clear()
        With tableCoolers
            For i = 0 To .Rows.Count - 1
                Dim c As New Cooler(.Rows(i).Item("CHOPEIRA"))
                c.Type = .Rows(i).Item("TIPO")
                c.State = .Rows(i).Item("RECOLHIDO")
                coolers.Add(c.ID, c)
            Next
        End With

        'cylinders.Clear()
        'With tableCylinders
        '    For i = 0 To .Rows.Count - 1
        '        Dim g As New Cylinder(.Rows(i).Item("CILINDRO"))   
        '        g.Kind = Item.Kinds.Cilindro
        '        g.Type = .Rows(i).Item("TIPO")
        '        g.State = .Rows(i).Item("RECOLHIDO")
        '        cylinders.Add(g.ID, g)
        '    Next
        'End With   

        'valves.Clear()
        'With tableValves
        '    For i = 0 To .Rows.Count - 1
        '        Dim v As New Valve(.Rows(i).Item("VÁLVULA"))
        '        v.Kind = Item.Kinds.Cilindro
        '        v.Type = .Rows(i).Item("TIPO")
        '        v.State = .Rows(i).Item("RECOLHIDO")
        '        valves.Add(v.ID, v)
        '    Next
        'End With

    End Sub

    ''' <summary>
    ''' Loads all product information into a dictionary of <see cref="Product"/> objects
    ''' </summary>
    Public Sub LoadProducts()

        products.Clear()

        'ADDS MAIN INFORMATION OF ALL PRODUCTS
        With tableProducts
            For i = 0 To .Rows.Count - 1
                Dim p As New Product(.Rows(i).Item("PRODUTO"))
                p.Brand = .Rows(i).Item("MARCA")
                p.Stock = .Rows(i).Item("ESTOQUE")
                p.Quantity = 0
                p.Value = 0
                p.Cost = CDbl(.Rows(i).Item("CUSTO").ToString.ToZero)
                p.Price = CDbl(.Rows(i).Item("PREÇO").ToString.ToZero)
                p.Price2 = CDbl(.Rows(i).Item("PREÇO2").ToString.ToZero)
                products.Add(p.Code, p)
            Next i
        End With

    End Sub

    ''' <summary>
    ''' Loads all client information into a dictionary of <see cref="Client"/> objects
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
                c.ID = CInt(.Rows(i).Item("ID").ToString.ToZero)
                clients.Add(c.Name, c)
            Next
        End With

    End Sub

    ''' <summary>
    ''' Loads all vendor information into a dictionary of Vendor objects: <see cref="vendors"/>
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
    ''' Loads company owners (from tableResp) into a list of <see cref="String"/>
    ''' </summary>
    Public Sub LoadOwners()

        owners.Clear()
        With tableOwners
            For i = 0 To .Rows.Count - 1
                owners.Add(.Rows(i).Item("RESP"))
            Next
        End With

    End Sub

    ''' <summary>
    ''' Loads all order information into a dictionary of <see cref="Sale"/> objects
    ''' </summary>
    Public Sub LoadSales()

        Try
            tableOrders.Columns.Remove("ENDERECO")
        Catch ex As Exception
        End Try

        sales.Clear()

        With tableOrders
            For i = 0 To .Rows.Count - 1
                Dim s As New Sale(.Rows(i).Item("ID"))
                s.Client = clients(.Rows(i).Item("CLIENTE"))
                s.SellingDate = DateValue(.Rows(i).Item("DATA1").ToString.ToDateNotNull)
                s.RetrievingDate = DateValue(.Rows(i).Item("DATA2").ToString.ToDateNotNull)
                s.SellingResponsible = .Rows(i).Item("RESP1")
                s.RetrievingResponsible = .Rows(i).Item("RESP2")
                s.Retrieved = .Rows(i).Item("RECOLHIDO")
                s.Observation = .Rows(i).Item("OBS")
                s.Paid = .Rows(i).Item("PAGO").ToString.ToBoolNotNull

                s.Products.Clear()
                Dim productList = Split(.Rows(i).Item("PEDIDO"), ";").ToList
                Dim priceList = Split(.Rows(i).Item("PREÇOS"), ";").ToList
                For Each product In productList.Except({""})
                    Dim code As String = Split(product, " x ").Last
                    Dim qtty As Double = CDbl(Split(product, " x ").First)
                    Dim pr = New Product(code)
                    With pr
                        pr.Brand = products(code).Brand
                        pr.Value = CDbl(priceList(productList.IndexOf(product)).Replace("$ ", ""))
                        pr.Quantity = qtty
                    End With
                    s.Products.Add(pr.Code, pr)
                Next
                Dim items = Split(.Rows(i).Item("ITENS"), " ").ToList.Except({""})
                If items.Count > 0 Then
                    For Each item In items
                        If barrels.ContainsKey(item) Then
                            s.Barrels.Add(item, barrels(item))
                            barrels(item).Sales.Add(s)
                        End If
                        If coolers.ContainsKey(item) Then
                            s.Coolers.Add(item, coolers(item))
                            coolers(item).Sales.Add(s)
                        End If
                    Next
                End If
                sales.Add(s.ID, s)

                clients(s.Client.Name).Sales.Add(s)
            Next
        End With

    End Sub

    ''' <summary>
    ''' Loads all order information into a dictionary of <see cref="Purchase"/> objects
    ''' </summary>
    Public Sub LoadPurchases()

        purchases.Clear()

        With tablePurchases
            For i = 0 To .Rows.Count - 1
                Dim p As New Purchase(.Rows(i).Item("ID"))
                p.BuyingDate = DateValue(.Rows(i).Item("DATA").ToString.ToZero)
                p.Observation = .Rows(i).Item("OBS")
                p.Paid = .Rows(i).Item("PAGO").ToString.ToBoolNotNull

                p.Products.Clear()
                Dim productList = Split(.Rows(i).Item("COMPRA"), ";").ToList
                Dim proceList = Split(.Rows(i).Item("PREÇOS"), ";").ToList
                For Each product In productList.Except({""})
                    Dim code As String = Split(product, " x ").Last
                    Dim qtty As Double = CDbl(Split(product, " x ").First)
                    Dim pr = New Product(code)
                    With pr
                        pr.Brand = products(code).Brand
                        pr.Value = CDbl(proceList(productList.IndexOf(product)).Replace("$ ", ""))
                        pr.Quantity = qtty
                    End With

                    p.Products.Add(pr.Code, pr)
                Next
                purchases.Add(p.ID, p)

                vendors(p.Vendor.Name).Purchases.Add(p)
            Next
        End With

    End Sub

    ''' <summary>   
    ''' Loads every product's history information into a dictionary of <see cref="Product"/> and <see cref="DataTable"/> objects
    ''' </summary>
    Public Sub LoadProductTables()

        'ADDS ALL PRODUCT TABLES TO A LIST
        For Each p In products.Values
            Try
                p.Table = ReadCSV(appDataFolder + p.TableName + ".csv", "|", True, True)
            Catch exx As Exception
                p.Table = ReadCSV(appDataFolder + p.TableName + ".csv", "|", True, False)
            End Try
            'productTables.Add(p.Code, table)
        Next

        'ADDS ORDER AND PURCHASE INFORMATION FOR EACH PRODUCT
        For Each p In products.Values
            With p.Table
                For i = 0 To .Rows.Count - 1
                    If CDbl(.Rows(i).Item("ENTRADA").ToString.ToZero) > 0 Then

                        Dim purchase As New Product.Purchase(.Rows(i).Item("ID"))
                        purchase.BuyingDate = DateValue(.Rows(i).Item("DATA"))
                        purchase.Description = .Rows(i).Item("HISTÓRICO")
                        purchase.Quantity = .Rows(i).Item("ENTRADA")
                        'purchase.Stock = .Rows(i).Item("SALDO")
                        purchase.Value = .Rows(i).Item("ENTRADA ($)")
                        'purchase.Balance = .Rows(i).Item("BALANÇO")
                        purchase.Parent = p

                        Try
                            purchase.Paid = purchases(purchase.ID).Paid
                        Catch ex As Exception

                        End Try

                        Try
                            p.Purchases.Add(purchase.ID, purchase)
                            p.Orders.Add(purchase)
                        Catch ex As Exception
                        End Try

                    ElseIf CDbl(.Rows(i).Item("SAÍDA").ToString.ToZero) > 0 Then

                        Dim sale As New Product.Sale(.Rows(i).Item("ID"))
                        sale.SellingDate = DateValue(.Rows(i).Item("DATA"))
                        sale.Description = .Rows(i).Item("HISTÓRICO")
                        sale.Quantity = .Rows(i).Item("SAÍDA")
                        'sale.Stock = .Rows(i).Item("SALDO")
                        sale.Value = .Rows(i).Item("SAÍDA ($)")
                        'sale.Balance = .Rows(i).Item("BALANÇO")
                        sale.Parent = p

                        Try
                            sale.Paid = sales(sale.ID).Paid
                        Catch ex As Exception

                        End Try

                        Try
                            p.Sales.Add(sale.ID, sale)
                            p.Orders.Add(sale)
                        Catch ex As Exception
                        End Try

                    End If
                Next
            End With
        Next

    End Sub

    ''' <summary>
    ''' Gets the client name from the Description field
    ''' </summary>
    ''' <param name="words"></param>
    ''' <returns></returns>
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
            Return result
        End If

    End Function

    ''' <summary>
    ''' Gets the vendor name from the Description field
    ''' </summary>
    ''' <param name="words"></param>
    ''' <returns></returns>
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
            Return result
        End If

    End Function

    ''' <summary>
    ''' Calculates all individual <see cref="Product.Discount"/> values for the list of <see cref="Order.Products"/>
    ''' </summary>
    ''' <param name="thisOrder"></param>
    Public Sub GetProportionalDiscounts(thisOrder As Order)
        If thisOrder.Products.Count = 0 Then Exit Sub

        For Each p In thisOrder.Products.Values
            If p.HasDiscount Then
                p.Discount = (p.Value * p.Quantity) * thisOrder.TotalDiscount / thisOrder.Products.Values.Where(Function(x) x.HasDiscount).Select(Function(y) y.Quantity * y.Value).Sum() / p.Quantity
            Else
                p.Discount = 0
            End If
        Next

    End Sub

    ''' <summary>
    ''' Updates all tables locally, replacing the old CSV files by new ones
    ''' </summary>
    Public Sub UpdateTables()

        'UPDATES THE CLIENT TABLE
        Dim c = 0
        For Each cli In clients.Values
            Try
                tableClients.Rows(c).Item("ENDERECO") = clients(tableClients.Rows(c).Item("CLIENTE")).FullAddress.ToString.NotNull
            Catch ex As Exception
                If Not tableClients.Rows(c - 1).Item(0) = cli.Name Then
                    tableClients.Rows.Add(cli.Name,
                                      cli.Phone.ToString.NotNull,
                                      cli.Address.ToString.NotNull,
                                      cli.Neighborhood.ToString.NotNull,
                                      cli.Location.ToString.NotNull,
                                      cli.FullAddress.ToString.NotNull,
                                      cli.ID.ToString.NotNull)
                End If
            End Try
            c += 1
        Next
        Dim lastRow = tableClients.Rows.Count - 1
        If tableClients.Rows(lastRow).Item(0).ToString.NotNull = "" Then tableClients.Rows.RemoveAt(lastRow)
        Dim dvc As New DataView(tableClients)
        dvc.Sort = "CLIENTE ASC"
        Dim dtc = dvc.ToTable
        For c = 0 To dtc.Rows.Count - 1
            dtc.Rows(c).Item("ID") = c + 1
        Next
        Try
            WriteCSV(dtc, NameOf(tableClients), "|", True)
        Catch ex As Exception
        End Try

        'UPDATES THE VENDOR TABLE
        With tableVendors
            .Rows.Clear()
            Dim i = 0
            For Each v In vendors.Keys
                .Rows.Add()
                .Rows(i).Item(0) = v
                i += 1
            Next
        End With
        Try
            WriteCSV(tableVendors, NameOf(tableVendors), "|", True)
        Catch ex As Exception
        End Try

        'UPDATES THE PRODUCTS TABLE (STOCK)
        For Each p In products.Values
            Dim t = p.Table
            p.Stock = p.LastStock
        Next

        With tableProducts
            For p = 0 To .Rows.Count - 1
                .Rows(p).Item("ESTOQUE") = products(.Rows(p).Item("PRODUTO")).Stock
                .Rows(p).Item("CUSTO") = products(.Rows(p).Item("PRODUTO")).Cost
                .Rows(p).Item("PREÇO") = products(.Rows(p).Item("PRODUTO")).Price
            Next
        End With
        Dim dvp As New DataView(tableProducts)
        dvp.Sort = "PRODUTO ASC, MARCA ASC"
        Dim dtp = dvp.ToTable
        Try
            WriteCSV(dtp, NameOf(tableProducts), "|", True)
        Catch ex As Exception
        End Try

        'UPDATES THE ORDERS DATATABLE
        With tableOrders
            For i = 0 To .Rows.Count - 1
                Dim sale = sales(.Rows(i).Item("ID"))
                .Rows(i).Item("CLIENTE") = sale.Client.Name
                .Rows(i).Item("ITENS") = Join(sale.ItemList.ToArray, " ")
                .Rows(i).Item("RESP1") = sale.SellingResponsible
                .Rows(i).Item("DATA1") = sale.SellingDate.ToShortDateString
                .Rows(i).Item("RESP2") = sale.RetrievingResponsible
                If sale.RetrievingResponsible = "" Then
                    .Rows(i).Item("DATA2") = ""
                Else
                    .Rows(i).Item("DATA2") = sale.RetrievingDate.ToShortDateString
                End If
                .Rows(i).Item("RECOLHIDO") = sale.Retrieved
                .Rows(i).Item("CHOPEIRA") = sale.IncludesCooler
                .Rows(i).Item("PEDIDO") = Join(sale.ProductList.ToArray, "; ")
                .Rows(i).Item("PREÇOS") = Join(sale.ValueList.ToArray, "; ")
                .Rows(i).Item("TOTAL") = sale.Total
                .Rows(i).Item("OBS") = sale.Observation
                .Rows(i).Item("PAGO") = sale.Paid
            Next
        End With
        WriteCSV(tableOrders, NameOf(tableOrders), "|", True)

        'UPDATES THE PURCHASES DATATABLE
        With tablePurchases
            For j = 0 To .Rows.Count - 1
                Dim purchase = purchases(.Rows(j).Item("ID"))
                .Rows(j).Item("DATA") = purchase.BuyingDate.ToShortDateString
                .Rows(j).Item("COMPRA") = Join(purchase.ProductList.ToArray, "; ")
                .Rows(j).Item("PREÇOS") = Join(purchase.ValueList.ToArray, "; ")
                .Rows(j).Item("TOTAL") = purchase.Total
                .Rows(j).Item("OBS") = purchase.Observation
                .Rows(j).Item("PAGO") = purchase.Paid
            Next
        End With
        WriteCSV(tablePurchases, NameOf(tablePurchases), "|", True)

        'UPDATES EACH PRODUCT DATATABLE
        For Each p In products.Values
            Dim dvi As New DataView(p.Table)
            dvi.Sort = "N ASC"
            Dim dti = dvi.ToTable
            Try
                WriteCSV(dti, p.TableName, "|", True)
            Catch ex As Exception
            End Try
        Next

#Region "OLD"
        'For Each p In products.Values
        'Dim pTable = p.Table
        'pTable.Rows.Clear()

        'For Each e In p.Orders
        '    If p.Purchases.ContainsKey(e.ID) Then
        '        Dim purchase = TryCast(e, Product.Purchase)
        '        pTable.Rows.Add(e.Index,
        '                        purchase.BuyingDate.ToString("yyyy/MM/dd"),
        '                        purchase.ID,
        '                        purchase.Description,
        '                        purchase.Quantity,
        '                        0,
        '                        purchase.Stock,
        '                        purchase.Value,
        '                        0,
        '                        purchase.Balance)
        '    ElseIf p.Sales.ContainsKey(e.ID) Then
        '        Dim sale = TryCast(e, Product.Sale)
        '        pTable.Rows.Add(e.Index,
        '                        sale.SellingDate.ToString("yyyy/MM/dd"),
        '                        sale.ID,
        '                        sale.Description,
        '                        0,
        '                        sale.Quantity,
        '                        sale.Stock,
        '                        0,
        '                        sale.Value,
        '                        sale.Balance)
        '    End If
        'Next
        'Dim dvi As New DataView(pTable)
        'dvi.Sort = "DATA ASC"
        'Dim dti = dvi.ToTable
        'Next
#End Region

        'UPDATES BARRELS TABLE
        With tableBarrels
            For i = 0 To .Rows.Count - 1
                Dim bb = barrels(.Rows(i).Item("BARRIL"))
                .Rows(i).Item("RECOLHIDO") = bb.State.ToString
            Next
        End With
        Try
            WriteCSV(tableBarrels, "tableB", "|", True)
        Catch ex As Exception
        End Try

        'UPDATES COOLERS TABLE  
        With tableCoolers
            For i = 0 To .Rows.Count - 1
                Dim cc = coolers(.Rows(i).Item("CHOPEIRA"))
                .Rows(i).Item("RECOLHIDO") = cc.State.ToString
            Next
        End With
        Try
            WriteCSV(tableCoolers, "tableC", "|", True)
        Catch ex As Exception
        End Try

    End Sub

    ''' <summary>
    ''' Returns the Collection of <see cref="Item"/> objects, those that can either be <see cref="Barrel"/>, <see cref="Cooler"/>, <see cref="Cylinder"/> or <see cref="Valve"/>
    ''' </summary>
    ''' <returns></returns>
    Public Function ItemsCollection() As Dictionary(Of String, Item)
        Dim result As New Dictionary(Of String, Item)
        For Each b In barrels
            result.Add(b.Key, b.Value)
        Next
        For Each c In coolers
            result.Add(c.Key, c.Value)
        Next
        For Each g In cylinders
            result.Add(g.Key, g.Value)
        Next
        For Each v In valves
            result.Add(v.Key, v.Value)
        Next
        Return result
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="firstDay"></param>
    ''' <param name="lastDay"></param>
    ''' <returns></returns>
    Public Function GetBalanceFrom(firstDay As Date, lastDay As Date, Optional values As String = "b") As Double

        Dim result As Double = 0

        For Each p In products.Values
            Dim pTable = products(p.Code).Table
            Dim monthPurchases = p.Purchases.Values.Where(Function(y) y.BuyingDate >= firstDay And y.BuyingDate <= lastDay)
            Dim monthSales = p.Sales.Values.Where(Function(x) x.SellingDate >= firstDay And x.SellingDate <= lastDay)
            Dim monthQttyIn = monthPurchases.Sum(Function(y) y.Quantity)
            Dim monthQttyOut = monthSales.Sum(Function(x) x.Quantity)
            Dim monthMoneyOut = monthPurchases.Sum(Function(y) y.Value * CInt(y.Paid))
            Dim monthMoneyIn = monthSales.Sum(Function(x) x.Value * CInt(x.Paid))

            Select Case values.ToLower
                Case "c"
                    result += monthMoneyOut
                Case "p"
                    result -= monthMoneyIn
                Case Else
                    result -= monthMoneyIn - monthMoneyOut
            End Select

        Next

        Return result

    End Function

    ''' <summary>
    ''' Synchronizes all tables with the remote server, according to the updated list of files (see <see cref="UpdatedSyncList()"/>)
    ''' </summary>
    Public Sub SyncTables()

        Dim synclist = UpdatedSyncList()

        'DOWNLOADS EACH FILE FROM THE LIST OF FILES    
        For Each file In synclist
            If isSyncing Then
                Dim filename As String = file.Split("\").Last
                Try
                    Extensions.SyncFile(file, uploadDataFolder + filename, downloadDataFolder + filename, user, pass)
                Catch ex As Exception
                    currentSync = "Failed to sync " + filename
                End Try
            Else
                currentSync = "Not syncing"
                Exit Sub
            End If
        Next

        currentSync = ""
        MsgBox("Banco de dados atualizado com sucesso!")

    End Sub

    ''' <summary>
    ''' Compares the local list of files to the remote server's list of files, then returns a synchronized list
    ''' </summary>
    ''' <returns></returns>
    Public Function UpdatedSyncList() As List(Of String)

        localList = System.IO.Directory.EnumerateFiles(appDataFolder).ToList

        'SyncTablesFile

        remoteList = ListRemoteFiles(uploadDataFolder, user, pass)

        'JOINS TWO LISTS INTO A HASHSET
        Dim tableSet As New HashSet(Of String)
        For i = 0 To Math.Max(localList.Count, remoteList.Count) - 1
            Try
                tableSet.Add(localList(i))
            Catch ex As Exception
            End Try
            Try
                tableSet.Add(appDataFolder + remoteList(i))
            Catch ex As Exception
            End Try
        Next

        Return tableSet.ToList

    End Function

    Public Sub SyncTablesFile()

        Dim localDates As New List(Of String)
        For Each f In localList
            localDates.Add(System.IO.File.GetLastWriteTime(f))
        Next

        Dim tables As New DataTable
        tables.Columns.Add("NOME")
        tables.Columns.Add("DATA")
        For i = 0 To localList.Count - 1
            tables.Rows.Add(localList(i), localDates(i))
        Next
        WriteCSV(tables, NameOf(tables), "|", True)

        UploadFile(appDataFolder + "tables.csv", uploadDataFolder + "tables.csv", user, pass)

        DownloadFile(downloadDataFolder + "tables.csv", appDataFolder + "tables.csv", user, pass)

    End Sub

End Module
