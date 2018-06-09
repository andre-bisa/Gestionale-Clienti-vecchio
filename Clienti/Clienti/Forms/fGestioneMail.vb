Imports System
Imports System.Data
Imports System.Data.Odbc
Imports Clienti.mFunzioni


Public Class fGestioneMail
    Private _FormChiamante As Form
    Private _IDMAIL As Integer
    Private _CodiceCliente As String = vbNullString
    Private _SceDati As EnumSceDati = Nothing

    Private IDGruppi() As Integer

    Public Property SceDati As EnumSceDati
        Get
            Return _SceDati
        End Get
        Set(value As EnumSceDati)
            _SceDati = value
            Select Case _SceDati
                Case EnumSceDati.SceOK
                    'Codcie per aggiornare/aggiungere mail
                    If Trim(txtEMAIL.Text) = vbNullString Then Exit Property
                    If Trim(txtCODICECLIENTE.Text) = vbNullString Then Exit Property
                    If CodiceCliente <> vbNullString Then
                        ' Aggiungi
                        EseguiSQL("INSERT INTO Mails(CODICECLIENTE, EMAIL, NOTEMAIL) VALUES(" & Apici(txtCODICECLIENTE.Text) & ", " & Apici(txtEMAIL.Text) & ", " & Apici(txtNOTEMAIL.Text) & ")")
                    Else
                        ' Aggiorna
                        EseguiSQL("UPDATE Mails SET EMAIL=" & Apici(txtEMAIL.Text) & ", NOTEMAIL=" & Apici(txtNOTEMAIL.Text) & " WHERE IDMAIL=" & txtID.Text)
                        'elimino tutti i gruppi
                        EseguiSQL("DELETE FROM gruppomail WHERE IDMAIL=" & txtID.Text)
                        'ora aggiungo solo quelli che ho selezionato
                        For i As Integer = 0 To clsGRUPPI.CheckedIndices.Count - 1 Step 1
                            EseguiSQL("INSERT INTO gruppomail(IDGRUPPO, IDMAIL) VALUES(" & IDGruppi(clsGRUPPI.CheckedIndices.Item(i)) & ", " & txtID.Text & ")")
                        Next i
                    End If
                    LanciaSub(FormChiamante, "AggiornaMail")
                    Me.Close()

                Case Else
            End Select
        End Set
    End Property

    Public Property CodiceCliente As String
        Get
            Return _CodiceCliente
        End Get
        Set(value As String)
            _CodiceCliente = value
        End Set
    End Property

    Public Property IDMAIL As Integer
        Get
            Return _IDMAIL
        End Get
        Set(value As Integer)
            _IDMAIL = value
        End Set
    End Property

    Public Property FormChiamante As Form
        Get
            Return _FormChiamante
        End Get
        Set(value As Form)
            _FormChiamante = value
        End Set
    End Property

    Private Sub fGestioneTelefoni_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter
        AbilitaMainMenuSotto(EnumMainMenuSotto.OK)
    End Sub

    Private Sub fGestioneTelefoni_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CambiaProprieta(_FormChiamante, "Enabled", True)
    End Sub

    Private Sub fGestioneTelefoni_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        fMain.fMain_KeyDown(sender, e)
    End Sub

    Private Sub fGestioneTelefoni_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDMAIL, CODICECLIENTE, EMAIL, NOTEMAIL", "FROM Mails", , "WHERE IDMAIL=" & IDMAIL)
        letto.Read()
        If letto.HasRows Then
            txtCODICECLIENTE.Text = letto.Item("CODICECLIENTE").ToString
            txtEMAIL.Text = letto.Item("EMAIL").ToString
            txtNOTEMAIL.Text = letto.Item("NOTEMAIL").ToString
            txtID.Text = IDMAIL
        Else
            txtID.Text = "(NEW)"
            txtCODICECLIENTE.Text = CodiceCliente
            txtEMAIL.Text = vbNullString
            txtNOTEMAIL.Text = vbNullString
        End If

        'i gruppi si possono usare solo se la mail è già stata inserita (se siamo in modifica)
        If letto.HasRows Then
            clsGRUPPI.Items.Clear()
            'svuoto l'array contenente gli ID dei gruppi (in ordine, come la lista)
            IDGruppi = Nothing
            letto = QueryLeggi("SELECT IDGRUPPO, NOMEGRUPPO", "FROM GRUPPI", , "WHERE BOOELIMINATO=FALSE")

            While letto.Read()
                If IDGruppi Is Nothing Then ReDim IDGruppi(0) Else ReDim Preserve IDGruppi(IDGruppi.Count)
                IDGruppi(IDGruppi.Count - 1) = letto.Item("IDGRUPPO")
                clsGRUPPI.Items.Add(letto.Item("NOMEGRUPPO"))
                Using temp As OdbcDataReader = QueryLeggi("SELECT *", "FROM gruppomail", , "WHERE IDMAIL=" & txtID.Text & " AND IDGRUPPO=" & letto.Item("IDGRUPPO"))
                    temp.Read()
                    If temp.HasRows Then
                        clsGRUPPI.SetItemChecked(clsGRUPPI.Items.Count - 1, True)
                    End If
                End Using
            End While
        Else
            clsGRUPPI.Enabled = False
        End If

    End Sub

    Private Sub btnSalva_Click(sender As System.Object, e As System.EventArgs) Handles btnSalva.Click
        SceDati = EnumSceDati.SceOK
    End Sub

End Class