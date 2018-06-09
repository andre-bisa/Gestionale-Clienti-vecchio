<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGestioneDecodifiche
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.txtCODICE = New System.Windows.Forms.TextBox()
        Me.txtDESCRIZIONE = New System.Windows.Forms.TextBox()
        Me.btnSalva = New System.Windows.Forms.Button()
        Me.btnElimina = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(40, 13)
        Label1.TabIndex = 0
        Label1.Text = "Codice"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 43)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(62, 13)
        Label3.TabIndex = 2
        Label3.Text = "Descrizione"
        '
        'txtCODICE
        '
        Me.txtCODICE.Location = New System.Drawing.Point(95, 6)
        Me.txtCODICE.MaxLength = 5
        Me.txtCODICE.Name = "txtCODICE"
        Me.txtCODICE.Size = New System.Drawing.Size(53, 20)
        Me.txtCODICE.TabIndex = 0
        Me.txtCODICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDESCRIZIONE
        '
        Me.txtDESCRIZIONE.Location = New System.Drawing.Point(95, 40)
        Me.txtDESCRIZIONE.MaxLength = 250
        Me.txtDESCRIZIONE.Name = "txtDESCRIZIONE"
        Me.txtDESCRIZIONE.Size = New System.Drawing.Size(183, 20)
        Me.txtDESCRIZIONE.TabIndex = 1
        '
        'btnSalva
        '
        Me.btnSalva.Image = Global.Clienti.My.Resources.Resources.Save
        Me.btnSalva.Location = New System.Drawing.Point(33, 72)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(75, 27)
        Me.btnSalva.TabIndex = 2
        Me.btnSalva.Text = "&Salva"
        Me.btnSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'btnElimina
        '
        Me.btnElimina.Image = Global.Clienti.My.Resources.Resources.Delete
        Me.btnElimina.Location = New System.Drawing.Point(140, 72)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(74, 27)
        Me.btnElimina.TabIndex = 3
        Me.btnElimina.Text = "&Elimina"
        Me.btnElimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnElimina.UseVisualStyleBackColor = True
        '
        'fGestioneDecodifiche
        '
        Me.AcceptButton = Me.btnSalva
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 111)
        Me.Controls.Add(Me.btnElimina)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.txtDESCRIZIONE)
        Me.Controls.Add(Me.txtCODICE)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fGestioneDecodifiche"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creazione/Modifica decodifica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCODICE As System.Windows.Forms.TextBox
    Friend WithEvents txtDESCRIZIONE As System.Windows.Forms.TextBox
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents btnElimina As System.Windows.Forms.Button
End Class
