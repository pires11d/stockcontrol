Imports System.Runtime.CompilerServices
Imports System.Globalization
Imports System.Drawing
Imports System.Net
Imports System.IO


''' <summary>
''' Module designed to contain all necessary tools for either file, text, number or language handling operations
''' </summary>
Public Module Extensions


    Private msgQuestion = ChooseLang("Você deseja fazer o download da versão atualizada?",
                         "Do you wish to download the latest version?")
    Private msgError = ChooseLang("Arquivo não encontrado. Por favor verifique sua conexão com a internet.",
                          "File not found. Please check your internet connection.")

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

    <Extension()>
    Public Function NotNull(ByVal arg As String) As String
        Return If(IsNothing(arg), "", arg)
    End Function

    <Extension()>
    Public Function ToZero(ByVal arg As String) As String
        Return If(IsNothing(arg) OrElse arg = "", 0, arg)
    End Function

    <Extension()>
    Public Function ToDateNotNull(ByVal arg As String) As String
        If IsNothing(arg) OrElse arg = "" Then arg = Date.Today.ToString
        If arg = Date.MinValue Then arg = Date.Today.ToString
        Return arg
    End Function

    <Extension()>
    Public Function ToBoolNotNull(ByVal arg As String) As Boolean
        If IsNothing(arg) OrElse arg = "" Then arg = False
        arg = CBool(arg)
        Return arg
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
    ''' Returns a color representing a value of 
    ''' </summary>
    ''' <param name="bool"></param>
    ''' <returns></returns>
    Public Function ColorFromBoolean(bool As Boolean) As Color

        If bool Then
            Return Color.Green
        Else
            Return Color.Red
        End If

    End Function

    ''' <summary>
    ''' Returns a color representing a value of 
    ''' </summary>
    ''' <param name="bool"></param>
    ''' <returns></returns>
    Public Function StringFromBoolean(bool As Boolean) As String

        If bool Then
            Return "SIM"
        Else
            Return "NÃO"
        End If

    End Function

    ''' <summary>
    ''' Converts a string in a ASCII format to a simpler format, 
    ''' replacing all problematic characters by regular letters
    ''' </summary>
    ''' <param name="arg"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension>
    Public Function ToRegular(ByVal arg As String) As String

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
    Public Function ToIrregular(ByVal arg As String) As String

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
    ''' Function that joins words into a text, separated by a delimiter (ex.: ","), but only if the words aren't null
    ''' </summary>
    ''' <returns></returns>
    Public Function JoinText(words As String(), Optional delimiter As String = ",")
        Dim text As String = ""
        Dim i = 1
        For Each word In words
            If IsNothing(word) Or
                word = "" Or
                word = " " Or
                word = "-" Then
                text += word
            Else
                If i = words.Count Then
                    text += word
                Else
                    text += word + delimiter + " "
                End If
            End If
            i += 1
        Next
        Return text
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
    ''' Returns the chosen integer value as a n-digit string, given an integer input for the number of digits
    ''' </summary>
    ''' <returns></returns>
    ''' <param name="number"></param>
    ''' <param name="digits"></param>
    Public Function Numberfy(number As Integer, Optional digits As Integer = 2) As String
        Dim strNumber = CStr(number)

        If digits <= 1 Then Return strNumber

        For i = 1 To digits
            If Len(strNumber) < i Then
                strNumber = "0" + strNumber
            End If
        Next

        Return strNumber

    End Function

    ''' <summary>
    ''' Returns a price-formatted value as string, given the value typed in the current <paramref name="control"/>
    ''' </summary>
    ''' <param name="control"></param>
    Public Sub Stringify(control As Object)
        Try
            Dim value = CDbl(control.Text)
            control.Text = value.ToString("0.00")
            If value > 0 Then
                Dim i = Len(CStr(CInt(value)))
                control.Select(i, 0)
            End If
        Catch ex As Exception
            'Dim oldValue = control.Text.ToString
            'Dim value = oldValue.Replace("..", ".")
            'control.text = value
            'Dim i = Len(CStr(CInt(value)))
            'control.Select(i + 1, 0)
        End Try
    End Sub

    ''' <summary>
    ''' Reads a CSV file and loads its content into a <see cref="DataTable"/> object
    ''' </summary>
    ''' <param name="fileName"></param>
    ''' <param name="delimiter"></param>
    ''' <param name="hasTitles"></param>
    ''' <param name="addIdColumn"></param>
    ''' <returns></returns>
    Public Function ReadCSV(fileName As String,
                            Optional delimiter As String = ",",
                            Optional hasTitles As Boolean = True,
                            Optional addIdColumn As Boolean = False) As DataTable

        Dim result As New DataTable
        Dim currentRow As IEnumerable(Of String)
        Dim fixedRow As New List(Of String)
        Using reader = New Microsoft.VisualBasic.FileIO.TextFieldParser(fileName) With
                {.Delimiters = {delimiter},
                 .TextFieldType = FileIO.FieldType.Delimited,
                 .TrimWhiteSpace = True}

            If hasTitles Then
                currentRow = reader.ReadFields
                If addIdColumn Then
                    result.Columns.Add("N")
                End If
                For Each c In currentRow
                    result.Columns.Add(c.ToIrregular.ToUpper)
                Next
            End If

            Dim counter = 1
            While Not reader.EndOfData
                currentRow = reader.ReadFields

                'If currentRow.Count = 1 Then
                '    Continue While
                'End If

                While currentRow.Count > result.Columns.Count
                    result.Columns.Add()
                End While
                fixedRow.Clear()
                If addIdColumn Then
                    fixedRow.Add(counter)
                End If
                For Each c In currentRow
                    c = c.ToIrregular
                    fixedRow.Add(c.NotNull)
                Next
                result.Rows.Add(fixedRow.ToArray)
                counter += 1
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
    Public Sub AddHeader(table As DataTable, header As List(Of String))

        If table.Columns.Count > 0 Then Exit Sub

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

        Dim filePath = appDataFolder + tableName + ".csv"

        Dim headerRow As New List(Of String)
        For Each col In table.Columns
            headerRow.Add(col.ToString)
        Next

        Using writer As StreamWriter = New StreamWriter(filePath)
            If includeHeaders Then
                writer.WriteLine(String.Join(delimiter, headerRow))
            End If
            For Each row As DataRow In table.Rows
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

    ''' <summary>
    ''' Downloads file from the chosen URL to the chosen local path
    ''' </summary>
    ''' <param name="remotePath"></param>
    ''' <param name="localPath"></param>
    ''' <param name="user"></param>
    ''' <param name="pass"></param>
    Public Sub DownloadFile(remotePath As String, localPath As String,
                            Optional user As String = "", Optional pass As String = "")

        user = ""
        pass = ""

        'GETS FILE CREATION DATE
        Dim localDate As DateTime = File.GetLastWriteTime(localPath)

        'CREATES URI
        Dim uri = New Uri(remotePath)

        'CREATES REQUEST TO THE URL USING VALID CREDENTIALS
        Dim myRequest As HttpWebRequest = WebRequest.Create(uri)
        myRequest.Credentials = New NetworkCredential(user, pass)

        'GETS RESPONSE FROM THE REQUEST AND CHECKS ITS STATUS
        Dim myResponse As HttpWebResponse = myRequest.GetResponse()
        If myResponse.StatusCode = System.Net.HttpStatusCode.OK Then

            'CHECKS IF WEBSITE'S VERSION IS NEWER
            If localDate < myResponse.LastModified Then
                'File.Delete(localPath)
                'My.Computer.Network.DownloadFile(uri, localPath, user, pass)
                My.Computer.Network.DownloadFile(uri, localPath, myRequest.Credentials, True, 100, True)
            End If

        End If

        'CLOSES WEB RESPONSE
        myResponse.Close()

    End Sub

    ''' <summary>
    ''' Uploads a desired local file into a server, specified by its URL
    ''' </summary>
    ''' <param name="localPath"></param>
    ''' <param name="remotePath"></param>
    ''' <param name="user"></param>
    ''' <param name="pass"></param>
    Public Sub UploadFile(localPath As String, remotePath As String,
                           Optional user As String = "", Optional pass As String = "")

        'CHECKS IF FILE EXISTS IN LOCAL FOLDER
        If Not File.Exists(localPath) Then
            Exit Sub
        End If

        'CREATES UPLOAD REQUEST   
        Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(remotePath), FtpWebRequest)
        ftpRequest.Method = WebRequestMethods.Ftp.UploadFile
        ftpRequest.Credentials = New NetworkCredential(user, pass)

        'GETS FILE CONTENT AS BYTES
        Dim bytes() As Byte = System.IO.File.ReadAllBytes(localPath)
        ftpRequest.ContentLength = bytes.Length

        'CHECKS IF WEBSITE'S VERSION IS NEWER
        Dim UploadStream As Stream = ftpRequest.GetRequestStream
        UploadStream.Write(bytes, 0, bytes.Length)
        UploadStream.Close()

    End Sub

    ''' <summary>
    ''' Synchronizes the desired local file with a remote server
    ''' </summary>
    ''' <param name="localPath"></param>
    ''' <param name="uploadPath"></param>
    ''' <param name="downloadPath"></param>
    ''' <param name="user"></param>
    ''' <param name="pass"></param>
    Public Sub SyncFile(localPath As String, uploadPath As String, downloadPath As String,
                        Optional user As String = "", Optional pass As String = "")

        'CHECKS IF FILE EXISTS IN LOCAL FOLDER
        If Not File.Exists(localPath) Then
            DownloadFile(downloadPath, localPath, user, pass)
            Exit Sub
        End If

        'CREATES URI
        Dim uri = New Uri(downloadPath)

        'CREATES DOWNLOAD REQUEST   
        Dim myRequest As HttpWebRequest = WebRequest.Create(uri)
        myRequest.Credentials = New NetworkCredential("", "")
        Dim myResponse As HttpWebResponse = myRequest.GetResponse()

        'GETS FILE CREATION DATES
        Dim localDate As DateTime = File.GetLastWriteTime(localPath)
        Dim remoteDate As DateTime = myResponse.LastModified

        myResponse.Close()

        If localDate > remoteDate Then
            'currentSync = "Uploading " + localPath.Split("\").Last
            UploadFile(localPath, uploadPath, user, pass)
        Else
            'currentSync = "Downloading " + downloadPath.Split("/").Last
            DownloadFile(downloadPath, localPath, user, pass)
        End If

    End Sub

    ''' <summary>
    ''' Function that returns the list of files inside a remote directory, given its URL and user credentials
    ''' </summary>
    ''' <param name="remoteDir"></param>
    ''' <param name="user"></param>
    ''' <param name="pass"></param>
    ''' <returns></returns>
    Public Function ListRemoteFiles(remoteDir As String,
                                    Optional user As String = "", Optional pass As String = "") As List(Of String)

        Dim result As New List(Of String)
        Dim strReader As StreamReader = Nothing
        Dim sline As String = ""
        Dim ftpRequest As FtpWebRequest = Nothing
        Dim ftpResponse As FtpWebResponse = Nothing

        ftpRequest = CType(WebRequest.Create(remoteDir), FtpWebRequest)
        ftpRequest.Credentials = New NetworkCredential(user, pass)
        ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory
        ftpResponse = CType(ftpRequest.GetResponse, FtpWebResponse)

        strReader = New StreamReader(ftpResponse.GetResponseStream)

        If strReader IsNot Nothing Then sline = strReader.ReadLine

        While sline IsNot Nothing
            result.Add(sline)
            sline = strReader.ReadLine
        End While

        If ftpResponse IsNot Nothing Then
            ftpResponse.Close()
            ftpResponse = Nothing
        End If

        If strReader IsNot Nothing Then
            strReader.Close()
            strReader = Nothing
        End If

        Return result.Except({".", ".."}).ToList

    End Function

    ''' <summary>
    ''' Function that searches for a filename recursively inside a folder and its subfolders, returning its filepath, if found
    ''' </summary>
    ''' <param name="rootFolder"></param>
    ''' <param name="filename"></param>
    ''' <returns></returns>
    Public Function FindFile(rootFolder As String, filename As String) As String

        Dim files = IO.Directory.GetFileSystemEntries(rootFolder)
        For Each file In files
            If file.EndsWith("java.exe") Then
                Return file
            End If
        Next

        Try
            Dim folders = IO.Directory.GetDirectories(rootFolder)
            For Each folder In folders
                FindFile(folder, filename)
            Next
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Module
