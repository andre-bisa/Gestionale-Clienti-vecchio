Public Class fMain

    Private _OggettiInForm As Object() = Nothing

    Public booNonPulireForm As Boolean = False

    Private Property OggettiInForm As Object()
        Get
            If _OggettiInForm Is Nothing Then _OggettiInForm = OggettiInOggetto(Me)
            Return _OggettiInForm
        End Get
        Set(value As Object())
            _OggettiInForm = value
        End Set
    End Property




    Private Sub Main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' CONFERMA DI USCITA, REMMATO PER IL DEBUG!
        If ChiusuraForzata = False Then
            If (MsgBox("L'applicazione verrà terminata, procedere?", MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Chiudere?") = MsgBoxResult.No) Then
                e.Cancel = True
            End If
        End If
        Connessione.Close()
    End Sub

    Public Sub fMain_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        e.Handled = True
        With Me
            Select Case e.KeyCode
                Case Keys.PageUp ' Successivo / Ultimo Record
                    If (e.KeyCode And Not Keys.Modifiers) = Keys.PageUp AndAlso e.Modifiers = Keys.Control Then
                        ' Ctrl + PageUp
                        .tlsUltimoRecord.PerformClick()
                    Else
                        .tlsSuccessivo.PerformClick()
                    End If

                Case Keys.PageDown ' Precedente / Primo Record
                    If (e.KeyCode And Not Keys.Modifiers) = Keys.PageDown AndAlso e.Modifiers = Keys.Control Then
                        ' Ctrl + PageDown
                        .tlsPrimoRecord.PerformClick()
                    Else
                        .tlsPrecedente.PerformClick()
                    End If
                Case Keys.F12 ' OK
                    .tlsOK.PerformClick()
                Case Keys.F10 ' Annulla
                    .tlsAnnulla.PerformClick()
                Case Keys.R ' Modalità ricerca
                    If (e.KeyCode And Not Keys.Modifiers) = Keys.R AndAlso e.Modifiers = Keys.Control Then
                        ' Ctrl + R
                        tlsRicerca.PerformClick()
                    End If
                Case Keys.M ' Modalità modifica
                    If (e.KeyCode And Not Keys.Modifiers) = Keys.M AndAlso e.Modifiers = Keys.Control Then
                        ' Ctrl + M
                        tlsModifica.PerformClick()
                    End If
                Case Keys.I ' Modalità ricerca
                    If (e.KeyCode And Not Keys.Modifiers) = Keys.I AndAlso e.Modifiers = Keys.Control Then
                        ' Ctrl + I
                        tlsInserisci.PerformClick()
                    End If

                Case Else
                    e.Handled = False
            End Select
        End With
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Imposto il TimerAvvioForm, aggiungo l'Handler
        AddHandler mFunzioni.TimerAvvioForm.Tick, AddressOf Tick
        mFunzioni.TimerAvvioForm.Interval = 100

        Me.MainMenuStrip = Me.MenuStrip1
        Me.WindowState = FormWindowState.Maximized
        kMainForm = Me
        CheckConnessione() ' Controlla la connessione, se fallisce chiude l'applicazione
        ktlsToolStripDown = ToolStripDown
        ktlsMenuModifiche = tlsMenu
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
        AbilitaMenuModifica(False)
        mFunzioni.ktlsStato = Me.tlsStato
        CaricaTestoControlli(Me, OggettiInForm)
        Me.Text = My.Application.Info.Title & "  -  " & Application.ProductVersion
        CheckDirectories()
        'LeggiFileIni()
        Timer1.Start()
        AggiornaStato("Pronto")
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        tlsBLOCKMAIUSC.Enabled = Control.IsKeyLocked(Keys.CapsLock)
        tlsINS.Enabled = Control.IsKeyLocked(Keys.Insert)
        tlsOrario.Text = Format(Now.Hour, "00") & ":" & Format(Now.Minute, "00")
        tlsDate.Text = Date.Today.Day.ToString("00") & "/" & Date.Today.Month.ToString("00") & "/" & Date.Today.Year.ToString("0000")
        tlsChiudi.Visible = Not IsNothing(ActiveMdiChild)
    End Sub

    Private Sub tlsClienti_Click(sender As System.Object, e As System.EventArgs) Handles tlsClienti.Click
        AggiornaStato("Apertura form...")
        AggiungiForm(fClienti, {"Modalita"}, {EnumModalita.ModRic})
        AggiornaStato("Pronto")
    End Sub

    Private Sub tlsRicerca_CheckedChanged(sender As Object, e As System.EventArgs) Handles tlsRicerca.CheckedChanged
        If (tlsRicerca.Checked) Then
            tlsInserisci.Checked = False
            tlsModifica.Checked = False
            If Not IsNothing(Me.ActiveMdiChild) Then _
                If OttieniProprieta(Me.ActiveMdiChild, "Modalita") <> EnumModalita.ModRic Then _
                    CambiaProprieta(Me.ActiveMdiChild, "Modalita", EnumModalita.ModRic)
        End If
    End Sub

    Private Sub tlsModifica_CheckedChanged(sender As Object, e As System.EventArgs) Handles tlsModifica.CheckedChanged
        If (tlsModifica.Checked) Then
            tlsRicerca.Checked = False
            tlsInserisci.Checked = False
            If Not IsNothing(Me.ActiveMdiChild) Then _
                If OttieniProprieta(Me.ActiveMdiChild, "Modalita") <> EnumModalita.ModMod Then _
                    CambiaProprieta(Me.ActiveMdiChild, "Modalita", EnumModalita.ModMod)
        End If
    End Sub

    Private Sub tlsInserisci_CheckedChanged(sender As Object, e As System.EventArgs) Handles tlsInserisci.CheckedChanged
        If (tlsInserisci.Checked) Then
            tlsModifica.Checked = False
            tlsRicerca.Checked = False
            If Not IsNothing(Me.ActiveMdiChild) Then _
                If OttieniProprieta(Me.ActiveMdiChild, "Modalita") <> EnumModalita.ModIns Then _
                    CambiaProprieta(Me.ActiveMdiChild, "Modalita", EnumModalita.ModIns)
        End If
    End Sub

    Private Sub tlsOK_Click(sender As System.Object, e As System.EventArgs) Handles tlsOK.Click
        ' Al Click "OK" lancia la funzione TastoOK all'interno della form attiva
        Try
            If tlsOK.Enabled = False Then Exit Sub
            If Me.ActiveMdiChild Is Nothing Then Exit Sub
            'If (_Modalita <> EnumModalita.Modifica) Then tlsModifica.PerformClick()

            CambiaProprieta(Me.ActiveMdiChild, "SceDati", EnumSceDati.SceOK)

            'CambiaProprieta(Me.ActiveMdiChild, "Modalita", _Modalita)
            'Dim item As Object = Activator.CreateInstance(Type.GetType("Clienti." & Me.ActiveMdiChild.Name, True, True))
            'item.GetType().GetProperty("Modalita").SetValue(item, _Modalita, Nothing)
            'LanciaSub(Me.ActiveMdiChild.Name, "TastoOK", Parameters:={})
            'Dim Item As Object = Activator.CreateInstance(Type.GetType("Clienti." & Me.ActiveMdiChild.Name, True, True))
            'Item.GetType().GetMethod("TastoOK").Invoke(Item, parameters:={})
        Catch ex As Exception
            MsgBox("Errore nell'esecuzione del tasto OK." & vbNewLine & vbNewLine & "Errore: " & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub ChiudiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChiudiToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub tlsPrecedente_Click(sender As System.Object, e As System.EventArgs) Handles tlsPrecedente.Click
        Try
            If tlsPrecedente.Enabled = False Then Exit Sub
            If Me.ActiveMdiChild Is Nothing Then Exit Sub
            CambiaProprieta(Me.ActiveMdiChild, "SceDati", EnumSceDati.ScePrecedente)
        Catch ex As Exception
            MsgBox("Errore nell'esecuzione del tasto Precedente." & vbNewLine & vbNewLine & "Errore: " & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub tlsSuccessivo_Click(sender As System.Object, e As System.EventArgs) Handles tlsSuccessivo.Click
        Try
            If tlsSuccessivo.Enabled = False Then Exit Sub
            If Me.ActiveMdiChild Is Nothing Then Exit Sub
            CambiaProprieta(Me.ActiveMdiChild, "SceDati", EnumSceDati.SceSuccessivo)
        Catch ex As Exception
            MsgBox("Errore nell'esecuzione del tasto Precedente." & vbNewLine & vbNewLine & "Errore: " & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub tlsPrimoRecord_Click(sender As System.Object, e As System.EventArgs) Handles tlsPrimoRecord.Click
        Try
            If tlsPrimoRecord.Enabled = False Then Exit Sub
            If Me.ActiveMdiChild Is Nothing Then Exit Sub
            CambiaProprieta(Me.ActiveMdiChild, "SceDati", EnumSceDati.ScePrimoRecord)
        Catch ex As Exception
            MsgBox("Errore nell'esecuzione del tasto Precedente." & vbNewLine & vbNewLine & "Errore: " & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub tlsUltimoRecord_Click(sender As System.Object, e As System.EventArgs) Handles tlsUltimoRecord.Click
        Try
            If tlsUltimoRecord.Enabled = False Then Exit Sub
            If Me.ActiveMdiChild Is Nothing Then Exit Sub
            CambiaProprieta(Me.ActiveMdiChild, "SceDati", EnumSceDati.SceUltimoRecord)
        Catch ex As Exception
            MsgBox("Errore nell'esecuzione del tasto Precedente." & vbNewLine & vbNewLine & "Errore: " & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub tlsAnnulla_Click(sender As System.Object, e As System.EventArgs) Handles tlsAnnulla.Click
        Try
            If tlsAnnulla.Enabled = False Then Exit Sub
            If Me.ActiveMdiChild Is Nothing Then Exit Sub
            CambiaProprieta(Me.ActiveMdiChild, "SceDati", EnumSceDati.SceAnn)
        Catch ex As Exception
            MsgBox("Errore nell'esecuzione del tasto Precedente." & vbNewLine & vbNewLine & "Errore: " & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub tlsInserisci_Click(sender As System.Object, e As System.EventArgs) Handles tlsInserisci.Click
        If tlsInserisci.Checked = False Then tlsInserisci.Checked = True
    End Sub

    Private Sub tlsModifica_Click(sender As System.Object, e As System.EventArgs) Handles tlsModifica.Click
        If tlsModifica.Checked = False Then tlsModifica.Checked = True
    End Sub

    Private Sub tlsRicerca_Click(sender As System.Object, e As System.EventArgs) Handles tlsRicerca.Click
        If tlsRicerca.Checked = False Then tlsRicerca.Checked = True
    End Sub

    Private Sub OpzioniToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpzioniToolStripMenuItem.Click
        AggiornaStato("Apertura form...")
        AggiungiForm(fOpzioni)
        AggiornaStato("Pronto")
    End Sub

    Private Sub tlsChiudi_Click(sender As System.Object, e As System.EventArgs)
        On Error GoTo Fine
        LanciaSub(Me.ActiveMdiChild, "Close")
Fine:
    End Sub

    Private Sub RecuperoEliminatiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RecuperoEliminatiToolStripMenuItem.Click
        AggiornaStato("Apertura form...")
        AggiungiForm(OttieniForm("fRecuperoEliminati"))
        AggiornaStato("Pronto")
    End Sub

    Private Sub tlsChiudi_Click_1(sender As System.Object, e As System.EventArgs) Handles tlsChiudi.Click
        LanciaSub(Me.ActiveMdiChild, "Close")
    End Sub

    Private Sub tlsFatture_Click(sender As System.Object, e As System.EventArgs) Handles tlsFatture.Click
        MsgBox("Funzione non ancora attiva!", MsgBoxStyle.Information)
        Exit Sub
        AggiornaStato("Apertura form...")
        AggiungiForm(fFatture)
        AggiornaStato("Pronto")
    End Sub

    Private Sub NewsletterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewsletterToolStripMenuItem.Click
        AggiornaStato("Apertura form...")
        AggiungiForm(fNewsletter)
        AggiornaStato("Pronto")
    End Sub

    Private Sub GruppiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruppiToolStripMenuItem.Click
        AggiornaStato("Apertura form...")
        AggiungiForm(fGestioneGruppiMail)
        AggiornaStato("Pronto")
    End Sub

End Class