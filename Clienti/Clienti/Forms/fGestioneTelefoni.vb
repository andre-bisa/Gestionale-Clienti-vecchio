Imports System
Imports System.Data
Imports System.Data.Odbc
Imports Clienti.mFunzioni


Public Class fGestioneTelefoni
    Private _FormChiamante As Form
    Private _IDTelefono As Integer
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
                    If Trim(txtTELEFONO.Text) = vbNullString Then Exit Property
                    If Trim(txtCODICECLIENTE.Text) = vbNullString Then Exit Property
                    If CodiceCliente <> vbNullString Then
                        ' Aggiungi
                        EseguiSQL("INSERT INTO Telefoni(CODICECLIENTE, TELEFONO, NOTETELEFONO) VALUES(" & Apici(txtCODICECLIENTE.Text) & ", " & Apici(txtTELEFONO.Text) & ", " & Apici(TXTNOTETELEFONO.Text) & ")")
                    Else
                        ' Aggiorna
                        EseguiSQL("UPDATE Telefoni SET TELEFONO=" & Apici(txtTELEFONO.Text) & ", NOTETELEFONO=" & Apici(TXTNOTETELEFONO.Text) & " WHERE IDTELEFONO=" & txtID.Text)
                    End If
                    LanciaSub(FormChiamante, "AggiornaTelefoni")
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

    Public Property IDTelefono As Integer
        Get
            Return _IDTelefono
        End Get
        Set(value As Integer)
            _IDTelefono = value
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
        Dim letto As OdbcDataReader = QueryLeggi("SELECT IDTELEFONO, CODICECLIENTE, TELEFONO, NOTETELEFONO", "FROM Telefoni", , "WHERE IDTELEFONO=" & _IDTelefono)
        letto.Read()
        If letto.HasRows Then
            txtCODICECLIENTE.Text = letto.Item("CODICECLIENTE").ToString
            txtTELEFONO.Text = letto.Item("TELEFONO").ToString
            TXTNOTETELEFONO.Text = letto.Item("NOTETELEFONO").ToString
            txtID.Text = IDTelefono
        Else
            txtID.Text = "(NEW)"
            txtCODICECLIENTE.Text = CodiceCliente
            txtTELEFONO.Text = vbNullString
            TXTNOTETELEFONO.Text = vbNullString
        End If
    End Sub

    Private Sub btnSalva_Click(sender As System.Object, e As System.EventArgs) Handles btnSalva.Click
        SceDati = EnumSceDati.SceOK
    End Sub
End Class