Imports Clienti.mDB

Public Class fTabellaClienti
    Private _SQL As String = vbNullString
    Private _Campi As String() = Nothing

    Public Property SQL As String
        Get
            Return _SQL
        End Get
        Set(value As String)
            _SQL = value
        End Set
    End Property

    Public WriteOnly Property Campi As String
        Set(value As String)
            _Campi = Split(value, "|")
        End Set
    End Property


    Private Sub ScriviDataGrid()
        Dim letto As OdbcDataReader = EseguiSQL(SQL)
        dgvTabellaClienti.Columns.Clear()
        For i As Integer = 0 To letto.FieldCount - 1 Step 1
            Dim header As String = vbNullString
            If Not IsNothing(_Campi) Then
                If _Campi.Count >= letto.FieldCount Then header = _Campi(i) Else header = letto.GetName(i)
            Else
                header = letto.GetName(i)
            End If
            dgvTabellaClienti.Columns.Add(letto.GetName(i), header)
            ' Posso rendere così il campo nascosto
            dgvTabellaClienti.Columns(dgvTabellaClienti.Columns.Count - 1).Visible = (header <> "*NO*")
        Next i
        While letto.Read
            dgvTabellaClienti.Rows.Add()
            For i As Integer = 0 To letto.FieldCount - 1 Step 1
                dgvTabellaClienti.Rows(dgvTabellaClienti.Rows.Count - 1).Cells(i).Value = letto.Item(i)
            Next i
        End While
    End Sub

    Private Sub fTabellaClienti_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
        AbilitaMenuModifica(False)
    End Sub

    Private Sub fTabellaClienti_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        AbilitaMainMenuSotto(EnumMainMenuSotto.Niente)
        AbilitaMenuModifica(False)
    End Sub

    Private Sub fTabellaClienti_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        ScriviDataGrid()
    End Sub

End Class