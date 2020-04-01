Imports StockLib.Extensions


''' <summary>
''' Main Module, where the program events are located
''' </summary>
Public Module Main

    Public companyName As String = "L'jaica"
    Public appDataFolder As String
    Public downloadDataFolder As String
    Public uploadDataFolder As String
    Private user As String = "pires11d"
    Private pass As String = "calculera"
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
    Public productTables As New Dictionary(Of Product, DataTable)
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

        tableVendors = ReadCSV(appDataFolder + "tableVendor.csv", "|")
        LoadVendors()

        tableClients = ReadCSV(appDataFolder + "tableClients.csv", "|")
        LoadClients()

        tableOwners = ReadCSV(appDataFolder + "tableResp.csv", "|")
        LoadOwners()

        tableBarrels = ReadCSV(appDataFolder + "tableB.csv", "|")
        tableCoolers = ReadCSV(appDataFolder + "tableC.csv", "|")
        'tableCylinders = ReadCSV(appDataFolder + "tableG.csv", "|")
        'tableValves = ReadCSV(appDataFolder + "tableV.csv", "|")
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
                b.Kind = Item.Kinds.Barril
                b.Type = .Rows(i).Item("TIPO")
                b.State = .Rows(i).Item("RECOLHIDO")
                barrels.Add(b.ID, b)
            Next
        End With

        coolers.Clear()
        With tableCoolers
            For i = 0 To .Rows.Count - 1
                Dim c As New Cooler(.Rows(i).Item("CHOPEIRA"))
                c.Kind = Item.Kinds.Chopeira
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
                p.Cost = .Rows(i).Item("CUSTO")
                p.Price = .Rows(i).Item("PREÇO")
                p.Price2 = .Rows(i).Item("PREÇO2")
                products.Add(p.Code, p)
            Next i
        End With

    End Sub

    ''' <summary>   
    ''' Loads every product's history information into a dictionary of <see cref="Product"/> and <see cref="DataTable"/> objects
    ''' </summary>
    Public Sub LoadProductTables()

        'ADDS ALL PRODUCT TABLES TO A LIST
        productTables.Clear()

        For Each p In products.Values
            Try
                Dim table As New DataTable
                Try
                    table = ReadCSV(appDataFolder + p.TableName + ".csv", "|", True, True)
                Catch exx As Exception
                    table = ReadCSV(appDataFolder + p.TableName + ".csv", "|", True, False)
                End Try
                productTables.Add(p, table)
            Catch ex As Exception

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
                        'purchase.Stock = .Rows(i).Item("SALDO")
                        purchase.Value = .Rows(i).Item("ENTRADA ($)")
                        'purchase.Balance = .Rows(i).Item("BALANÇO")
                        purchase.Parent = p

                        p.Purchases.Add(purchase.ID, purchase)
                        p.Orders.Add(purchase)

                    ElseIf CDbl(.Rows(i).Item("SAÍDA").ToString.ToZero) > 0 Then

                        Dim sale As New Product.Sale(.Rows(i).Item("ID"))
                        sale.SellingDate = DateValue(.Rows(i).Item("DATA"))
                        sale.Description = .Rows(i).Item("HISTÓRICO")
                        sale.Quantity = .Rows(i).Item("SAÍDA")
                        'sale.Stock = .Rows(i).Item("SALDO")
                        sale.Value = .Rows(i).Item("SAÍDA ($)")
                        'sale.Balance = .Rows(i).Item("BALANÇO")
                        sale.Parent = p

                        p.Sales.Add(sale.ID, sale)
                        p.Orders.Add(sale)

                    End If
                Next
            End With
        Next

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
                s.SellingDate = DateValue(.Rows(i).Item("DATA1").ToString.ToDateNotNull)
                s.RetrievingDate = DateValue(.Rows(i).Item("DATA2").ToString.ToDateNotNull)
                s.SellingResponsible = .Rows(i).Item("RESP1")
                s.RetrievingResponsible = .Rows(i).Item("RESP2")
                s.Retrieved = .Rows(i).Item("RECOLHIDO")
                s.Products.Clear()
                Dim productList = Split(.Rows(i).Item("PEDIDO"), ";").ToList
                Dim priceList = Split(.Rows(i).Item("PREÇOS"), ";").ToList
                For Each product In productList.Except({""})
                    Dim code As String = Split(product, " x ").Last
                    Dim qtty As Double = CDbl(Split(product, " x ").First)
                    Dim pp = New Product(code)
                    With pp
                        pp.Brand = products(code).Brand
                        pp.Value = CDbl(priceList(productList.IndexOf(product)).Replace("$ ", ""))
                        pp.Quantity = qtty
                    End With
                    s.Products.Add(pp.Code, pp)
                Next
                Dim items = Split(.Rows(i).Item("ITENS"), " ").ToList.Except({""})
                If items.Count > 0 Then
                    For Each item In items
                        If barrels.ContainsKey(item) Then
                            s.Barrels.Add(item, barrels(item))
                            barrels(item).Orders.Add(s)
                        End If
                        If coolers.ContainsKey(item) Then
                            s.Coolers.Add(item, coolers(item))
                            coolers(item).Orders.Add(s)
                        End If
                    Next
                End If
                s.Observation = .Rows(i).Item("OBS")
                s.Client = clients(.Rows(i).Item("CLIENTE"))
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
                p.Products.Clear()
                Dim productList = Split(.Rows(i).Item("COMPRA"), ";").ToList
                Dim proceList = Split(.Rows(i).Item("PREÇOS"), ";").ToList
                For Each product In productList.Except({""})
                    Dim code As String = Split(product, " x ").Last
                    Dim qtty As Double = CDbl(Split(product, " x ").First)
                    Dim pp = New Product(code)
                    With pp
                        pp.Brand = products(code).Brand
                        pp.Value = CDbl(proceList(productList.IndexOf(product)).Replace("$ ", ""))
                        pp.Quantity = qtty
                    End With

                    p.Products.Add(pp.Code, pp)
                Next
                p.Observation = .Rows(i).Item("OBS")
                purchases.Add(p.ID, p)

                vendors(p.Vendor.Name).Purchases.Add(p)
            Next
        End With

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

        'UPDATES THE PRODUCTS TABLE (STOCK)
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
                .Rows(i).Item("PEDIDO") = Join(sale.OrderList.ToArray, "; ")
                .Rows(i).Item("PREÇOS") = Join(sale.PriceList.ToArray, "; ")
                .Rows(i).Item("TOTAL") = sale.Total
                .Rows(i).Item("OBS") = sale.Observation
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

            For Each e In pTable.Key.Orders
                If pTable.Key.Purchases.ContainsKey(e.ID) Then
                    Dim purchase = TryCast(e, Product.Purchase)
                    pTable.Value.Rows.Add(purchase.Index,
                                          purchase.BuyingDate.ToString("yyyy/MM/dd"),
                                          purchase.ID,
                                          purchase.Description,
                                          purchase.Quantity,
                                          0,
                                          purchase.Stock,
                                          purchase.Value,
                                          0,
                                          purchase.Balance)
                ElseIf pTable.Key.Sales.ContainsKey(e.ID) Then
                    Dim sale = TryCast(e, Product.Sale)
                    pTable.Value.Rows.Add(sale.Index,
                                  sale.SellingDate.ToString("yyyy/MM/dd"),
                                  sale.ID,
                                  sale.Description,
                                  0,
                                  sale.Quantity,
                                  sale.Stock,
                                  0,
                                  sale.Value,
                                  sale.Balance)
                End If
            Next
            Dim dvi As New DataView(pTable.Value)
            dvi.Sort = "N ASC"
            Dim dti = dvi.ToTable
            Try
                WriteCSV(dti, pTable.Key.TableName, "|", True)
            Catch ex As Exception
            End Try

        Next

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
