Imports System
Imports System.Data
Imports System.Data.Odbc
Imports Clienti.mFunzioni


Public Class fGestioneReferenti
    Private _FormChiamante As Form
    Private _IDREFERENTE As Integer
    Private _CodiceCliente As String = vbNullString
    Private _SceDati As EnumSceDati = Nothing

    Public Property SceDati As EnumSceDati
        Get
            Return _SceDati
        End Get
        Set(value As EnumSceDati)
            _SceDati = value
            Select Case _SceDati
                Case EnumSceDati.SceOK
                    'Codcie per aggiornare/aggiungere numero di cell
                    If Trim(txtNOMEREFERENTE.Text) = vbNullString Then Exit Property
                    If Trim(txtCODICECLIENTE.Text) = vbNullString Then Exit Property
                    If CodiceCliente <> vbNullString Then
                        ' Aggiungi
                        EseguiSQL("INSERT INTO Referenti(CODICECLIENTE, NOMEREFERENTE, NOTEREFERENTE) VALUES(" & Apici(txtCODICECLIENTE.Text) & ", " & Apici(txtNOMEREFERENTE.Text) & ", " & Apici(txtNOTEREFERENTE.Text) & ")")
                    Else
                        ' Aggiorna
                        EseguiSQL("UPDATE Referenti SET NOMEREFERENTE=" & Apici(txtNOMEREFERENTE.Text) & ", NOTEREFERENTE=" & Apici(txtNOTEREFERENTE.Text) & " WHERE IDREFERENTE=" & txtID.Text)
                    End If
                    LanciaSub(FormChiamante, "AggiornaReferenti")
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

    Public Property IDREFERENTE As Integer
        Get
            Return _IDREFERENTE
        End Get
        Set(value As Integer)
            _IDREFERENTE = value
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
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDREFERENTE, CODICECLIENTE, NOMEREFERENTE, NOTEREFERENTE", "FROM Referenti", , "WHERE IDREFERENTE=" & IDREFERENTE)
        letto.Read()
        If letto.HasRows Then
            txtCODICECLIENTE.Text = letto.Item("CODICECLIENTE").ToString
            txtNOMEREFERENTE.Text = letto.Item("NOMEREFERENTE").ToString
            txtNOTEREFERENTE.Text = letto.Item("NOTEREFERENTE").ToString
            txtID.Text = IDREFERENTE
        Else
            txtID.Text = "(NEW)"
            txtCODICECLIENTE.Text = CodiceCliente
            txtNOMEREFERENTE.Text = vbNullString
            txtNOTEREFERENTE.Text = vbNullString
        End If
    End Sub

    Private Sub btnSalva_Click(sender As System.Object, e As System.EventArgs) Handles btnSalva.Click
        SceDati = EnumSceDati.SceOK
    End Sub
End Class