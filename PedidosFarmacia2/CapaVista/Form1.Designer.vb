<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.chkSecundaria = New System.Windows.Forms.CheckBox()
        Me.chkPrincipal = New System.Windows.Forms.CheckBox()
        Me.rbtnCemefar = New System.Windows.Forms.RadioButton()
        Me.rbtnEmpsephar = New System.Windows.Forms.RadioButton()
        Me.rbtnCofarma = New System.Windows.Forms.RadioButton()
        Me.CboxTipoM = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtNombreM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(482, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(645, 273)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(94, 29)
        Me.btnConfirmar.TabIndex = 51
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(196, 273)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 29)
        Me.btnCancelar.TabIndex = 50
        Me.btnCancelar.Text = "Regresar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(36, 273)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 29)
        Me.btnSalir.TabIndex = 49
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'chkSecundaria
        '
        Me.chkSecundaria.AutoSize = True
        Me.chkSecundaria.Location = New System.Drawing.Point(492, 213)
        Me.chkSecundaria.Name = "chkSecundaria"
        Me.chkSecundaria.Size = New System.Drawing.Size(104, 24)
        Me.chkSecundaria.TabIndex = 48
        Me.chkSecundaria.Text = "Secundaria"
        Me.chkSecundaria.UseVisualStyleBackColor = True
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoSize = True
        Me.chkPrincipal.Location = New System.Drawing.Point(372, 212)
        Me.chkPrincipal.Name = "chkPrincipal"
        Me.chkPrincipal.Size = New System.Drawing.Size(88, 24)
        Me.chkPrincipal.TabIndex = 47
        Me.chkPrincipal.Text = "Principal"
        Me.chkPrincipal.UseVisualStyleBackColor = True
        '
        'rbtnCemefar
        '
        Me.rbtnCemefar.AutoSize = True
        Me.rbtnCemefar.Location = New System.Drawing.Point(611, 182)
        Me.rbtnCemefar.Name = "rbtnCemefar"
        Me.rbtnCemefar.Size = New System.Drawing.Size(86, 24)
        Me.rbtnCemefar.TabIndex = 46
        Me.rbtnCemefar.TabStop = True
        Me.rbtnCemefar.Text = "Cemefar"
        Me.rbtnCemefar.UseVisualStyleBackColor = True
        '
        'rbtnEmpsephar
        '
        Me.rbtnEmpsephar.AutoSize = True
        Me.rbtnEmpsephar.Location = New System.Drawing.Point(482, 182)
        Me.rbtnEmpsephar.Name = "rbtnEmpsephar"
        Me.rbtnEmpsephar.Size = New System.Drawing.Size(104, 24)
        Me.rbtnEmpsephar.TabIndex = 45
        Me.rbtnEmpsephar.TabStop = True
        Me.rbtnEmpsephar.Text = "Empsephar"
        Me.rbtnEmpsephar.UseVisualStyleBackColor = True
        '
        'rbtnCofarma
        '
        Me.rbtnCofarma.AutoSize = True
        Me.rbtnCofarma.Location = New System.Drawing.Point(373, 182)
        Me.rbtnCofarma.Name = "rbtnCofarma"
        Me.rbtnCofarma.Size = New System.Drawing.Size(87, 24)
        Me.rbtnCofarma.TabIndex = 44
        Me.rbtnCofarma.TabStop = True
        Me.rbtnCofarma.Text = "Cofarma"
        Me.rbtnCofarma.UseVisualStyleBackColor = True
        '
        'CboxTipoM
        '
        Me.CboxTipoM.FormattingEnabled = True
        Me.CboxTipoM.Items.AddRange(New Object() {"analgésico", "analéptico", "anestésico", "antiácido", "antidepresivo", "antibióticos"})
        Me.CboxTipoM.Location = New System.Drawing.Point(372, 115)
        Me.CboxTipoM.Name = "CboxTipoM"
        Me.CboxTipoM.Size = New System.Drawing.Size(214, 28)
        Me.CboxTipoM.TabIndex = 43
        Me.CboxTipoM.Text = "Seleccione un Medicamento"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(372, 149)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(125, 27)
        Me.txtCantidad.TabIndex = 42
        '
        'txtNombreM
        '
        Me.txtNombreM.Location = New System.Drawing.Point(372, 82)
        Me.txtNombreM.Name = "txtNombreM"
        Me.txtNombreM.Size = New System.Drawing.Size(297, 27)
        Me.txtNombreM.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Sucursal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(243, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Distribuidor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(262, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Tipo Medicamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nombre Medicamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(171, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 36)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Sistema de Pedido Medicamento"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnConfirmar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.chkSecundaria)
        Me.Panel1.Controls.Add(Me.chkPrincipal)
        Me.Panel1.Controls.Add(Me.rbtnCemefar)
        Me.Panel1.Controls.Add(Me.rbtnEmpsephar)
        Me.Panel1.Controls.Add(Me.rbtnCofarma)
        Me.Panel1.Controls.Add(Me.CboxTipoM)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.txtNombreM)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 332)
        Me.Panel1.TabIndex = 53
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 365)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents chkSecundaria As CheckBox
    Friend WithEvents chkPrincipal As CheckBox
    Friend WithEvents rbtnCemefar As RadioButton
    Friend WithEvents rbtnEmpsephar As RadioButton
    Friend WithEvents rbtnCofarma As RadioButton
    Friend WithEvents CboxTipoM As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtNombreM As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
