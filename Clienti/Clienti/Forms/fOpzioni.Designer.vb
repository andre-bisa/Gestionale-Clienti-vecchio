<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fOpzioni
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCOLORERICERCA = New System.Windows.Forms.Label()
        Me.lblCOLOREMODIFICA = New System.Windows.Forms.Label()
        Me.lblCOLOREINSERIMENTO = New System.Windows.Forms.Label()
        Me.ColorDlg = New System.Windows.Forms.ColorDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkautologin = New System.Windows.Forms.CheckBox()
        Me.cmbAccesso = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEliminaUtente = New System.Windows.Forms.Button()
        Me.btnModificaUtente = New System.Windows.Forms.Button()
        Me.btnAggiungiUtente = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvUtenti = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATTIVO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCOLORERICERCA)
        Me.GroupBox1.Controls.Add(Me.lblCOLOREMODIFICA)
        Me.GroupBox1.Controls.Add(Me.lblCOLOREINSERIMENTO)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 110)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colori"
        '
        'lblCOLORERICERCA
        '
        Me.lblCOLORERICERCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOLORERICERCA.Location = New System.Drawing.Point(6, 68)
        Me.lblCOLORERICERCA.Name = "lblCOLORERICERCA"
        Me.lblCOLORERICERCA.Size = New System.Drawing.Size(100, 23)
        Me.lblCOLORERICERCA.TabIndex = 5
        Me.lblCOLORERICERCA.Text = "Ricerca"
        Me.lblCOLORERICERCA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCOLOREMODIFICA
        '
        Me.lblCOLOREMODIFICA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOLOREMODIFICA.Location = New System.Drawing.Point(6, 45)
        Me.lblCOLOREMODIFICA.Name = "lblCOLOREMODIFICA"
        Me.lblCOLOREMODIFICA.Size = New System.Drawing.Size(100, 23)
        Me.lblCOLOREMODIFICA.TabIndex = 4
        Me.lblCOLOREMODIFICA.Text = "Modifica"
        Me.lblCOLOREMODIFICA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCOLOREINSERIMENTO
        '
        Me.lblCOLOREINSERIMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOLOREINSERIMENTO.Location = New System.Drawing.Point(6, 22)
        Me.lblCOLOREINSERIMENTO.Name = "lblCOLOREINSERIMENTO"
        Me.lblCOLOREINSERIMENTO.Size = New System.Drawing.Size(100, 23)
        Me.lblCOLOREINSERIMENTO.TabIndex = 3
        Me.lblCOLOREINSERIMENTO.Text = "Inserimento"
        Me.lblCOLOREINSERIMENTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColorDlg
        '
        Me.ColorDlg.SolidColorOnly = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(305, 288)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(297, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Varie"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkautologin)
        Me.GroupBox2.Controls.Add(Me.cmbAccesso)
        Me.GroupBox2.Location = New System.Drawing.Point(149, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(119, 84)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accesso"
        '
        'chkautologin
        '
        Me.chkautologin.AutoSize = True
        Me.chkautologin.Enabled = False
        Me.chkautologin.Location = New System.Drawing.Point(17, 51)
        Me.chkautologin.Name = "chkautologin"
        Me.chkautologin.Size = New System.Drawing.Size(73, 17)
        Me.chkautologin.TabIndex = 1
        Me.chkautologin.Text = "Auto login"
        Me.chkautologin.UseVisualStyleBackColor = True
        '
        'cmbAccesso
        '
        Me.cmbAccesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccesso.FormattingEnabled = True
        Me.cmbAccesso.Items.AddRange(New Object() {"Non salvare", "Salva utente", "Salva utente e password"})
        Me.cmbAccesso.Location = New System.Drawing.Point(6, 24)
        Me.cmbAccesso.Name = "cmbAccesso"
        Me.cmbAccesso.Size = New System.Drawing.Size(107, 21)
        Me.cmbAccesso.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btnEliminaUtente)
        Me.TabPage2.Controls.Add(Me.btnModificaUtente)
        Me.TabPage2.Controls.Add(Me.btnAggiungiUtente)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(297, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Utenti"
        '
        'btnEliminaUtente
        '
        Me.btnEliminaUtente.Image = Global.Clienti.My.Resources.Resources.Delete
        Me.btnEliminaUtente.Location = New System.Drawing.Point(206, 233)
        Me.btnEliminaUtente.Name = "btnEliminaUtente"
        Me.btnEliminaUtente.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminaUtente.TabIndex = 3
        Me.btnEliminaUtente.Text = "Elimina"
        Me.btnEliminaUtente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminaUtente.UseVisualStyleBackColor = True
        '
        'btnModificaUtente
        '
        Me.btnModificaUtente.Image = Global.Clienti.My.Resources.Resources.modifica
        Me.btnModificaUtente.Location = New System.Drawing.Point(110, 233)
        Me.btnModificaUtente.Name = "btnModificaUtente"
        Me.btnModificaUtente.Size = New System.Drawing.Size(75, 23)
        Me.btnModificaUtente.TabIndex = 2
        Me.btnModificaUtente.Text = "Modifica"
        Me.btnModificaUtente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificaUtente.UseVisualStyleBackColor = True
        '
        'btnAggiungiUtente
        '
        Me.btnAggiungiUtente.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnAggiungiUtente.Location = New System.Drawing.Point(15, 233)
        Me.btnAggiungiUtente.Name = "btnAggiungiUtente"
        Me.btnAggiungiUtente.Size = New System.Drawing.Size(75, 23)
        Me.btnAggiungiUtente.TabIndex = 1
        Me.btnAggiungiUtente.Text = "Aggiungi"
        Me.btnAggiungiUtente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAggiungiUtente.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvUtenti)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 224)
        Me.Panel1.TabIndex = 0
        '
        'dgvUtenti
        '
        Me.dgvUtenti.AllowUserToAddRows = False
        Me.dgvUtenti.AllowUserToDeleteRows = False
        Me.dgvUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUtenti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.USERNAME, Me.ATTIVO})
        Me.dgvUtenti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUtenti.Location = New System.Drawing.Point(0, 0)
        Me.dgvUtenti.MultiSelect = False
        Me.dgvUtenti.Name = "dgvUtenti"
        Me.dgvUtenti.ReadOnly = True
        Me.dgvUtenti.RowHeadersVisible = False
        Me.dgvUtenti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvUtenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUtenti.Size = New System.Drawing.Size(291, 224)
        Me.dgvUtenti.TabIndex = 0
        '
        'ID
        '
        Me.ID.FillWeight = 30.0!
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 30
        '
        'USERNAME
        '
        Me.USERNAME.HeaderText = "Username"
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.ReadOnly = True
        '
        'ATTIVO
        '
        Me.ATTIVO.HeaderText = "Attivo"
        Me.ATTIVO.Name = "ATTIVO"
        Me.ATTIVO.ReadOnly = True
        Me.ATTIVO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ATTIVO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'fOpzioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 292)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fOpzioni"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opzioni"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCOLORERICERCA As System.Windows.Forms.Label
    Friend WithEvents lblCOLOREMODIFICA As System.Windows.Forms.Label
    Friend WithEvents lblCOLOREINSERIMENTO As System.Windows.Forms.Label
    Friend WithEvents ColorDlg As System.Windows.Forms.ColorDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnEliminaUtente As System.Windows.Forms.Button
    Friend WithEvents btnModificaUtente As System.Windows.Forms.Button
    Friend WithEvents btnAggiungiUtente As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvUtenti As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAccesso As System.Windows.Forms.ComboBox
    Friend WithEvents chkautologin As System.Windows.Forms.CheckBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ATTIVO As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
