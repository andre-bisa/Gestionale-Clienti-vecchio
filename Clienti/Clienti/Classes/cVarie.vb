Public Enum EnumSceDati As UInteger
    SceNothing
    SceOK
    SceAnn
    ScePrimoRecord
    ScePrecedente
    SceSuccessivo
    SceUltimoRecord
    SceZoom
End Enum

Public Enum EnumModalita
    ModIns
    ModMod
    ModRic
End Enum

Public Enum EnumMainMenuSotto
    Tutto
    Niente
    OK
    Records
    Annulla
    Ordinamento
End Enum

Public Enum EnumDatabases
    Access
    MySql
End Enum

Public Class cRecordsLetti

    Private _SQL As String
    Public Const MinIndex As Integer = 1
    Private IndiceCorrete As Integer
    Private IndiceMassimo As Integer
    Private Conn As New OdbcConnection(kstrConn)
    Private letto As OdbcDataReader

    Public Property SQL As String
        Get
            Return _SQL
        End Get
        Set(value As String)
            _SQL = SQL
        End Set
    End Property

    Public Property Index As Integer
        Get
            Return IndiceCorrete
        End Get
        Set(value As Integer)
            If value > IndiceMassimo Then
                IndiceCorrete = IndiceMassimo
            ElseIf value < MinIndex Then
                IndiceCorrete = MinIndex
            Else
                IndiceCorrete = value
            End If
            GetValue(IndiceCorrete)
        End Set
    End Property

    Public Property MaxIndex As Integer
        Get
            Return IndiceMassimo
        End Get
        Set(value As Integer)
            IndiceMassimo = value
        End Set
    End Property

    Public Function GetValue() As OdbcDataReader
        Return GetValue(IndiceCorrete)
    End Function

    Public Function GetValue(ByVal Index As Integer) As OdbcDataReader
        Dim EsseQElle As String = SQL
        If kTipoDatabase = EnumDatabases.MySql Then EsseQElle &= " LIMIT " & (IndiceCorrete - 1) & ",1"
        letto = EseguiSQL(EsseQElle)
        Select Case kTipoDatabase
            Case EnumDatabases.Access
                SetLettoByPosition(Index)
            Case EnumDatabases.MySql
                letto.Read()
        End Select
        GetValue = letto
        'MsgBox(IndiceCorrete & " di " & IndiceMassimo)
    End Function

    Public ReadOnly Property Value As OdbcDataReader
        Get
            Return GetValue()
        End Get
    End Property

    Public Sub AggiornaLettura()
        Try
            If (Conn.State <> ConnectionState.Open) Then Conn.Open()
            IndiceMassimo = ContaSQL("(" & SQL & ") tab1")
            If (Index > IndiceMassimo) Then Index = IndiceMassimo
        Catch ex As Exception
            Conn.Close()
            MsgBox("Errore aggiornamento lettura.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub New(ByVal SQL As String)
        Try
            _SQL = SQL
            If (Conn.State = ConnectionState.Open) Then Conn.Close()
            Conn.Open()
            IndiceMassimo = ContaSQL("(" & SQL & ") tab1")
            IndiceCorrete = 1
            'letto = EseguiSQL(SQL)
        Catch ex As Exception
            Conn.Close()
            MsgBox("Errore creazione classe!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Overloads Sub Dispose()
        Conn.Close()
        Me.Finalize()
    End Sub



    ' --------------------   P R I V A T E   S U B   &   F U N C T I O N S   -------------------------------

    ' Attualmente usato solo per Access
    Private Sub SetLettoByPosition(ByVal position As Integer)
        For i As Integer = 1 To position Step 1
            If Not letto.Read() Then
                letto = Nothing
                Exit For
            End If
        Next
    End Sub

End Class

