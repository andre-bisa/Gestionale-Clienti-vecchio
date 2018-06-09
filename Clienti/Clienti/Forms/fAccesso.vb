Imports Clienti.mFunzioni


Public Class fAccesso

    ' Flag:
    ' TRUE  = faccio MD5
    ' FALSE = non faccio MD5 
    Private flagMD5 As Boolean = True

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim usr As String = Trim(UsernameTextBox.Text.Replace("'", vbNullString).Replace("""", vbNullString).Replace("*", vbNullString).Replace("%", vbNullString))
        Dim psw As String = Trim(PasswordTextBox.Text.Replace("'", vbNullString).Replace("""", vbNullString).Replace("*", vbNullString).Replace("%", vbNullString))

        'If CheckAccesso(usr, psw) Then
        If mUtente.CaricaProfilo(usr, psw, flagMD5) Then
            fMain.Show()
            Me.Close()
        Else
            MsgBox("Errore, username o password errati!")
        End If

        ' Resetto il flag, se per caso la password salvata dovesse essere sbagliata...
        flagMD5 = True
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub fAccesso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckConnessione()
        LeggiFileIni()
        Me.Text = My.Application.Info.Title & " Accesso  -  " & Application.ProductVersion
        ' Consento auto-login
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ' Consento auto-login
        Timer1.Stop()
        UsernameTextBox.Text = mUtente.USERNAME
        PasswordTextBox.Text = mUtente.PASSWORD
        If Len(UsernameTextBox.Text) > 0 Then PasswordTextBox.Focus()
        If OpzioniBisa.AutoLogin Or OpzioniBisa.ComboAccesso = EnumComboAccesso.UserEPassword Then flagMD5 = False
        If OpzioniBisa.AutoLogin Then OK.PerformClick()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        flagMD5 = True
    End Sub
End Class
