<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.lblTituloCli = New System.Windows.Forms.Label()
        Me.txtTelefonoCli = New System.Windows.Forms.TextBox()
        Me.txtSexoCli = New System.Windows.Forms.TextBox()
        Me.txtDniCli = New System.Windows.Forms.TextBox()
        Me.txtNombreCli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellidoCli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccionCli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmailCli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        Me.btnGuardar.IconColor = System.Drawing.Color.Black
        Me.btnGuardar.IconSize = 30
        Me.btnGuardar.Location = New System.Drawing.Point(154, 250)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Rotation = 0R
        Me.btnGuardar.Size = New System.Drawing.Size(230, 40)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblTituloCli
        '
        Me.lblTituloCli.AutoSize = True
        Me.lblTituloCli.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloCli.Location = New System.Drawing.Point(162, 22)
        Me.lblTituloCli.Name = "lblTituloCli"
        Me.lblTituloCli.Size = New System.Drawing.Size(0, 19)
        Me.lblTituloCli.TabIndex = 20
        '
        'txtTelefonoCli
        '
        Me.txtTelefonoCli.Location = New System.Drawing.Point(408, 112)
        Me.txtTelefonoCli.Name = "txtTelefonoCli"
        Me.txtTelefonoCli.Size = New System.Drawing.Size(63, 20)
        Me.txtTelefonoCli.TabIndex = 19
        '
        'txtSexoCli
        '
        Me.txtSexoCli.Location = New System.Drawing.Point(245, 112)
        Me.txtSexoCli.Name = "txtSexoCli"
        Me.txtSexoCli.Size = New System.Drawing.Size(63, 20)
        Me.txtSexoCli.TabIndex = 18
        '
        'txtDniCli
        '
        Me.txtDniCli.Location = New System.Drawing.Point(100, 112)
        Me.txtDniCli.Name = "txtDniCli"
        Me.txtDniCli.Size = New System.Drawing.Size(63, 20)
        Me.txtDniCli.TabIndex = 17
        '
        'txtNombreCli
        '
        Me.txtNombreCli.Location = New System.Drawing.Point(100, 71)
        Me.txtNombreCli.Name = "txtNombreCli"
        Me.txtNombreCli.Size = New System.Drawing.Size(139, 20)
        Me.txtNombreCli.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Sexo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombres:"
        '
        'txtApellidoCli
        '
        Me.txtApellidoCli.Location = New System.Drawing.Point(332, 71)
        Me.txtApellidoCli.Name = "txtApellidoCli"
        Me.txtApellidoCli.Size = New System.Drawing.Size(139, 20)
        Me.txtApellidoCli.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Apellidos:"
        '
        'txtDireccionCli
        '
        Me.txtDireccionCli.Location = New System.Drawing.Point(100, 153)
        Me.txtDireccionCli.Name = "txtDireccionCli"
        Me.txtDireccionCli.Size = New System.Drawing.Size(371, 20)
        Me.txtDireccionCli.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Dirección:"
        '
        'txtEmailCli
        '
        Me.txtEmailCli.Location = New System.Drawing.Point(100, 194)
        Me.txtEmailCli.Name = "txtEmailCli"
        Me.txtEmailCli.Size = New System.Drawing.Size(371, 20)
        Me.txtEmailCli.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Email:"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 318)
        Me.Controls.Add(Me.txtEmailCli)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDireccionCli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtApellidoCli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblTituloCli)
        Me.Controls.Add(Me.txtTelefonoCli)
        Me.Controls.Add(Me.txtSexoCli)
        Me.Controls.Add(Me.txtDniCli)
        Me.Controls.Add(Me.txtNombreCli)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents lblTituloCli As Label
    Friend WithEvents txtTelefonoCli As TextBox
    Friend WithEvents txtSexoCli As TextBox
    Friend WithEvents txtDniCli As TextBox
    Friend WithEvents txtNombreCli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellidoCli As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDireccionCli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmailCli As TextBox
    Friend WithEvents Label8 As Label
End Class
