Public Class fProgress
    Private _Max As Integer

    Public Property SceDati As EnumSceDati
        Get
            Return vbNull
        End Get
        Set(value As EnumSceDati)
        End Set
    End Property

    Public Property Max As Integer
        Get
            Return _Max
        End Get
        Set(value As Integer)
            _Max = value
            Progress.Maximum = _Max
        End Set
    End Property

    Private Sub fProgress_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Progress.Maximum = _Max
        Progress.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblProgresso.Text = Progress.Value & "/" & Max
    End Sub
End Class