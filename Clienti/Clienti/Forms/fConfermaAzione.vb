Public Class fConfermaAzione

    Private Conferma As Boolean = False
    Private _TestoAggiuntivo As String = Nothing

    Public Property TestoAggiuntivo As String
        Get
            Return _TestoAggiuntivo
        End Get
        Set(value As String)
            _TestoAggiuntivo = value
        End Set
    End Property

    Private Sub btnControlla_Click(sender As System.Object, e As System.EventArgs) Handles btnControlla.Click
        If Len(TestoAggiuntivo) > 0 Then
            If MsgBox(TestoAggiuntivo & vbNewLine & vbNewLine & "Continuare comunque?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Continuare?") = MsgBoxResult.No Then Exit Sub
        End If
        If UCase(MD5(Trim(txtPassword.Text))) = UCase(mUtente.PASSWORD) Then
            Conferma = True
        Else
            Conferma = False
            MsgBox("Password errata!", MsgBoxStyle.Information)
        End If

        Me.Close()
    End Sub

    Private Sub btnAnnulla_Click(sender As System.Object, e As System.EventArgs) Handles btnAnnulla.Click
        Conferma = False
        Me.Close()
    End Sub

    Private Sub fConfermaAzione_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Conferma Then Me.DialogResult = Windows.Forms.DialogResult.Yes Else Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub fConfermaAzione_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Len(TestoAggiuntivo) > 0 Then
            lblTestoAggiuntivo.Text = TestoAggiuntivo
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblTestoAggiuntivo.ForeColor = Color.Red
    End Sub
End Class