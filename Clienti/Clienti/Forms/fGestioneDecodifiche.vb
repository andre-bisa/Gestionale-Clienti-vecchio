Public Class fGestioneDecodifiche
    Private _SceDati As EnumSceDati = Nothing
    Private _Codice As String = vbNullString
    Public FormChiamante As Form
    Public NomeTabella As String
    Public Campo As String
    Public CampoDecodifica As String

    Public Property SceDati As EnumSceDati
        Get
            Return _SceDati
        End Get
        Set(value As EnumSceDati)
            _SceDati = value
            Select Case SceDati
                Case EnumSceDati.SceOK
                    If Len(Codice) > 0 Then
                        ' Aggiorna
                        MsgBox("Record aggiornati: " & QueryNumerico("UPDATE " & NomeTabella & " SET " & CampoDecodifica & "=" & Apici(txtDESCRIZIONE.Text) & " WHERE " & Campo & "=" & Apici(txtCODICE.Text)), MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aggiornati")
                    Else
                        ' Nuovo
                        MsgBox("Record creati: " & QueryNumerico("INSERT INTO " & NomeTabella & "(" & Campo & "," & CampoDecodifica & ") VALUES(" & Apici(txtCODICE.Text) & "," & Apici(txtDESCRIZIONE.Text) & ")"), MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Creati")
                    End If
                    Me.Close()

                Case Else
            End Select
        End Set
    End Property

    Public Property Codice As String
        Get
            Return _Codice
        End Get
        Set(value As String)
            _Codice = value
        End Set
    End Property

    Private Sub fGestioneDecodifiche_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter
        AbilitaMenuModifica(False)
        AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
    End Sub

    Private Sub fGestioneDecodifiche_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CambiaProprieta(FormChiamante, "Enabled", True)
        LanciaSub(FormChiamante, "AggiornaElenco")
    End Sub

    Private Sub fGestioneDecodifiche_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub fGestioneDecodifiche_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
        AbilitaMenuModifica(False)
    End Sub

    Private Sub fGestioneDecodifiche_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AbilitaMenuModifica(False)
        AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
        If Len(Codice) > 0 Then
            txtCODICE.Text = Codice
            txtCODICE.Enabled = False
            txtDESCRIZIONE.Text = Controlla(CampoDecodifica, NomeTabella, Campo & " = " & Apici(Codice))
            btnElimina.Enabled = True
        Else
            txtCODICE.Text = vbNullString
            txtCODICE.Enabled = True
            txtDESCRIZIONE.Text = vbNullString
            btnElimina.Enabled = False
        End If
    End Sub

    Private Sub btnSalva_Click(sender As System.Object, e As System.EventArgs) Handles btnSalva.Click
        CambiaProprieta(Me, "SceDati", EnumSceDati.SceOK)
    End Sub

    Private Sub txtCODICE_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCODICE.KeyDown
        Select Case e.KeyCode
            Case Else
                fGestioneDecodifiche_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub txtDESCRIZIONE_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDESCRIZIONE.KeyDown
        Select Case e.KeyCode
            Case Else
                fGestioneDecodifiche_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub btnElimina_Click(sender As System.Object, e As System.EventArgs) Handles btnElimina.Click
        If MsgBox("Confermi eliminazione?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Confermi?") = MsgBoxResult.No Then Exit Sub
        If ConfermaAzione("Azione irrevocabile! I valori che avevano questa descrizione andranno definitivamente persi!") = False Then Exit Sub
        QueryNumerico("DELETE FROM " & NomeTabella & " WHERE " & Campo & "=" & Apici(txtCODICE.Text))
        CambiaProprieta(FormChiamante, "Eliminazione", True)
        Me.Close()
    End Sub
End Class