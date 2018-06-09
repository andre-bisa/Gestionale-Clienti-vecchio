<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fNewsletter
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvMail = New System.Windows.Forms.DataGridView()
        Me.txtOggetto = New System.Windows.Forms.TextBox()
        Me.txtTesto = New System.Windows.Forms.RichTextBox()
        Me.cmbPriorita = New System.Windows.Forms.ComboBox()
        Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAGIONESOCIALECLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvGruppi = New System.Windows.Forms.DataGridView()
        Me.CHECK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDGRUPPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEGRUPPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEGRUPPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lnkTutto = New System.Windows.Forms.LinkLabel()
        Me.lnkNiente = New System.Windows.Forms.LinkLabel()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(18, 49)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 13)
        Label1.TabIndex = 1
        Label1.Text = "Oggetto"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(18, 84)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(34, 13)
        Label2.TabIndex = 2
        Label2.Text = "Testo"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(18, 16)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(39, 13)
        Label3.TabIndex = 6
        Label3.Text = "Priorità"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvMail)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Indirizzi Email"
        '
        'dgvMail
        '
        Me.dgvMail.AllowUserToAddRows = False
        Me.dgvMail.AllowUserToDeleteRows = False
        Me.dgvMail.AllowUserToOrderColumns = True
        Me.dgvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.IDMAIL, Me.EMAIL, Me.NOTEMAIL, Me.RAGIONESOCIALECLIENTE})
        Me.dgvMail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMail.Location = New System.Drawing.Point(3, 16)
        Me.dgvMail.Name = "dgvMail"
        Me.dgvMail.ReadOnly = True
        Me.dgvMail.RowHeadersVisible = False
        Me.dgvMail.Size = New System.Drawing.Size(326, 152)
        Me.dgvMail.TabIndex = 0
        '
        'txtOggetto
        '
        Me.txtOggetto.Location = New System.Drawing.Point(69, 46)
        Me.txtOggetto.Name = "txtOggetto"
        Me.txtOggetto.Size = New System.Drawing.Size(257, 20)
        Me.txtOggetto.TabIndex = 3
        '
        'txtTesto
        '
        Me.txtTesto.HideSelection = False
        Me.txtTesto.Location = New System.Drawing.Point(69, 81)
        Me.txtTesto.Name = "txtTesto"
        Me.txtTesto.Size = New System.Drawing.Size(257, 200)
        Me.txtTesto.TabIndex = 4
        Me.txtTesto.Text = ""
        '
        'cmbPriorita
        '
        Me.cmbPriorita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriorita.FormattingEnabled = True
        Me.cmbPriorita.Items.AddRange(New Object() {"Bassa", "Normale", "Alta"})
        Me.cmbPriorita.Location = New System.Drawing.Point(69, 13)
        Me.cmbPriorita.Name = "cmbPriorita"
        Me.cmbPriorita.Size = New System.Drawing.Size(121, 21)
        Me.cmbPriorita.TabIndex = 5
        '
        'CHK
        '
        Me.CHK.HeaderText = "?"
        Me.CHK.Name = "CHK"
        Me.CHK.ReadOnly = True
        Me.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHK.Width = 20
        '
        'IDMAIL
        '
        Me.IDMAIL.HeaderText = "IDMAIL"
        Me.IDMAIL.Name = "IDMAIL"
        Me.IDMAIL.ReadOnly = True
        Me.IDMAIL.Visible = False
        '
        'EMAIL
        '
        Me.EMAIL.HeaderText = "Email"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        '
        'NOTEMAIL
        '
        Me.NOTEMAIL.HeaderText = "Note"
        Me.NOTEMAIL.Name = "NOTEMAIL"
        Me.NOTEMAIL.ReadOnly = True
        '
        'RAGIONESOCIALECLIENTE
        '
        Me.RAGIONESOCIALECLIENTE.HeaderText = "Ragione sociale"
        Me.RAGIONESOCIALECLIENTE.Name = "RAGIONESOCIALECLIENTE"
        Me.RAGIONESOCIALECLIENTE.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvGruppi)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 169)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gruppi"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTesto)
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Me.cmbPriorita)
        Me.GroupBox3.Controls.Add(Me.txtOggetto)
        Me.GroupBox3.Location = New System.Drawing.Point(360, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 346)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mail"
        '
        'dgvGruppi
        '
        Me.dgvGruppi.AllowUserToAddRows = False
        Me.dgvGruppi.AllowUserToDeleteRows = False
        Me.dgvGruppi.AllowUserToOrderColumns = True
        Me.dgvGruppi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGruppi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHECK, Me.IDGRUPPO, Me.NOMEGRUPPO, Me.NOTEGRUPPO})
        Me.dgvGruppi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGruppi.Location = New System.Drawing.Point(3, 16)
        Me.dgvGruppi.Name = "dgvGruppi"
        Me.dgvGruppi.ReadOnly = True
        Me.dgvGruppi.RowHeadersVisible = False
        Me.dgvGruppi.Size = New System.Drawing.Size(323, 150)
        Me.dgvGruppi.TabIndex = 1
        '
        'CHECK
        '
        Me.CHECK.Frozen = True
        Me.CHECK.HeaderText = "?"
        Me.CHECK.Name = "CHECK"
        Me.CHECK.ReadOnly = True
        Me.CHECK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHECK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHECK.Width = 20
        '
        'IDGRUPPO
        '
        Me.IDGRUPPO.HeaderText = "IDGRUPPO"
        Me.IDGRUPPO.Name = "IDGRUPPO"
        Me.IDGRUPPO.ReadOnly = True
        Me.IDGRUPPO.Visible = False
        '
        'NOMEGRUPPO
        '
        Me.NOMEGRUPPO.HeaderText = "Gruppo"
        Me.NOMEGRUPPO.Name = "NOMEGRUPPO"
        Me.NOMEGRUPPO.ReadOnly = True
        '
        'NOTEGRUPPO
        '
        Me.NOTEGRUPPO.HeaderText = "Note"
        Me.NOTEGRUPPO.Name = "NOTEGRUPPO"
        Me.NOTEGRUPPO.ReadOnly = True
        '
        'lnkTutto
        '
        Me.lnkTutto.AutoSize = True
        Me.lnkTutto.Location = New System.Drawing.Point(143, 3)
        Me.lnkTutto.Name = "lnkTutto"
        Me.lnkTutto.Size = New System.Drawing.Size(77, 13)
        Me.lnkTutto.TabIndex = 9
        Me.lnkTutto.TabStop = True
        Me.lnkTutto.Text = "Seleziona tutto"
        Me.lnkTutto.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkNiente
        '
        Me.lnkNiente.AutoSize = True
        Me.lnkNiente.Location = New System.Drawing.Point(226, 3)
        Me.lnkNiente.Name = "lnkNiente"
        Me.lnkNiente.Size = New System.Drawing.Size(89, 13)
        Me.lnkNiente.TabIndex = 10
        Me.lnkNiente.TabStop = True
        Me.lnkNiente.Text = "Deseleziona tutto"
        Me.lnkNiente.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'fNewsletter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 370)
        Me.Controls.Add(Me.lnkNiente)
        Me.Controls.Add(Me.lnkTutto)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fNewsletter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newsletter"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvMail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvGruppi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvMail As System.Windows.Forms.DataGridView
    Friend WithEvents txtOggetto As System.Windows.Forms.TextBox
    Friend WithEvents txtTesto As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbPriorita As System.Windows.Forms.ComboBox
    Friend WithEvents CHK As DataGridViewCheckBoxColumn
    Friend WithEvents IDMAIL As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents NOTEMAIL As DataGridViewTextBoxColumn
    Friend WithEvents RAGIONESOCIALECLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvGruppi As DataGridView
    Friend WithEvents CHECK As DataGridViewCheckBoxColumn
    Friend WithEvents IDGRUPPO As DataGridViewTextBoxColumn
    Friend WithEvents NOMEGRUPPO As DataGridViewTextBoxColumn
    Friend WithEvents NOTEGRUPPO As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lnkTutto As LinkLabel
    Friend WithEvents lnkNiente As LinkLabel
End Class
