﻿Imports System.Runtime.CompilerServices
Imports System.Globalization
Imports System.IO


Public Module Extensions

    <Extension()>
    Public Function IsValidNonZero(ByVal Arg As Double) As Boolean
        Return (Not Double.IsNaN(Arg) AndAlso
                Arg <> 0 AndAlso
                Not Double.IsInfinity(Arg))
    End Function

    Friend Function GetxmlLine(prop As String, value As String) As String
        Return String.Format("<{0}>{1}</{0}>", prop, value)
    End Function

    <Extension()>
    Public Function ErrorsToZero(ByVal arg As Double) As Double
        Return If(Double.IsNaN(arg) OrElse Double.IsInfinity(arg), 0, arg)
    End Function

    ''' <summary>
    ''' Selects from the input strings the one that is in the program's current language
    ''' </summary>
    ''' <param name="pt">Portuguese string</param>
    ''' <param name="en">English string</param>
    ''' <returns></returns>
    Public Function ChooseLang(pt As String, en As String, Optional englishFirst As Boolean = False) As String
        Dim condition = CultureInfo.CurrentCulture.Parent.Equals((New CultureInfo("pt-br")).Parent)
        If englishFirst Then condition = Not condition

        If condition Then
            Return pt
        Else
            Return en
        End If
    End Function

    ''' <summary>
    ''' Changes the number decimal separator to ".", even though if the system's is ","
    ''' </summary>
    Public Sub ChangeSeparator(Optional dec As String = ".")
        On Error Resume Next
        CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = dec
        CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator = dec
        CultureInfo.CurrentCulture.Parent.NumberFormat.NumberDecimalSeparator = dec
        CultureInfo.CurrentUICulture.Parent.NumberFormat.NumberDecimalSeparator = dec
        CultureInfo.DefaultThreadCurrentCulture.NumberFormat.NumberDecimalSeparator = dec
        CultureInfo.DefaultThreadCurrentUICulture.NumberFormat.NumberDecimalSeparator = dec
    End Sub

    ''' <summary>
    ''' Converts a string in a ASCII format to a simpler format, 
    ''' replacing all problematic characters by regular letters
    ''' </summary>
    ''' <param name="arg"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension>
    Public Function toRegular(ByVal arg As String) As String

        arg = arg.Replace("à", "a")
        arg = arg.Replace("á", "a")
        arg = arg.Replace("â", "a")
        arg = arg.Replace("ã", "a")

        arg = arg.Replace("é", "e")
        arg = arg.Replace("ê", "e")

        arg = arg.Replace("í", "i")
        arg = arg.Replace("î", "i")

        arg = arg.Replace("ó", "o")
        arg = arg.Replace("ô", "o")
        arg = arg.Replace("õ", "o")

        arg = arg.Replace("ú", "u")

        arg = arg.Replace("ç", "c")

        Return arg

    End Function

    ''' <summary>
    ''' Converts a coded string format to the UTF-8 format, 
    ''' replacing all problematic characters by special characters
    ''' </summary>
    ''' <param name="arg"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension>
    Public Function toIrregular(ByVal arg As String) As String

        arg = Replace(arg, "\~a", "ã")
        arg = Replace(arg, "\~o", "õ")
        arg = Replace(arg, "\^a", "â")
        arg = Replace(arg, "\^e", "ê")
        arg = Replace(arg, "\^o", "ô")
        arg = Replace(arg, "\^A", "Â")
        arg = Replace(arg, "\^E", "Ê")
        arg = Replace(arg, "\^O", "Ô")
        arg = Replace(arg, "\'a", "á")
        arg = Replace(arg, "\'e", "é")
        arg = Replace(arg, "\'i", "í")
        arg = Replace(arg, "\'o", "ó")
        arg = Replace(arg, "\'u", "ú")
        arg = Replace(arg, "\'A", "Á")
        arg = Replace(arg, "\'E", "É")
        arg = Replace(arg, "\'I", "Í")
        arg = Replace(arg, "\'O", "Ó")
        arg = Replace(arg, "\'U", "Ú")
        arg = Replace(arg, "\c c", "ç")
        arg = Replace(arg, "\C C", "Ç")
        arg = Replace(arg, "�", "ç")

        Return arg

    End Function

    ''' <summary>
    ''' Unit conversion dictionary. Uses the following equation:    
    ''' <para></para>
    ''' Y = A + B.X,  where:            
    ''' <para></para>
    ''' Y = SI value 
    ''' <para></para>
    ''' X = Unit value    
    ''' <para></para>
    ''' Ex.: Converting 60 degrees celsius (°C) to Kelvin (K) 
    ''' <para></para>
    ''' Y = 273.15 + 1 * 60.0      
    ''' <para></para>
    ''' Y = 333.15 K
    ''' 
    ''' </summary>
    Public Units As New Dictionary(Of String, Double()) From {
        {"%", {0, 0.01}},
        {"(%)", {0, 1}},
        {"#", {0, 1}},
        {"°", {0, 0.017453293}},
        {"°C", {273.15, 1}},
        {"dez", {0, 10}},
        {"g/L", {0, 1000000}},
        {"kg/L", {0, 1000}},
        {"h", {0, 3600}},
        {"min", {0, 60}},
        {"L", {0, 1000}},
        {"L/m³", {0, 0.001}},
        {"L/s", {0, 0.001}},
        {"m³/h", {0, 0.000277778}},
        {"m³/ton", {0, 1000}},
        {"km", {0, 1000}},
        {"cm", {0, 0.01}},
        {"mm", {0, 0.001}},
        {"in", {0, 0.0254}},
        {"μm", {0, 0.000001}},
        {"cm²", {0, 0.0001}},
        {"mm²", {0, 0.000001}},
        {"μm²", {0, 0.000000000001}},
        {"rev/h", {0, 0.001745329}},
        {"rev/s", {0, 6.283185307}},
        {"ton/h", {0, 0.277777778}},
        {"bar", {0, 100000}},
        {"atm", {0, 101325}},
        {"mmH2O", {101325, 9.80664857}},
        {"mmHg", {101325, 133.3223684}},
        {"cm/s", {0, 0.01}},
        {"mm/s", {0, 0.001}},
        {"m/h", {0, 0.000277778}},
        {"cm²/s", {0, 0.0001}},
        {"mm²/s", {0, 0.000001}}
    }

    ''' <summary>
    ''' Dictionary containing all SI units and their corresponding MLT values
    ''' </summary>
    Public ToDimension As New Dictionary(Of String, String) From {
        {"m", "_L"},
        {"m²", "_L2"},
        {"m³", "_L3"},
        {"kg", "_M"},
        {"s", "_T"},
        {"Hz", "_1.T"},
        {"kg/kg", "_M.M"},
        {"%", "_M.M"},
        {"kg/s", "_M.T"},
        {"m/s", "_L.T"},
        {"m²/s", "_L2.T"},
        {"m³/s", "_L3.T"},
        {"m³/kg", "_L3.M"},
        {"kg/m³", "_M.L3"},
        {"Pa", "_M.LT2"},
        {"Pa· s", "_M.LT"},
        {"Pa·s", "_M.LT"},
        {"Pa. s", "_M.LT"},
        {"Pa.s", "_M.LT"},
        {"#", "_num"},
        {"(%)", "_num"},
        {"-", "-"},
        {"", "-"},
        {"K", "_theta"},
        {"rad", "_alpha"},
        {"rad/s", "_alpha.T"}
    }

    ''' <summary>
    ''' Reads a CSV file and loads its content into a <see cref="DataTable"/> object
    ''' </summary>
    ''' <param name="fileName"></param>
    ''' <param name="hasTitles"></param>
    ''' <param name="delimiter"></param>
    ''' <returns></returns>
    Public Function DataTableFromCSV(fileName As String,
                                     hasTitles As Boolean,
                                     Optional delimiter As String = ",") As DataTable
        Dim result As New DataTable
        Dim currentRow As IEnumerable(Of String)
        Dim fixedRow As New List(Of String)
        Using reader = New Microsoft.VisualBasic.FileIO.TextFieldParser(fileName) With
                {.Delimiters = {delimiter},
                 .TextFieldType = FileIO.FieldType.Delimited,
                 .TrimWhiteSpace = True}

            If hasTitles Then
                currentRow = reader.ReadFields
                For Each c In currentRow
                    result.Columns.Add(c.toIrregular.ToUpper)
                Next
            End If

            While Not reader.EndOfData
                currentRow = reader.ReadFields
                While currentRow.Count > result.Columns.Count
                    result.Columns.Add()
                End While
                fixedRow.Clear()
                For Each c In currentRow
                    c = c.toIrregular
                    fixedRow.Add(c)
                Next
                result.Rows.Add(fixedRow.ToArray)
            End While

        End Using

        Return result

    End Function

    ''' <summary>
    ''' Adds a row of data to the <see cref="DataTable"/>
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="dataList"></param>
    Public Sub AddToDataTable(table As DataTable,
                              dataList As List(Of String))
        On Error Resume Next

        Dim dr As DataRow = table.NewRow()

        For i = 0 To dataList.Count() - 1
            dr(i) = dataList(i)
        Next
        With table
            .NewRow()
            .Rows.Add(dr)
        End With

    End Sub

    ''' <summary>
    ''' Inserts the values on the header for the CSV file
    ''' </summary>
    ''' <param name="table"></param>
    Public Sub AddHeaders(table As DataTable, Optional hasHeaders As Boolean = False)

        If Not hasHeaders Then Exit Sub
        If table.Columns.Count > 0 Then Exit Sub

        Dim header As New List(Of String)
        With header
            .Add("ID")
            .Add("FAT")
            .Add("RET")
            .Add("MISC")
            .Add("Sout")
            .Add("Lout")
            .Add("T")
            .Add("Slvl")
            .Add("Eff")
            .Add("yi")
            .Add("EVAP")
        End With

        Dim dr As DataRow = table.NewRow()
        For Each item In header
            table.Columns.Add(item)
            dr(item) = item
        Next
        table.NewRow()
        table.Rows.Add(dr)

    End Sub

    ''' <summary>
    ''' Writes a DataTable as a CSV file
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="tableName"></param>
    Sub WriteCSV(table As DataTable, tableName As String, Optional delimiter As String = ",", Optional includeHeaders As Boolean = False)

        Dim path As String = appDataFolder & tableName
        'today = DateTime.Now.ToString("yyyy'.'MM'.'dd'-'HH'h'mm'min'")
        'path &= "\" & Today

        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If

        Dim newTable As DataTable
        newTable = table.Copy
        AddHeaders(newTable, includeHeaders)

        Using writer As StreamWriter = New StreamWriter(path & ".csv")
            For Each row As DataRow In newTable.Rows
                writer.WriteLine(String.Join(delimiter, row.ItemArray))
            Next

            writer.Flush()
        End Using

    End Sub

    <Extension()>
    Public Iterator Function AsEnumerable(rows As DataRowCollection) As IEnumerable(Of DataRow)
        For Each row As DataRow In rows
            Yield row
        Next
    End Function

    ''' <summary>
    ''' Retrieves the Public IP Adress using the Ipify API 
    ''' </summary>
    Public Function IPify() As String
        Dim PublicIP As String = ""
        Dim wc As New Net.WebClient
        AddHandler wc.DownloadStringCompleted, New Net.DownloadStringCompletedEventHandler(Sub(wcsender, wce)
                                                                                               PublicIP = wce.Result
                                                                                           End Sub)
        wc.DownloadStringAsync(New Uri("https://api.ipify.org/"))
        Return PublicIP
    End Function

    ''' <summary>
    ''' Gets user's IP address
    ''' </summary>
    ''' <returns></returns>
    Private Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)
        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                Return ipheal.ToString()
            End If
        Next
    End Function

    ''' <summary>
    ''' Gets user's MAC address
    ''' </summary>
    ''' <returns></returns>
    Function GetMyMacAddress() As String
        Dim nics = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function

End Module
