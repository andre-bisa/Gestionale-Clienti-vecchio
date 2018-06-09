<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fClienti
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
        Dim Label8 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgAnagrafica = New System.Windows.Forms.TabPage()
        Me.txtRICERCAREFERENTE = New System.Windows.Forms.TextBox()
        Me.lblRicercaReferente = New System.Windows.Forms.Label()
        Me.txtSEDEALTERNATIVA = New System.Windows.Forms.TextBox()
        Me.txtPROVINCIA = New System.Windows.Forms.TextBox()
        Me.grpReferenti = New System.Windows.Forms.GroupBox()
        Me.btnAddReferenti = New System.Windows.Forms.Button()
        Me.dgvReferenti = New System.Windows.Forms.DataGridView()
        Me.IDREFERENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEREFERENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEREFERENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpMail = New System.Windows.Forms.GroupBox()
        Me.btnAddMail = New System.Windows.Forms.Button()
        Me.dgvMail = New System.Windows.Forms.DataGridView()
        Me.IDMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpTelefoni = New System.Windows.Forms.GroupBox()
        Me.btnAddTelefono = New System.Windows.Forms.Button()
        Me.dgvTelefoni = New System.Windows.Forms.DataGridView()
        Me.IDTELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTETELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCATALOGO = New System.Windows.Forms.TextBox()
        Me.txtNOTE = New System.Windows.Forms.TextBox()
        Me.txtGIORNALINO = New System.Windows.Forms.TextBox()
        Me.txtINDIRIZZOCLIENTE = New System.Windows.Forms.TextBox()
        Me.txtPI_CF = New System.Windows.Forms.TextBox()
        Me.tpgVisite = New System.Windows.Forms.TabPage()
        Me.btnNuovaVisita = New System.Windows.Forms.Button()
        Me.dgvVisite = New System.Windows.Forms.DataGridView()
        Me.IDVISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTVISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAUSALEVISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_VISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEVISITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpTelefonate = New System.Windows.Forms.TabPage()
        Me.btnNuovaTelefonata = New System.Windows.Forms.Button()
        Me.dgvTelefonate = New System.Windows.Forms.DataGridView()
        Me.IDTELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTTELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAUSALETELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_TELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTETELEFONATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpPreventivi = New System.Windows.Forms.TabPage()
        Me.btnNuovoPreventivo = New System.Windows.Forms.Button()
        Me.dgvPreventivi = New System.Windows.Forms.DataGridView()
        Me.IDPREVENTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERCORSOPDFPREVENTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODICECLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTPREVENTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVBTNPDFPREVENTIVO = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SALVAFILEPREVENTIVO = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NOTEPREVENTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpOrdini = New System.Windows.Forms.TabPage()
        Me.dgvOrdini = New System.Windows.Forms.DataGridView()
        Me.IDORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAUSALEORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_ORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEORDINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuovoOrdine = New System.Windows.Forms.Button()
        Me.tbpAzioniCliente = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnApriInTabella = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminaUtente = New System.Windows.Forms.Button()
        Me.txtRAGIONESOCIALECLIENTE = New System.Windows.Forms.TextBox()
        Me.grpVisite = New System.Windows.Forms.GroupBox()
        Me.txtIDVISITA = New System.Windows.Forms.TextBox()
        Me.btnSalvaVisita = New System.Windows.Forms.Button()
        Me.btnTornaElencoVisite = New System.Windows.Forms.Button()
        Me.txtNOTEVISITA = New System.Windows.Forms.TextBox()
        Me.txtDTVISITA = New System.Windows.Forms.DateTimePicker()
        Me.txtDESC_VISITA = New System.Windows.Forms.TextBox()
        Me.txtCAUSALEVISITA = New System.Windows.Forms.TextBox()
        Me.txtCODICECLIENTE = New System.Windows.Forms.TextBox()
        Me.chkBOOPROVV = New System.Windows.Forms.CheckBox()
        Me.grpTelefonata = New System.Windows.Forms.GroupBox()
        Me.txtIDTELEFONATA = New System.Windows.Forms.TextBox()
        Me.btnSalvaTelefonata = New System.Windows.Forms.Button()
        Me.btnTornaElencoTelefonata = New System.Windows.Forms.Button()
        Me.txtNOTETELEFONATA = New System.Windows.Forms.TextBox()
        Me.txtDTTELEFONATA = New System.Windows.Forms.DateTimePicker()
        Me.txtDESC_TELEFONATA = New System.Windows.Forms.TextBox()
        Me.txtCAUSALETELEFONATA = New System.Windows.Forms.TextBox()
        Me.grpPreventivo = New System.Windows.Forms.GroupBox()
        Me.btnSfogliaPreventivo = New System.Windows.Forms.Button()
        Me.txtPERCORSOPDFPREVENTIVO = New System.Windows.Forms.TextBox()
        Me.txtIDPREVENTIVO = New System.Windows.Forms.TextBox()
        Me.btnSalvaPreventivo = New System.Windows.Forms.Button()
        Me.btnTornaElencoPreventivo = New System.Windows.Forms.Button()
        Me.txtNOTEPREVENTIVO = New System.Windows.Forms.TextBox()
        Me.txtDTPREVENTIVO = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.grpOrdine = New System.Windows.Forms.GroupBox()
        Me.txtIDORDINE = New System.Windows.Forms.TextBox()
        Me.btnSalvaOrdine = New System.Windows.Forms.Button()
        Me.btnTornaElencoOrdine = New System.Windows.Forms.Button()
        Me.txtNOTEORDINE = New System.Windows.Forms.TextBox()
        Me.txtDTORDINE = New System.Windows.Forms.DateTimePicker()
        Me.txtDESC_ORDINE = New System.Windows.Forms.TextBox()
        Me.txtCAUSALEORDINE = New System.Windows.Forms.TextBox()
        Me.chkEvitaProvvisorio = New System.Windows.Forms.CheckBox()
        Me.chkBOOEXCLIENTE = New System.Windows.Forms.CheckBox()
        Me.chkEvitaEx = New System.Windows.Forms.CheckBox()
        Me.lblUltimaAzione = New System.Windows.Forms.Label()
        Me.txtDATAULTIMAAZIONE = New System.Windows.Forms.TextBox()
        Label8 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tpgAnagrafica.SuspendLayout()
        Me.grpReferenti.SuspendLayout()
        CType(Me.dgvReferenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMail.SuspendLayout()
        CType(Me.dgvMail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTelefoni.SuspendLayout()
        CType(Me.dgvTelefoni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgVisite.SuspendLayout()
        CType(Me.dgvVisite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpTelefonate.SuspendLayout()
        CType(Me.dgvTelefonate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPreventivi.SuspendLayout()
        CType(Me.dgvPreventivi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpOrdini.SuspendLayout()
        CType(Me.dgvOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpAzioniCliente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpVisite.SuspendLayout()
        Me.grpTelefonata.SuspendLayout()
        Me.grpPreventivo.SuspendLayout()
        Me.grpOrdine.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(19, 22)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(73, 13)
        Label8.TabIndex = 0
        Label8.Text = "Causale Visita"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(19, 50)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(30, 13)
        Label11.TabIndex = 1
        Label11.Text = "Data"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(28, 80)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(30, 13)
        Label12.TabIndex = 2
        Label12.Text = "Note"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(28, 80)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(30, 13)
        Label1.TabIndex = 2
        Label1.Text = "Note"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(19, 50)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(30, 13)
        Label13.TabIndex = 1
        Label13.Text = "Data"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(19, 22)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(99, 13)
        Label14.TabIndex = 0
        Label14.Text = "Causale Telefonata"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(28, 52)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(30, 13)
        Label15.TabIndex = 2
        Label15.Text = "Note"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(76, 22)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(30, 13)
        Label16.TabIndex = 1
        Label16.Text = "Data"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(28, 170)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(28, 13)
        Label17.TabIndex = 8
        Label17.Text = "PDF"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(28, 80)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(30, 13)
        Label19.TabIndex = 2
        Label19.Text = "Note"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(19, 50)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(30, 13)
        Label20.TabIndex = 1
        Label20.Text = "Data"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(19, 22)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(79, 13)
        Label21.TabIndex = 0
        Label21.Text = "Causale Ordine"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(192, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(35, 13)
        Label2.TabIndex = 3
        Label2.Tag = "L"
        Label2.Text = "PI/CF"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(61, 18)
        Label3.TabIndex = 5
        Label3.Tag = "L"
        Label3.Text = "C. Cliente"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(10, 35)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 7
        Label4.Tag = "L"
        Label4.Text = "Indirizzo"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(5, 93)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(54, 13)
        Label6.TabIndex = 11
        Label6.Tag = "L"
        Label6.Text = "Giornalino"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(15, 124)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(33, 13)
        Label7.TabIndex = 13
        Label7.Tag = "L"
        Label7.Text = "Note:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(10, 9)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(49, 13)
        Label9.TabIndex = 18
        Label9.Tag = "L"
        Label9.Text = "Catalogo"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(5, 63)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(85, 13)
        Label18.TabIndex = 22
        Label18.Tag = "L"
        Label18.Text = "Sede Alternativa"
        Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(269, 35)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(51, 13)
        Label5.TabIndex = 21
        Label5.Tag = "L"
        Label5.Text = "Provincia"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgAnagrafica)
        Me.TabControl1.Controls.Add(Me.tpgVisite)
        Me.TabControl1.Controls.Add(Me.tbpTelefonate)
        Me.TabControl1.Controls.Add(Me.tbpPreventivi)
        Me.TabControl1.Controls.Add(Me.tbpOrdini)
        Me.TabControl1.Controls.Add(Me.tbpAzioniCliente)
        Me.TabControl1.ItemSize = New System.Drawing.Size(63, 18)
        Me.TabControl1.Location = New System.Drawing.Point(12, 57)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(13, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 316)
        Me.TabControl1.TabIndex = 7
        Me.TabControl1.TabStop = False
        Me.TabControl1.Tag = ""
        '
        'tpgAnagrafica
        '
        Me.tpgAnagrafica.BackColor = System.Drawing.SystemColors.Control
        Me.tpgAnagrafica.Controls.Add(Me.txtRICERCAREFERENTE)
        Me.tpgAnagrafica.Controls.Add(Me.lblRicercaReferente)
        Me.tpgAnagrafica.Controls.Add(Me.txtSEDEALTERNATIVA)
        Me.tpgAnagrafica.Controls.Add(Label18)
        Me.tpgAnagrafica.Controls.Add(Label5)
        Me.tpgAnagrafica.Controls.Add(Me.txtPROVINCIA)
        Me.tpgAnagrafica.Controls.Add(Me.grpReferenti)
        Me.tpgAnagrafica.Controls.Add(Me.grpMail)
        Me.tpgAnagrafica.Controls.Add(Me.grpTelefoni)
        Me.tpgAnagrafica.Controls.Add(Me.txtCATALOGO)
        Me.tpgAnagrafica.Controls.Add(Label9)
        Me.tpgAnagrafica.Controls.Add(Me.txtNOTE)
        Me.tpgAnagrafica.Controls.Add(Label7)
        Me.tpgAnagrafica.Controls.Add(Me.txtGIORNALINO)
        Me.tpgAnagrafica.Controls.Add(Label6)
        Me.tpgAnagrafica.Controls.Add(Me.txtINDIRIZZOCLIENTE)
        Me.tpgAnagrafica.Controls.Add(Label4)
        Me.tpgAnagrafica.Controls.Add(Me.txtPI_CF)
        Me.tpgAnagrafica.Controls.Add(Label2)
        Me.tpgAnagrafica.Location = New System.Drawing.Point(4, 22)
        Me.tpgAnagrafica.Name = "tpgAnagrafica"
        Me.tpgAnagrafica.Padding = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.tpgAnagrafica.Size = New System.Drawing.Size(640, 290)
        Me.tpgAnagrafica.TabIndex = 0
        Me.tpgAnagrafica.Tag = "P+++"
        Me.tpgAnagrafica.Text = "Anagrafica Cliente"
        Me.tpgAnagrafica.ToolTipText = "Anagrafica"
        '
        'txtRICERCAREFERENTE
        '
        Me.txtRICERCAREFERENTE.Location = New System.Drawing.Point(71, 233)
        Me.txtRICERCAREFERENTE.MaxLength = 255
        Me.txtRICERCAREFERENTE.Name = "txtRICERCAREFERENTE"
        Me.txtRICERCAREFERENTE.Size = New System.Drawing.Size(156, 20)
        Me.txtRICERCAREFERENTE.TabIndex = 8
        Me.txtRICERCAREFERENTE.Tag = "V"
        '
        'lblRicercaReferente
        '
        Me.lblRicercaReferente.AutoSize = True
        Me.lblRicercaReferente.Location = New System.Drawing.Point(11, 236)
        Me.lblRicercaReferente.Name = "lblRicercaReferente"
        Me.lblRicercaReferente.Size = New System.Drawing.Size(54, 13)
        Me.lblRicercaReferente.TabIndex = 23
        Me.lblRicercaReferente.Tag = "L"
        Me.lblRicercaReferente.Text = "Referente"
        '
        'txtSEDEALTERNATIVA
        '
        Me.txtSEDEALTERNATIVA.Location = New System.Drawing.Point(96, 60)
        Me.txtSEDEALTERNATIVA.MaxLength = 255
        Me.txtSEDEALTERNATIVA.Name = "txtSEDEALTERNATIVA"
        Me.txtSEDEALTERNATIVA.Size = New System.Drawing.Size(197, 20)
        Me.txtSEDEALTERNATIVA.TabIndex = 5
        Me.txtSEDEALTERNATIVA.Tag = "T+++"
        '
        'txtPROVINCIA
        '
        Me.txtPROVINCIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPROVINCIA.Location = New System.Drawing.Point(320, 32)
        Me.txtPROVINCIA.MaxLength = 3
        Me.txtPROVINCIA.Name = "txtPROVINCIA"
        Me.txtPROVINCIA.Size = New System.Drawing.Size(41, 20)
        Me.txtPROVINCIA.TabIndex = 4
        Me.txtPROVINCIA.Tag = "T+++"
        Me.txtPROVINCIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpReferenti
        '
        Me.grpReferenti.Controls.Add(Me.btnAddReferenti)
        Me.grpReferenti.Controls.Add(Me.dgvReferenti)
        Me.grpReferenti.Location = New System.Drawing.Point(393, 210)
        Me.grpReferenti.Name = "grpReferenti"
        Me.grpReferenti.Size = New System.Drawing.Size(237, 74)
        Me.grpReferenti.TabIndex = 11
        Me.grpReferenti.TabStop = False
        Me.grpReferenti.Tag = "G-+-"
        Me.grpReferenti.Text = "Referenti"
        '
        'btnAddReferenti
        '
        Me.btnAddReferenti.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnAddReferenti.Location = New System.Drawing.Point(206, 8)
        Me.btnAddReferenti.Name = "btnAddReferenti"
        Me.btnAddReferenti.Size = New System.Drawing.Size(25, 21)
        Me.btnAddReferenti.TabIndex = 21
        Me.btnAddReferenti.UseVisualStyleBackColor = True
        '
        'dgvReferenti
        '
        Me.dgvReferenti.AllowUserToAddRows = False
        Me.dgvReferenti.AllowUserToDeleteRows = False
        Me.dgvReferenti.AllowUserToResizeRows = False
        Me.dgvReferenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReferenti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDREFERENTE, Me.NOMEREFERENTE, Me.NOTEREFERENTE})
        Me.dgvReferenti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReferenti.Location = New System.Drawing.Point(3, 16)
        Me.dgvReferenti.MultiSelect = False
        Me.dgvReferenti.Name = "dgvReferenti"
        Me.dgvReferenti.ReadOnly = True
        Me.dgvReferenti.RowHeadersVisible = False
        Me.dgvReferenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReferenti.Size = New System.Drawing.Size(231, 55)
        Me.dgvReferenti.TabIndex = 0
        Me.dgvReferenti.Tag = "D"
        '
        'IDREFERENTE
        '
        Me.IDREFERENTE.HeaderText = "ID"
        Me.IDREFERENTE.Name = "IDREFERENTE"
        Me.IDREFERENTE.ReadOnly = True
        Me.IDREFERENTE.Visible = False
        '
        'NOMEREFERENTE
        '
        Me.NOMEREFERENTE.HeaderText = "Referente"
        Me.NOMEREFERENTE.Name = "NOMEREFERENTE"
        Me.NOMEREFERENTE.ReadOnly = True
        '
        'NOTEREFERENTE
        '
        Me.NOTEREFERENTE.HeaderText = "Note"
        Me.NOTEREFERENTE.Name = "NOTEREFERENTE"
        Me.NOTEREFERENTE.ReadOnly = True
        '
        'grpMail
        '
        Me.grpMail.Controls.Add(Me.btnAddMail)
        Me.grpMail.Controls.Add(Me.dgvMail)
        Me.grpMail.Location = New System.Drawing.Point(393, 108)
        Me.grpMail.Name = "grpMail"
        Me.grpMail.Size = New System.Drawing.Size(237, 99)
        Me.grpMail.TabIndex = 10
        Me.grpMail.TabStop = False
        Me.grpMail.Tag = "G-+-"
        Me.grpMail.Text = "E-Mail"
        '
        'btnAddMail
        '
        Me.btnAddMail.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnAddMail.Location = New System.Drawing.Point(206, 8)
        Me.btnAddMail.Name = "btnAddMail"
        Me.btnAddMail.Size = New System.Drawing.Size(25, 21)
        Me.btnAddMail.TabIndex = 21
        Me.btnAddMail.UseVisualStyleBackColor = True
        '
        'dgvMail
        '
        Me.dgvMail.AllowUserToAddRows = False
        Me.dgvMail.AllowUserToDeleteRows = False
        Me.dgvMail.AllowUserToResizeRows = False
        Me.dgvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDMAIL, Me.EMAIL, Me.NOTEMAIL})
        Me.dgvMail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMail.Location = New System.Drawing.Point(3, 16)
        Me.dgvMail.MultiSelect = False
        Me.dgvMail.Name = "dgvMail"
        Me.dgvMail.ReadOnly = True
        Me.dgvMail.RowHeadersVisible = False
        Me.dgvMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMail.Size = New System.Drawing.Size(231, 80)
        Me.dgvMail.TabIndex = 0
        Me.dgvMail.Tag = "D"
        '
        'IDMAIL
        '
        Me.IDMAIL.HeaderText = "ID"
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
        'grpTelefoni
        '
        Me.grpTelefoni.Controls.Add(Me.btnAddTelefono)
        Me.grpTelefoni.Controls.Add(Me.dgvTelefoni)
        Me.grpTelefoni.Location = New System.Drawing.Point(393, 6)
        Me.grpTelefoni.Name = "grpTelefoni"
        Me.grpTelefoni.Size = New System.Drawing.Size(237, 99)
        Me.grpTelefoni.TabIndex = 9
        Me.grpTelefoni.TabStop = False
        Me.grpTelefoni.Tag = "G-+-"
        Me.grpTelefoni.Text = "Telefoni"
        '
        'btnAddTelefono
        '
        Me.btnAddTelefono.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnAddTelefono.Location = New System.Drawing.Point(206, 8)
        Me.btnAddTelefono.Name = "btnAddTelefono"
        Me.btnAddTelefono.Size = New System.Drawing.Size(25, 21)
        Me.btnAddTelefono.TabIndex = 21
        Me.btnAddTelefono.UseVisualStyleBackColor = True
        '
        'dgvTelefoni
        '
        Me.dgvTelefoni.AllowUserToAddRows = False
        Me.dgvTelefoni.AllowUserToDeleteRows = False
        Me.dgvTelefoni.AllowUserToResizeRows = False
        Me.dgvTelefoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefoni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTELEFONO, Me.TELEFONO, Me.NOTETELEFONO})
        Me.dgvTelefoni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTelefoni.Location = New System.Drawing.Point(3, 16)
        Me.dgvTelefoni.MultiSelect = False
        Me.dgvTelefoni.Name = "dgvTelefoni"
        Me.dgvTelefoni.ReadOnly = True
        Me.dgvTelefoni.RowHeadersVisible = False
        Me.dgvTelefoni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefoni.Size = New System.Drawing.Size(231, 80)
        Me.dgvTelefoni.TabIndex = 0
        Me.dgvTelefoni.Tag = "D"
        '
        'IDTELEFONO
        '
        Me.IDTELEFONO.HeaderText = "ID"
        Me.IDTELEFONO.Name = "IDTELEFONO"
        Me.IDTELEFONO.ReadOnly = True
        Me.IDTELEFONO.Visible = False
        '
        'TELEFONO
        '
        Me.TELEFONO.HeaderText = "Telefoni"
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.ReadOnly = True
        '
        'NOTETELEFONO
        '
        Me.NOTETELEFONO.HeaderText = "Note"
        Me.NOTETELEFONO.Name = "NOTETELEFONO"
        Me.NOTETELEFONO.ReadOnly = True
        '
        'txtCATALOGO
        '
        Me.txtCATALOGO.Location = New System.Drawing.Point(65, 6)
        Me.txtCATALOGO.MaxLength = 10
        Me.txtCATALOGO.Name = "txtCATALOGO"
        Me.txtCATALOGO.Size = New System.Drawing.Size(121, 20)
        Me.txtCATALOGO.TabIndex = 1
        Me.txtCATALOGO.Tag = "T+++"
        '
        'txtNOTE
        '
        Me.txtNOTE.Location = New System.Drawing.Point(54, 120)
        Me.txtNOTE.Multiline = True
        Me.txtNOTE.Name = "txtNOTE"
        Me.txtNOTE.Size = New System.Drawing.Size(256, 97)
        Me.txtNOTE.TabIndex = 7
        Me.txtNOTE.Tag = "T++-"
        '
        'txtGIORNALINO
        '
        Me.txtGIORNALINO.Location = New System.Drawing.Point(58, 90)
        Me.txtGIORNALINO.MaxLength = 50
        Me.txtGIORNALINO.Name = "txtGIORNALINO"
        Me.txtGIORNALINO.Size = New System.Drawing.Size(206, 20)
        Me.txtGIORNALINO.TabIndex = 6
        Me.txtGIORNALINO.Tag = "T+++"
        '
        'txtINDIRIZZOCLIENTE
        '
        Me.txtINDIRIZZOCLIENTE.Location = New System.Drawing.Point(61, 32)
        Me.txtINDIRIZZOCLIENTE.MaxLength = 255
        Me.txtINDIRIZZOCLIENTE.Name = "txtINDIRIZZOCLIENTE"
        Me.txtINDIRIZZOCLIENTE.Size = New System.Drawing.Size(206, 20)
        Me.txtINDIRIZZOCLIENTE.TabIndex = 3
        Me.txtINDIRIZZOCLIENTE.Tag = "T+++O"
        '
        'txtPI_CF
        '
        Me.txtPI_CF.Location = New System.Drawing.Point(233, 6)
        Me.txtPI_CF.MaxLength = 16
        Me.txtPI_CF.Name = "txtPI_CF"
        Me.txtPI_CF.Size = New System.Drawing.Size(150, 20)
        Me.txtPI_CF.TabIndex = 2
        Me.txtPI_CF.Tag = "T+++"
        '
        'tpgVisite
        '
        Me.tpgVisite.BackColor = System.Drawing.SystemColors.Control
        Me.tpgVisite.Controls.Add(Me.btnNuovaVisita)
        Me.tpgVisite.Controls.Add(Me.dgvVisite)
        Me.tpgVisite.Location = New System.Drawing.Point(4, 22)
        Me.tpgVisite.Name = "tpgVisite"
        Me.tpgVisite.Padding = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.tpgVisite.Size = New System.Drawing.Size(640, 290)
        Me.tpgVisite.TabIndex = 1
        Me.tpgVisite.Tag = "P-+-"
        Me.tpgVisite.Text = "Visite"
        Me.tpgVisite.ToolTipText = "Visite"
        '
        'btnNuovaVisita
        '
        Me.btnNuovaVisita.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnNuovaVisita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuovaVisita.Location = New System.Drawing.Point(10, 257)
        Me.btnNuovaVisita.Name = "btnNuovaVisita"
        Me.btnNuovaVisita.Size = New System.Drawing.Size(99, 23)
        Me.btnNuovaVisita.TabIndex = 1
        Me.btnNuovaVisita.Text = "  &Nuova Visita"
        Me.btnNuovaVisita.UseCompatibleTextRendering = True
        Me.btnNuovaVisita.UseVisualStyleBackColor = True
        '
        'dgvVisite
        '
        Me.dgvVisite.AllowUserToAddRows = False
        Me.dgvVisite.AllowUserToDeleteRows = False
        Me.dgvVisite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVisite.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVisite.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDVISITA, Me.DTVISITA, Me.CAUSALEVISITA, Me.DESC_VISITA, Me.NOTEVISITA})
        Me.dgvVisite.Location = New System.Drawing.Point(6, 6)
        Me.dgvVisite.MultiSelect = False
        Me.dgvVisite.Name = "dgvVisite"
        Me.dgvVisite.ReadOnly = True
        Me.dgvVisite.RowHeadersVisible = False
        Me.dgvVisite.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvVisite.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVisite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVisite.ShowEditingIcon = False
        Me.dgvVisite.Size = New System.Drawing.Size(600, 245)
        Me.dgvVisite.TabIndex = 0
        Me.dgvVisite.Tag = "D"
        '
        'IDVISITA
        '
        Me.IDVISITA.Frozen = True
        Me.IDVISITA.HeaderText = "ID"
        Me.IDVISITA.Name = "IDVISITA"
        Me.IDVISITA.ReadOnly = True
        Me.IDVISITA.Visible = False
        '
        'DTVISITA
        '
        Me.DTVISITA.FillWeight = 175.0!
        Me.DTVISITA.Frozen = True
        Me.DTVISITA.HeaderText = "Data Visita"
        Me.DTVISITA.MinimumWidth = 50
        Me.DTVISITA.Name = "DTVISITA"
        Me.DTVISITA.ReadOnly = True
        Me.DTVISITA.Width = 175
        '
        'CAUSALEVISITA
        '
        Me.CAUSALEVISITA.Frozen = True
        Me.CAUSALEVISITA.HeaderText = "Causale Visita"
        Me.CAUSALEVISITA.Name = "CAUSALEVISITA"
        Me.CAUSALEVISITA.ReadOnly = True
        '
        'DESC_VISITA
        '
        Me.DESC_VISITA.FillWeight = 150.0!
        Me.DESC_VISITA.Frozen = True
        Me.DESC_VISITA.HeaderText = "Descrizione"
        Me.DESC_VISITA.MinimumWidth = 50
        Me.DESC_VISITA.Name = "DESC_VISITA"
        Me.DESC_VISITA.ReadOnly = True
        Me.DESC_VISITA.Width = 150
        '
        'NOTEVISITA
        '
        Me.NOTEVISITA.FillWeight = 150.0!
        Me.NOTEVISITA.Frozen = True
        Me.NOTEVISITA.HeaderText = "Note"
        Me.NOTEVISITA.MinimumWidth = 50
        Me.NOTEVISITA.Name = "NOTEVISITA"
        Me.NOTEVISITA.ReadOnly = True
        Me.NOTEVISITA.Width = 150
        '
        'tbpTelefonate
        '
        Me.tbpTelefonate.BackColor = System.Drawing.SystemColors.Control
        Me.tbpTelefonate.Controls.Add(Me.btnNuovaTelefonata)
        Me.tbpTelefonate.Controls.Add(Me.dgvTelefonate)
        Me.tbpTelefonate.Location = New System.Drawing.Point(4, 22)
        Me.tbpTelefonate.Name = "tbpTelefonate"
        Me.tbpTelefonate.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTelefonate.Size = New System.Drawing.Size(640, 290)
        Me.tbpTelefonate.TabIndex = 2
        Me.tbpTelefonate.Tag = "P-+-"
        Me.tbpTelefonate.Text = "Telefonate"
        '
        'btnNuovaTelefonata
        '
        Me.btnNuovaTelefonata.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnNuovaTelefonata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuovaTelefonata.Location = New System.Drawing.Point(6, 257)
        Me.btnNuovaTelefonata.Name = "btnNuovaTelefonata"
        Me.btnNuovaTelefonata.Size = New System.Drawing.Size(122, 23)
        Me.btnNuovaTelefonata.TabIndex = 2
        Me.btnNuovaTelefonata.Text = "   &Nuova Telefonata"
        Me.btnNuovaTelefonata.UseCompatibleTextRendering = True
        Me.btnNuovaTelefonata.UseVisualStyleBackColor = True
        '
        'dgvTelefonate
        '
        Me.dgvTelefonate.AllowUserToAddRows = False
        Me.dgvTelefonate.AllowUserToDeleteRows = False
        Me.dgvTelefonate.AllowUserToResizeRows = False
        Me.dgvTelefonate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTelefonate.ColumnHeadersHeight = 21
        Me.dgvTelefonate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTELEFONATA, Me.DTTELEFONATA, Me.CAUSALETELEFONATA, Me.DESC_TELEFONATA, Me.NOTETELEFONATA})
        Me.dgvTelefonate.Location = New System.Drawing.Point(6, 6)
        Me.dgvTelefonate.Name = "dgvTelefonate"
        Me.dgvTelefonate.ReadOnly = True
        Me.dgvTelefonate.RowHeadersVisible = False
        Me.dgvTelefonate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTelefonate.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTelefonate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonate.Size = New System.Drawing.Size(600, 245)
        Me.dgvTelefonate.TabIndex = 1
        Me.dgvTelefonate.Tag = "D"
        '
        'IDTELEFONATA
        '
        Me.IDTELEFONATA.HeaderText = "IDTELEFONATE"
        Me.IDTELEFONATA.Name = "IDTELEFONATA"
        Me.IDTELEFONATA.ReadOnly = True
        Me.IDTELEFONATA.Visible = False
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
        Me.tbpPreventivi.Controls.Add(Me.btnNuovoPreventivo)
        Me.tbpPreventivi.Controls.Add(Me.dgvPreventivi)
        Me.tbpPreventivi.Location = New System.Drawing.Point(4, 22)
        Me.tbpPreventivi.Name = "tbpPreventivi"
        Me.tbpPreventivi.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPreventivi.Size = New System.Drawing.Size(640, 290)
        Me.tbpPreventivi.TabIndex = 3
        Me.tbpPreventivi.Tag = "P-+-"
        Me.tbpPreventivi.Text = "Preventivi"
        '
        'btnNuovoPreventivo
        '
        Me.btnNuovoPreventivo.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnNuovoPreventivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuovoPreventivo.Location = New System.Drawing.Point(6, 257)
        Me.btnNuovoPreventivo.Name = "btnNuovoPreventivo"
        Me.btnNuovoPreventivo.Size = New System.Drawing.Size(122, 23)
        Me.btnNuovoPreventivo.TabIndex = 4
        Me.btnNuovoPreventivo.Text = "   &Nuovo Preventivo"
        Me.btnNuovoPreventivo.UseCompatibleTextRendering = True
        Me.btnNuovoPreventivo.UseVisualStyleBackColor = True
        '
        'dgvPreventivi
        '
        Me.dgvPreventivi.AllowUserToAddRows = False
        Me.dgvPreventivi.AllowUserToDeleteRows = False
        Me.dgvPreventivi.AllowUserToResizeRows = False
        Me.dgvPreventivi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPreventivi.ColumnHeadersHeight = 21
        Me.dgvPreventivi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPREVENTIVO, Me.PERCORSOPDFPREVENTIVO, Me.CODICECLIENTE, Me.DTPREVENTIVO, Me.DGVBTNPDFPREVENTIVO, Me.SALVAFILEPREVENTIVO, Me.NOTEPREVENTIVO})
        Me.dgvPreventivi.Location = New System.Drawing.Point(6, 6)
        Me.dgvPreventivi.Name = "dgvPreventivi"
        Me.dgvPreventivi.ReadOnly = True
        Me.dgvPreventivi.RowHeadersVisible = False
        Me.dgvPreventivi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPreventivi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPreventivi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPreventivi.Size = New System.Drawing.Size(600, 245)
        Me.dgvPreventivi.TabIndex = 3
        Me.dgvPreventivi.Tag = "D"
        '
        'IDPREVENTIVO
        '
        Me.IDPREVENTIVO.HeaderText = "IDPREVENTIVO"
        Me.IDPREVENTIVO.Name = "IDPREVENTIVO"
        Me.IDPREVENTIVO.ReadOnly = True
        Me.IDPREVENTIVO.Visible = False
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
        'tbpOrdini
        '
        Me.tbpOrdini.BackColor = System.Drawing.SystemColors.Control
        Me.tbpOrdini.Controls.Add(Me.dgvOrdini)
        Me.tbpOrdini.Controls.Add(Me.btnNuovoOrdine)
        Me.tbpOrdini.Location = New System.Drawing.Point(4, 22)
        Me.tbpOrdini.Name = "tbpOrdini"
        Me.tbpOrdini.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOrdini.Size = New System.Drawing.Size(640, 290)
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
        Me.dgvOrdini.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDORDINE, Me.DTORDINE, Me.CAUSALEORDINE, Me.DESC_ORDINE, Me.NOTEORDINE})
        Me.dgvOrdini.Location = New System.Drawing.Point(6, 6)
        Me.dgvOrdini.Name = "dgvOrdini"
        Me.dgvOrdini.ReadOnly = True
        Me.dgvOrdini.RowHeadersVisible = False
        Me.dgvOrdini.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvOrdini.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrdini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrdini.Size = New System.Drawing.Size(600, 245)
        Me.dgvOrdini.TabIndex = 7
        Me.dgvOrdini.Tag = "D"
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
        'btnNuovoOrdine
        '
        Me.btnNuovoOrdine.Image = Global.Clienti.My.Resources.Resources.Add
        Me.btnNuovoOrdine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuovoOrdine.Location = New System.Drawing.Point(6, 257)
        Me.btnNuovoOrdine.Name = "btnNuovoOrdine"
        Me.btnNuovoOrdine.Size = New System.Drawing.Size(122, 23)
        Me.btnNuovoOrdine.TabIndex = 6
        Me.btnNuovoOrdine.Text = "&Nuovo Ordine"
        Me.btnNuovoOrdine.UseCompatibleTextRendering = True
        Me.btnNuovoOrdine.UseVisualStyleBackColor = True
        '
        'tbpAzioniCliente
        '
        Me.tbpAzioniCliente.BackColor = System.Drawing.SystemColors.Control
        Me.tbpAzioniCliente.Controls.Add(Me.GroupBox2)
        Me.tbpAzioniCliente.Controls.Add(Me.GroupBox1)
        Me.tbpAzioniCliente.Location = New System.Drawing.Point(4, 22)
        Me.tbpAzioniCliente.Name = "tbpAzioniCliente"
        Me.tbpAzioniCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAzioniCliente.Size = New System.Drawing.Size(640, 290)
        Me.tbpAzioniCliente.TabIndex = 4
        Me.tbpAzioniCliente.Tag = "P-+-"
        Me.tbpAzioniCliente.Text = "Azioni Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnApriInTabella)
        Me.GroupBox2.Location = New System.Drawing.Point(247, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 74)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apri in Tabella"
        '
        'btnApriInTabella
        '
        Me.btnApriInTabella.Image = Global.Clienti.My.Resources.Resources.tabella
        Me.btnApriInTabella.Location = New System.Drawing.Point(6, 24)
        Me.btnApriInTabella.Name = "btnApriInTabella"
        Me.btnApriInTabella.Size = New System.Drawing.Size(116, 42)
        Me.btnApriInTabella.TabIndex = 0
        Me.btnApriInTabella.Text = "Apri Ricerca in &Tabella"
        Me.btnApriInTabella.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApriInTabella.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEliminaUtente)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 74)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "Azioni Utente con Approvazione"
        '
        'btnEliminaUtente
        '
        Me.btnEliminaUtente.Image = Global.Clienti.My.Resources.Resources.Cancel
        Me.btnEliminaUtente.Location = New System.Drawing.Point(33, 24)
        Me.btnEliminaUtente.Name = "btnEliminaUtente"
        Me.btnEliminaUtente.Size = New System.Drawing.Size(110, 42)
        Me.btnEliminaUtente.TabIndex = 10
        Me.btnEliminaUtente.Text = "Elimina Utente"
        Me.btnEliminaUtente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminaUtente.UseVisualStyleBackColor = True
        '
        'txtRAGIONESOCIALECLIENTE
        '
        Me.txtRAGIONESOCIALECLIENTE.Enabled = False
        Me.txtRAGIONESOCIALECLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRAGIONESOCIALECLIENTE.Location = New System.Drawing.Point(136, 7)
        Me.txtRAGIONESOCIALECLIENTE.Name = "txtRAGIONESOCIALECLIENTE"
        Me.txtRAGIONESOCIALECLIENTE.Size = New System.Drawing.Size(391, 22)
        Me.txtRAGIONESOCIALECLIENTE.TabIndex = 1
        Me.txtRAGIONESOCIALECLIENTE.TabStop = False
        Me.txtRAGIONESOCIALECLIENTE.Tag = "T+--O"
        '
        'grpVisite
        '
        Me.grpVisite.Controls.Add(Me.txtIDVISITA)
        Me.grpVisite.Controls.Add(Me.btnSalvaVisita)
        Me.grpVisite.Controls.Add(Me.btnTornaElencoVisite)
        Me.grpVisite.Controls.Add(Me.txtNOTEVISITA)
        Me.grpVisite.Controls.Add(Me.txtDTVISITA)
        Me.grpVisite.Controls.Add(Me.txtDESC_VISITA)
        Me.grpVisite.Controls.Add(Me.txtCAUSALEVISITA)
        Me.grpVisite.Controls.Add(Label12)
        Me.grpVisite.Controls.Add(Label11)
        Me.grpVisite.Controls.Add(Label8)
        Me.grpVisite.Location = New System.Drawing.Point(12, 79)
        Me.grpVisite.Name = "grpVisite"
        Me.grpVisite.Size = New System.Drawing.Size(612, 251)
        Me.grpVisite.TabIndex = 7
        Me.grpVisite.TabStop = False
        Me.grpVisite.Text = "Visite"
        '
        'txtIDVISITA
        '
        Me.txtIDVISITA.Location = New System.Drawing.Point(428, 19)
        Me.txtIDVISITA.Name = "txtIDVISITA"
        Me.txtIDVISITA.Size = New System.Drawing.Size(100, 20)
        Me.txtIDVISITA.TabIndex = 7
        Me.txtIDVISITA.Visible = False
        '
        'btnSalvaVisita
        '
        Me.btnSalvaVisita.Image = Global.Clienti.My.Resources.Resources.Save
        Me.btnSalvaVisita.Location = New System.Drawing.Point(440, 220)
        Me.btnSalvaVisita.Name = "btnSalvaVisita"
        Me.btnSalvaVisita.Size = New System.Drawing.Size(75, 25)
        Me.btnSalvaVisita.TabIndex = 6
        Me.btnSalvaVisita.Text = "Salva"
        Me.btnSalvaVisita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvaVisita.UseVisualStyleBackColor = True
        '
        'btnTornaElencoVisite
        '
        Me.btnTornaElencoVisite.Location = New System.Drawing.Point(521, 220)
        Me.btnTornaElencoVisite.Name = "btnTornaElencoVisite"
        Me.btnTornaElencoVisite.Size = New System.Drawing.Size(75, 25)
        Me.btnTornaElencoVisite.TabIndex = 5
        Me.btnTornaElencoVisite.Text = "Elenco"
        Me.btnTornaElencoVisite.UseVisualStyleBackColor = True
        '
        'txtNOTEVISITA
        '
        Me.txtNOTEVISITA.Location = New System.Drawing.Point(64, 77)
        Me.txtNOTEVISITA.Multiline = True
        Me.txtNOTEVISITA.Name = "txtNOTEVISITA"
        Me.txtNOTEVISITA.Size = New System.Drawing.Size(329, 82)
        Me.txtNOTEVISITA.TabIndex = 4
        Me.txtNOTEVISITA.Tag = "T++-"
        '
        'txtDTVISITA
        '
        Me.txtDTVISITA.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.txtDTVISITA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDTVISITA.Location = New System.Drawing.Point(64, 50)
        Me.txtDTVISITA.Name = "txtDTVISITA"
        Me.txtDTVISITA.Size = New System.Drawing.Size(153, 20)
        Me.txtDTVISITA.TabIndex = 3
        Me.txtDTVISITA.Tag = "T++-"
        '
        'txtDESC_VISITA
        '
        Me.txtDESC_VISITA.Enabled = False
        Me.txtDESC_VISITA.Location = New System.Drawing.Point(170, 19)
        Me.txtDESC_VISITA.Name = "txtDESC_VISITA"
        Me.txtDESC_VISITA.Size = New System.Drawing.Size(229, 20)
        Me.txtDESC_VISITA.TabIndex = 1
        Me.txtDESC_VISITA.Tag = "T---"
        '
        'txtCAUSALEVISITA
        '
        Me.txtCAUSALEVISITA.Location = New System.Drawing.Point(98, 19)
        Me.txtCAUSALEVISITA.Name = "txtCAUSALEVISITA"
        Me.txtCAUSALEVISITA.Size = New System.Drawing.Size(66, 20)
        Me.txtCAUSALEVISITA.TabIndex = 0
        Me.txtCAUSALEVISITA.Tag = "T++-"
        '
        'txtCODICECLIENTE
        '
        Me.txtCODICECLIENTE.Location = New System.Drawing.Point(76, 9)
        Me.txtCODICECLIENTE.MaxLength = 5
        Me.txtCODICECLIENTE.Name = "txtCODICECLIENTE"
        Me.txtCODICECLIENTE.Size = New System.Drawing.Size(54, 20)
        Me.txtCODICECLIENTE.TabIndex = 0
        Me.txtCODICECLIENTE.Tag = "T+++O"
        Me.txtCODICECLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkBOOPROVV
        '
        Me.chkBOOPROVV.AutoSize = True
        Me.chkBOOPROVV.Location = New System.Drawing.Point(533, 11)
        Me.chkBOOPROVV.Name = "chkBOOPROVV"
        Me.chkBOOPROVV.Size = New System.Drawing.Size(84, 17)
        Me.chkBOOPROVV.TabIndex = 2
        Me.chkBOOPROVV.Tag = "F++++"
        Me.chkBOOPROVV.Text = "Provvisorio?"
        Me.chkBOOPROVV.UseVisualStyleBackColor = True
        '
        'grpTelefonata
        '
        Me.grpTelefonata.Controls.Add(Me.txtIDTELEFONATA)
        Me.grpTelefonata.Controls.Add(Me.btnSalvaTelefonata)
        Me.grpTelefonata.Controls.Add(Me.btnTornaElencoTelefonata)
        Me.grpTelefonata.Controls.Add(Me.txtNOTETELEFONATA)
        Me.grpTelefonata.Controls.Add(Me.txtDTTELEFONATA)
        Me.grpTelefonata.Controls.Add(Me.txtDESC_TELEFONATA)
        Me.grpTelefonata.Controls.Add(Me.txtCAUSALETELEFONATA)
        Me.grpTelefonata.Controls.Add(Label1)
        Me.grpTelefonata.Controls.Add(Label13)
        Me.grpTelefonata.Controls.Add(Label14)
        Me.grpTelefonata.Location = New System.Drawing.Point(12, 79)
        Me.grpTelefonata.Name = "grpTelefonata"
        Me.grpTelefonata.Size = New System.Drawing.Size(612, 251)
        Me.grpTelefonata.TabIndex = 8
        Me.grpTelefonata.TabStop = False
        Me.grpTelefonata.Text = "Telefonate"
        '
        'txtIDTELEFONATA
        '
        Me.txtIDTELEFONATA.Location = New System.Drawing.Point(457, 22)
        Me.txtIDTELEFONATA.Name = "txtIDTELEFONATA"
        Me.txtIDTELEFONATA.Size = New System.Drawing.Size(100, 20)
        Me.txtIDTELEFONATA.TabIndex = 7
        Me.txtIDTELEFONATA.Visible = False
        '
        'btnSalvaTelefonata
        '
        Me.btnSalvaTelefonata.Image = Global.Clienti.My.Resources.Resources.Save
        Me.btnSalvaTelefonata.Location = New System.Drawing.Point(440, 218)
        Me.btnSalvaTelefonata.Name = "btnSalvaTelefonata"
        Me.btnSalvaTelefonata.Size = New System.Drawing.Size(75, 27)
        Me.btnSalvaTelefonata.TabIndex = 6
        Me.btnSalvaTelefonata.Text = "Salva"
        Me.btnSalvaTelefonata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvaTelefonata.UseVisualStyleBackColor = True
        '
        'btnTornaElencoTelefonata
        '
        Me.btnTornaElencoTelefonata.Location = New System.Drawing.Point(521, 218)
        Me.btnTornaElencoTelefonata.Name = "btnTornaElencoTelefonata"
        Me.btnTornaElencoTelefonata.Size = New System.Drawing.Size(75, 27)
        Me.btnTornaElencoTelefonata.TabIndex = 5
        Me.btnTornaElencoTelefonata.Text = "Elenco"
        Me.btnTornaElencoTelefonata.UseVisualStyleBackColor = True
        '
        'txtNOTETELEFONATA
        '
        Me.txtNOTETELEFONATA.Location = New System.Drawing.Point(64, 77)
        Me.txtNOTETELEFONATA.Multiline = True
        Me.txtNOTETELEFONATA.Name = "txtNOTETELEFONATA"
        Me.txtNOTETELEFONATA.Size = New System.Drawing.Size(329, 82)
        Me.txtNOTETELEFONATA.TabIndex = 4
        Me.txtNOTETELEFONATA.Tag = "T++-"
        '
        'txtDTTELEFONATA
        '
        Me.txtDTTELEFONATA.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.txtDTTELEFONATA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDTTELEFONATA.Location = New System.Drawing.Point(64, 50)
        Me.txtDTTELEFONATA.Name = "txtDTTELEFONATA"
        Me.txtDTTELEFONATA.Size = New System.Drawing.Size(153, 20)
        Me.txtDTTELEFONATA.TabIndex = 3
        Me.txtDTTELEFONATA.Tag = "T++-"
        '
        'txtDESC_TELEFONATA
        '
        Me.txtDESC_TELEFONATA.Enabled = False
        Me.txtDESC_TELEFONATA.Location = New System.Drawing.Point(196, 19)
        Me.txtDESC_TELEFONATA.Name = "txtDESC_TELEFONATA"
        Me.txtDESC_TELEFONATA.Size = New System.Drawing.Size(229, 20)
        Me.txtDESC_TELEFONATA.TabIndex = 1
        Me.txtDESC_TELEFONATA.Tag = "T---"
        '
        'txtCAUSALETELEFONATA
        '
        Me.txtCAUSALETELEFONATA.Location = New System.Drawing.Point(124, 19)
        Me.txtCAUSALETELEFONATA.Name = "txtCAUSALETELEFONATA"
        Me.txtCAUSALETELEFONATA.Size = New System.Drawing.Size(66, 20)
        Me.txtCAUSALETELEFONATA.TabIndex = 0
        Me.txtCAUSALETELEFONATA.Tag = "T++-"
        '
        'grpPreventivo
        '
        Me.grpPreventivo.Controls.Add(Me.btnSfogliaPreventivo)
        Me.grpPreventivo.Controls.Add(Me.txtPERCORSOPDFPREVENTIVO)
        Me.grpPreventivo.Controls.Add(Label17)
        Me.grpPreventivo.Controls.Add(Me.txtIDPREVENTIVO)
        Me.grpPreventivo.Controls.Add(Me.btnSalvaPreventivo)
        Me.grpPreventivo.Controls.Add(Me.btnTornaElencoPreventivo)
        Me.grpPreventivo.Controls.Add(Me.txtNOTEPREVENTIVO)
        Me.grpPreventivo.Controls.Add(Me.txtDTPREVENTIVO)
        Me.grpPreventivo.Controls.Add(Label15)
        Me.grpPreventivo.Controls.Add(Label16)
        Me.grpPreventivo.Location = New System.Drawing.Point(12, 79)
        Me.grpPreventivo.Name = "grpPreventivo"
        Me.grpPreventivo.Size = New System.Drawing.Size(612, 251)
        Me.grpPreventivo.TabIndex = 9
        Me.grpPreventivo.TabStop = False
        Me.grpPreventivo.Text = "Preventivo"
        '
        'btnSfogliaPreventivo
        '
        Me.btnSfogliaPreventivo.Location = New System.Drawing.Point(318, 165)
        Me.btnSfogliaPreventivo.Name = "btnSfogliaPreventivo"
        Me.btnSfogliaPreventivo.Size = New System.Drawing.Size(75, 23)
        Me.btnSfogliaPreventivo.TabIndex = 3
        Me.btnSfogliaPreventivo.Text = "Sfoglia..."
        Me.btnSfogliaPreventivo.UseVisualStyleBackColor = True
        '
        'txtPERCORSOPDFPREVENTIVO
        '
        Me.txtPERCORSOPDFPREVENTIVO.Location = New System.Drawing.Point(64, 167)
        Me.txtPERCORSOPDFPREVENTIVO.Name = "txtPERCORSOPDFPREVENTIVO"
        Me.txtPERCORSOPDFPREVENTIVO.ReadOnly = True
        Me.txtPERCORSOPDFPREVENTIVO.Size = New System.Drawing.Size(248, 20)
        Me.txtPERCORSOPDFPREVENTIVO.TabIndex = 2
        '
        'txtIDPREVENTIVO
        '
        Me.txtIDPREVENTIVO.Location = New System.Drawing.Point(457, 22)
        Me.txtIDPREVENTIVO.Name = "txtIDPREVENTIVO"
        Me.txtIDPREVENTIVO.Size = New System.Drawing.Size(100, 20)
        Me.txtIDPREVENTIVO.TabIndex = 7
        Me.txtIDPREVENTIVO.Visible = False
        '
        'btnSalvaPreventivo
        '
        Me.btnSalvaPreventivo.Image = Global.Clienti.My.Resources.Resources.Save
        Me.btnSalvaPreventivo.Location = New System.Drawing.Point(440, 218)
        Me.btnSalvaPreventivo.Name = "btnSalvaPreventivo"
        Me.btnSalvaPreventivo.Size = New System.Drawing.Size(75, 27)
        Me.btnSalvaPreventivo.TabIndex = 4
        Me.btnSalvaPreventivo.Text = "Salva"
        Me.btnSalvaPreventivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvaPreventivo.UseVisualStyleBackColor = True
        '
        'btnTornaElencoPreventivo
        '
        Me.btnTornaElencoPreventivo.Location = New System.Drawing.Point(521, 218)
        Me.btnTornaElencoPreventivo.Name = "btnTornaElencoPreventivo"
        Me.btnTornaElencoPreventivo.Size = New System.Drawing.Size(75, 27)
        Me.btnTornaElencoPreventivo.TabIndex = 5
        Me.btnTornaElencoPreventivo.Text = "Elenco"
        Me.btnTornaElencoPreventivo.UseVisualStyleBackColor = True
        '
        'txtNOTEPREVENTIVO
        '
        Me.txtNOTEPREVENTIVO.Location = New System.Drawing.Point(64, 49)
        Me.txtNOTEPREVENTIVO.Multiline = True
        Me.txtNOTEPREVENTIVO.Name = "txtNOTEPREVENTIVO"
        Me.txtNOTEPREVENTIVO.Size = New System.Drawing.Size(329, 110)
        Me.txtNOTEPREVENTIVO.TabIndex = 1
        Me.txtNOTEPREVENTIVO.Tag = "T++-"
        '
        'txtDTPREVENTIVO
        '
        Me.txtDTPREVENTIVO.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.txtDTPREVENTIVO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDTPREVENTIVO.Location = New System.Drawing.Point(124, 19)
        Me.txtDTPREVENTIVO.Name = "txtDTPREVENTIVO"
        Me.txtDTPREVENTIVO.Size = New System.Drawing.Size(199, 20)
        Me.txtDTPREVENTIVO.TabIndex = 0
        Me.txtDTPREVENTIVO.Tag = "T++-"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'grpOrdine
        '
        Me.grpOrdine.Controls.Add(Me.txtIDORDINE)
        Me.grpOrdine.Controls.Add(Me.btnSalvaOrdine)
        Me.grpOrdine.Controls.Add(Me.btnTornaElencoOrdine)
        Me.grpOrdine.Controls.Add(Me.txtNOTEORDINE)
        Me.grpOrdine.Controls.Add(Me.txtDTORDINE)
        Me.grpOrdine.Controls.Add(Me.txtDESC_ORDINE)
        Me.grpOrdine.Controls.Add(Me.txtCAUSALEORDINE)
        Me.grpOrdine.Controls.Add(Label19)
        Me.grpOrdine.Controls.Add(Label20)
        Me.grpOrdine.Controls.Add(Label21)
        Me.grpOrdine.Location = New System.Drawing.Point(12, 79)
        Me.grpOrdine.Name = "grpOrdine"
        Me.grpOrdine.Size = New System.Drawing.Size(612, 251)
        Me.grpOrdine.TabIndex = 10
        Me.grpOrdine.TabStop = False
        Me.grpOrdine.Text = "Ordine"
        '
        'txtIDORDINE
        '
        Me.txtIDORDINE.Location = New System.Drawing.Point(457, 22)
        Me.txtIDORDINE.Name = "txtIDORDINE"
        Me.txtIDORDINE.Size = New System.Drawing.Size(100, 20)
        Me.txtIDORDINE.TabIndex = 7
        Me.txtIDORDINE.Visible = False
        '
        'btnSalvaOrdine
        '
        Me.btnSalvaOrdine.Image = Global.Clienti.My.Resources.Resources.Save
        Me.btnSalvaOrdine.Location = New System.Drawing.Point(440, 218)
        Me.btnSalvaOrdine.Name = "btnSalvaOrdine"
        Me.btnSalvaOrdine.Size = New System.Drawing.Size(75, 27)
        Me.btnSalvaOrdine.TabIndex = 6
        Me.btnSalvaOrdine.Text = "Salva"
        Me.btnSalvaOrdine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvaOrdine.UseVisualStyleBackColor = True
        '
        'btnTornaElencoOrdine
        '
        Me.btnTornaElencoOrdine.Location = New System.Drawing.Point(521, 218)
        Me.btnTornaElencoOrdine.Name = "btnTornaElencoOrdine"
        Me.btnTornaElencoOrdine.Size = New System.Drawing.Size(75, 27)
        Me.btnTornaElencoOrdine.TabIndex = 5
        Me.btnTornaElencoOrdine.Text = "Elenco"
        Me.btnTornaElencoOrdine.UseVisualStyleBackColor = True
        '
        'txtNOTEORDINE
        '
        Me.txtNOTEORDINE.Location = New System.Drawing.Point(64, 77)
        Me.txtNOTEORDINE.Multiline = True
        Me.txtNOTEORDINE.Name = "txtNOTEORDINE"
        Me.txtNOTEORDINE.Size = New System.Drawing.Size(329, 82)
        Me.txtNOTEORDINE.TabIndex = 4
        Me.txtNOTEORDINE.Tag = "T++-"
        '
        'txtDTORDINE
        '
        Me.txtDTORDINE.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.txtDTORDINE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDTORDINE.Location = New System.Drawing.Point(64, 50)
        Me.txtDTORDINE.Name = "txtDTORDINE"
        Me.txtDTORDINE.Size = New System.Drawing.Size(153, 20)
        Me.txtDTORDINE.TabIndex = 3
        Me.txtDTORDINE.Tag = "T++-"
        '
        'txtDESC_ORDINE
        '
        Me.txtDESC_ORDINE.Enabled = False
        Me.txtDESC_ORDINE.Location = New System.Drawing.Point(196, 19)
        Me.txtDESC_ORDINE.Name = "txtDESC_ORDINE"
        Me.txtDESC_ORDINE.Size = New System.Drawing.Size(229, 20)
        Me.txtDESC_ORDINE.TabIndex = 1
        Me.txtDESC_ORDINE.Tag = "T---"
        '
        'txtCAUSALEORDINE
        '
        Me.txtCAUSALEORDINE.Location = New System.Drawing.Point(124, 19)
        Me.txtCAUSALEORDINE.Name = "txtCAUSALEORDINE"
        Me.txtCAUSALEORDINE.Size = New System.Drawing.Size(66, 20)
        Me.txtCAUSALEORDINE.TabIndex = 0
        Me.txtCAUSALEORDINE.Tag = "T++-"
        '
        'chkEvitaProvvisorio
        '
        Me.chkEvitaProvvisorio.AutoSize = True
        Me.chkEvitaProvvisorio.Checked = True
        Me.chkEvitaProvvisorio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEvitaProvvisorio.Location = New System.Drawing.Point(623, 11)
        Me.chkEvitaProvvisorio.Name = "chkEvitaProvvisorio"
        Me.chkEvitaProvvisorio.Size = New System.Drawing.Size(50, 17)
        Me.chkEvitaProvvisorio.TabIndex = 3
        Me.chkEvitaProvvisorio.Tag = "N--+"
        Me.chkEvitaProvvisorio.Text = "Evita"
        Me.chkEvitaProvvisorio.UseVisualStyleBackColor = True
        '
        'chkBOOEXCLIENTE
        '
        Me.chkBOOEXCLIENTE.AutoSize = True
        Me.chkBOOEXCLIENTE.Location = New System.Drawing.Point(533, 34)
        Me.chkBOOEXCLIENTE.Name = "chkBOOEXCLIENTE"
        Me.chkBOOEXCLIENTE.Size = New System.Drawing.Size(40, 17)
        Me.chkBOOEXCLIENTE.TabIndex = 4
        Me.chkBOOEXCLIENTE.Tag = "F++++"
        Me.chkBOOEXCLIENTE.Text = "EX"
        Me.chkBOOEXCLIENTE.UseVisualStyleBackColor = True
        '
        'chkEvitaEx
        '
        Me.chkEvitaEx.AutoSize = True
        Me.chkEvitaEx.Checked = True
        Me.chkEvitaEx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEvitaEx.Location = New System.Drawing.Point(623, 34)
        Me.chkEvitaEx.Name = "chkEvitaEx"
        Me.chkEvitaEx.Size = New System.Drawing.Size(50, 17)
        Me.chkEvitaEx.TabIndex = 5
        Me.chkEvitaEx.Tag = "N--+"
        Me.chkEvitaEx.Text = "Evita"
        Me.chkEvitaEx.UseVisualStyleBackColor = True
        '
        'lblUltimaAzione
        '
        Me.lblUltimaAzione.AutoSize = True
        Me.lblUltimaAzione.Location = New System.Drawing.Point(12, 34)
        Me.lblUltimaAzione.Name = "lblUltimaAzione"
        Me.lblUltimaAzione.Size = New System.Drawing.Size(71, 13)
        Me.lblUltimaAzione.TabIndex = 25
        Me.lblUltimaAzione.Tag = "L"
        Me.lblUltimaAzione.Text = "Ultima Azione"
        Me.lblUltimaAzione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDATAULTIMAAZIONE
        '
        Me.txtDATAULTIMAAZIONE.Enabled = False
        Me.txtDATAULTIMAAZIONE.Location = New System.Drawing.Point(89, 31)
        Me.txtDATAULTIMAAZIONE.MaxLength = 10
        Me.txtDATAULTIMAAZIONE.Name = "txtDATAULTIMAAZIONE"
        Me.txtDATAULTIMAAZIONE.Size = New System.Drawing.Size(121, 20)
        Me.txtDATAULTIMAAZIONE.TabIndex = 6
        Me.txtDATAULTIMAAZIONE.Tag = "V"
        Me.txtDATAULTIMAAZIONE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fClienti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 385)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtDATAULTIMAAZIONE)
        Me.Controls.Add(Me.chkEvitaEx)
        Me.Controls.Add(Me.lblUltimaAzione)
        Me.Controls.Add(Me.chkBOOEXCLIENTE)
        Me.Controls.Add(Me.chkEvitaProvvisorio)
        Me.Controls.Add(Me.chkBOOPROVV)
        Me.Controls.Add(Me.txtCODICECLIENTE)
        Me.Controls.Add(Me.txtRAGIONESOCIALECLIENTE)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.grpPreventivo)
        Me.Controls.Add(Me.grpOrdine)
        Me.Controls.Add(Me.grpTelefonata)
        Me.Controls.Add(Me.grpVisite)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fClienti"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clienti"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgAnagrafica.ResumeLayout(False)
        Me.tpgAnagrafica.PerformLayout()
        Me.grpReferenti.ResumeLayout(False)
        CType(Me.dgvReferenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMail.ResumeLayout(False)
        CType(Me.dgvMail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTelefoni.ResumeLayout(False)
        CType(Me.dgvTelefoni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgVisite.ResumeLayout(False)
        CType(Me.dgvVisite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpTelefonate.ResumeLayout(False)
        CType(Me.dgvTelefonate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPreventivi.ResumeLayout(False)
        CType(Me.dgvPreventivi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpOrdini.ResumeLayout(False)
        CType(Me.dgvOrdini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpAzioniCliente.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpVisite.ResumeLayout(False)
        Me.grpVisite.PerformLayout()
        Me.grpTelefonata.ResumeLayout(False)
        Me.grpTelefonata.PerformLayout()
        Me.grpPreventivo.ResumeLayout(False)
        Me.grpPreventivo.PerformLayout()
        Me.grpOrdine.ResumeLayout(False)
        Me.grpOrdine.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpgAnagrafica As System.Windows.Forms.TabPage
    Friend WithEvents tpgVisite As System.Windows.Forms.TabPage
    Friend WithEvents btnNuovaVisita As System.Windows.Forms.Button
    Friend WithEvents dgvVisite As System.Windows.Forms.DataGridView
    Friend WithEvents tbpTelefonate As System.Windows.Forms.TabPage
    Friend WithEvents btnNuovaTelefonata As System.Windows.Forms.Button
    Friend WithEvents dgvTelefonate As System.Windows.Forms.DataGridView
    Friend WithEvents txtPI_CF As System.Windows.Forms.TextBox
    Friend WithEvents txtCATALOGO As System.Windows.Forms.TextBox
    Friend WithEvents txtNOTE As System.Windows.Forms.TextBox
    Friend WithEvents txtGIORNALINO As System.Windows.Forms.TextBox
    Friend WithEvents txtINDIRIZZOCLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents txtRAGIONESOCIALECLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents grpVisite As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvaVisita As System.Windows.Forms.Button
    Friend WithEvents btnTornaElencoVisite As System.Windows.Forms.Button
    Friend WithEvents txtNOTEVISITA As System.Windows.Forms.TextBox
    Friend WithEvents txtDTVISITA As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDESC_VISITA As System.Windows.Forms.TextBox
    Friend WithEvents txtCAUSALEVISITA As System.Windows.Forms.TextBox
    Friend WithEvents txtCODICECLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents chkBOOPROVV As System.Windows.Forms.CheckBox
    Friend WithEvents txtIDVISITA As System.Windows.Forms.TextBox
    Friend WithEvents IDVISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTVISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAUSALEVISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_VISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTEVISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpTelefoni As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTelefoni As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddTelefono As System.Windows.Forms.Button
    Friend WithEvents IDTELEFONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTETELEFONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpTelefonata As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDTELEFONATA As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvaTelefonata As System.Windows.Forms.Button
    Friend WithEvents btnTornaElencoTelefonata As System.Windows.Forms.Button
    Friend WithEvents txtNOTETELEFONATA As System.Windows.Forms.TextBox
    Friend WithEvents txtDTTELEFONATA As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDESC_TELEFONATA As System.Windows.Forms.TextBox
    Friend WithEvents txtCAUSALETELEFONATA As System.Windows.Forms.TextBox
    Friend WithEvents IDTELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTTELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAUSALETELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_TELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTETELEFONATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpMail As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddMail As System.Windows.Forms.Button
    Friend WithEvents dgvMail As System.Windows.Forms.DataGridView
    Friend WithEvents IDMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTEMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbpPreventivi As System.Windows.Forms.TabPage
    Friend WithEvents btnNuovoPreventivo As System.Windows.Forms.Button
    Friend WithEvents dgvPreventivi As System.Windows.Forms.DataGridView
    Friend WithEvents grpPreventivo As System.Windows.Forms.GroupBox
    Friend WithEvents btnSfogliaPreventivo As System.Windows.Forms.Button
    Friend WithEvents txtPERCORSOPDFPREVENTIVO As System.Windows.Forms.TextBox
    Friend WithEvents txtIDPREVENTIVO As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvaPreventivo As System.Windows.Forms.Button
    Friend WithEvents btnTornaElencoPreventivo As System.Windows.Forms.Button
    Friend WithEvents txtNOTEPREVENTIVO As System.Windows.Forms.TextBox
    Friend WithEvents txtDTPREVENTIVO As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents IDPREVENTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PERCORSOPDFPREVENTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODICECLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTPREVENTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVBTNPDFPREVENTIVO As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SALVAFILEPREVENTIVO As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NOTEPREVENTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpReferenti As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddReferenti As System.Windows.Forms.Button
    Friend WithEvents dgvReferenti As System.Windows.Forms.DataGridView
    Friend WithEvents IDREFERENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMEREFERENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTEREFERENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminaUtente As System.Windows.Forms.Button
    Friend WithEvents tbpAzioniCliente As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnApriInTabella As System.Windows.Forms.Button
    Friend WithEvents txtPROVINCIA As System.Windows.Forms.TextBox
    Friend WithEvents txtSEDEALTERNATIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtRICERCAREFERENTE As System.Windows.Forms.TextBox
    Friend WithEvents tbpOrdini As System.Windows.Forms.TabPage
    Friend WithEvents dgvOrdini As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuovoOrdine As System.Windows.Forms.Button
    Friend WithEvents grpOrdine As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDORDINE As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvaOrdine As System.Windows.Forms.Button
    Friend WithEvents btnTornaElencoOrdine As System.Windows.Forms.Button
    Friend WithEvents txtNOTEORDINE As System.Windows.Forms.TextBox
    Friend WithEvents txtDTORDINE As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDESC_ORDINE As System.Windows.Forms.TextBox
    Friend WithEvents txtCAUSALEORDINE As System.Windows.Forms.TextBox
    Friend WithEvents IDORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAUSALEORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_ORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTEORDINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkEvitaProvvisorio As System.Windows.Forms.CheckBox
    Friend WithEvents chkBOOEXCLIENTE As System.Windows.Forms.CheckBox
    Friend WithEvents chkEvitaEx As System.Windows.Forms.CheckBox
    Friend WithEvents txtDATAULTIMAAZIONE As System.Windows.Forms.TextBox
    Friend WithEvents lblUltimaAzione As System.Windows.Forms.Label
    Friend WithEvents lblRicercaReferente As System.Windows.Forms.Label
End Class
