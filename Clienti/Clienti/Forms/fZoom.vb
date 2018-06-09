Imports System.Data.OleDb
Imports System.Data.Odbc


Public Class fZoom
    Private flgFatto As Boolean = False             ' Se true è stato selezionato qualcosa

    Private _NomeTabella As String                  ' Tabella nella quale effettuare la ricerca
    Private _CampoDecodifica As String              ' Campo che contiene la decodifica
    Private _TextBoxRitorno As TextBox              ' TextBox per il ritorno del valore
    Private _Filtro As String = vbNullString        ' Filtro Aggiuntivo
    Private _CampoCodice As String                  ' Campo del codice ad cercare
    Private _Chiamante As TextBox                   ' Campo che mi ha chiamato
    Private _FormChiamante As Form                  ' Form chiamante
    Private _Eliminazione As Boolean = False        ' Variabile che se settata true significa che è stato eliminato qualche valore nelle decodifiche

    Public AbilitaGestione As Boolean = True       ' Se true sarà possibile Modificare/Aggiungere

    ' ------------------   P R O P R I E T A'   ------------------
    Public Property Eliminazione As Boolean
        Get
            Return _Eliminazione
        End Get
        Set(value As Boolean)
            _Eliminazione = value
        End Set
    End Property

    Public Property NomeTabella As String
        Get
            Return _NomeTabella
        End Get
        Set(value As String)
            _NomeTabella = value
        End Set
    End Property

    Public Property CampoDecodifica As String
        Get
            Return _CampoDecodifica
        End Get
        Set(value As String)
            _CampoDecodifica = value
        End Set
    End Property

    Public Property TextBoxRitorno As TextBox
        Get
            Return _TextBoxRitorno
        End Get
        Set(value As TextBox)
            _TextBoxRitorno = value
        End Set
    End Property

    Public Property FiltroAgg As String
        Get
            Return _Filtro
        End Get
        Set(value As String)
            _Filtro = value
        End Set
    End Property

    Public Property CampoCodice As String
        Get
            Return _CampoCodice
        End Get
        Set(value As String)
            _CampoCodice = value
        End Set
    End Property

    Public Property Chiamante As TextBox
        Get
            Return _Chiamante
        End Get
        Set(value As TextBox)
            _Chiamante = value
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



    Private Sub fZoom_HandleCreated(sender As Object, e As System.EventArgs) Handles Me.HandleCreated
        LeggiERiempi()
    End Sub

    Private Sub fZoom_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter
        AbilitaMenuModifica(False)
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
    End Sub

    Private Sub fZoom_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CambiaProprieta(_FormChiamante, "SceDati", EnumSceDati.SceNothing)
        CambiaProprieta(_FormChiamante, "Enabled", True)
        If Eliminazione Then LanciaSub(FormChiamante, "AggiornaTutteTabelle")
        _TextBoxRitorno.Text = Controlla(_CampoDecodifica, _NomeTabella, _CampoCodice & " = " & Apici(_Chiamante.Text) & _Filtro)
        _TextBoxRitorno.Focus()
        If flgFatto Then SendKeys.Send("{TAB}") ' Passo al controllo successivo
    End Sub

    Private Sub fZoom_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F5
                AggiornaElenco()

            Case Else
                fMain.fMain_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub fZoom_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
        AbilitaMenuModifica(False)
    End Sub

    Private Sub fZoom_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnModifica.Enabled = AbilitaGestione
        btnNuovo.Enabled = AbilitaGestione
    End Sub

    Private Sub dgvELENCO_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvELENCO.CellContentDoubleClick, dgvELENCO.CellDoubleClick
        _Chiamante.Text = dgvELENCO.Rows(e.RowIndex).Cells(0).Value
        _TextBoxRitorno.Text = dgvELENCO.Rows(e.RowIndex).Cells(1).Value
        flgFatto = True
        Me.Close()
    End Sub

    Private Sub txtFILTRA_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFILTRA.KeyDown
        Select Case e.KeyCode
            Case Else
                fZoom_KeyDown(sender, e)
        End Select
    End Sub

    Private Sub txtFILTRA_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFILTRA.TextChanged
        On Error GoTo Fine
        Dim SQL As String = vbNullString
        SQL = "(" & CampoCodice & " LIKE " & Apici(kLikeOperator & txtFILTRA.Text & kLikeOperator) & " OR " & CampoDecodifica & " LIKE " & Apici(kLikeOperator & txtFILTRA.Text & kLikeOperator) & ")"
        LeggiERiempi(SQL)

        'Exit Sub

        'For i As Integer = 0 To dgvELENCO.Rows.Count - 1
        'If Len(txtFILTRA.Text) = 0 Then
        'dgvELENCO.Rows(i).Visible = True
        'Continue For
        'End If
        'Dim booContiene As Boolean = False
        'For c As Integer = 0 To dgvELENCO.Rows(i).Cells.Count - 1
        'If dgvELENCO.Rows(i).Cells(c).Value.ToString.ToLower.Trim.Contains(LCase(Trim(txtFILTRA.Text))) Then
        'booContiene = True
        'End If
        'Next c
        'dgvELENCO.Rows(i).Visible = booContiene
        'Next i
Fine:
    End Sub

    Public Sub AggiornaElenco()
        Call LeggiERiempi()
    End Sub

    Private Sub LeggiERiempi(Optional ByVal SQL_Where As String = vbNullString)
        Try
            Dim temp As String = txtFILTRA.Text
            Dim SQL As String = "SELECT " & _CampoCodice & ", " & _CampoDecodifica & " FROM " & _NomeTabella & " WHERE 1=1 "

            If Len(_Filtro) > 0 Then
                SQL = SQL & " AND " & _Filtro
            End If

            If Not IsNothing(SQL_Where) Then
                SQL = SQL & " AND " & SQL_Where
            End If

            'Dim letto As OdbcDataReader = QueryLeggi("SELECT " & _CampoCodice & ", " & _CampoDecodifica, " FROM " & _NomeTabella, , " WHERE " & IIf(Len(_Filtro) > 0, _Filtro, " 1=1 "))
            Dim letto As OdbcDataReader = EseguiSQL(SQL)
            dgvELENCO.Rows.Clear()
            While letto.Read
                If temp <> txtFILTRA.Text Then Exit While
                dgvELENCO.Rows.Add()
                dgvELENCO.Rows(dgvELENCO.Rows.Count - 1).Cells(0).Value = letto.Item(_CampoCodice)
                dgvELENCO.Rows(dgvELENCO.Rows.Count - 1).Cells(1).Value = letto.Item(_CampoDecodifica)
                Application.DoEvents()
                If temp <> txtFILTRA.Text Then Exit While
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCreaNuovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuovo.Click
        Dim f As New fGestioneDecodifiche
        With f
            .MdiParent = kMainForm
            .FormChiamante = Me
            .Codice = vbNullString
            .NomeTabella = NomeTabella
            .Campo = CampoCodice
            .CampoDecodifica = CampoDecodifica
            Me.Enabled = False
            .Show()
        End With
    End Sub

    Private Sub btnModifica_Click(sender As System.Object, e As System.EventArgs) Handles btnModifica.Click
        On Error GoTo Fine
        Dim f As New fGestioneDecodifiche
        With f
            .MdiParent = kMainForm
            .FormChiamante = Me
            .Codice = dgvELENCO.Rows(dgvELENCO.SelectedRows(0).Index).Cells(0).Value
            .NomeTabella = NomeTabella
            .Campo = CampoCodice
            .CampoDecodifica = CampoDecodifica
            Me.Enabled = False
            .Show()
        End With
Fine:
    End Sub

    Private Sub dgvELENCO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvELENCO.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                _Chiamante.Text = dgvELENCO.Rows(dgvELENCO.SelectedRows(0).Index).Cells(0).Value
                _TextBoxRitorno.Text = dgvELENCO.Rows(dgvELENCO.SelectedRows(0).Index).Cells(1).Value
                flgFatto = True
                Me.Close()

            Case Else
                fZoom_KeyDown(sender, e)
        End Select
    End Sub

End Class