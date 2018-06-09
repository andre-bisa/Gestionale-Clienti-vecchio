<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGestioneMail
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
        Dim Label4 As System.Windows.Forms.Label
        Me.txtEMAIL = New System.Windows.Forms.TextBox()
        Me.txtNOTEMAIL = New System.Windows.Forms.TextBox()
        Me.btnSalva = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCODICECLIENTE = New System.Windows.Forms.TextBox()
        Me.clsGRUPPI = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(18, 13)
        Label1.TabIndex = 0
        Label1.Text = "ID"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(97, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(92, 13)
        Label2.TabIndex = 1
        Label2.Text = "CODICECLIENTE"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(11, 33)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(39, 13)
        Label3.TabIndex = 2
        Label3.Text = "EMAIL"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(12, 60)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(37, 13)
        Label4.TabIndex = 3
        Label4.Text = "NOTE"
        '
        'txtEMAIL
        '
        Me.txtEMAIL.Location = New System.Drawing.Point(55, 30)
        Me.txtEMAIL.MaxLength = 50
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Size = New System.Drawing.Size(193, 20)
        Me.txtEMAIL.TabIndex = 6
        '
        'txtNOTEMAIL
        '
        Me.txtNOTEMAIL.Location = New System.Drawing.Point(55, 60)
        Me.txtNOTEMAIL.Multiline = True
        Me.txtNOTEMAIL.Name = "txtNOTEMAIL"
        Me.txtNOTEMAIL.Size = New System.Drawing.Size(193, 129)
        Me.txtNOTEMAIL.TabIndex = 7
        '
        'btnSalva
        '
        Me.btnSalva.Image = Global.Clienti.My.Resources.Resources.Save
        Me.btnSalva.Location = New System.Drawing.Point(144, 198)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(75, 25)
        Me.btnSalva.TabIndex = 8
        Me.btnSalva.Text = "Salva"
        Me.btnSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(36, 6)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(44, 20)
        Me.txtID.TabIndex = 9
        '
        'txtCODICECLIENTE
        '
        Me.txtCODICECLIENTE.Enabled = False
        Me.txtCODICECLIENTE.Location = New System.Drawing.Point(195, 6)
        Me.txtCODICECLIENTE.MaxLength = 5
        Me.txtCODICECLIENTE.Name = "txtCODICECLIENTE"
        Me.txtCODICECLIENTE.Size = New System.Drawing.Size(66, 20)
        Me.txtCODICECLIENTE.TabIndex = 10
        '
        'clsGRUPPI
        '
        Me.clsGRUPPI.CheckOnClick = True
        Me.clsGRUPPI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clsGRUPPI.FormattingEnabled = True
        Me.clsGRUPPI.Location = New System.Drawing.Point(3, 16)
        Me.clsGRUPPI.Name = "clsGRUPPI"
        Me.clsGRUPPI.Size = New System.Drawing.Size(116, 161)
        Me.clsGRUPPI.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clsGRUPPI)
        Me.GroupBox1.Location = New System.Drawing.Point(267, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 180)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gruppo"
        '
        'fGestioneMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 235)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCODICECLIENTE)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.txtNOTEMAIL)
        Me.Controls.Add(Me.txtEMAIL)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fGestioneMail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica/Aggiungi Telefono"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents txtNOTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtCODICECLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents clsGRUPPI As CheckedListBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
