Public Class cUtente
    Public ID As Integer
    Public USERNAME As String
    Public PASSWORD As String
    Public ATTIVO As Boolean

    Public Function CaricaProfilo(ByVal User As String, Password As String, Optional ByVal flgMD5 As Boolean = True) As Boolean
        On Error GoTo Err
        CaricaProfilo = False
        If (Connessione.State = ConnectionState.Closed) Then Connessione.Open()
        Dim cmd As OdbcCommand = Connessione.CreateCommand
        cmd.CommandType = CommandType.Text
        ' Cripto la password se serve
        If flgMD5 Then Password = MD5(Password)
        cmd.CommandText = "SELECT * FROM Accesso WHERE USERNAME = " & Apici(User) & " AND ATTIVO=TRUE"
        ' Carico il modulo utente
        Dim letto As OdbcDataReader = cmd.ExecuteReader()
        While letto.Read()
            If UCase(letto.Item("PASSWORD")) = UCase(Password) Then
                mUtente = New cUtente
                With mUtente
                    .ID = CInt(letto.Item("ID"))
                    .USERNAME = letto.Item("USERNAME")
                    .PASSWORD = Password
                    .ATTIVO = CBool(letto.Item("ATTIVO"))
                End With
                CaricaProfilo = True
            End If
        End While

        ' Salvo le impostazioni per i prossimi login
        If CaricaProfilo Then SalvaFileIni()

        Return CaricaProfilo
Err:
        CaricaProfilo = False
    End Function

End Class
