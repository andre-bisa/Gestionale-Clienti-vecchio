<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fRecuperoEliminati
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgVisite = New System.Windows.Forms.TabPage()
        Me.dgvVisite = New System.Windows.Forms.DataGridView()
        Me.VCHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VCLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTVISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAUSALEVISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_VISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEVISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDVISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpTelefonate = New System.Windows.Forms.TabPage()
        Me.dgvTelefonate = New System.Windows.Forms.DataGridView()
        Me.TCHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDTELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTTELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAUSALETELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_TELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTETELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpPreventivi = New System.Windows.Forms.TabPage()
        Me.dgvPreventivi = New System.Windows.Forms.DataGridView()
        Me.PCHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PCLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERCORSOPDFPREVENTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODICECLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTPREVENTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVBTNPDFPREVENTIVO = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SALVAFILEPREVENTIVO = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NOTEPREVENTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPREVENTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpOrdini = New System.Windows.Forms.TabPage()
        Me.dgvOrdini = New System.Windows.Forms.DataGridView()
        Me.OCHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OCLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAUSALEORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_ORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.tpgVisite.SuspendLayout()
        CType(Me.dgvVisite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpTelefonate.SuspendLayout()
        CType(Me.dgvTelefonate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPreventivi.SuspendLayout()
        CType(Me.dgvPreventivi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpOrdini.SuspendLayout()
        CType(Me.dgvOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgVisite)
        Me.TabControl1.Controls.Add(Me.tbpTelefonate)
        Me.TabControl1.Controls.Add(Me.tbpPreventivi)
        Me.TabControl1.Controls.Add(Me.tbpOrdini)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(63, 18)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(13, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(631, 301)
        Me.TabControl1.TabIndex = 8
        Me.TabControl1.TabStop = False
        Me.TabControl1.Tag = ""
        '
        'tpgVisite
        '
        Me.tpgVisite.BackColor = System.Drawing.SystemColors.Control
        Me.tpgVisite.Controls.Add(Me.dgvVisite)
        Me.tpgVisite.Location = New System.Drawing.Point(4, 22)
        Me.tpgVisite.Name = "tpgVisite"
        Me.tpgVisite.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgVisite.Size = New System.Drawing.Size(623, 275)
        Me.tpgVisite.TabIndex = 1
        Me.tpgVisite.Tag = "P-+-"
        Me.tpgVisite.Text = "Visite"
        Me.tpgVisite.ToolTipText = "Visite"
        '
        'dgvVisite
        '
        Me.dgvVisite.AllowUserToAddRows = False
        Me.dgvVisite.AllowUserToDeleteRows = False
        Me.dgvVisite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVisite.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVisite.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VCHK, Me.VCLIENTE, Me.DTVISITA, Me.CAUSALEVISITA, Me.DESC_VISITA, Me.NOTEVISITA, Me.IDVISITA})
        Me.dgvVisite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVisite.Location = New System.Drawing.Point(3, 3)
        Me.dgvVisite.MultiSelect = False
        Me.dgvVisite.Name = "dgvVisite"
        Me.dgvVisite.ReadOnly = True
        Me.dgvVisite.RowHeadersVisible = False
        Me.dgvVisite.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvVisite.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVisite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVisite.ShowEditingIcon = False
        Me.dgvVisite.Size = New System.Drawing.Size(617, 269)
        Me.dgvVisite.TabIndex = 0
        Me.dgvVisite.Tag = "D"
        '
        'VCHK
        '
        Me.VCHK.FillWeight = 30.0!
        Me.VCHK.Frozen = True
        Me.VCHK.HeaderText = "?"
        Me.VCHK.Name = "VCHK"
        Me.VCHK.ReadOnly = True
        Me.VCHK.Width = 30
        '
        'VCLIENTE
        '
        Me.VCLIENTE.HeaderText = "Cliente"
        Me.VCLIENTE.Name = "VCLIENTE"
        Me.VCLIENTE.ReadOnly = True
        '
        'DTVISITA
        '
        Me.DTVISITA.FillWeight = 175.0!
        Me.DTVISITA.HeaderText = "Data Visita"
        Me.DTVISITA.MinimumWidth = 50
        Me.DTVISITA.Name = "DTVISITA"
        Me.DTVISITA.ReadOnly = True
        Me.DTVISITA.Width = 175
        '
        'CAUSALEVISITA
        '
        Me.CAUSALEVISITA.HeaderText = "Causale Visita"
        Me.CAUSALEVISITA.Name = "CAUSALEVISITA"
        Me.CAUSALEVISITA.ReadOnly = True
        '
        'DESC_VISITA
        '
        Me.DESC_VISITA.FillWeight = 150.0!
        Me.DESC_VISITA.HeaderText = "Descrizione"
        Me.DESC_VISITA.MinimumWidth = 50
        Me.DESC_VISITA.Name = "DESC_VISITA"
        Me.DESC_VISITA.ReadOnly = True
        Me.DESC_VISITA.Width = 150
        '
        'NOTEVISITA
        '
        Me.NOTEVISITA.FillWeight = 150.0!
        Me.NOTEVISITA.HeaderText = "Note"
        Me.NOTEVISITA.MinimumWidth = 50
        Me.NOTEVISITA.Name = "NOTEVISITA"
        Me.NOTEVISITA.ReadOnly = True
        Me.NOTEVISITA.Width = 150
        '
        'IDVISITA
        '
        Me.IDVISITA.HeaderText = "ID"
        Me.IDVISITA.Name = "IDVISITA"
        Me.IDVISITA.ReadOnly = True
        Me.IDVISITA.Visible = False
        '
        'tbpTelefonate
        '
        Me.tbpTelefonate.BackColor = System.Drawing.SystemColors.Control
        Me.tbpTelefonate.Controls.Add(Me.dgvTelefonate)
        Me.tbpTelefonate.Location = New System.Drawing.Point(4, 22)
        Me.tbpTelefonate.Name = "tbpTelefonate"
        Me.tbpTelefonate.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTelefonate.Size = New System.Drawing.Size(623, 275)
        Me.tbpTelefonate.TabIndex = 2
        Me.tbpTelefonate.Tag = "P-+-"
        Me.tbpTelefonate.Text = "Telefonate"
        '
        'dgvTelefonate
        '
        Me.dgvTelefonate.AllowUserToAddRows = False
        Me.dgvTelefonate.AllowUserToDeleteRows = False
        Me.dgvTelefonate.AllowUserToResizeRows = False
        Me.dgvTelefonate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTelefonate.ColumnHeadersHeight = 21
        Me.dgvTelefonate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCHK, Me.IDTELEFONATA, Me.TCLIENTE, Me.DTTELEFONATA, Me.CAUSALETELEFONATA, Me.DESC_TELEFONATA, Me.NOTETELEFONATA})
        Me.dgvTelefonate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTelefonate.Location = New System.Drawing.Point(3, 3)
        Me.dgvTelefonate.Name = "dgvTelefonate"
        Me.dgvTelefonate.ReadOnly = True
        Me.dgvTelefonate.RowHeadersVisible = False
        Me.dgvTelefonate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTelefonate.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTelefonate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonate.Size = New System.Drawing.Size(617, 269)
        Me.dgvTelefonate.TabIndex = 1
        Me.dgvTelefonate.Tag = "D"
        '
        'TCHK
        '
        Me.TCHK.FillWeight = 30.0!
        Me.TCHK.Frozen = True
        Me.TCHK.HeaderText = "?"
        Me.TCHK.Name = "TCHK"
        Me.TCHK.ReadOnly = True
        Me.TCHK.Width = 30
        '
        'IDTELEFONATA
        '
        Me.IDTELEFONATA.HeaderText = "IDTELEFONATE"
        Me.IDTELEFONATA.Name = "IDTELEFONATA"
        Me.IDTELEFONATA.ReadOnly = True
        Me.IDTELEFONATA.Visible = False
        '
        'TCLIENTE
        '
        Me.TCLIENTE.HeaderText = "Cliente"
        Me.TCLIENTE.Name = "TCLIENTE"
        Me.TCLIENTE.ReadOnly = True
        '
        'DTTELEFONATA
        '
        Me.DTTELEFONATA.FillWeight = 175.0!
        Me.DTTELEFONATA.HeaderText = "Data Telefonata"
        Me.DTTELEFONATA.MinimumWidth = 50
        Me.DTTELEFONATA.Name = "DTTELEFONATA"
        Me.DTTELEFONATA.ReadOnly = True
        Me.DTTELEFONATA.Width = 175
        '
        'CAUSALETELEFONATA
        '
        Me.CAUSALETELEFONATA.HeaderText = "Causale Telefonata"
        Me.CAUSALETELEFONATA.Name = "CAUSALETELEFONATA"
        Me.CAUSALETELEFONATA.ReadOnly = True
        Me.CAUSALETELEFONATA.Visible = False
        '
        'DESC_TELEFONATA
        '
        Me.DESC_TELEFONATA.FillWeight = 200.0!
        Me.DESC_TELEFONATA.HeaderText = "Descrizione"
        Me.DESC_TELEFONATA.MinimumWidth = 50
        Me.DESC_TELEFONATA.Name = "DESC_TELEFONATA"
        Me.DESC_TELEFONATA.ReadOnly = True
        Me.DESC_TELEFONATA.Width = 200
        '
        'NOTETELEFONATA
        '
        Me.NOTETELEFONATA.FillWeight = 200.0!
        Me.NOTETELEFONATA.HeaderText = "Note"
        Me.NOTETELEFONATA.MinimumWidth = 50
        Me.NOTETELEFONATA.Name = "NOTETELEFONATA"
        Me.NOTETELEFONATA.ReadOnly = True
        Me.NOTETELEFONATA.Width = 200
        '
        'tbpPreventivi
        '
        Me.tbpPreventivi.BackColor = System.Drawing.SystemColors.Control
        Me.tbpPreventivi.Controls.Add(Me.dgvPreventivi)
        Me.tbpPreventivi.Location = New System.Drawing.Point(4, 22)
        Me.tbpPreventivi.Name = "tbpPreventivi"
        Me.tbpPreventivi.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPreventivi.Size = New System.Drawing.Size(623, 275)
        Me.tbpPreventivi.TabIndex = 3
        Me.tbpPreventivi.Tag = "P-+-"
        Me.tbpPreventivi.Text = "Preventivi"
        '
        'dgvPreventivi
        '
        Me.dgvPreventivi.AllowUserToAddRows = False
        Me.dgvPreventivi.AllowUserToDeleteRows = False
        Me.dgvPreventivi.AllowUserToResizeRows = False
        Me.dgvPreventivi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPreventivi.ColumnHeadersHeight = 21
        Me.dgvPreventivi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PCHK, Me.PCLIENTE, Me.PERCORSOPDFPREVENTIVO, Me.CODICECLIENTE, Me.DTPREVENTIVO, Me.DGVBTNPDFPREVENTIVO, Me.SALVAFILEPREVENTIVO, Me.NOTEPREVENTIVO, Me.IDPREVENTIVO})
        Me.dgvPreventivi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPreventivi.Location = New System.Drawing.Point(3, 3)
        Me.dgvPreventivi.Name = "dgvPreventivi"
        Me.dgvPreventivi.ReadOnly = True
        Me.dgvPreventivi.RowHeadersVisible = False
        Me.dgvPreventivi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPreventivi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPreventivi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPreventivi.Size = New System.Drawing.Size(617, 269)
        Me.dgvPreventivi.TabIndex = 3
        Me.dgvPreventivi.Tag = "D"
        '
        'PCHK
        '
        Me.PCHK.FillWeight = 30.0!
        Me.PCHK.Frozen = True
        Me.PCHK.HeaderText = "?"
        Me.PCHK.Name = "PCHK"
        Me.PCHK.ReadOnly = True
        Me.PCHK.Width = 30
        '
        'PCLIENTE
        '
        Me.PCLIENTE.HeaderText = "Cliente"
        Me.PCLIENTE.Name = "PCLIENTE"
        Me.PCLIENTE.ReadOnly = True
        '
        'PERCORSOPDFPREVENTIVO
        '
        Me.PERCORSOPDFPREVENTIVO.HeaderText = "Percorso PDF"
        Me.PERCORSOPDFPREVENTIVO.Name = "PERCORSOPDFPREVENTIVO"
        Me.PERCORSOPDFPREVENTIVO.ReadOnly = True
        Me.PERCORSOPDFPREVENTIVO.Visible = False
        '
        'CODICECLIENTE
        '
        Me.CODICECLIENTE.HeaderText = "CODICECLIENTE"
        Me.CODICECLIENTE.Name = "CODICECLIENTE"
        Me.CODICECLIENTE.ReadOnly = True
        Me.CODICECLIENTE.Visible = False
        '
        'DTPREVENTIVO
        '
        Me.DTPREVENTIVO.FillWeight = 200.0!
        Me.DTPREVENTIVO.HeaderText = "Data Preventivo"
        Me.DTPREVENTIVO.Name = "DTPREVENTIVO"
        Me.DTPREVENTIVO.ReadOnly = True
        Me.DTPREVENTIVO.Width = 200
        '
        'DGVBTNPDFPREVENTIVO
        '
        Me.DGVBTNPDFPREVENTIVO.FillWeight = 40.0!
        Me.DGVBTNPDFPREVENTIVO.HeaderText = "Apri File"
        Me.DGVBTNPDFPREVENTIVO.Image = Global.Clienti.My.Resources.Resources.Apri_PDF
        Me.DGVBTNPDFPREVENTIVO.Name = "DGVBTNPDFPREVENTIVO"
        Me.DGVBTNPDFPREVENTIVO.ReadOnly = True
        Me.DGVBTNPDFPREVENTIVO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVBTNPDFPREVENTIVO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGVBTNPDFPREVENTIVO.ToolTipText = "Apri"
        Me.DGVBTNPDFPREVENTIVO.Width = 40
        '
        'SALVAFILEPREVENTIVO
        '
        Me.SALVAFILEPREVENTIVO.FillWeight = 40.0!
        Me.SALVAFILEPREVENTIVO.HeaderText = "Salva File"
        Me.SALVAFILEPREVENTIVO.Image = Global.Clienti.My.Resources.Resources.Save_PDF
        Me.SALVAFILEPREVENTIVO.Name = "SALVAFILEPREVENTIVO"
        Me.SALVAFILEPREVENTIVO.ReadOnly = True
        Me.SALVAFILEPREVENTIVO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SALVAFILEPREVENTIVO.ToolTipText = "Salva"
        Me.SALVAFILEPREVENTIVO.Width = 40
        '
        'NOTEPREVENTIVO
        '
        Me.NOTEPREVENTIVO.FillWeight = 230.0!
        Me.NOTEPREVENTIVO.HeaderText = "Note"
        Me.NOTEPREVENTIVO.Name = "NOTEPREVENTIVO"
        Me.NOTEPREVENTIVO.ReadOnly = True
        Me.NOTEPREVENTIVO.Width = 230
        '
        'IDPREVENTIVO
        '
        Me.IDPREVENTIVO.HeaderText = "IDPREVENTIVO"
        Me.IDPREVENTIVO.Name = "IDPREVENTIVO"
        Me.IDPREVENTIVO.ReadOnly = True
        Me.IDPREVENTIVO.Visible = False
        '
        'tbpOrdini
        '
        Me.tbpOrdini.BackColor = System.Drawing.SystemColors.Control
        Me.tbpOrdini.Controls.Add(Me.dgvOrdini)
        Me.tbpOrdini.Location = New System.Drawing.Point(4, 22)
        Me.tbpOrdini.Name = "tbpOrdini"
        Me.tbpOrdini.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOrdini.Size = New System.Drawing.Size(623, 275)
        Me.tbpOrdini.TabIndex = 5
        Me.tbpOrdini.Tag = "P-+-"
        Me.tbpOrdini.Text = "Ordini"
        '
        'dgvOrdini
        '
        Me.dgvOrdini.AllowUserToAddRows = False
        Me.dgvOrdini.AllowUserToDeleteRows = False
        Me.dgvOrdini.AllowUserToResizeRows = False
        Me.dgvOrdini.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvOrdini.ColumnHeadersHeight = 21
        Me.dgvOrdini.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OCHK, Me.OCLIENTE, Me.IDORDINE, Me.DTORDINE, Me.CAUSALEORDINE, Me.DESC_ORDINE, Me.NOTEORDINE})
        Me.dgvOrdini.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrdini.Location = New System.Drawing.Point(3, 3)
        Me.dgvOrdini.Name = "dgvOrdini"
        Me.dgvOrdini.ReadOnly = True
        Me.dgvOrdini.RowHeadersVisible = False
        Me.dgvOrdini.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvOrdini.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrdini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrdini.Size = New System.Drawing.Size(617, 269)
        Me.dgvOrdini.TabIndex = 7
        Me.dgvOrdini.Tag = "D"
        '
        'OCHK
        '
        Me.OCHK.FillWeight = 30.0!
        Me.OCHK.Frozen = True
        Me.OCHK.HeaderText = "?"
        Me.OCHK.Name = "OCHK"
        Me.OCHK.ReadOnly = True
        Me.OCHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OCHK.Width = 30
        '
        'OCLIENTE
        '
        Me.OCLIENTE.HeaderText = "Cliente"
        Me.OCLIENTE.Name = "OCLIENTE"
        Me.OCLIENTE.ReadOnly = True
        '
        'IDORDINE
        '
        Me.IDORDINE.HeaderText = "IDORDINE"
        Me.IDORDINE.Name = "IDORDINE"
        Me.IDORDINE.ReadOnly = True
        Me.IDORDINE.Visible = False
        '
        'DTORDINE
        '
        Me.DTORDINE.FillWeight = 175.0!
        Me.DTORDINE.HeaderText = "Data Ordine"
        Me.DTORDINE.MinimumWidth = 50
        Me.DTORDINE.Name = "DTORDINE"
        Me.DTORDINE.ReadOnly = True
        Me.DTORDINE.Width = 175
        '
        'CAUSALEORDINE
        '
        Me.CAUSALEORDINE.HeaderText = "Causale Ordine"
        Me.CAUSALEORDINE.Name = "CAUSALEORDINE"
        Me.CAUSALEORDINE.ReadOnly = True
        Me.CAUSALEORDINE.Visible = False
        '
        'DESC_ORDINE
        '
        Me.DESC_ORDINE.FillWeight = 200.0!
        Me.DESC_ORDINE.HeaderText = "Descrizione"
        Me.DESC_ORDINE.MinimumWidth = 50
        Me.DESC_ORDINE.Name = "DESC_ORDINE"
        Me.DESC_ORDINE.ReadOnly = True
        Me.DESC_ORDINE.Width = 200
        '
        'NOTEORDINE
        '
        Me.NOTEORDINE.FillWeight = 200.0!
        Me.NOTEORDINE.HeaderText = "Note"
        Me.NOTEORDINE.MinimumWidth = 50
        Me.NOTEORDINE.Name = "NOTEORDINE"
        Me.NOTEORDINE.ReadOnly = True
        Me.NOTEORDINE.Width = 200
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'fRecuperoEliminati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 301)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fRecuperoEliminati"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recupero Eliminati"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgVisite.ResumeLayout(False)
        CType(Me.dgvVisite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpTelefonate.ResumeLayout(False)
        CType(Me.dgvTelefonate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPreventivi.ResumeLayout(False)
        CType(Me.dgvPreventivi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpOrdini.ResumeLayout(False)
        CType(Me.dgvOrdini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpgVisite As System.Windows.Forms.TabPage
    Friend WithEvents dgvVisite As System.Windows.Forms.DataGridView
    Friend WithEvents tbpTelefonate As System.Windows.Forms.TabPage
    Friend WithEvents dgvTelefonate As System.Windows.Forms.DataGridView
    Friend WithEvents tbpPreventivi As System.Windows.Forms.TabPage
    Friend WithEvents dgvPreventivi As System.Windows.Forms.DataGridView
    Friend WithEvents tbpOrdini As System.Windows.Forms.TabPage
    Friend WithEvents dgvOrdini As System.Windows.Forms.DataGridView
    Friend WithEvents VCHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VCLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTVISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAUSALEVISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_VISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTEVISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDVISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDTELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTTELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAUSALETELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_TELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTETELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PCLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PERCORSOPDFPREVENTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODICECLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTPREVENTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVBTNPDFPREVENTIVO As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SALVAFILEPREVENTIVO As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NOTEPREVENTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPREVENTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OCHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OCLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAUSALEORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_ORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTEORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
