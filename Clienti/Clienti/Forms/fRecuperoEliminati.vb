Public Class fRecuperoEliminati

    Private _SceDati As EnumSceDati

    Public Property SceDati As EnumSceDati
        Get
            Return _SceDati
        End Get
        Set(value As EnumSceDati)
            _SceDati = value

            Select Case _SceDati
                Case EnumSceDati.SceOK
                    SceDatiOK()
                Case EnumSceDati.SceAnn
                    AggiornaTabelle()
                Case Else
            End Select
        End Set
    End Property

    Private Sub fRecuperoEliminati_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter
        AbilitaMainMenuSotto({EnumMainMenuSotto.OK, EnumMainMenuSotto.Annulla})
        AbilitaMenuModifica(False)
        AggiornaTabelle()
    End Sub

    Private Sub fRecuperoEliminati_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AbilitaMainMenuSotto({EnumMainMenuSotto.OK, EnumMainMenuSotto.Annulla})
    End Sub

    Public Sub AggiornaTabelle()
        CaricaOrdini()
        CaricaVisite()
        CaricaTelefonate()
        CaricaPreventivi()
    End Sub

    Private Sub fRecuperoEliminati_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
        AbilitaMenuModifica(False)
    End Sub

    Private Sub dgvPreventivi_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPreventivi.CellClick
        On Error GoTo Err
        Select Case e.ColumnIndex
            Case 5  ' è la colonna del pulsante APRI FILE
                Process.Start(dgvPreventivi.Rows(e.RowIndex).Cells("PERCORSOPDFPREVENTIVO").Value)

            Case 6  ' è la colonna del pulsante SALVA FILE
                If Not System.IO.File.Exists(dgvPreventivi.SelectedRows(0).Cells("PERCORSOPDFPREVENTIVO").Value) Then Throw New Exception
                Dim ext As String = System.IO.Path.GetExtension(dgvPreventivi.SelectedRows(0).Cells("PERCORSOPDFPREVENTIVO").Value)
                With SaveFileDialog1
                    .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
                    .Filter = "Preventivo|*" & ext
                    .FilterIndex = 1
                    .FileName = "Preventivo"
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Copia(dgvPreventivi.SelectedRows(0).Cells("PERCORSOPDFPREVENTIVO").Value, .FileName)
                    End If

                End With

            Case Else
        End Select
        Exit Sub
Err:
        MsgBox("Errore, probabilmente il file non esiste più.", MsgBoxStyle.Critical, "Errore")
    End Sub


    Private Sub CaricaPreventivi()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella preventivi...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT 0 AS PCHK, IDPREVENTIVO, DTPREVENTIVO, PERCORSOPDFPREVENTIVO, NOTEPREVENTIVO", " FROM Preventivi ", "INNER JOIN Clienti ON Clienti.CODICECLIENTE=Preventivi.CODICECLIENTE", " WHERE Preventivi.BOOELIMINATO=TRUE")
        RiempiColonneDaDB(dgvPreventivi, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaTelefonate()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella telefoni...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT 0 AS TCHK, IDTELEFONATA, DTTELEFONATA, Telefonate.CAUSALETELEFONATA, D.DESC_TELEFONATA, NOTETELEFONATA", " FROM Telefonate ", " INNER JOIN CausaleTelefonateDescrizione AS D ON Telefonate.CAUSALETELEFONATA = D.CAUSALETELEFONATA INNER JOIN Clienti ON Clienti.CODICECLIENTE=Telefonate.CODICECLIENTE", " WHERE Telefonate.BOOELIMINATO=TRUE")
        RiempiColonneDaDB(dgvTelefonate, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaOrdini()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella ordini...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT 0 AS OCHK, IDORDINE, DTORDINE, Ordini.CAUSALEORDINE, D.DESC_ORDINE, NOTEORDINE, RAGIONESOCIALECLIENTE AS OCLIENTE", " FROM Ordini ", " INNER JOIN CausaleOrdiniDescrizione AS D ON Ordini.CAUSALEORDINE = D.CAUSALEORDINE INNER JOIN Clienti ON Clienti.CODICECLIENTE=Ordini.CODICECLIENTE", " WHERE Ordini.BOOELIMINATO=TRUE")
        RiempiColonneDaDB(dgvOrdini, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaVisite()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella viste...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT 0 AS VCHK, IDVISITA, DTVISITA, DESC_VISITA, NOTEVISITA, Visite.CAUSALEVISITA, RAGIONESOCIALECLIENTE AS VCLIENTE", "FROM Visite", "INNER JOIN CausaleVisitaDescrizione AS C ON Visite.CAUSALEVISITA = C.CAUSALEVISITA INNER JOIN Clienti ON Clienti.CODICECLIENTE=Visite.CODICECLIENTE", "WHERE Visite.BOOELIMINATO=TRUE")
        RiempiColonneDaDB(dgvVisite, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub SceDatiOK()
        For i As Integer = 1 To dgvVisite.Rows.Count Step 1
            If Convert.ToBoolean(dgvVisite.Rows(i - 1).Cells("VCHK").Value) Then
                EseguiSQL("UPDATE Visite SET BOOELIMINATO=FALSE WHERE IDVISITA=" & dgvVisite.Rows(i - 1).Cells("IDVISITA").Value)
            End If
        Next i
        For i As Integer = 1 To dgvTelefonate.Rows.Count Step 1
            If Convert.ToBoolean(dgvTelefonate.Rows(i - 1).Cells("TCHK").Value) Then
                EseguiSQL("UPDATE Telefonate SET BOOELIMINATO=FALSE WHERE IDTELEFONATA=" & dgvTelefonate.Rows(i - 1).Cells("IDTELEFONATA").Value)
            End If
        Next i
        For i As Integer = 1 To dgvPreventivi.Rows.Count Step 1
            If Convert.ToBoolean(dgvPreventivi.Rows(i - 1).Cells("PCHK").Value) Then
                EseguiSQL("UPDATE Preventivi SET BOOELIMINATO=FALSE WHERE IDPREVENTIVO=" & dgvPreventivi.Rows(i - 1).Cells("IDPREVENTIVO").Value)
            End If
        Next i
        For i As Integer = 1 To dgvOrdini.Rows.Count Step 1
            If Convert.ToBoolean(dgvOrdini.Rows(i - 1).Cells("OCHK").Value) Then
                EseguiSQL("UPDATE Ordini SET BOOELIMINATO=FALSE WHERE IDORDINE=" & dgvOrdini.Rows(i - 1).Cells("IDORDINE").Value)
            End If
        Next i
        AggiornaTabelle()
    End Sub

    Private Sub CellClicks(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVisite.CellClick, dgvTelefonate.CellClick, dgvPreventivi.CellClick, dgvOrdini.CellClick
        Select Case e.ColumnIndex
            Case 0 ' Il CHK
                TryCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not TryCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        End Select
    End Sub

End Class