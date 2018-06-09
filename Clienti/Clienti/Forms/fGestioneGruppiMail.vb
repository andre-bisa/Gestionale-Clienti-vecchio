Public Class fGestioneGruppiMail

    Private _SceDati As EnumSceDati = Nothing


    Public Property SceDati As EnumSceDati
        Get
            Return _SceDati
        End Get
        Set(value As EnumSceDati)
            _SceDati = value
            Select Case SceDati
                Case EnumSceDati.SceOK
                    If Apici(txtIDGRUPPO.Text) <> vbNullString AndAlso Apici(txtNOMEGRUPPO.Text) <> vbNullString AndAlso QueryNumerico("UPDATE Gruppi SET NOMEGRUPPO=" & Apici(txtNOMEGRUPPO.Text) & ", NOTEGRUPPO=" & Apici(txtNOTEGRUPPO.Text) & " WHERE IDGRUPPO=" & txtIDGRUPPO.Text) > 0 Then
                        MsgBox("Gruppo aggiornato con successo.")
                        AggiornaGruppi()
                    End If
            End Select
        End Set
    End Property

    Public Sub AggiornaGruppi()
        Call CaricaGruppi()
        Call CaricaMail()
        Call CaricaSelezionato()
        Call SelezionaMailGruppo(dgvGruppi.Rows(dgvGruppi.SelectedCells(0).RowIndex).Cells("IDGRUPPO").Value)
    End Sub

    Private Sub CaricaGruppi()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella gruppi...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDGRUPPO, NOMEGRUPPO", "From Gruppi", , "WHERE BOOELIMINATO=FALSE")
        RiempiColonneDaDB(dgvGruppi, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaMail()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella mail...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT 0 as CHK, M.IDMAIL, M.EMAIL, M.NOTEMAIL, C.RAGIONESOCIALECLIENTE", "From Mails as M", " INNER JOIN CLIENTI AS C ON C.CODICECLIENTE=M.CODICECLIENTE ", "WHERE M.BOOELIMINATO=FALSE")
        RiempiColonneDaDB(dgvMail, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaSelezionato()
        txtIDGRUPPO.Text = dgvGruppi.Rows(dgvGruppi.SelectedCells(0).RowIndex).Cells("IDGRUPPO").Value
        txtNOMEGRUPPO.Text = dgvGruppi.Rows(dgvGruppi.SelectedCells(0).RowIndex).Cells("NOMEGRUPPO").Value
        txtNOTEGRUPPO.Text = dgvGruppi.Rows(dgvGruppi.SelectedCells(0).RowIndex).Cells("NOTEGRUPPO").Value
    End Sub

    Private Sub SelezionaTutto(ByVal flag As Boolean)
        For Each riga As DataGridViewRow In dgvMail.Rows
            riga.Cells("CHK").Value = flag
        Next
    End Sub

    Private Sub SelezionaMailGruppo(ByVal IDGruppo As Integer)
        Dim letto As OdbcDataReader = EseguiSQL("SELECT IDGRUPPO, IDMAIL FROM gruppomail WHERE IDGRUPPO=" & IDGruppo)
        While letto.Read()
            For Each riga As DataGridViewRow In dgvMail.Rows
                If letto.Item("IDMAIL") = riga.Cells("IDMAIL").Value Then
                    riga.Cells("CHK").Value = True
                End If
            Next
        End While
    End Sub


    Private Sub fGestioneGruppiMail_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
        AggiornaGruppi()
    End Sub

    Private Sub fGestioneGruppiMail_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        fMain.fMain_KeyDown(sender, e)
    End Sub

    Private Sub fGestioneGruppiMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaGruppi()
        CaricaMail()

        dgvMail.Enabled = False
        Try
            dgvGruppi.Rows(0).Selected = True
        Catch ex As Exception
        End Try
        CaricaSelezionato()
        SelezionaTutto(False)
        SelezionaMailGruppo(dgvGruppi.Rows(0).Cells("IDGRUPPO").Value)
    End Sub

    Private Sub SalvaMails()
        Try
            'txtIDGRUPPO non è ancora stato aggiornato
            'svuoto le mail all'interno di questo gruppo
            EseguiSQL("DELETE FROM gruppomail WHERE IDGRUPPO=" & txtIDGRUPPO.Text)
            'procedo a reinserire le mail nel gruppo
            For Each riga As DataGridViewRow In dgvMail.Rows
                If riga.Cells("CHK").Value Then EseguiSQL("INSERT INTO gruppomail(IDGRUPPO, IDMAIL) VALUES(" & txtIDGRUPPO.Text & ", " & riga.Cells("IDMAIL").Value & ")")
            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub dgvGruppi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGruppi.CellContentClick, dgvGruppi.CellClick
        dgvMail.Enabled = True
        TryCast(sender, DataGridView).Rows(e.RowIndex).Selected = True
        SalvaMails()
        CaricaSelezionato()
        SelezionaTutto(False)
        SelezionaMailGruppo(TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("IDGRUPPO").Value)
    End Sub

    Private Sub btnAddGruppo_Click(sender As Object, e As EventArgs) Handles btnAddGruppo.Click
        Dim nome As String = InputBox("Nome nuovo gruppo", "Creazione gruppo")
        If nome <> vbNullString Then QueryNumerico("INSERT INTO Gruppi (NOMEGRUPPO) VALUES(" & Apici(nome) & ")")
        AggiornaGruppi()
    End Sub

    Private Sub dgvMail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMail.CellContentClick
        Try
            Select Case e.ColumnIndex
                Case 0 ' Il CHK
                    TryCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not TryCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If MsgBox("Confermi di voler eliminare il gruppo " & txtNOMEGRUPPO.Text & " mail?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confermi?") = MsgBoxResult.Yes Then
            If ConfermaAzione("Confermi eliminazione gruppo " & txtNOMEGRUPPO.Text & " mail?") Then
                EseguiSQL("UPDATE Gruppi SET BOOELIMINATO=TRUE WHERE IDGRUPPO=" & txtIDGRUPPO.Text)
            End If
        End If
        AggiornaGruppi()
    End Sub


End Class