Imports Clienti.mFunzioni
Imports ADOX

Module mDB
    Public Const kDirectoryDatabaseAccess = "C:\\Database\\"
    Public Const kDatabaseAccess = kDirectoryDatabaseAccess & "Clienti.accdb"

    Public Const kTipoDatabase As EnumDatabases = EnumDatabases.MySql

    ' Connessione tramite ODBC
    Public Const kstrConn = "dsn=ODBCDBCLIENTI;uid=root;pwd=;"
    ' Connessione senza ODBC
    'Public Const kstrConn = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=" & kDatabaseFile & ";"

    Public Connessione As New OdbcConnection(kstrConn)

    Public Sub CheckConnessione()
        Try
            CheckDirectories()
            If Connessione.State <> ConnectionState.Open Then Connessione.Open()
        Catch ex As Exception
            MsgBox("Impossibile stabilire una connessione, il programma verrà arrestato.", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxSetForeground, "DataBase non trovato")
            ChiusuraForzata = True
            End
        End Try
    End Sub

    Private Sub CheckDatabase(ByVal DatabasePath As String) ' Inutilizzata
        If Not (IO.File.Exists(DatabasePath)) Then
            ' Creo il DataBase vuoto
            Dim cat As Catalog = New Catalog()
            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & kDatabaseAccess & ";Jet OLEDB:Engine Type=5")
            cat = Nothing
        End If
    End Sub

    Public Function QueryNumerico(ByVal SQL As String) As Integer
        On Error GoTo Err
        If (Connessione.State = ConnectionState.Closed) Then Connessione.Open()
        Dim cmd As OdbcCommand = Connessione.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = SQL

        QueryNumerico = cmd.ExecuteNonQuery
        Exit Function
Err:
        MsgBox("Errore funzione 'QueryAggiungi'", MsgBoxStyle.Critical)
    End Function

    Public Function QueryLeggi(ByVal QSELECT As String, ByVal QFROM As String, Optional ByVal QINNER As String = vbNullString, Optional ByVal QWHERE As String = vbNullString) As OdbcDataReader
        On Error GoTo Err
        QueryLeggi = Nothing
        If (Connessione.State = ConnectionState.Closed) Then Connessione.Open()
        Dim cmd As OdbcCommand = Connessione.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = QSELECT & " " & QFROM
        If Len(QINNER) > 0 Then
            cmd.CommandText = cmd.CommandText & " " & QINNER
        End If
        If Len(QWHERE) > 0 Then
            cmd.CommandText = cmd.CommandText & " " & QWHERE
        End If
        QueryLeggi = cmd.ExecuteReader
        Exit Function
Err:
        QueryLeggi = Nothing
Ext:
        MsgBox("Errore funzione 'QueryLeggi'", MsgBoxStyle.Critical)
    End Function

    Public Function GeneraSQL(ByVal Tabella As String, ByVal vCampi() As String, ByVal Where As String) As String
        On Error GoTo Err
        GeneraSQL = Nothing

        For Each Campo As String In vCampi
            If GeneraSQL Is Nothing Then GeneraSQL = "SELECT " & Campo
            GeneraSQL = GeneraSQL & ", " & Campo
        Next

        GeneraSQL = GeneraSQL & " FROM " & Tabella & " WHERE " & Where
        Exit Function
Err:
        MsgBox("Errore funzione 'GeneraSQL'", MsgBoxStyle.Critical)
    End Function

    Public Function DataADatabase(ByVal data As String) As String
        DataADatabase = vbNullString
        If IsDate(data) Then
            Select Case kTipoDatabase
                Case EnumDatabases.Access
                    DataAccess(data)
                Case EnumDatabases.MySql
                    DataMysql(data)
            End Select
        End If
        DataADatabase = data
    End Function

    Private Sub DataAccess(ByRef data As String)
        data = "#" & data & "#"
    End Sub

    Private Sub DataMysql(ByRef data As String)
        Dim dt As Date = data
        data = Apici(dt.Year & "/" & dt.Month & "/" & dt.Day & " " & dt.Hour & ":" & dt.Minute & ":" & dt.Second)
    End Sub

    Public Function ContaSQL(ByVal Tabella As String, Optional ByVal Where As String = vbNullString) As Integer
        On Error GoTo Err
        If (Connessione.State = ConnectionState.Closed) Then Connessione.Open()
        Dim cmd As OdbcCommand = Connessione.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT COUNT(*) FROM " & Tabella
        If (Where <> vbNullString) Then cmd.CommandText &= " WHERE " & Where
        ContaSQL = cmd.ExecuteScalar
        Exit Function
Err:
        ContaSQL = 0
        'MsgBox("Errore funzione 'ContaSQL'", MsgBoxStyle.Critical)
    End Function

    Public Function EseguiSQL(ByVal SQL As String) As OdbcDataReader
        On Error GoTo Err
        If (Connessione.State = ConnectionState.Closed) Then Connessione.Open()
        Dim cmd As OdbcCommand = Connessione.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = SQL

        EseguiSQL = cmd.ExecuteReader
        Exit Function
Err:
        MsgBox("Errore funzione 'EseguiSQL'", MsgBoxStyle.Critical)
    End Function

    Public Function Controlla(ByVal Campo As String, ByVal Tabella As String, Optional ByVal Where As String = vbNullString) As String
        On Error GoTo Err
        Controlla = vbNullString
        If (Connessione.State = ConnectionState.Closed) Then Connessione.Open()
        Dim cmd As OdbcCommand = Connessione.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT DISTINCT " & Campo & " FROM " & Tabella
        If Len(Where) > 0 Then
            cmd.CommandText = cmd.CommandText & " WHERE " & Where
        End If
        Controlla = cmd.ExecuteScalar
        If Controlla Is Nothing Then
            GoTo Err
        Else
            GoTo Ext
        End If
Err:
        Controlla = "# Non Trovato! #"
Ext:
    End Function

End Module
