<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTabellaClienti
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
        Me.dgvTabellaClienti = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTabellaClienti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTabellaClienti
        '
        Me.dgvTabellaClienti.AllowUserToAddRows = False
        Me.dgvTabellaClienti.AllowUserToDeleteRows = False
        Me.dgvTabellaClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabellaClienti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabellaClienti.Location = New System.Drawing.Point(0, 0)
        Me.dgvTabellaClienti.MultiSelect = False
        Me.dgvTabellaClienti.Name = "dgvTabellaClienti"
        Me.dgvTabellaClienti.ReadOnly = True
        Me.dgvTabellaClienti.RowHeadersVisible = False
        Me.dgvTabellaClienti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTabellaClienti.RowTemplate.ReadOnly = True
        Me.dgvTabellaClienti.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTabellaClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabellaClienti.ShowEditingIcon = False
        Me.dgvTabellaClienti.Size = New System.Drawing.Size(744, 322)
        Me.dgvTabellaClienti.TabIndex = 0
        '
        'fTabellaClienti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 322)
        Me.Controls.Add(Me.dgvTabellaClienti)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fTabellaClienti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tabella Clienti"
        CType(Me.dgvTabellaClienti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvTabellaClienti As System.Windows.Forms.DataGridView
End Class
