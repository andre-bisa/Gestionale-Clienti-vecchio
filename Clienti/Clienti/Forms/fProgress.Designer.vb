<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fProgress
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblProgresso = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(9, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(198, 23)
        Label1.TabIndex = 1
        Label1.Text = "Esecuzione in corso..."
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(12, 43)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(260, 23)
        Me.Progress.TabIndex = 0
        '
        'Timer1
        '
        '
        'lblProgresso
        '
        Me.lblProgresso.Location = New System.Drawing.Point(213, 9)
        Me.lblProgresso.Name = "lblProgresso"
        Me.lblProgresso.Size = New System.Drawing.Size(59, 23)
        Me.lblProgresso.TabIndex = 2
        Me.lblProgresso.Text = "0/0"
        Me.lblProgresso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 79)
        Me.Controls.Add(Me.lblProgresso)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Progress)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fProgress"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esecuzione"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblProgresso As System.Windows.Forms.Label
End Class
