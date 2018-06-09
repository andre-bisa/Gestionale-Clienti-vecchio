Imports System
Imports System.Data
Imports System.Data.Odbc
Imports Clienti.mFunzioni
'Imports Clienti.fMain
'Imports Clienti.Definizioni

Public Class fClienti

    Private _SceDati As EnumSceDati = Nothing
    Private _Modalita As EnumModalita = Nothing
    Private _OggettiInForm As Object() = Nothing
    Private _OrdinaPer As String = Nothing
    Private _Ordina As String = Nothing

    Private RecordsLetti As cRecordsLetti

    Private Const kTabAnagrafica As Integer = 0
    Private Const kTabVisite As Integer = 1
    Private Const kTabTelefonate As Integer = 2
    Private Const kTabPreventivi As Integer = 3
    Private Const kTabOrdini As Integer = 4
    Private Const kTabAzioniCliente As Integer = 5

    Private booNonPulireForm As Boolean = False
    Private CodiceClienteOld As String = vbNullString

    ' COSTANTI ZOOM
    Private Const kNomeTabella = "Clienti"
    Private Const kCampoCodice = "CODICECLIENTE"
    Private Const kCampoDecodifica = "RAGIONESOCIALECLIENTE"
    Private Const kFiltroAgg = ""
    Private Const kChiavePrimaria = "CODICECLIENTE"

    Public Property Ordina As String
        Get
            Return _Ordina
        End Get
        Set(value As String)
            _Ordina = value
        End Set
    End Property

    Public Property OrdinaPer As String
        Get
            Return _OrdinaPer
        End Get
        Set(value As String)
            _OrdinaPer = value
        End Set
    End Property

    Private Property OggettiInForm As Object()
        Get
            If _OggettiInForm Is Nothing Then _OggettiInForm = OggettiInOggetto(Me)
            Return _OggettiInForm
        End Get
        Set(value As Object())
            _OggettiInForm = value
        End Set
    End Property

    Public Property Modalita As EnumModalita
        Get
            Return _Modalita
        End Get
        Set(value As EnumModalita)
            _Modalita = value
            ModificaModalita(Modalita, OggettiInForm)
        End Set
    End Property
    Public Property SceDati As EnumSceDati
        Get
            Return _SceDati
        End Get
        Set(value As EnumSceDati)
            _SceDati = value
            Selezione(SceDati)
        End Set
    End Property

    Private Sub Selezione(ByVal Azione As EnumSceDati)
        Select Case Azione
            Case EnumSceDati.SceNothing
                Exit Sub
            Case EnumSceDati.SceAnn
                ApplicoLettura(RecordsLetti.GetValue)

            Case EnumSceDati.SceOK
                Select Case Modalita
                    Case EnumModalita.ModIns
                        Inserisci()
                    Case EnumModalita.ModMod
                        If RecordsLetti Is Nothing Then
                            Ricerca()
                            GoTo Ext
                        End If
                        Modifica()
                    Case EnumModalita.ModRic
                        Ricerca()
                        If RecordsLetti Is Nothing Then GoTo Ext
                        AbilitaMainMenuSotto(EnumMainMenuSotto.Tutto)
                    Case Else

                End Select
            Case EnumSceDati.ScePrecedente
                If (RecordsLetti.Index > cRecordsLetti.MinIndex) Then
                    RecordsLetti.Index = RecordsLetti.Index - 1
                    ApplicoLettura(RecordsLetti.GetValue)
                    CodiceClienteOld = txtCODICECLIENTE.Text
                Else
                    MsgBox("Impossibile, il record selezionato è il primo.", MsgBoxStyle.Information)
                End If
            Case EnumSceDati.SceSuccessivo
                If (RecordsLetti.Index < RecordsLetti.MaxIndex) Then
                    RecordsLetti.Index = RecordsLetti.Index + 1
                    ApplicoLettura(RecordsLetti.GetValue)
                    CodiceClienteOld = txtCODICECLIENTE.Text
                Else
                    MsgBox("Impossibile, il record selezionato è l'ultimo.", MsgBoxStyle.Information)
                End If
            Case EnumSceDati.SceUltimoRecord
                If (RecordsLetti.Index < RecordsLetti.MaxIndex) Then
                    RecordsLetti.Index = RecordsLetti.MaxIndex
                    ApplicoLettura(RecordsLetti.GetValue)
                    CodiceClienteOld = txtCODICECLIENTE.Text
                Else
                    MsgBox("Impossibile, il record selezionato è l'ultimo.", MsgBoxStyle.Information)
                End If
            Case EnumSceDati.ScePrimoRecord
                If (RecordsLetti.Index > cRecordsLetti.MinIndex) Then
                    RecordsLetti.Index = cRecordsLetti.MinIndex
                    ApplicoLettura(RecordsLetti.GetValue)
                    CodiceClienteOld = txtCODICECLIENTE.Text
                Else
                    MsgBox("Impossibile, il record selezionato è il primo.", MsgBoxStyle.Information)
                End If
            Case EnumSceDati.SceZoom
                AbilitaMainMenuDaModalita(Modalita, SceDati)

            Case Else
        End Select
Ext:
    End Sub

    Private Sub Modifica()
        On Error GoTo Err
        AggiornaStato("Controllo correttezza campi")
        For Each c As Control In OggettiInForm
            On Error GoTo Nxt
            AggiornaStato(".", True)
            Application.DoEvents()
            If (c.Tag Is Nothing) Or (c.Tag = "") Then GoTo Nxt
            If Len(c.Tag) < 5 Then GoTo Nxt
            If c.Tag.ToString.Substring(4, 1) = kTagObbligatorio Then
                Select Case Leftt(c.Tag, 1)
                    Case kTagTextBox
                        If Len(c.Text) = 0 Then
                            MsgBox("Riempire i campi obbligatori!" & vbNewLine & "Campo obbligatorio da inserire: " & c.Name, MsgBoxStyle.Information)
                            GoTo Ext
                        End If
                End Select
            End If
Nxt:
        Next c
        On Error GoTo Err
        AggiornaStato("Aggiornamento in corso...")
        ' ORA FINALMENTE INSERISCE IL RECORD
        If MsgBox("Confermi aggiornamento?", vbInformation + MsgBoxStyle.YesNo, "Confermi?") = MsgBoxResult.No Then GoTo Ext

        Dim RicercaCodiceCliente As String = CodiceClienteOld  ' Nel campo WHERE
        Dim ModificaCodiceCliente As String = CodiceClienteOld  ' Nel campo UPDATE

        If CodiceClienteOld <> txtCODICECLIENTE.Text Then
            ModificaCodiceCliente = txtCODICECLIENTE.Text
            ' Controllo che non esista il codice cliente
            If Leftt(Controlla(kCampoDecodifica, kNomeTabella, kCampoCodice & " = " & Apici(ModificaCodiceCliente) & kFiltroAgg), 1) <> kHash Then
                MsgBox("Codice cliente già esistente", vbInformation)
                txtCODICECLIENTE.Focus()
                GoTo ext
            End If

        Else
            ' Controllo che esista il codice cliente
            If Leftt(Controlla(kCampoDecodifica, kNomeTabella, kCampoCodice & " = " & Apici(ModificaCodiceCliente) & kFiltroAgg), 1) = kHash Then
                MsgBox("Impossibile trovare il codice cliente.", vbInformation)
                txtCODICECLIENTE.Focus()
                GoTo Ext
            End If
        End If

        Dim RAggiornati As Integer = QueryNumerico("UPDATE Clienti SET BOOEXCLIENTE=" & chkBOOEXCLIENTE.Checked & ", BOOPROVV=" & chkBOOPROVV.Checked & ", CATALOGO=" & Apici(txtCATALOGO.Text) & ", " & _
                          "RAGIONESOCIALECLIENTE=" & Apici(txtRAGIONESOCIALECLIENTE.Text) & ", PI_CF=" & Apici(txtPI_CF.Text) & ", INDIRIZZOCLIENTE=" & Apici(txtINDIRIZZOCLIENTE.Text) & _
                          ", GIORNALINO=" & Apici(txtGIORNALINO.Text) & ", PROVINCIA=" & Apici(txtPROVINCIA.Text) & ", SEDEALTERNATIVA=" & Apici(txtSEDEALTERNATIVA.Text) & _
                          ", CODICECLIENTE=" & Apici(ModificaCodiceCliente) & ", NOTE=" & Apici(txtNOTE.Text) & " WHERE CODICECLIENTE=" & Apici(RicercaCodiceCliente))
        MsgBox("Record aggiornati: " & RAggiornati, vbInformation)
        RecordsLetti.AggiornaLettura()
        ApplicoLettura(RecordsLetti.Value)
        GoTo Ext
Err:
        MsgBox("Errore nella modifica del record, nessuna azione verrà eseguita!", MsgBoxStyle.Critical)
Ext:
        AggiornaStato("Pronto")
        Exit Sub
    End Sub

    Private Sub Inserisci()
        On Error GoTo Err
        AggiornaStato("Controllo correttezza campi")
        For Each c As Control In OggettiInForm
            On Error GoTo Nxt
            AggiornaStato(".", True)
            Application.DoEvents()
            If (c.Tag Is Nothing) Or (c.Tag = "") Then Continue For
            If Len(c.Tag) < 5 Then Continue For
            If c.Tag.ToString.Substring(4, 1) = kTagObbligatorio Then
                Select Case Leftt(c.Tag, 1)
                    Case kTagTextBox
                        If Len(c.Text) = 0 Then
                            MsgBox("Riempire i campi obbligatori!" & vbNewLine & "Campo obbligatorio da inserire: " & c.Name, MsgBoxStyle.Information)
                            GoTo ext
                        End If
                End Select
            End If
Nxt:
        Next c
        On Error GoTo Err
        If Leftt(Controlla(kCampoDecodifica, kNomeTabella, kCampoCodice & " = " & Apici(txtCODICECLIENTE.Text) & kFiltroAgg), 1) <> kHash Then
            MsgBox("Codice cliente già esistente", vbInformation)
            txtCODICECLIENTE.Focus()
            GoTo ext
        End If
        AggiornaStato("Inserimento in corso...")
        ' ORA FINALMENTE INSERISCE IL RECORD
        If MsgBox("Confermi inserimento?", vbInformation + MsgBoxStyle.YesNo, "Inserimento?") = MsgBoxResult.No Then GoTo Ext
        Dim NAggiunti As Integer = QueryNumerico("INSERT INTO Clienti(CODICECLIENTE, BOOPROVV, CATALOGO, " &
                      "RAGIONESOCIALECLIENTE, PI_CF, INDIRIZZOCLIENTE, GIORNALINO, NOTE, PROVINCIA, SEDEALTERNATIVA, BOOEXCLIENTE) " &
                      " VALUES (" & Apici(txtCODICECLIENTE.Text) & ", " &
                      chkBOOPROVV.Checked & ", " & Apici(txtCATALOGO.Text) &
                      ", " & Apici(txtRAGIONESOCIALECLIENTE.Text) & ", " & Apici(txtPI_CF.Text) &
                      ", " & Apici(txtINDIRIZZOCLIENTE.Text) &
                      ", " & Apici(txtGIORNALINO.Text) & ", " & Apici(txtNOTE.Text) &
                      ", " & Apici(txtPROVINCIA.Text) & ", " & Apici(txtSEDEALTERNATIVA.Text) &
                      ", " & chkBOOEXCLIENTE.Checked &
                        ")")
        MsgBox("Record inseriti: " & NAggiunti, vbInformation)
        Me.Modalita = EnumModalita.ModMod ' Mi posiziono in modalità modifica
        GoTo Ext

Err:
        MsgBox("Errore funzione Inserisci", MsgBoxStyle.Critical)

Ext:
        AggiornaStato("Pronto")
        Exit Sub
    End Sub

    Private Sub ApplicoLettura(ByVal letto As OdbcDataReader)
        Try
            If RecordsLetti.MaxIndex <= 0 Then
                MsgBox("Nessun record trovato.", MsgBoxStyle.Information)
                Me.Modalita = EnumModalita.ModRic
                'PulisciForm()
                Exit Sub
            End If
            If IsNothing(letto) Then
                MsgBox("Nessun record trovato." & vbNewLine & "Errore non previsto!", MsgBoxStyle.Critical)
                RecordsLetti = Nothing
                Me.Close()
                Exit Sub
            End If

            ' Imposto la modalità modifica, la quale poi andrà a cliccare il tls giusto
            Me.Modalita = EnumModalita.ModMod

            RiempiCampiDaRicercaQuery(Me, letto, OggettiInForm)
            CaricaVisite()
            CaricaTelefonate()
            CaricaOrdini()
            CaricaTelefoni()
            CaricaMail()
            CaricaPreventivi()
            CaricaReferenti()
            Application.DoEvents()
        Catch ex As Exception
            MsgBox("Errore funzione ApplicoLettura", MsgBoxStyle.Critical)
        End Try
        AggiornaStato("Pronto")
    End Sub

    Private Sub Ricerca()
        On Error GoTo Err
        Dim ComandoSQL_Where As String = vbNullString
        'If (Me.txtCODICECLIENTE.Text <> "") Then ComandoSQL_Where = "WHERE CODICECLIENTE = " & Apici(Me.txtCODICECLIENTE.Text)
        AggiornaStato("Ricerca in corso...")
        RiempiSQLWhere(ComandoSQL_Where)
        If Not chkEvitaProvvisorio.Checked Then
            ComandoSQL_Where &= " AND Clienti.BOOPROVV=" & chkBOOPROVV.Checked
        End If
        If Not chkEvitaEx.Checked Then
            ComandoSQL_Where &= " AND Clienti.BOOEXCLIENTE=" & chkBOOEXCLIENTE.Checked
        End If
        If Len(txtRICERCAREFERENTE.Text) > 0 Then
            ComandoSQL_Where = ComandoSQL_Where & " AND Referenti.NOMEREFERENTE LIKE " & Apici(kLikeOperator & txtRICERCAREFERENTE.Text & kLikeOperator)
        End If
        'RecordsLetti = New cRecordsLetti("SELECT * FROM Clienti " & ComandoSQL_Where & " ORDER BY CODICECLIENTE")
        Dim SQL As String = vbNullString
        SQL = "SELECT Clienti.*, DataUltimaAzione.DATAULTIMAAZIONE AS DATAULTIMAAZIONE FROM Clienti LEFT JOIN dataultimaazione ON Clienti.CODICECLIENTE = DataUltimaAzione.CODICECLIENTE " & _
            " LEFT JOIN Referenti ON Clienti.CODICECLIENTE=Referenti.CODICECLIENTE " & _
            ComandoSQL_Where
        If Len(OrdinaPer) > 0 Then
            SQL = SQL & " ORDER BY " & OrdinaPer & " " & Ordina
        End If
        RecordsLetti = New cRecordsLetti(SQL)
        If (RecordsLetti.MaxIndex > 0) Then
            ApplicoLettura(RecordsLetti.Value)
        Else ' Se non trovo nulla
            RecordsLetti = Nothing
            booNonPulireForm = True
            'Me.Modalita = EnumModalita.Ricerca
            fMain.tlsRicerca.Checked = True ' Rimetto la modalità come ricerca
            MsgBox("Nessun Record Trovato.", MsgBoxStyle.Information)
            GoTo Ext
        End If

        CodiceClienteOld = txtCODICECLIENTE.Text
        Exit Sub
Err:
        MsgBox("Errore nella funzione Ricerca", MsgBoxStyle.Critical)
Ext:
        Exit Sub
    End Sub

    Private Sub RiempiSQLWhere(ByRef ComandoSQL_Where As String)
        On Error GoTo Ext
        ComandoSQL_Where = " WHERE 1=1 "
        For Each ctrl As Control In OggettiInForm
            On Error GoTo Prox
            If (ctrl.Tag Is Nothing) Then Continue For
            If (ctrl.Text = vbNullString) Then Continue For
            Select Case Leftt(ctrl.Tag, 1)
                Case kTagTextBox
                    If ctrl.Tag.ToString.Substring(3, 1) = kTagAttivo Then
                        If Rightt(ctrl.Name, ctrl.Name.Length - 3) = kChiavePrimaria Then
                            ComandoSQL_Where = ComandoSQL_Where & " AND " & "Clienti." & Rightt(ctrl.Name, ctrl.Name.Length - 3) & "=" & Apici(ctrl.Text)
                        Else
                            ComandoSQL_Where = ComandoSQL_Where & " AND " & Rightt(ctrl.Name, ctrl.Name.Length - 3) & " LIKE " & Apici(kLikeOperator & ctrl.Text & kLikeOperator)
                        End If
                    End If

                Case kTagInvisibile
                    ' Non eseguo azioni perchè il campo viene gestito manualmente

                Case kTagCheckAtt, kTagCheckDisatt
                    If Len(ctrl.Tag) = 5 And Rightt(ctrl.Tag, 1) = "+" Then GoTo Prox
                    ComandoSQL_Where = ComandoSQL_Where & " AND " & "Clienti." & Rightt(ctrl.Name, ctrl.Name.Length - 3) & " = " & TryCast(ctrl, CheckBox).Checked

                Case Else
            End Select

Prox:
        Next ctrl
        Exit Sub
Ext:
        MsgBox("Errore funzione RiempiSQLWhere.", MsgBoxStyle.Critical)
    End Sub

    Private Sub CaricaPreventivi()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella preventivi...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDPREVENTIVO, DTPREVENTIVO, PERCORSOPDFPREVENTIVO, NOTEPREVENTIVO", " FROM Preventivi ", , " WHERE CODICECLIENTE = " & Apici(txtCODICECLIENTE.Text) & " AND BOOELIMINATO=FALSE")
        RiempiColonneDaDB(dgvPreventivi, letto)
        'DGVBTNPDFPREVENTIVO.UseColumnTextForButtonValue = True
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaTelefonate()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella telefoni...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDTELEFONATA, DTTELEFONATA, Telefonate.CAUSALETELEFONATA, D.DESC_TELEFONATA, NOTETELEFONATA", " FROM Telefonate ", " INNER JOIN CausaleTelefonateDescrizione AS D ON Telefonate.CAUSALETELEFONATA = D.CAUSALETELEFONATA", " WHERE BOOELIMINATO=FALSE AND CODICECLIENTE = " & Apici(txtCODICECLIENTE.Text))
        RiempiColonneDaDB(dgvTelefonate, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaVisite()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella viste...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDVISITA, DTVISITA, DESC_VISITA, NOTEVISITA, Visite.CAUSALEVISITA", "FROM Visite", "INNER JOIN CausaleVisitaDescrizione AS C ON Visite.CAUSALEVISITA = C.CAUSALEVISITA", "WHERE BOOELIMINATO=FALSE AND CODICECLIENTE = " & Apici(txtCODICECLIENTE.Text))
        RiempiColonneDaDB(dgvVisite, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaTelefoni()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella telefoni...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDTELEFONO, TELEFONO, NOTETELEFONO", "FROM Telefoni", , "WHERE BOOELIMINATO=FALSE AND CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text))
        RiempiColonneDaDB(dgvTelefoni, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaMail()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella mail...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDMAIL, EMAIL, NOTEMAIL", "FROM Mails", , "WHERE BOOELIMINATO=FALSE AND CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text))
        RiempiColonneDaDB(dgvMail, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaReferenti()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella referenti...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDREFERENTE, NOMEREFERENTE, NOTEREFERENTE", "FROM Referenti", , "WHERE BOOELIMINATO=FALSE AND CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text))
        RiempiColonneDaDB(dgvReferenti, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub CaricaOrdini()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella ordini...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDORDINE, DTORDINE, Ordini.CAUSALEORDINE, D.DESC_ORDINE, NOTEORDINE", " FROM Ordini ", " INNER JOIN CausaleOrdiniDescrizione AS D ON Ordini.CAUSALEORDINE = D.CAUSALEORDINE", " WHERE BOOELIMINATO=FALSE AND CODICECLIENTE = " & Apici(txtCODICECLIENTE.Text))
        RiempiColonneDaDB(dgvOrdini, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Public Sub AggiornaOrdini()
        Call CaricaOrdini()
    End Sub

    Public Sub AggiornaReferenti()
        Call CaricaReferenti()
    End Sub

    Public Sub AggiornaTelefoni()
        Call CaricaTelefoni()
    End Sub

    Public Sub AggiornaVisite()
        Call CaricaVisite()
    End Sub

    Public Sub AggiornaMail()
        Call CaricaMail()
    End Sub

    Public Sub AggiornaPreventivi()
        Call CaricaPreventivi()
    End Sub

    Public Sub AggiornaTutteTabelle()
        Call AggiornaMail()
        Call AggiornaOrdini()
        Call AggiornaPreventivi()
        Call AggiornaReferenti()
        Call AggiornaTelefoni()
        Call AggiornaVisite()
    End Sub

    Private Sub ModificaModalita(ByVal Modo As EnumModalita, Optional ByVal Oggetti() As Object = Nothing)
        AggiornaStato("Caricamento")
        TabControl1.BringToFront()
        Select Case Modo
            Case EnumModalita.ModIns
                PulisciForm()
                AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
                If fMain.tlsInserisci.Checked = False Then fMain.tlsInserisci.Checked = True
                txtCODICECLIENTE.Focus()
                'Me.Modalita = EnumModalita.Inserimento
            Case EnumModalita.ModMod
                If RecordsLetti Is Nothing Then ' Se non ha letto nulla ricerca
                    Me.SceDati = EnumSceDati.SceOK
                    'fMain.tlsOK.PerformClick() ' Eseguo la ricerca come se avessi premuto il tasto OK
                    Exit Sub ' Esco perchè la ricerca cambia da sola la modalità in modifica e quindi evito di passarci 2 volte
                End If
                AbilitaMainMenuSotto(EnumMainMenuSotto.Tutto)
                If fMain.tlsModifica.Checked = False Then fMain.tlsModifica.Checked = True
            Case EnumModalita.ModRic
                PulisciForm()
                AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
                If fMain.tlsRicerca.Checked = False Then fMain.tlsRicerca.Checked = True
                txtCODICECLIENTE.Focus()

            Case Else
        End Select
        On Error Resume Next

        CaricaControlli(Me, Modalita, OggettiInForm)

        txtRICERCAREFERENTE.Visible = (Modalita = EnumModalita.ModRic)
        lblRicercaReferente.Visible = (Modalita = EnumModalita.ModRic)

        lblUltimaAzione.Visible = (Modalita = EnumModalita.ModMod)
        txtDATAULTIMAAZIONE.Visible = (Modalita = EnumModalita.ModMod)


Fine:
        kMainForm.UseWaitCursor = False
        AggiornaStato("Pronto")
    End Sub

    Private Sub PulisciForm()
        On Error GoTo Ext
        If booNonPulireForm Then GoTo Ext
        AggiornaStato("Pulizia form in corso...")
        RecordsLetti = Nothing
        kMainForm.UseWaitCursor = True
        For Each ctrl As Control In OggettiInForm
            Application.DoEvents()
            AggiornaStato(".", True)
            If (ctrl.Tag Is Nothing) Then Continue For
            If Not Len(ctrl.Tag) > 0 Then Continue For
            Select Case ctrl.Tag.ToString.Substring(0, 1)
                Case kTagTextBox, kTagInvisibile
                    ctrl.Text = vbNullString
                Case kTagDataGridView
                    TryCast(ctrl, DataGridView).Rows.Clear()
                Case kTagCheckAtt
                    TryCast(ctrl, CheckBox).Checked = True
                Case kTagCheckDisatt
                    TryCast(ctrl, CheckBox).Checked = False

                Case Else
            End Select
        Next
Ext:
        booNonPulireForm = False
        kMainForm.UseWaitCursor = False
        AggiornaStato("Pronto")
    End Sub

    Private Sub Clienti_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AbilitaMenuModifica(False)
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
    End Sub

    Private Sub fClienti_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter
        AbilitaMainMenuDaModalita(Modalita, SceDati)
        SelezionaOrdinaPer(OrdinaPer)
    End Sub

    Private Sub fClienti_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
        AbilitaMenuModifica(False)
        AttivaOrdinaPer(False)
    End Sub

    Private Sub fClienti_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        fMain.fMain_KeyDown(sender, e)
    End Sub

    Private Sub Clienti_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Abilito i menu
        AbilitaMenuModifica(True)
        AbilitaMainMenuSotto({EnumMainMenuSotto.OK, EnumMainMenuSotto.Ordinamento})

        ' Carico gli oggetti della form e carico il testo dei controlli da DataBase
        CaricaTestoControlli(Me, OggettiInForm)
        txtCODICECLIENTE.Focus()

        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop

        SvuotaOrdinaPer()
        OrdinaPer = "Clienti.CODICECLIENTE"
        AggiungiOrdinaPer("Codice Cliente|Clienti.CODICECLIENTE|Ragione Sociale|Clienti.RAGIONESOCIALECLIENTE|Indirizzo|Clienti.INDIRIZZOCLIENTE|Data Ultima Azione|DataUltimaAzione.DATAULTIMAAZIONE")

        AbilitaOrdinamentoCrescenteDecrescente(True)
        Ordina = "ASC"

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        TabControl1.BringToFront()
    End Sub

    Private Sub dgvVisite_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVisite.CellDoubleClick
        On Error GoTo Fine
        txtIDVISITA.Text = dgvVisite.Rows(e.RowIndex).Cells(0).Value
        txtDTVISITA.Text = dgvVisite.Rows(e.RowIndex).Cells(1).Value
        txtNOTEVISITA.Text = Nz(dgvVisite.Rows(e.RowIndex).Cells(4).Value, vbNullString)
        txtCAUSALEVISITA.Text = dgvVisite.Rows(e.RowIndex).Cells(2).Value
        txtDESC_VISITA.Text = dgvVisite.Rows(e.RowIndex).Cells(3).Value
        grpVisite.BringToFront()
Fine:
    End Sub

    Private Sub txtCAUSALEVISITA_DoubleClick(sender As Object, e As System.EventArgs) Handles txtCAUSALEVISITA.DoubleClick
        If Me.Modalita <> EnumModalita.ModMod Then Exit Sub
        If FormMultiIstanzaSingola(fZoom) Then Exit Sub
        Dim f As New fZoom
        With f
            .MdiParent = kMainForm
            .TextBoxRitorno = txtDESC_VISITA
            .FiltroAgg = kFiltroAgg
            .CampoDecodifica = "DESC_VISITA"
            .NomeTabella = "CausaleVisitaDescrizione"
            .CampoCodice = "CAUSALEVISITA"
            .Chiamante = txtCAUSALEVISITA
            .FormChiamante = Me
            Me.SceDati = EnumSceDati.SceZoom
            Me.Enabled = False
            .Show()
        End With
    End Sub

    Private Sub txtCAUSALEVISITA_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCAUSALEVISITA.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Call txtCAUSALEVISITA_DoubleClick(Nothing, Nothing)

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub txtCAUSALEVISITA_LostFocus(sender As Object, e As System.EventArgs) Handles txtCAUSALEVISITA.LostFocus
        txtDESC_VISITA.Text = Controlla("DESC_VISITA", "CausaleVisitaDescrizione", "CAUSALEVISITA = " & Apici(txtCAUSALEVISITA.Text))
    End Sub

    Private Sub txtCODICECLIENTE_DoubleClick(sender As Object, e As System.EventArgs) Handles txtCODICECLIENTE.DoubleClick
        If Me.Modalita <> EnumModalita.ModRic Then Exit Sub
        If FormMultiIstanzaSingola(fZoom) Then Exit Sub
        Dim f As New fZoom
        With f
            .MdiParent = kMainForm
            .TextBoxRitorno = txtRAGIONESOCIALECLIENTE
            .FiltroAgg = kFiltroAgg
            .CampoDecodifica = kCampoDecodifica
            .NomeTabella = kNomeTabella
            .CampoCodice = kCampoCodice
            .Chiamante = txtCODICECLIENTE
            .FormChiamante = Me
            .AbilitaGestione = False
            Me.SceDati = EnumSceDati.SceZoom
            Me.Enabled = False
            .Show()
        End With
    End Sub

    Private Sub txtCODICECLIENTE_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCODICECLIENTE.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Call txtCODICECLIENTE_DoubleClick(Nothing, Nothing)

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub txtCODICECLIENTE_LostFocus(sender As Object, e As System.EventArgs) Handles txtCODICECLIENTE.LostFocus
        If Modalita <> EnumModalita.ModRic Then Exit Sub
        If Len(txtCODICECLIENTE.Text) <= 0 Then
            txtRAGIONESOCIALECLIENTE.Text = vbNullString
            Exit Sub
        End If
        txtRAGIONESOCIALECLIENTE.Text = Controlla(kCampoDecodifica, kNomeTabella, kCampoCodice & " = " & Apici(txtCODICECLIENTE.Text) & kFiltroAgg)
    End Sub

    Private Sub btnNuovaVisita_Click(sender As System.Object, e As System.EventArgs) Handles btnNuovaVisita.Click
        txtDTVISITA.Text = vbNullString
        txtNOTEVISITA.Text = vbNullString
        txtCAUSALEVISITA.Text = vbNullString
        txtDESC_VISITA.Text = vbNullString
        txtIDVISITA.Text = vbNullString
        grpVisite.BringToFront()
    End Sub

    Private Sub btnSalvaVisita_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvaVisita.Click
        On Error GoTo Fine
        Call txtCAUSALEVISITA_LostFocus(Nothing, Nothing)
        'Salvataggio della visita
        If Leftt(txtDESC_VISITA.Text, 1) = kHash Then
            MsgBox("Inserire un codice visita valido!")
            Exit Sub
        End If
        If ContaSQL("Visite", "IDVISITA = " & txtIDVISITA.Text) < 1 Then
            'Inserisco
            MsgBox("Inseriti: " & QueryNumerico("INSERT INTO Visite(CODICECLIENTE, DTVISITA, CAUSALEVISITA, NOTEVISITA) VALUES(" & Apici(txtCODICECLIENTE.Text) & ", " & DataADatabase(txtDTVISITA.Value) & ", " & Apici(txtCAUSALEVISITA.Text) & ", " & Apici(txtNOTEVISITA.Text) & ")") & " records.")
        Else
            'Aggiorno
            MsgBox("Aggiornati: " & QueryNumerico("UPDATE Visite SET DTVISITA=" & DataADatabase(txtDTVISITA.Value) & ", CAUSALEVISITA=" & Apici(txtCAUSALEVISITA.Text) & ", NOTEVISITA=" & Apici(txtNOTEVISITA.Text) & " WHERE CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text) & " AND IDVISITA=" & txtIDVISITA.Text) & " records.")
        End If

        AggiornaVisite()
        btnTornaElencoVisite.PerformClick()

        Exit Sub
Fine:
        MsgBox("Errore funzione SalvaVisita")
        Exit Sub
    End Sub

    Private Sub dgvVisite_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvVisite.KeyDown
        On Error GoTo Fine
        Select Case e.KeyCode
            Case Keys.Delete
                If dgvVisite.SelectedRows.Count < 1 Then Exit Sub
                If MsgBox("Confermi eliminazione record?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "Eliminazione?") = MsgBoxResult.No Then
                    Exit Sub
                End If
                If QueryNumerico("UPDATE Visite SET BOOELIMINATO=TRUE WHERE CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text) & " AND IDVISITA=" & dgvVisite.SelectedRows(0).Cells("IDVISITA").Value) > 0 Then MsgBox("Record eliminato con successo", MsgBoxStyle.Information, "Operazione eseguita")
                AggiornaVisite()
            Case Keys.Enter
                If dgvVisite.SelectedRows.Count < 1 Then Exit Sub
                'Dim a As New DataGridViewCellEventArgs(dgvVisite.SelectedCells(0).ColumnIndex, dgvVisite.SelectedCells(0).RowIndex)
                dgvVisite_CellDoubleClick(sender, New DataGridViewCellEventArgs(dgvVisite.SelectedCells(0).ColumnIndex, dgvVisite.SelectedCells(0).RowIndex))


            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
        Exit Sub
Fine:
        MsgBox("Errore sub dgvVisite KeyDown", MsgBoxStyle.Critical)
        Exit Sub
    End Sub

    Private Sub btnAddTelefono_Click(sender As System.Object, e As System.EventArgs) Handles btnAddTelefono.Click
        If FormMultiIstanzaSingola(fGestioneTelefoni) Then Exit Sub
        Dim f As New fGestioneTelefoni
        With f
            .MdiParent = kMainForm
            .FormChiamante = Me
            .IDTelefono = -1
            .CodiceCliente = txtCODICECLIENTE.Text
        End With
        Me.Enabled = False
        f.Show()
    End Sub

    Private Sub dgvTelefoni_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTelefoni.CellDoubleClick
        If FormMultiIstanzaSingola(fGestioneTelefoni) Then Exit Sub
        Dim f As New fGestioneTelefoni
        With f
            .MdiParent = kMainForm
            .FormChiamante = Me
            .IDTelefono = dgvTelefoni.SelectedRows(0).Cells("IDTELEFONO").Value
        End With
        Me.Enabled = False
        f.Show()
    End Sub

    Private Sub dgvTelefoni_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvTelefoni.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                If ContaSQL("Telefoni", "IDTELEFONO=" & dgvTelefoni.SelectedRows(0).Cells("IDTELEFONO").Value) < 1 Then
                    MsgBox("Telefono non trovato.", MsgBoxStyle.Information)
                    AggiornaTelefoni()
                    Exit Sub
                End If
                If MsgBox("Sicuro di voler eliminare il numero di telefono selezionato?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Confermi?") = MsgBoxResult.No Then
                    Exit Sub
                End If
                'If QueryNumerico("UPDATE Telefoni SET BOOELIMINATO=TRUE WHERE IDTELEFONO=" & dgvTelefoni.SelectedRows(0).Cells("IDTELEFONO").Value) > 0 Then MsgBox("Record eliminato con successo", MsgBoxStyle.Information, "Operazione eseguita")
                MsgBox("Eliminati: " & QueryNumerico("UPDATE Telefoni SET BOOELIMINATO=TRUE WHERE IDTELEFONO=" & dgvTelefoni.SelectedRows(0).Cells("IDTELEFONO").Value) & " records.", MsgBoxStyle.Information)
                AggiornaTelefoni()

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub btnTornaElencoTelefonata_Click(sender As System.Object, e As System.EventArgs) Handles btnTornaElencoTelefonata.Click, btnTornaElencoPreventivo.Click, btnTornaElencoVisite.Click, btnTornaElencoOrdine.Click
        TabControl1.BringToFront()
    End Sub

    Private Sub dgvTelefonate_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTelefonate.CellDoubleClick
        On Error GoTo Fine
        txtIDTELEFONATA.Text = dgvTelefonate.Rows(e.RowIndex).Cells("IDTELEFONATA").Value
        txtDTTELEFONATA.Text = dgvTelefonate.Rows(e.RowIndex).Cells("DTTELEFONATA").Value
        txtNOTETELEFONATA.Text = Nz(dgvTelefonate.Rows(e.RowIndex).Cells("NOTETELEFONATA").Value, vbNullString)
        txtCAUSALETELEFONATA.Text = dgvTelefonate.Rows(e.RowIndex).Cells("CAUSALETELEFONATA").Value
        txtDESC_TELEFONATA.Text = dgvTelefonate.Rows(e.RowIndex).Cells("DESC_TELEFONATA").Value
        grpTelefonata.BringToFront()
Fine:
    End Sub

    Private Sub txtCAUSALETELEFONATA_DoubleClick(sender As Object, e As System.EventArgs) Handles txtCAUSALETELEFONATA.DoubleClick
        If Me.Modalita <> EnumModalita.ModMod Then Exit Sub
        If FormMultiIstanzaSingola(fZoom) Then Exit Sub
        Dim f As New fZoom
        With f
            .MdiParent = kMainForm
            .TextBoxRitorno = txtDESC_TELEFONATA
            .FiltroAgg = kFiltroAgg
            .CampoDecodifica = "DESC_TELEFONATA"
            .NomeTabella = "CausaleTelefonateDescrizione"
            .CampoCodice = "CAUSALETELEFONATA"
            .Chiamante = txtCAUSALETELEFONATA
            .FormChiamante = Me
            Me.SceDati = EnumSceDati.SceZoom
            Me.Enabled = False
            .Show()
        End With
    End Sub

    Private Sub txtCAUSALETELEFONATA_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCAUSALETELEFONATA.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Call txtCAUSALETELEFONATA_DoubleClick(Nothing, Nothing)

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub txtCAUSALETELEFONATA_LostFocus(sender As Object, e As System.EventArgs) Handles txtCAUSALETELEFONATA.LostFocus
        txtDESC_TELEFONATA.Text = Controlla("DESC_TELEFONATA", "CausaleTelefonateDescrizione", "CAUSALETELEFONATA = " & Apici(txtCAUSALETELEFONATA.Text))
    End Sub

    Private Sub btnSalvaTelefonata_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvaTelefonata.Click
        On Error GoTo Fine
        Call txtCAUSALETELEFONATA_LostFocus(Nothing, Nothing)
        'Salvataggio della visita
        If Leftt(txtDESC_TELEFONATA.Text, 1) = kHash Then
            MsgBox("Inserire un codice telefonata valido!")
            Exit Sub
        End If
        If ContaSQL("Telefonate", "IDTELEFONATA = " & txtIDTELEFONATA.Text) < 1 Then
            'Inserisco
            MsgBox("Inseriti: " & QueryNumerico("INSERT INTO Telefonate(CODICECLIENTE, DTTELEFONATA, CAUSALETELEFONATA, NOTETELEFONATA) VALUES(" & Apici(txtCODICECLIENTE.Text) & ", " & DataADatabase(txtDTTELEFONATA.Value) & ", " & Apici(txtCAUSALETELEFONATA.Text) & ", " & Apici(txtNOTETELEFONATA.Text) & ")") & " records.")
        Else
            'Aggiorno
            MsgBox("Aggiornati: " & QueryNumerico("UPDATE Telefonate SET DTTELEFONATA=" & DataADatabase(txtDTTELEFONATA.Value) & ", CAUSALETELEFONATA=" & Apici(txtCAUSALETELEFONATA.Text) & ", NOTETELEFONATA=" & Apici(txtNOTETELEFONATA.Text) & " WHERE CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text) & " AND IDTELEFONATA=" & txtIDTELEFONATA.Text) & " records.")
        End If

        CaricaTelefonate()
        btnTornaElencoTelefonata.PerformClick()

        Exit Sub
Fine:
        MsgBox("Errore funzione SalvaTelefonata")
        Exit Sub
    End Sub

    Private Sub btnNuovaTelefonata_Click(sender As System.Object, e As System.EventArgs) Handles btnNuovaTelefonata.Click
        txtDTTELEFONATA.Text = vbNullString
        txtNOTETELEFONATA.Text = vbNullString
        txtCAUSALETELEFONATA.Text = vbNullString
        txtDESC_TELEFONATA.Text = vbNullString
        txtIDTELEFONATA.Text = vbNullString
        grpTelefonata.BringToFront()
    End Sub

    Private Sub dgvTelefonate_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvTelefonate.KeyDown
        On Error GoTo Fine
        Select Case e.KeyCode
            Case Keys.Delete
                If dgvTelefonate.SelectedRows.Count < 1 Then Exit Sub
                If MsgBox("Confermi eliminazione record?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "Eliminazione?") = MsgBoxResult.No Then
                    Exit Sub
                End If
                If QueryNumerico("UPDATE Telefonate SET BOOELIMINATO=TRUE WHERE CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text) & " AND IDTELEFONATA=" & dgvTelefonate.SelectedRows(0).Cells("IDTELEFONATA").Value) > 0 Then MsgBox("Record eliminato con successo", MsgBoxStyle.Information, "Operazione eseguita")
                CaricaTelefonate()
            Case Keys.Enter
                If dgvTelefonate.SelectedRows.Count < 1 Then Exit Sub
                dgvTelefonate_CellDoubleClick(sender, New DataGridViewCellEventArgs(dgvTelefonate.SelectedCells(0).ColumnIndex, dgvTelefonate.SelectedCells(0).RowIndex))

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
        Exit Sub
Fine:
        MsgBox("Errore sub dgvTelefonate KeyDown", MsgBoxStyle.Critical)
        Exit Sub
    End Sub

    Private Sub dgvMail_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMail.CellDoubleClick
        If FormMultiIstanzaSingola(fGestioneMail) Then Exit Sub
        Dim Proprieta() As String = Nothing
        Dim Valori() As Object = Nothing
        AggiungiProprieta("FormChiamante", Me, Proprieta, Valori)
        AggiungiProprieta("IDMAIL", dgvMail.SelectedRows(0).Cells("IDMAIL").Value, Proprieta, Valori)
        AggiungiForm(fGestioneMail, Proprieta, Valori)
    End Sub

    Private Sub btnAddMail_Click(sender As System.Object, e As System.EventArgs) Handles btnAddMail.Click
        If FormMultiIstanzaSingola(fGestioneMail) Then Exit Sub
        Dim Proprieta() As String = Nothing
        Dim Valori() As Object = Nothing
        AggiungiProprieta("FormChiamante", Me, Proprieta, Valori)
        AggiungiProprieta("IDMAIL", -1, Proprieta, Valori)
        AggiungiProprieta("CodiceCliente", txtCODICECLIENTE.Text, Proprieta, Valori)
        AggiungiForm(fGestioneMail, Proprieta, Valori)
    End Sub

    Private Sub dgvMail_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvMail.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                If ContaSQL("Mails", "IDMAIL=" & dgvMail.SelectedRows(0).Cells("IDMAIL").Value) < 1 Then
                    MsgBox("Mail non trovata.", MsgBoxStyle.Information)
                    AggiornaMail()
                    Exit Sub
                End If
                If MsgBox("Sicuro di voler eliminare la mail selezionata?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Confermi?") = MsgBoxResult.No Then
                    Exit Sub
                End If
                MsgBox("Eliminati: " & QueryNumerico("UPDATE Mails SET BOOELIMINATO=TRUE WHERE IDMAIL=" & dgvMail.SelectedRows(0).Cells("IDMAIL").Value) & " records.", MsgBoxStyle.Information)
                AggiornaMail()

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub btnNuovoPreventivo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuovoPreventivo.Click
        txtDTPREVENTIVO.Text = vbNullString
        txtNOTEPREVENTIVO.Text = vbNullString
        txtIDPREVENTIVO.Text = vbNullString
        txtPERCORSOPDFPREVENTIVO.Text = vbNullString
        grpPreventivo.BringToFront()
    End Sub

    Private Sub dgvPreventivi_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPreventivi.CellClick
        Select Case e.ColumnIndex
            Case 4  ' è la colonna del pulsante APRI FILE
                Process.Start(dgvPreventivi.Rows(e.RowIndex).Cells("PERCORSOPDFPREVENTIVO").Value)

            Case 5  ' è la colonna del pulsante SALVA FILE
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
    End Sub

    Private Sub dgvPreventivi_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPreventivi.CellDoubleClick
        On Error GoTo Fine
        txtIDPREVENTIVO.Text = dgvPreventivi.Rows(e.RowIndex).Cells("IDPREVENTIVO").Value
        txtDTPREVENTIVO.Text = dgvPreventivi.Rows(e.RowIndex).Cells("DTPREVENTIVO").Value
        txtNOTEPREVENTIVO.Text = Nz(dgvPreventivi.Rows(e.RowIndex).Cells("NOTEPREVENTIVO").Value, vbNullString)
        txtPERCORSOPDFPREVENTIVO.Text = dgvPreventivi.Rows(e.RowIndex).Cells("PERCORSOPDFPREVENTIVO").Value
        grpPreventivo.BringToFront()
Fine:
    End Sub

    Private Sub dgvPreventivi_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvPreventivi.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                If ContaSQL("Preventivi", "IDPREVENTIVO=" & dgvPreventivi.SelectedRows(0).Cells("IDPREVENTIVO").Value) < 1 Then
                    MsgBox("Preventivo non trovato.", MsgBoxStyle.Information)
                    AggiornaPreventivi()
                    Exit Sub
                End If
                If MsgBox("Sicuro di voler eliminare il preventivo selezionato?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Confermi?") = MsgBoxResult.No Then
                    Exit Sub
                End If
                'MsgBox("Eliminati: " & QueryNumerico("DELETE FROM Preventivi WHERE IDPREVENTIVO=" & dgvPreventivi.SelectedRows(0).Cells("IDPREVENTIVO").Value) & " records.", MsgBoxStyle.Information)
                MsgBox("Eliminati: " & QueryNumerico("UPDATE Preventivi SET BOOELIMINATO=TRUE WHERE IDPREVENTIVO=" & dgvPreventivi.SelectedRows(0).Cells("IDPREVENTIVO").Value) & " records.", MsgBoxStyle.Information)
                AggiornaPreventivi()

            Case Keys.Enter
                If dgvPreventivi.SelectedRows.Count = 0 Then Exit Sub
                Process.Start(dgvPreventivi.SelectedRows(0).Cells("PERCORSOPDFPREVENTIVO").Value)

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub btnSalvaPreventivo_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvaPreventivo.Click
        On Error GoTo Fine
        Dim flgAllegato As Boolean = True
        If (Len(txtPERCORSOPDFPREVENTIVO.Text) <= 0) Or (Not System.IO.File.Exists(txtPERCORSOPDFPREVENTIVO.Text)) Then
            If MsgBox("Procedere senza allegare alcun file?", MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Procedere?") = MsgBoxResult.No Then Exit Sub
            txtPERCORSOPDFPREVENTIVO.Text = vbNullString
            flgAllegato = False
        End If
        'Salvataggio del preventivo
        Dim PathSalvataggio As String = vbNullString
        If ContaSQL("Preventivi", "IDPREVENTIVO = " & txtIDPREVENTIVO.Text) < 1 Then
            'Inserisco
            If flgAllegato Then ' Se ci sono allegati
                PathSalvataggio = kPathDirectoryAllegati & Now.Year & "_" & Now.Month & "_" & Now.Day & "_" & Now.Hour & "_" & Now.Minute & "_" & Now.Second & "_" & "Preventivo" & System.IO.Path.GetExtension(txtPERCORSOPDFPREVENTIVO.Text)
                Copia(txtPERCORSOPDFPREVENTIVO.Text, PathSalvataggio)
            Else ' Se non ci sono allegati
                PathSalvataggio = vbNullString
            End If

            MsgBox("Inseriti: " & QueryNumerico("INSERT INTO Preventivi(CODICECLIENTE, DTPREVENTIVO, PERCORSOPDFPREVENTIVO, NOTEPREVENTIVO) VALUES(" & Apici(txtCODICECLIENTE.Text) & ", " & DataADatabase(txtDTPREVENTIVO.Value) & ", " & Apici(PathSalvataggio) & ", " & Apici(txtNOTEPREVENTIVO.Text) & ")") & " records.")
        Else
            'Aggiorno
            If flgAllegato Then
                PathSalvataggio = Controlla("PERCORSOPDFPREVENTIVO", "Preventivi", " IDPREVENTIVO=" & txtIDPREVENTIVO.Text)
                If Len(PathSalvataggio) > 0 Then
                    Copia(txtPERCORSOPDFPREVENTIVO.Text, PathSalvataggio)
                Else
                    PathSalvataggio = kPathDirectoryAllegati & Now.Year & "_" & Now.Month & "_" & Now.Day & "_" & Now.Hour & "_" & Now.Minute & "_" & Now.Second & "_" & "Preventivo" & System.IO.Path.GetExtension(txtPERCORSOPDFPREVENTIVO.Text)
                    Copia(txtPERCORSOPDFPREVENTIVO.Text, PathSalvataggio)
                End If

            Else
                PathSalvataggio = vbNullString
            End If
            MsgBox("Aggiornati: " & QueryNumerico("UPDATE Preventivi SET DTPREVENTIVO=" & DataADatabase(txtDTPREVENTIVO.Value) & ", NOTEPREVENTIVO=" & Apici(txtNOTEPREVENTIVO.Text) & ", PERCORSOPDFPREVENTIVO=" & Apici(PathSalvataggio) & " WHERE IDPREVENTIVO=" & txtIDPREVENTIVO.Text) & " records.")
        End If

        AggiornaPreventivi()
        btnTornaElencoTelefonata.PerformClick()

        Exit Sub
Fine:
        MsgBox("Errore funzione SalvaPreventivo")
        Exit Sub
    End Sub

    Private Sub btnSfogliaPreventivo_Click(sender As System.Object, e As System.EventArgs) Handles btnSfogliaPreventivo.Click
        With OpenFileDialog1
            .Filter = "File PDF (*.pdf)|*.pdf|Tutti i File (*.*)|*.*"
            .FileName = "Preventivo"
            If Len(txtPERCORSOPDFPREVENTIVO.Text) > 0 Then
                .InitialDirectory = System.IO.Path.GetDirectoryName(txtPERCORSOPDFPREVENTIVO.Text)
                If Len(System.IO.Path.GetExtension(txtPERCORSOPDFPREVENTIVO.Text)) > 0 Then .Filter = "File|*" & System.IO.Path.GetExtension(txtPERCORSOPDFPREVENTIVO.Text) & "|" & .Filter
                .FileName = System.IO.Path.GetFileNameWithoutExtension(txtPERCORSOPDFPREVENTIVO.Text)
            Else
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            End If
            .FilterIndex = 1
            .CheckFileExists = True
            .ShowReadOnly = False
            Select Case .ShowDialog
                Case Windows.Forms.DialogResult.OK
                    txtPERCORSOPDFPREVENTIVO.Text = .FileName
                Case Windows.Forms.DialogResult.Cancel
                    ' Nulla per ora
            End Select
            'Copia(.FileName, kPathDirectoryAllegati & "\\" & Now.Year & "_" & Now.Month & "_" & Now.Day & "_" & Now.Hour & "_" & Now.Minute & "_" & Now.Second & "_" & System.IO.Path.GetFileName(.FileName))
        End With
    End Sub

    Private Sub dgvReferenti_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReferenti.CellDoubleClick
        If FormMultiIstanzaSingola(fGestioneReferenti) Then Exit Sub
        Dim Proprieta() As String = Nothing
        Dim Valori() As Object = Nothing
        AggiungiProprieta("FormChiamante", Me, Proprieta, Valori)
        AggiungiProprieta("IDREFERENTE", dgvReferenti.SelectedRows(0).Cells("IDREFERENTE").Value, Proprieta, Valori)
        AggiungiForm(fGestioneReferenti, Proprieta, Valori)
    End Sub

    Private Sub dgvReferenti_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvReferenti.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                If ContaSQL("Referenti", "IDREFERENTE=" & dgvReferenti.SelectedRows(0).Cells("IDREFERENTE").Value) < 1 Then
                    MsgBox("Referente non trovato.", MsgBoxStyle.Information)
                    AggiornaReferenti()
                    Exit Sub
                End If
                If MsgBox("Sicuro di voler eliminare il referente selezionato?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Confermi?") = MsgBoxResult.No Then
                    Exit Sub
                End If
                MsgBox("Eliminati: " & QueryNumerico("UPDATE Referenti SET BOOELIMINATO=TRUE WHERE IDREFERENTE=" & dgvReferenti.SelectedRows(0).Cells("IDREFERENTE").Value) & " records.", MsgBoxStyle.Information)
                AggiornaReferenti()

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub btnAddReferenti_Click(sender As System.Object, e As System.EventArgs) Handles btnAddReferenti.Click
        If FormMultiIstanzaSingola(fGestioneReferenti) Then Exit Sub
        Dim Proprieta() As String = Nothing
        Dim Valori() As Object = Nothing
        AggiungiProprieta("FormChiamante", Me, Proprieta, Valori)
        AggiungiProprieta("IDREFERENTE", -1, Proprieta, Valori)
        AggiungiProprieta("CodiceCliente", txtCODICECLIENTE.Text, Proprieta, Valori)
        AggiungiForm(fGestioneReferenti, Proprieta, Valori)
    End Sub

    Private Sub btnEliminaUtente_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminaUtente.Click
        If MsgBox("L'azione che si sta per eseguire è irrevocabile, eseguirla comunque?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "Eseguire?") = MsgBoxResult.No Then Exit Sub
        If ConfermaAzione() Then
            If QueryNumerico("DELETE FROM Clienti WHERE CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text)) > 0 Then
                'NON POSSO FARE IL BOOELIMINATO!!
                MsgBox("Utente eliminato.", MsgBoxStyle.Information, "Azione eseguita con successo")
                fMain.tlsRicerca.Checked = True
                TabControl1.SelectedIndex = 0
                txtCODICECLIENTE.Focus()
            Else
                MsgBox("Errore nell'eliminazione dell'utente, si prega di riprovare...", MsgBoxStyle.Critical, "Errore eliminazione")
            End If
        Else
            MsgBox("Password errata!")
            Exit Sub
        End If
    End Sub

    Private Sub btnApriInTabella_Click(sender As System.Object, e As System.EventArgs) Handles btnApriInTabella.Click
        ' Evito duplicazione della form
        If FormMultiIstanzaSingola(fTabellaClienti) Then Exit Sub
        Dim Proprieta() As String = Nothing
        Dim Valori() As Object = Nothing
        AggiungiProprieta("SQL", RecordsLetti.SQL, Proprieta, Valori)
        ' Scrivere *NO* come nome del campo per renderlo nascosto
        AggiungiProprieta("Campi", "Codice Cliente|Provvisorio|Ex Cliente|Catalogo|Ragione Sociale|P.I. / C.F.|Indirizzo|Sede Alternativa|Provincia|Giornalino|Note|*NO*|Ultima Azione", Proprieta, Valori)
        AggiungiProprieta("Location", New Point(Me.Location.X + 10, Me.Location.Y + 10), Proprieta, Valori)
        AggiungiForm(fTabellaClienti, Proprieta, Valori)
    End Sub

    Private Sub txtPERCORSOPDFPREVENTIVO_DoubleClick(sender As Object, e As System.EventArgs) Handles txtPERCORSOPDFPREVENTIVO.DoubleClick
        btnSfogliaPreventivo.PerformClick()
    End Sub

    Private Sub txtPERCORSOPDFPREVENTIVO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPERCORSOPDFPREVENTIVO.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete, Keys.Back
                txtPERCORSOPDFPREVENTIVO.Text = vbNullString
        End Select
    End Sub

    Private Sub dgvOrdini_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrdini.CellDoubleClick
        On Error GoTo Fine
        txtIDORDINE.Text = dgvOrdini.Rows(e.RowIndex).Cells("IDORDINE").Value
        txtDTORDINE.Text = dgvOrdini.Rows(e.RowIndex).Cells("DTORDINE").Value
        txtNOTEORDINE.Text = Nz(dgvOrdini.Rows(e.RowIndex).Cells("NOTEORDINE").Value, vbNullString)
        txtCAUSALEORDINE.Text = dgvOrdini.Rows(e.RowIndex).Cells("CAUSALEORDINE").Value
        txtDESC_ORDINE.Text = dgvOrdini.Rows(e.RowIndex).Cells("DESC_ORDINE").Value
        grpOrdine.BringToFront()
Fine:
    End Sub

    Private Sub btnSalvaOrdine_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvaOrdine.Click
        On Error GoTo Fine
        Call txtCAUSALEORDINE_LostFocus(Nothing, Nothing)
        'Salvataggio della visita
        If Leftt(txtDESC_ORDINE.Text, 1) = kHash Then
            MsgBox("Inserire un codice ordine valido!")
            Exit Sub
        End If
        If ContaSQL("Ordini", "IDORDINE = " & txtIDORDINE.Text) < 1 Then
            'Inserisco
            MsgBox("Inseriti: " & QueryNumerico("INSERT INTO Ordini(CODICECLIENTE, DTORDINE, CAUSALEORDINE, NOTEORDINE) VALUES(" & Apici(txtCODICECLIENTE.Text) & ", " & DataADatabase(txtDTORDINE.Value) & ", " & Apici(txtCAUSALEORDINE.Text) & ", " & Apici(txtNOTEORDINE.Text) & ")") & " records.")
        Else
            'Aggiorno
            MsgBox("Aggiornati: " & QueryNumerico("UPDATE Ordini SET DTORDINE=" & DataADatabase(txtDTORDINE.Value) & ", CAUSALEORDINE=" & Apici(txtCAUSALEORDINE.Text) & ", NOTEORDINE=" & Apici(txtNOTEORDINE.Text) & " WHERE CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text) & " AND IDORDINE=" & txtIDORDINE.Text) & " records.")
        End If

        CaricaOrdini()
        btnTornaElencoOrdine.PerformClick()

        Exit Sub
Fine:
        MsgBox("Errore funzione SalvaOrdini")
        Exit Sub
    End Sub

    Private Sub txtCAUSALEORDINE_DoubleClick(sender As Object, e As System.EventArgs) Handles txtCAUSALEORDINE.DoubleClick
        If Me.Modalita <> EnumModalita.ModMod Then Exit Sub
        If FormMultiIstanzaSingola(fZoom) Then Exit Sub
        Dim f As New fZoom
        With f
            .MdiParent = kMainForm
            .TextBoxRitorno = txtDESC_ORDINE
            .FiltroAgg = kFiltroAgg
            .CampoDecodifica = "DESC_ORDINE"
            .NomeTabella = "CausaleOrdiniDescrizione"
            .CampoCodice = "CAUSALEORDINE"
            .Chiamante = txtCAUSALEORDINE
            .FormChiamante = Me
            Me.SceDati = EnumSceDati.SceZoom
            Me.Enabled = False
            .Show()
        End With
    End Sub

    Private Sub txtCAUSALEORDINE_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCAUSALEORDINE.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Call txtCAUSALEORDINE_DoubleClick(Nothing, Nothing)

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub txtCAUSALEORDINE_LostFocus(sender As Object, e As System.EventArgs) Handles txtCAUSALEORDINE.LostFocus
        txtDESC_ORDINE.Text = Controlla("DESC_ORDINE", "CausaleOrdiniDescrizione", "CAUSALEORDINE = " & Apici(txtCAUSALEORDINE.Text))
    End Sub

    Private Sub dgvOrdini_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvOrdini.KeyDown
        On Error GoTo Fine
        Select Case e.KeyCode
            Case Keys.Delete
                If dgvOrdini.SelectedRows.Count < 1 Then Exit Sub
                If MsgBox("Confermi eliminazione record?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "Eliminazione?") = MsgBoxResult.No Then
                    Exit Sub
                End If
                If QueryNumerico("UPDATE Ordini SET BOOELIMINATO=TRUE WHERE CODICECLIENTE=" & Apici(txtCODICECLIENTE.Text) & " AND IDORDINE=" & dgvOrdini.SelectedRows(0).Cells("IDORDINE").Value) > 0 Then MsgBox("Record eliminato con successo", MsgBoxStyle.Information, "Operazione eseguita")
                CaricaOrdini()
            Case Keys.Enter
                If dgvOrdini.SelectedRows.Count < 1 Then Exit Sub
                dgvOrdini_CellDoubleClick(sender, New DataGridViewCellEventArgs(dgvOrdini.SelectedCells(0).ColumnIndex, dgvOrdini.SelectedCells(0).RowIndex))

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
        Exit Sub
Fine:
        MsgBox("Errore sub dgvOrdini KeyDown", MsgBoxStyle.Critical)
        Exit Sub
    End Sub

    Private Sub btnNuovoOrdine_Click(sender As System.Object, e As System.EventArgs) Handles btnNuovoOrdine.Click
        txtDTORDINE.Text = vbNullString
        txtNOTEORDINE.Text = vbNullString
        txtCAUSALEORDINE.Text = vbNullString
        txtDESC_ORDINE.Text = vbNullString
        txtIDORDINE.Text = vbNullString
        grpOrdine.BringToFront()
    End Sub

End Class