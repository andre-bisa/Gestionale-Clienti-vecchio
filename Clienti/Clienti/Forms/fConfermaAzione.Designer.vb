<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fConfermaAzione
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
        Dim Label2 As System.Windows.Forms.Label
        Me.btnControlla = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblTestoAggiuntivo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(13, 64)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 13)
        Label1.TabIndex = 0
        Label1.Text = "Password"
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Red
        Label2.Location = New System.Drawing.Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(331, 23)
        Label2.TabIndex = 3
        Label2.Text = "Devi reinserire la password per confermare l'azione!"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnControlla
        '
        Me.btnControlla.Location = New System.Drawing.Point(58, 87)
        Me.btnControlla.Name = "btnControlla"
        Me.btnControlla.Size = New System.Drawing.Size(75, 23)
        Me.btnControlla.TabIndex = 1
        Me.btnControlla.Text = "&Controlla"
        Me.btnControlla.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Location = New System.Drawing.Point(198, 87)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 2
        Me.btnAnnulla.Text = "&Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(72, 61)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(260, 20)
        Me.txtPassword.TabIndex = 0
        '
        'lblTestoAggiuntivo
        '
        Me.lblTestoAggiuntivo.AutoEllipsis = True
        Me.lblTestoAggiuntivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestoAggiuntivo.ForeColor = System.Drawing.Color.Red
        Me.lblTestoAggiuntivo.Location = New System.Drawing.Point(12, 32)
        Me.lblTestoAggiuntivo.Name = "lblTestoAggiuntivo"
        Me.lblTestoAggiuntivo.Size = New System.Drawing.Size(320, 23)
        Me.lblTestoAggiuntivo.TabIndex = 4
        Me.lblTestoAggiuntivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'fConfermaAzione
        '
        Me.AcceptButton = Me.btnControlla
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 122)
        Me.Controls.Add(Me.lblTestoAggiuntivo)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnControlla)
        Me.Controls.Add(Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fConfermaAzione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confermare azione per proseguire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnControlla As System.Windows.Forms.Button
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblTestoAggiuntivo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
