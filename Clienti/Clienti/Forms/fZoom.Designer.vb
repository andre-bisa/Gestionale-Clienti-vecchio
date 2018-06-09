<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fZoom
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
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Me.txtFILTRA = New System.Windows.Forms.TextBox()
        Me.dgvELENCO = New System.Windows.Forms.DataGridView()
        Me.CODICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DECODIFICA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuovo = New System.Windows.Forms.Button()
        Me.btnModifica = New System.Windows.Forms.Button()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvELENCO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFILTRA
        '
        Me.txtFILTRA.Location = New System.Drawing.Point(219, 3)
        Me.txtFILTRA.Name = "txtFILTRA"
        Me.txtFILTRA.Size = New System.Drawing.Size(128, 20)
        Me.txtFILTRA.TabIndex = 0
        '
        'dgvELENCO
        '
        Me.dgvELENCO.AllowUserToAddRows = False
        Me.dgvELENCO.AllowUserToDeleteRows = False
        Me.dgvELENCO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvELENCO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODICE, Me.DECODIFICA})
        Me.dgvELENCO.Location = New System.Drawing.Point(12, 29)
        Me.dgvELENCO.MultiSelect = False
        Me.dgvELENCO.Name = "dgvELENCO"
        Me.dgvELENCO.ReadOnly = True
        Me.dgvELENCO.RowHeadersVisible = False
        Me.dgvELENCO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvELENCO.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvELENCO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvELENCO.Size = New System.Drawing.Size(350, 437)
        Me.dgvELENCO.TabIndex = 1
        '
        'CODICE
        '
        Me.CODICE.FillWeight = 150.0!
        Me.CODICE.HeaderText = "Codice"
        Me.CODICE.Name = "CODICE"
        Me.CODICE.ReadOnly = True
        Me.CODICE.Width = 150
        '
        'DECODIFICA
        '
        Me.DECODIFICA.FillWeight = 175.0!
        Me.DECODIFICA.HeaderText = "Descrizione"
        Me.DECODIFICA.Name = "DECODIFICA"
        Me.DECODIFICA.ReadOnly = True
        Me.DECODIFICA.Width = 175
        '
        'btnNuovo
        '
        Me.btnNuovo.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnNuovo.Location = New System.Drawing.Point(125, 1)
        Me.btnNuovo.Name = "btnNuovo"
        Me.btnNuovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuovo.TabIndex = 2
        Me.btnNuovo.Text = "&Nuovo"
        Me.btnNuovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuovo.UseVisualStyleBackColor = True
        '
        'btnModifica
        '
        Me.btnModifica.Image = Global.Clienti.My.Resources.Resources.modifica
        Me.btnModifica.Location = New System.Drawing.Point(21, 1)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(82, 23)
        Me.btnModifica.TabIndex = 3
        Me.btnModifica.Text = "&Modifica"
        Me.btnModifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        PictureBox1.Image = Global.Clienti.My.Resources.Resources.lente
        PictureBox1.Location = New System.Drawing.Point(353, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(16, 16)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        '
        'fZoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 478)
        Me.Controls.Add(PictureBox1)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.btnNuovo)
        Me.Controls.Add(Me.dgvELENCO)
        Me.Controls.Add(Me.txtFILTRA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fZoom"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Elenco "
        CType(Me.dgvELENCO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFILTRA As System.Windows.Forms.TextBox
    Friend WithEvents dgvELENCO As System.Windows.Forms.DataGridView
    Friend WithEvents CODICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DECODIFICA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNuovo As System.Windows.Forms.Button
    Friend WithEvents btnModifica As System.Windows.Forms.Button
End Class
