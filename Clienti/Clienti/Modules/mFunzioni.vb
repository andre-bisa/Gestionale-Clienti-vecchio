Imports Clienti.mDB
Imports Clienti.mFileINI

Module mFunzioni

    'User e password di liberomail
    Public Const KMAILLIBERO = "daniela.lovi@libero.it"
    Public Const KUSERLIBERO = KMAILLIBERO
    Public Const KPASSLIBERO = "DALOANBI"
    Public Const KSERVERSMTPLIBERO = "smtp.libero.it"
    Public Const KPORTASMTPLIBERO As Integer = 25


    Public OpzioniBisa As New cOpzioniBisa

    Public kMainForm As Form
    Public ktlsStato As ToolStripLabel
    Public ktlsToolStripDown As ToolStrip
    Public ktlsMenuModifiche As ToolStrip

    ' PROPRIETA' NAME DEGLI OGGETTI NEL MENU' ALTO
    Public Const kNometlsInserisci = "tlsInserisci"
    Public Const kNometlsModifica = "tlsModifica"
    Public Const kNometlsRicerca = "tlsRicerca"

    Public ChiusuraForzata As Boolean = False

    Public kBackColorDefault As Color = Color.White   ' Colore di sfondo predefinito

    Public Const kHash As String = "#"
    Public Const kLikeOperator As String = "%"    ' % in SQL, * in Access

    ' -------------   COSTANTI TAG   -------------
    ' INSERISCI (1°) MODIFICA (2°) RICERCA (3°)
    ' 4°: (O) Obbligatorio / (V) Invisibile

    Public Const kTagAttivo = "+"              ' Attivo nelle modalità
    Public Const kTagDisattivo = "-"           ' Disattivo nelle modalità
    Public Const kTagObbligatorio = "O"        ' Obbligatorio come 4° posizione

    Public Const kTagTabPage = "P"             ' TabPage
    Public Const kTagProgressBar = "B"         ' ProgressBar
    Public Const kTagTextBox = "T"             ' TextBox
    Public Const kTagDataGridView = "D"        ' DataGridView
    Public Const kTagCheckAtt = "C"            ' CheckBox Default: True
    Public Const kTagCheckDisatt = "F"         ' CheckBox Default: False
    Public Const kTagGroupBox = "G"            ' GroupBox
    Public Const kTagLabel = "L"               ' Label
    Public Const kTagJolly = "N"               ' Tag jolly per attivare e disattivare campi

    Public Const kTagInvisibile = "V"          ' Invisibile, si gestisce con il + e - a seconda della modalità e si mette come 4° carattere

    Public mUtente As New cUtente

    Public Function MD5(ByVal testo As String) As String
        Dim hasher As System.Security.Cryptography.MD5 = System.Security.Cryptography.MD5.Create
        Dim dbytes As Byte() = hasher.ComputeHash(System.Text.Encoding.UTF8.GetBytes(testo))
        Dim builder As New System.Text.StringBuilder()
        For n As Integer = 0 To dbytes.Length - 1
            builder.Append(dbytes(n).ToString("X2"))
        Next n
        MD5 = builder.ToString
    End Function

    Public Function Copia(ByVal PercorsoDA As String, ByVal PercorsoA As String, Optional ByVal SostituzioneForzata As Boolean = True) As Boolean
        On Error GoTo Fine
        Copia = True
        System.IO.File.Copy(PercorsoDA, PercorsoA, SostituzioneForzata)
        Exit Function
Fine:
        Copia = False
    End Function

    Public Function SostituisciTutti(ByVal str As String, ByVal cosa As String, ByVal concosa As String) As String
        SostituisciTutti = Replace(str, cosa, concosa)
    End Function

    Public Function Apici(ByVal testo As String) As String
        Apici = "'" & Trim(SostituisciTutti(testo, "'", "''")) & "'"
    End Function

    Public Function ConfermaAzione(Optional ByVal Avviso As String = vbNullString) As Boolean
        ConfermaAzione = False
        Dim f As New fConfermaAzione
        f.TestoAggiuntivo = Avviso
        ConfermaAzione = (f.ShowDialog = DialogResult.Yes)
    End Function


    Public Sub RiempiCampiDaRicercaQuery(ByVal form As Form, ByVal letto As OdbcDataReader, Optional Oggetti() As Object = Nothing)
        On Error Resume Next
        AggiornaStato("Riempimento form in corso...")
        kMainForm.Cursor = Cursors.WaitCursor
        If IsNothing(letto) Then Exit Sub
        If (Oggetti Is Nothing) Then OggettiInOggetto(form)
        AggiornaStato(".", True)
        For i As Integer = 0 To (letto.FieldCount - 1) Step 1
            For Each c As Control In Oggetti
                If (letto.GetName(i) = Right(c.Name, c.Name.Length - 3)) Then
                    Select Case Leftt(c.Tag, 1)
                        Case kTagTextBox
                            c.Text = Nz(letto.Item(i), "")
                        Case kTagCheckDisatt, kTagCheckAtt
                            TryCast(c, CheckBox).Checked = Nz(letto.Item(i), IIf(Leftt(c.Tag, 1) = kTagCheckAtt, True, False))

                        Case Else ' Altrimenti faccio la ricerca per tipo
                            Select Case c.GetType.ToString
                                Case "System.Windows.Forms.CheckBox"
                                    TryCast(c, CheckBox).Checked = Nz(letto.Item(i), IIf(Leftt(c.Tag, 1) = kTagCheckAtt, True, False))

                                Case "System.Windows.Forms.TextBox"
                                    c.Text = letto.Item(i)

                                Case Else
                            End Select
                    End Select

                    Exit For
                End If
                Application.DoEvents()
            Next c
        Next i
        kMainForm.Cursor = Cursors.Default
    End Sub

    Public Sub CaricaControlli(ByVal f As Form, ByVal Modo As EnumModalita, Optional ByVal Oggetti() As Object = Nothing)
        On Error GoTo Fine
        AggiornaStato("Caricamento oggetti...")
        Dim posizione As Integer = 0 ' Mostra la posizione del tag
        ' Tracciato:
        ' 1°: Tipo Tag
        ' 2°: Inserimento (+/-)
        ' 3°: Modifica (+/-)
        ' 4°: Ricerca (+/-)
        ' 5°: Obbligatorio / Visibile
        ' 6°: Manuale (+/-)
        Select Case Modo
            Case EnumModalita.ModIns
                posizione = 2
            Case EnumModalita.ModMod
                posizione = 3
            Case EnumModalita.ModRic
                posizione = 4
        End Select
        On Error Resume Next
        kMainForm.UseWaitCursor = True
        If Oggetti Is Nothing Then Oggetti = OggettiInOggetto(f)
        For Each ctrl As Control In Oggetti
            Application.DoEvents()
            AggiornaStato(".", True)
            If (ctrl.Tag Is Nothing) Or (ctrl.Tag = "") Then Continue For
            On Error GoTo Salta
            ctrl.BackColor = kBackColorDefault
            Select Case ctrl.Tag.ToString.Substring(0, 1)
                Case kTagCheckAtt, kTagCheckDisatt, kTagTabPage, kTagLabel, kTagGroupBox, kTagJolly
                    ImpostaSfondo(OttieniProprieta(f, "Modalita"), ctrl)
                Case kTagTextBox
                    If Len(ctrl.Tag) < posizione Then
                        ImpostaSfondo(OttieniProprieta(f, "Modalita"), ctrl)
                    End If
            End Select
Salta:
            On Error Resume Next
            If Len(ctrl.Tag.ToString) < posizione Then Continue For
            ctrl.Enabled = (ctrl.Tag.ToString.Substring(posizione - 1, 1) = kTagAttivo)
            If ctrl.Enabled = False Then ImpostaSfondo(OttieniProprieta(f, "Modalita"), ctrl)
        Next
        On Error GoTo Salta2
        Select Case OttieniProprieta(f, "Modalita")
            Case EnumModalita.ModIns
                f.BackColor = OpzioniBisa.ColoreInserimento
            Case EnumModalita.ModMod
                f.BackColor = OpzioniBisa.ColoreModifica
            Case EnumModalita.ModRic
                f.BackColor = OpzioniBisa.ColoreRicerca
            Case Else
                f.BackColor = Color.FromName("Control")
        End Select
        Application.DoEvents()
Salta2:
        On Error GoTo Fine
Fine:
        kMainForm.UseWaitCursor = False
        AggiornaStato("Pronto")
    End Sub

    Private Sub ImpostaSfondo(ByVal Modalita As EnumModalita, ctrl As Control)
        Select Case Modalita
            Case EnumModalita.ModIns
                ctrl.BackColor = OpzioniBisa.ColoreInserimento
            Case EnumModalita.ModMod
                ctrl.BackColor = OpzioniBisa.ColoreModifica
            Case EnumModalita.ModRic
                ctrl.BackColor = OpzioniBisa.ColoreRicerca
            Case Else
                ctrl.BackColor = Color.FromName("Control")
        End Select
    End Sub

    Public Function OggettiInOggetto(ByVal Oggetto As Object) As Object()
        ' 
        ' FUNZIONE CHE PASSANDO UN OGGETTO (FORM, TABCONTROL ECC) RESTITUISCE TUTTI GLI OGGETTI AL SUO INTERNO
        ' 
        OggettiInOggetto = Nothing
        On Error Resume Next
        AggiornaStato("Caricamento controlli in corso ...")
        kMainForm.Cursor = Cursors.WaitCursor
        If (Oggetto Is Nothing) Then Exit Function
        Dim RetObj As New ArrayList
        Dim Elenco As String() = {"TabControl", "TabPage", "GroupBox", "ToolStrip", "MenuStrip"}
        Dim ArrObj As Control.ControlCollection = Nothing
        ArrObj = Oggetto.Controls.Items
        If (ArrObj Is Nothing) Then ArrObj = Oggetto.Controls
        For Each obj As Object In ArrObj
            AggiornaStato(".", True)
            RetObj.Add(obj)
            If (Elenco.Contains(obj.GetType.Name)) Then RetObj.AddRange(OggettiInOggetto(obj))
            Application.DoEvents()
        Next
        kMainForm.Cursor = Cursors.Default
        Return RetObj.ToArray
    End Function

    Private Sub ScriviTestoControlli(ByVal Obj As Object, ByVal letto As OdbcDataReader)
        On Error Resume Next
        If (Obj Is Nothing) Then Exit Sub
        With letto
            If (Obj.Name = .Item("NomeControllo")) Then
                Obj.Visible = .Item("AttivoControllo")
                Obj.Text = .Item("TestoControllo")
            End If
        End With
    End Sub

    Public Sub RiempiListaDaDB(ByVal lista As ComboBox, ByVal letto As OdbcDataReader, ByRef codifica() As String)
        On Error GoTo Err
        kMainForm.Cursor = Cursors.WaitCursor
        lista.Items.Clear()
        AggiornaStato("Riempimento in corso...")
        While letto.Read()
            AggiornaStato(".", True)
            lista.Items.Add(letto.Item(1).ToString)
            If codifica Is Nothing Then
                ReDim codifica(0)
            Else
                ReDim Preserve codifica(codifica.Count)
            End If
            codifica(codifica.Count - 1) = letto.Item(0).ToString
        End While
        GoTo Ext
Err:
        MsgBox("Errore riempimento lista " & Apici(lista.Name) & vbNewLine, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        lista.Items.Clear()
Ext:
        kMainForm.Cursor = Cursors.Default
        AggiornaStato("Lista riempita")
        Exit Sub
    End Sub

    Public Sub RiempiColonneDaDB(ByVal DataGrid As DataGridView, ByVal letto As OdbcDataReader)
        On Error GoTo Err
        kMainForm.Cursor = Cursors.WaitCursor
        DataGrid.Rows.Clear()
        AggiornaStato("Riempimento in corso...")
        While letto.Read()
            AggiornaStato(".", True)
            DataGrid.Rows.Add()
            On Error Resume Next
            For Each cell As DataGridViewCell In DataGrid.Rows(DataGrid.Rows.Count - 1).Cells
                If cell.GetType.ToString = "System.Windows.Forms.DataGridViewButtonCell" Then Continue For
                If cell.GetType.ToString = "System.Windows.Froms.DataGridViewImageCell" Then Continue For

                cell.Value = letto.Item(DataGrid.Columns(cell.ColumnIndex).Name)
                'REMMATO IL 30/08 PER SCRIVERE ANCHE LE ORE ED I MINUTI
                'If IsDate(cell.Value) Then cell.Value = Convert.ToDateTime(cell.Value).ToShortDateString
                ' Application.DoEvents()
            Next
            On Error GoTo Err
        End While
        GoTo Ext
Err:
        MsgBox("Errore riempimento tabella " & Apici(DataGrid.Name) & vbNewLine, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        DataGrid.Rows.Clear()
Ext:
        kMainForm.Cursor = Cursors.Default
        AggiornaStato("Tabella riempita")
        Exit Sub
    End Sub

    Public Sub CaricaTestoControlli(ByVal Form As Form, Optional ByVal Oggetti() As Object = Nothing)
        On Error GoTo Err
        AggiornaStato("Caricamento controlli")
        kMainForm.Cursor = Cursors.WaitCursor
        Dim letto As OdbcDataReader = QueryLeggi("SELECT NOMECONTROLLO, TESTOCONTROLLO, TIPOCAMPO, ATTIVOCONTROLLO", "FROM Controlli", "INNER JOIN TipoControlliDecodifica ON Controlli.TIPOCONTROLLO = TipoControlliDecodifica.TIPOCONTROLLO", "WHERE FORM = " & Apici(Form.Name))
        If IsNothing(letto) Then GoTo Err
        ' Inizio a controllare gli elementi
        If letto.IsClosed = True Then GoTo Err
        While letto.Read()
            AggiornaStato(".", True)
            ' Controllo la form prima di tutto
            If (letto.Item("NomeControllo") = Form.Name) Then
                Form.Text = letto.Item("TestoControllo")
                Continue While
            End If
            If Oggetti Is Nothing Then Oggetti = OggettiInOggetto(Form)
            For Each obj As Object In Oggetti
                ScriviTestoControlli(obj, letto)
                Application.DoEvents()
            Next
        End While
        AggiornaStato("Controlli caricati con successo")
Err:
        kMainForm.Cursor = Cursors.Default
        Exit Sub
    End Sub

    Public Function OttieniForm(ByVal NomeForm As String) As Form
        On Error GoTo Err
        Dim Tipo As Type
        Dim NomeFormCompleto As String
        NomeFormCompleto = My.Application.Info.AssemblyName & "." & NomeForm
        Tipo = Type.GetType(NomeFormCompleto, True, True)
        OttieniForm = CType(Activator.CreateInstance(Tipo), Form)
        Exit Function
Err:
        MsgBox("Errore, form inesistente nel progetto!", MsgBoxStyle.Critical)
        Return Nothing
    End Function

    Public Function FormMultiIstanzaSingola(ByVal classe As Object) As Boolean
        On Error GoTo Err
        FormMultiIstanzaSingola = False
        For Each form As Form In kMainForm.MdiChildren
            If (form.GetType.ToString = classe.GetType.ToString) Then
                FormMultiIstanzaSingola = True
                form.BringToFront()
                form.Focus()
                Exit For
            End If
        Next
        Exit Function
Err:
        FormMultiIstanzaSingola = True
    End Function

    Public Function ApriProgress(ByVal max As Integer) As fProgress
        ApriProgress = fProgress
        fProgress.Show()
        fProgress.Max = max
        fProgress.Focus()
    End Function

    Public Sub ChiudiProgress(ByVal progress As fProgress)
        progress.Close()
    End Sub

    Public Sub AggiungiForm(ByVal Form As Form, Optional ByVal Proprieta() As String = Nothing, Optional ByVal Valori() As Object = Nothing)
        On Error GoTo Err
        If Not IsNothing(Proprieta) And Not IsNothing(Valori) Then
            If Proprieta.Length <> Valori.Length Then
                Proprieta = Nothing
                Valori = Nothing
            End If
        End If

        ' Evito duplicati
        If FormMultiIstanzaSingola(Form) Then Exit Sub
        Form.MdiParent = kMainForm

        If Not IsNothing(Proprieta) And Not IsNothing(Valori) Then
            For i As Integer = 1 To Proprieta.Length Step 1
                CambiaProprieta(Form, Proprieta(i - 1), Valori(i - 1))
            Next
        End If

        Form.Show()
        Form.Focus()
        Exit Sub
Err:
        MsgBox("Errore funzione AggiungiForm." & vbNewLine & "Impossibile aprire la form richiesta.", MsgBoxStyle.Critical)
        Exit Sub
    End Sub

    Public Sub AggiungiProprieta(ByVal Proprieta As String, ByVal Valore As Object, ByRef ArrayProprieta() As String, ByRef ArrayValori() As Object)
        If IsNothing(ArrayProprieta) Then
            ReDim ArrayProprieta(0)
            ArrayProprieta(0) = Proprieta
            ReDim ArrayValori(0)
            ArrayValori(0) = Valore
        Else
            ReDim Preserve ArrayProprieta(ArrayProprieta.Count)
            ArrayProprieta(ArrayProprieta.Count - 1) = Proprieta
            ReDim Preserve ArrayValori(ArrayValori.Count)
            ArrayValori(ArrayValori.Count - 1) = Valore
        End If
    End Sub

    Public Sub AggiornaStato(ByVal Stato As String, Optional ByVal Concatena As Boolean = False)
        If Concatena Then
            ktlsStato.Text = ktlsStato.Text & Stato
        Else
            ktlsStato.Text = Stato
        End If
        Application.DoEvents()
    End Sub

    Public Sub LanciaSub(ByVal Form As Form, ByVal Metodo As String, Optional ByVal Parameters() As Object = Nothing)
        Form.GetType().GetMethod(Metodo).Invoke(Form, Parameters)
    End Sub

    Public Sub CambiaProprieta(ByVal form As Form, ByVal proprieta As String, ByVal valore As Object, Optional ByVal Indice() As Object = Nothing)
        Try
            form.GetType().GetProperty(proprieta).SetValue(form, valore, Indice)
        Catch ex As Exception
        End Try
    End Sub

    Public Function OttieniProprieta(ByVal f As Form, ByVal proprieta As String, Optional ByVal indice() As Object = Nothing) As Object
        Try
            OttieniProprieta = f.GetType().GetProperty(proprieta).GetValue(f, indice)
        Catch ex As Exception
            OttieniProprieta = Nothing
        End Try
    End Function

    Public Function Leftt(ByVal str As String, ByVal pos As Integer) As String
        Leftt = Microsoft.VisualBasic.Left(str, pos)
    End Function

    Public Function Rightt(ByVal str As String, ByVal pos As Integer) As String
        Rightt = Microsoft.VisualBasic.Right(str, pos)
    End Function

    Public Function Nz(ByVal Controlla As Object, ByVal Altrimenti As String) As String
        Nz = IIf(IsDBNull(Controlla), Altrimenti, Controlla)
    End Function

    Public Sub AbilitaMainMenuDaModalita(ByVal Modalita As EnumModalita, ByVal SceDati As EnumSceDati)
        Select Case SceDati
            Case EnumSceDati.SceZoom
                AbilitaMenuModifica(False)
                AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
                Exit Sub

            Case Else
        End Select

        Select Case Modalita
            Case EnumModalita.ModIns
                AbilitaMenuModifica(True)
                fMain.tlsInserisci.Checked = True
                AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
            Case EnumModalita.ModRic
                AbilitaMenuModifica(True)
                fMain.tlsRicerca.Checked = True
                AbilitaMainMenuSotto({EnumMainMenuSotto.OK, EnumMainMenuSotto.Ordinamento})
            Case EnumModalita.ModMod
                AbilitaMenuModifica(True)
                fMain.tlsModifica.Checked = True
                AbilitaMainMenuSotto(EnumMainMenuSotto.Tutto)
        End Select
    End Sub

    Public Sub AbilitaMainMenuSotto(ByVal Cosa() As EnumMainMenuSotto)
        On Error Resume Next
        ' Disabilito tutto
        For Each c As ToolStripItem In ktlsToolStripDown.Items
            c.Enabled = False
        Next

        For Each cs As EnumMainMenuSotto In Cosa
            Dim RicercaTag As String = vbNullString
            Dim flgTutti As Boolean = False

            Select Case cs
                Case EnumMainMenuSotto.Tutto
                    flgTutti = True
                Case EnumMainMenuSotto.Niente
                    flgTutti = False
                Case EnumMainMenuSotto.OK
                    RicercaTag = "OK"
                Case EnumMainMenuSotto.Records
                    RicercaTag = "R"
                Case EnumMainMenuSotto.Annulla
                    RicercaTag = "A"
                Case EnumMainMenuSotto.Ordinamento
                    RicercaTag = "ORD"
                Case Else
                    'MsgBox("Errore attivazione menu basso", vbCritical)
            End Select
            ' Evito che ci passi con Niente
            If flgTutti = False And RicercaTag = vbNullString Then Continue For
            For Each c As ToolStripItem In ktlsToolStripDown.Items
                If c.Tag Is Nothing Then Continue For
                'If c.Tag = "ORD" Then
                'c.Enabled = True
                'Continue For
                'End If
                If flgTutti Then
                    c.Enabled = True
                    Continue For
                Else
                    If c.Tag = RicercaTag Then c.Enabled = True
                End If
            Next c
        Next cs
    End Sub

    Public Sub AbilitaMainMenuSotto(ByVal Cosa As EnumMainMenuSotto) ' Overflow per abilitare anche solo 1 dato
        AbilitaMainMenuSotto({Cosa})
    End Sub

    Public Sub AbilitaMenuModifica(ByVal Flag As Boolean)
        For Each o As ToolStripButton In ktlsMenuModifiche.Items
            If o.Tag = "K" Then Continue For
            o.Enabled = Flag
            If (Flag = False) Then o.Checked = False
        Next o
    End Sub

#Region "Esegui Istruzioni Avvio Form"
    Public TimerAvvioForm As New Timer
    Dim Actions() As Action = Nothing
    Dim flgActionsParallelo As Boolean = False

    Public Sub EseguiAvvioForm(ParamArray Actions() As Action)
        mFunzioni.Actions = Actions
        flgActionsParallelo = False
        TimerAvvioForm.Start()
    End Sub

    Public Sub EseguiAvvioForm(ByVal flgParallelo As Boolean, ParamArray actions() As Action)
        mFunzioni.Actions = actions
        flgActionsParallelo = flgParallelo
        TimerAvvioForm.Start()
    End Sub

    Public Sub EseguiAvvioForm(ByVal intervallo As UInteger, ByVal flgParallelo As Boolean, ParamArray actions() As Action)
        mFunzioni.Actions = actions
        flgActionsParallelo = flgParallelo
        TimerAvvioForm.Interval = intervallo
        TimerAvvioForm.Start()
    End Sub

    Public Sub Tick()
        TimerAvvioForm.Stop()
        If flgActionsParallelo Then ' le eseguo in parallelo
            Threading.Tasks.Parallel.Invoke(mFunzioni.Actions)
        Else ' se non in parallelo le faccio una ad una
            For Each action As Action In mFunzioni.Actions
                action.Invoke()
            Next action
        End If
        mFunzioni.Actions = Nothing
        TimerAvvioForm.Interval = 100
    End Sub
#End Region

#Region "Ordina Per"
    'Creo le sub per permettere l'ordinamento nelle ricerche
    Private Sub EventoToolStripMenuItemClick(sender As Object, e As EventArgs)
        Try
            CambiaProprieta(fMain.ActiveMdiChild, "OrdinaPer", TryCast(sender, ToolStripMenuItem).Tag)
            SelezionaOrdinaPer(TryCast(sender, ToolStripMenuItem).Tag)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub AggiungiOrdinaPer(ByVal TestoDaVisualizzare As String, ByVal NomeCampo As String, Optional ByVal Selezionato As Boolean = False)
        Dim tls As New ToolStripMenuItem
        AddHandler tls.Click, AddressOf EventoToolStripMenuItemClick
        tls.Name = "OrdinaPerToolStripMenuItem" & NomeCampo
        tls.Text = TestoDaVisualizzare
        tls.Tag = NomeCampo
        tls.CheckOnClick = False
        tls.Checked = Selezionato
        fMain.OrdinaPerToolStripMenuItem.DropDownItems.Add(tls)

        Dim tls2 As New ToolStripMenuItem
        AddHandler tls2.Click, AddressOf EventoToolStripMenuItemClick
        tls2.Name = "OrdinaPerToolStripMenuItemDown" & NomeCampo
        tls2.Text = TestoDaVisualizzare
        tls2.Tag = NomeCampo
        tls2.CheckOnClick = False
        tls2.Checked = Selezionato
        fMain.ToolStripSplitOrdinamento.DropDownItems.Add(tls2)

        AttivaOrdinaPer(True)
    End Sub

    Public Sub SvuotaOrdinaPer()
        fMain.OrdinaPerToolStripMenuItem.DropDownItems.Clear()
        fMain.ToolStripSplitOrdinamento.DropDownItems.Clear()
        AttivaOrdinaPer(False)
    End Sub

    Public Sub AggiungiOrdinaPer(ByVal Espressione As String)
        ' STRUTTURA:
        ' Testo da visualizzare|NOMECAMPO|Testo da visualizzare2|NOMECAMPO2 ecc....
        For i As Integer = 0 To (Split(Espressione, "|").Count \ 2 - 1) Step 1
            AggiungiOrdinaPer(Split(Espressione, "|")(i * 2), Split(Espressione, "|")(i * 2 + 1))
        Next
    End Sub

    Public Sub AttivaOrdinaPer(ByVal Attiva As Boolean)
        fMain.OrdinaPerToolStripMenuItem.Visible = Attiva
        fMain.ToolStripSplitOrdinamento.Visible = Attiva
        fMain.ToolStripSeparator4.Visible = Attiva
    End Sub

    Public Sub SelezionaOrdinaPer(ByVal OrdinaPer As String)
        AttivaOrdinaPer(True)
        For Each tls As ToolStripMenuItem In fMain.OrdinaPerToolStripMenuItem.DropDownItems
            If tls.Tag = OrdinaPer Then
                tls.Checked = True
            Else
                tls.Checked = False
            End If
        Next
        For Each tls As ToolStripMenuItem In fMain.ToolStripSplitOrdinamento.DropDownItems
            If tls.Tag = OrdinaPer Then
                tls.Checked = True
            Else
                tls.Checked = False
            End If
        Next
    End Sub

    Public Sub SelezionaCrescenteDecrescente(ByVal Ordina As String)
        For Each tls As ToolStripMenuItem In fMain.ToolStripSplitCrescenteDecrescente.DropDownItems
            If tls.Tag = Ordina Then
                tls.Checked = True
            Else
                tls.Checked = False
            End If
        Next tls

        For Each tls As ToolStripMenuItem In fMain.OrdinaToolStripMenuItem.DropDownItems
            If tls.Tag = Ordina Then
                tls.Checked = True
            Else
                tls.Checked = False
            End If
        Next tls

        CambiaProprieta(fMain.ActiveMdiChild, "Ordina", Ordina)
    End Sub

    Public Sub AbilitaOrdinamentoCrescenteDecrescente(ByVal Flag As Boolean)
        Const kDefaultSelectedValue = "ASC" ' Variabile che definisce il valore di default

        AddHandler fMain.CrescenteToolStripMenuItem.Click, AddressOf EventoToolStripCrescenteDecrescenteMenuItemCheckedChanged
        AddHandler fMain.DecrescenteToolStripMenuItem.Click, AddressOf EventoToolStripCrescenteDecrescenteMenuItemCheckedChanged
        AddHandler fMain.CrescenteToolStripMenuItemUp.Click, AddressOf EventoToolStripCrescenteDecrescenteMenuItemCheckedChanged
        AddHandler fMain.DecrescenteToolStripMenuItemUp.Click, AddressOf EventoToolStripCrescenteDecrescenteMenuItemCheckedChanged

        fMain.ToolStripSplitCrescenteDecrescente.Visible = Flag
        fMain.OrdinaToolStripMenuItem.Visible = Flag

        SelezionaCrescenteDecrescente(kDefaultSelectedValue)
    End Sub

    Private Sub EventoToolStripCrescenteDecrescenteMenuItemCheckedChanged(sender As Object, e As EventArgs)
        Try
            TryCast(sender, ToolStripMenuItem).Checked = True
            'CambiaProprieta(fMain.ActiveMdiChild, "Ordina", TryCast(sender, ToolStripMenuItem).Tag)
            SelezionaCrescenteDecrescente(TryCast(sender, ToolStripMenuItem).Tag)
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Inviare E-Mail"
    Public Enum EnumInviaMail
        Inviata
        NonInviata
        DestinatarioNullo
    End Enum

    Public Enum EnumInviaMultiMail
        Inviate
        Errori
        NessunDestinatario
    End Enum

    Public Function InviaMultiMail(ByVal oggetto As String, ByVal corpo As String, ByVal destinatari() As String, Optional ByVal Priorita As Net.Mail.MailPriority = Net.Mail.MailPriority.Normal) As EnumInviaMultiMail
        If destinatari.Count = 0 Then ' controllo di aver inserito almeno un destinatario
            MsgBox("Errore, selezionare almeno un destinatario", MsgBoxStyle.Exclamation, "Errore")
            Return EnumInviaMultiMail.NessunDestinatario
        End If

        Dim ErroriDestinatari() As String = {} ' mail dove si è generato un errore

        AggiornaStato("Inizio invio mail...")
        Dim progress As fProgress = ApriProgress(destinatari.Count)
        Dim i As Integer = 0
        For Each destinatario As String In destinatari
            i += 1
            progress.Progress.Value += 1
            AggiornaStato("Mail " & i & "/" & destinatari.Count)
            Select Case InviaMail(oggetto, corpo, destinatario)
                Case EnumInviaMail.Inviata

                Case EnumInviaMail.NonInviata
                    ReDim Preserve ErroriDestinatari(ErroriDestinatari.Count)
                    ErroriDestinatari(ErroriDestinatari.Count - 1) = destinatario

                Case EnumInviaMail.DestinatarioNullo

            End Select
        Next destinatario
        ChiudiProgress(progress)
        AggiornaStato("Pronto")

        InviaMultiMail = EnumInviaMultiMail.Inviate

        If ErroriDestinatari.Count > 0 Then
            InviaMultiMail = EnumInviaMultiMail.Errori
            Dim messaggio As String = "Errore invio mail a: " & vbNewLine
            For Each errore In ErroriDestinatari
                messaggio &= "- " & errore & vbNewLine
            Next errore
            MsgBox(messaggio, MsgBoxStyle.Critical, "Errore invio mail")
        End If

    End Function

    Public Function InviaMail(ByVal oggetto As String, ByVal corpo As String, ByVal destinatario As String, Optional ByVal Priorita As Net.Mail.MailPriority = Net.Mail.MailPriority.Normal) As EnumInviaMail
        If destinatario = vbNullString Then
            MsgBox("Errore, selezionare un destinatario", MsgBoxStyle.Critical, "Errore")
            Return EnumInviaMail.DestinatarioNullo
        End If

        Dim client As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient(KSERVERSMTPLIBERO)

        client.EnableSsl = True
        client.Port = KPORTASMTPLIBERO
        ' user e password di libero!
        client.Credentials = New System.Net.NetworkCredential(KUSERLIBERO, KPASSLIBERO)

        Dim msg As New System.Net.Mail.MailMessage
        msg.DeliveryNotificationOptions = Net.Mail.DeliveryNotificationOptions.OnFailure
        msg.Subject = oggetto
        msg.IsBodyHtml = True
        msg.Body = corpo
        msg.Priority = Priorita
        msg.From = New System.Net.Mail.MailAddress(KMAILLIBERO)
        msg.Bcc.Add(destinatario)
        Try
            client.Send(msg)
        Catch ex As System.Net.Mail.SmtpFailedRecipientException
            Return EnumInviaMail.NonInviata
        End Try
        Return EnumInviaMail.Inviata
    End Function
#End Region

End Module