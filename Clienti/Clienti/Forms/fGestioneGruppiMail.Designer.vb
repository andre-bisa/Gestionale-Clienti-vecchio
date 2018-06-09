<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fGestioneGruppiMail
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
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddGruppo = New System.Windows.Forms.Button()
        Me.dgvGruppi = New System.Windows.Forms.DataGridView()
        Me.IDGRUPPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEGRUPPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEGRUPPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNOTEGRUPPO = New System.Windows.Forms.TextBox()
        Me.txtNOMEGRUPPO = New System.Windows.Forms.TextBox()
        Me.txtIDGRUPPO = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvMail = New System.Windows.Forms.DataGridView()
        Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAGIONESOCIALECLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvMail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(18, 13)
        Label1.TabIndex = 1
        Label1.Text = "ID"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 55)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(35, 13)
        Label2.TabIndex = 2
        Label2.Text = "Nome"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 85)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(30, 13)
        Label3.TabIndex = 3
        Label3.Text = "Note"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddGruppo)
        Me.GroupBox1.Controls.Add(Me.dgvGruppi)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gruppi"
        '
        'btnAddGruppo
        '
        Me.btnAddGruppo.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnAddGruppo.Location = New System.Drawing.Point(237, 9)
        Me.btnAddGruppo.Name = "btnAddGruppo"
        Me.btnAddGruppo.Size = New System.Drawing.Size(25, 21)
        Me.btnAddGruppo.TabIndex = 22
        Me.btnAddGruppo.UseVisualStyleBackColor = True
        '
        'dgvGruppi
        '
        Me.dgvGruppi.AllowUserToAddRows = False
        Me.dgvGruppi.AllowUserToDeleteRows = False
        Me.dgvGruppi.AllowUserToOrderColumns = True
        Me.dgvGruppi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGruppi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDGRUPPO, Me.NOMEGRUPPO, Me.NOTEGRUPPO})
        Me.dgvGruppi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGruppi.Location = New System.Drawing.Point(3, 16)
        Me.dgvGruppi.MultiSelect = False
        Me.dgvGruppi.Name = "dgvGruppi"
        Me.dgvGruppi.ReadOnly = True
        Me.dgvGruppi.RowHeadersVisible = False
        Me.dgvGruppi.Size = New System.Drawing.Size(264, 159)
        Me.dgvGruppi.TabIndex = 0
        '
        'IDGRUPPO
        '
        Me.IDGRUPPO.FillWeight = 30.0!
        Me.IDGRUPPO.Frozen = True
        Me.IDGRUPPO.HeaderText = "ID"
        Me.IDGRUPPO.Name = "IDGRUPPO"
        Me.IDGRUPPO.ReadOnly = True
        Me.IDGRUPPO.Width = 30
        '
        'NOMEGRUPPO
        '
        Me.NOMEGRUPPO.HeaderText = "Nome"
        Me.NOMEGRUPPO.Name = "NOMEGRUPPO"
        Me.NOMEGRUPPO.ReadOnly = True
        '
        'NOTEGRUPPO
        '
        Me.NOTEGRUPPO.HeaderText = "Note"
        Me.NOTEGRUPPO.Name = "NOTEGRUPPO"
        Me.NOTEGRUPPO.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNOTEGRUPPO)
        Me.GroupBox2.Controls.Add(Me.txtNOMEGRUPPO)
        Me.GroupBox2.Controls.Add(Me.txtIDGRUPPO)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 175)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dettagli"
        '
        'txtNOTEGRUPPO
        '
        Me.txtNOTEGRUPPO.Location = New System.Drawing.Point(65, 82)
        Me.txtNOTEGRUPPO.Multiline = True
        Me.txtNOTEGRUPPO.Name = "txtNOTEGRUPPO"
        Me.txtNOTEGRUPPO.Size = New System.Drawing.Size(129, 87)
        Me.txtNOTEGRUPPO.TabIndex = 6
        '
        'txtNOMEGRUPPO
        '
        Me.txtNOMEGRUPPO.Location = New System.Drawing.Point(65, 52)
        Me.txtNOMEGRUPPO.Name = "txtNOMEGRUPPO"
        Me.txtNOMEGRUPPO.Size = New System.Drawing.Size(129, 20)
        Me.txtNOMEGRUPPO.TabIndex = 5
        '
        'txtIDGRUPPO
        '
        Me.txtIDGRUPPO.Enabled = False
        Me.txtIDGRUPPO.Location = New System.Drawing.Point(65, 21)
        Me.txtIDGRUPPO.Name = "txtIDGRUPPO"
        Me.txtIDGRUPPO.Size = New System.Drawing.Size(46, 20)
        Me.txtIDGRUPPO.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvMail)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 196)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(476, 171)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Indirizzi Email"
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
        Me.dgvMail.Size = New System.Drawing.Size(470, 152)
        Me.dgvMail.TabIndex = 0
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
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(331, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(132, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Elimina gruppo selezionato"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'fGestioneGruppiMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 374)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fGestioneGruppiMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gruppi mail"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvGruppi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvMail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvGruppi As DataGridView
    Friend WithEvents IDGRUPPO As DataGridViewTextBoxColumn
    Friend WithEvents NOMEGRUPPO As DataGridViewTextBoxColumn
    Friend WithEvents NOTEGRUPPO As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNOTEGRUPPO As TextBox
    Friend WithEvents txtNOMEGRUPPO As TextBox
    Friend WithEvents txtIDGRUPPO As TextBox
    Friend WithEvents btnAddGruppo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvMail As DataGridView
    Friend WithEvents CHK As DataGridViewCheckBoxColumn
    Friend WithEvents IDMAIL As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents NOTEMAIL As DataGridViewTextBoxColumn
    Friend WithEvents RAGIONESOCIALECLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
