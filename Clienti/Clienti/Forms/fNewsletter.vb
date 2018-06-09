Public Class fNewsletter

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

    Private Sub SceDatiOK()
        Dim destinatari() As String = {}
        Dim oggetto As String = Trim(txtOggetto.Text)
        Dim testo As String = Trim(txtTesto.Text)

        If (oggetto = vbNullString) Or (testo = vbNullString) Then
            MsgBox("Errore, l'oggetto e il testo sono obbligatori.", MsgBoxStyle.Critical, "Errore")
            Exit Sub
        End If

        For Each row As DataGridViewRow In dgvMail.Rows
            If row.Cells("CHK").Value = True Then
                ReDim Preserve destinatari(destinatari.Count)
                destinatari(destinatari.Count - 1) = row.Cells("EMAIL").Value
            End If
        Next

        Dim Priorita As Net.Mail.MailPriority = Net.Mail.MailPriority.Normal
        Select Case cmbPriorita.SelectedIndex
            Case 0
                Priorita = Net.Mail.MailPriority.Low
            Case 1
                Priorita = Net.Mail.MailPriority.Normal
            Case 2
                Priorita = Net.Mail.MailPriority.High
        End Select

        Select Case InviaMultiMail(oggetto, testo, destinatari, Priorita)
            Case EnumInviaMultiMail.Inviate

            Case EnumInviaMultiMail.Errori

            Case EnumInviaMultiMail.NessunDestinatario

        End Select

    End Sub

    Private Sub fNewsletter_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter
        AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
        AbilitaMenuModifica(False)
        AggiornaTabelle()
    End Sub

    Private Sub fNewsletter_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
        AbilitaMenuModifica(False)
    End Sub

    Private Sub fNewsletter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Abilito i menu
        AbilitaMenuModifica(False)
        AbilitaMainMenuSotto(EnumMainMenuSotto.OK)

        ' Cario E-mail
        Call CaricaMail()
        Call CaricaGruppi()
        cmbPriorita.SelectedIndex = 1
    End Sub

    Private Sub AggiornaTabelle()
        Call CaricaMail()
        Call CaricaGruppi()
        Call AggiornaGruppi()
    End Sub

    Private Sub CaricaMail()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella mail...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT 0 AS CHK, M.IDMAIL, M.EMAIL, M.NOTEMAIL, C.RAGIONESOCIALECLIENTE", "FROM Mails as M", " INNER JOIN CLIENTI AS C ON C.CODICECLIENTE=M.CODICECLIENTE ", "WHERE M.BOOELIMINATO=FALSE")
        RiempiColonneDaDB(dgvMail, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaGruppi()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella gruppi...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT 0 AS CHEK, IDGRUPPO, NOMEGRUPPO, NOTEGRUPPO", "FROM Gruppi", , "WHERE BOOELIMINATO=FALSE")
        RiempiColonneDaDB(dgvGruppi, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub AggiornaGruppi()
        For Each riga As DataGridViewRow In dgvGruppi.Rows
            If riga.Cells("CHECK").Value = True Then
                SelezionaMailGruppo(riga.Cells("IDGRUPPO").Value, True)
            End If
        Next
    End Sub

    Private Sub SelezionaTutto(ByVal flag As Boolean)
        For Each riga As DataGridViewRow In dgvGruppi.Rows
            riga.Cells("CHECK").Value = False
        Next
        For Each riga As DataGridViewRow In dgvMail.Rows
            riga.Cells("CHK").Value = flag
        Next
    End Sub

    Private Sub SelezionaMailGruppo(ByVal IDGruppo As Integer, ByVal flag As Boolean)
        Dim letto As OdbcDataReader = EseguiSQL("SELECT IDGRUPPO, IDMAIL FROM gruppomail WHERE IDGRUPPO=" & IDGruppo)
        While letto.Read()
            For Each riga As DataGridViewRow In dgvMail.Rows
                If letto.Item("IDMAIL") = riga.Cells("IDMAIL").Value Then
                    riga.Cells("CHK").Value = flag
                End If
            Next
        End While
    End Sub

    Private Sub dgvMail_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMail.CellContentClick
        Select Case e.ColumnIndex
            Case 0 ' Il CHK
                TryCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not TryCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        End Select
    End Sub

    Private Sub dgvGruppi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGruppi.CellContentClick
        Select Case e.ColumnIndex
            Case 0 ' Il CHEK
                TryCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not TryCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                'ho selezionato quindi ora seleziono/deseleziono dal DataGrid sopra tutte le mail del gruppo
                SelezionaMailGruppo(TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("IDGRUPPO").Value, TryCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                AggiornaGruppi() ' così da riselezionare le mail presenti in altri gruppi
        End Select
    End Sub

    Private Sub lnkTutto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkTutto.LinkClicked
        SelezionaTutto(True)
    End Sub

    Private Sub lnkNiente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNiente.LinkClicked
        SelezionaTutto(False)
    End Sub
End Class