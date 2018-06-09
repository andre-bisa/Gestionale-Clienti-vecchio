Imports Clienti.mFunzioni

Public Class fOpzioni

    Private _SceDati As EnumSceDati

    Public Property SceDati As EnumSceDati
        Get
            Return _SceDati
        End Get
        Set(value As EnumSceDati)
            _SceDati = value

            Select Case _SceDati
                Case EnumSceDati.SceOK
                    If MsgBox("Confermi salvataggio impostazioni?", MsgBoxStyle.Information + MsgBoxStyle.YesNo + vbDefaultButton1, "Confermare?") = MsgBoxResult.Yes Then SalvaImpostazioni()
                Case Else
            End Select
        End Set
    End Property

    Private Sub SalvaImpostazioni()
        ' Colori
        OpzioniBisa.ColoreInserimento = lblCOLOREINSERIMENTO.BackColor
        OpzioniBisa.ColoreModifica = lblCOLOREMODIFICA.BackColor
        OpzioniBisa.ColoreRicerca = lblCOLORERICERCA.BackColor

        ' Accesso
        OpzioniBisa.ComboAccesso = cmbAccesso.SelectedIndex
        OpzioniBisa.AutoLogin = (chkautologin.Checked And cmbAccesso.SelectedIndex = EnumComboAccesso.UserEPassword)
        ' User & Password
        mUtente.USERNAME = mUtente.USERNAME
        mUtente.PASSWORD = mUtente.PASSWORD

        ' SALVO
        SalvaFileIni()
    End Sub

    Private Sub CaricaImpostazioni()
        ' Carico Colori
        lblCOLOREINSERIMENTO.BackColor = OpzioniBisa.ColoreInserimento
        lblCOLOREMODIFICA.BackColor = OpzioniBisa.ColoreModifica
        lblCOLORERICERCA.BackColor = OpzioniBisa.ColoreRicerca

        ' Accesso
        cmbAccesso.SelectedIndex = OpzioniBisa.ComboAccesso
        chkautologin.Enabled = (cmbAccesso.SelectedIndex = EnumComboAccesso.UserEPassword)
        chkautologin.Checked = OpzioniBisa.AutoLogin
    End Sub

    Private Sub CaricaUtenti()
        On Error GoTo Err
        AggiornaStato("Caricamento tabella utenti...")
        Dim letto As OdbcDataReader = QueryLeggi("SELECT ID, USERNAME, ATTIVO", "FROM Accesso")
        RiempiColonneDaDB(dgvUtenti, letto)
Err:
        AggiornaStato("Pronto")
    End Sub

    Private Sub lblCOLOREINSERIMENTO_Click(sender As System.Object, e As System.EventArgs) Handles lblCOLOREINSERIMENTO.Click
        ColorDlg.Color = lblCOLOREINSERIMENTO.BackColor
        ColorDlg.ShowDialog()
        lblCOLOREINSERIMENTO.BackColor = ColorDlg.Color
    End Sub

    Private Sub lblCOLOREMODIFICA_Click(sender As System.Object, e As System.EventArgs) Handles lblCOLOREMODIFICA.Click
        ColorDlg.Color = lblCOLOREMODIFICA.BackColor
        ColorDlg.ShowDialog()
        lblCOLOREMODIFICA.BackColor = ColorDlg.Color
    End Sub

    Private Sub lblCOLORERICERCA_Click(sender As System.Object, e As System.EventArgs) Handles lblCOLORERICERCA.Click
        ColorDlg.Color = lblCOLORERICERCA.BackColor
        ColorDlg.ShowDialog()
        lblCOLORERICERCA.BackColor = ColorDlg.Color
    End Sub

    Private Sub fOpzioni_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter
        AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
        CaricaImpostazioni()
        AbilitaMenuModifica(False)
    End Sub

    Private Sub fOpzioni_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
        CaricaImpostazioni()
        CaricaUtenti()
    End Sub

    Private Sub fOpzioni_LostFocus(sender As Object, e As System.EventArgs) Handles Me.Leave
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
        AbilitaMenuModifica(False)
    End Sub

    Private Sub dgvUtenti_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvUtenti.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnModificaUtente.PerformClick()

            Case Keys.Delete
                btnEliminaUtente.PerformClick()

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub btnEliminaUtente_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminaUtente.Click
        On Error GoTo Err
        If dgvUtenti.SelectedRows.Count < 1 Then Exit Sub
        If MsgBox("Confermi eliminazione utente?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "Eliminazione?") = MsgBoxResult.No Then
            Exit Sub
        End If
        MsgBox("Funzione ancora disabilitata per sicurezza.", MsgBoxStyle.Information)
        'MsgBox("Eliminati: " & QueryNumerico("DELETE FROM Accesso WHERE ID=" & dgvUtenti.SelectedRows(0).Cells("ID").Value) & " utenti.")
        CaricaUtenti()

Err:

    End Sub

    Private Sub cmbAccesso_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbAccesso.SelectedIndexChanged
        chkautologin.Enabled = (cmbAccesso.SelectedIndex = EnumComboAccesso.UserEPassword)
    End Sub
End Class