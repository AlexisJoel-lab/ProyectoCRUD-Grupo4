<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.txtSerieProd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtModeloProd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMarcaProd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.lblTituloProd = New System.Windows.Forms.Label()
        Me.txtStockProd = New System.Windows.Forms.TextBox()
        Me.txtNombreProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSerieProd
        '
        Me.txtSerieProd.Location = New System.Drawing.Point(119, 194)
        Me.txtSerieProd.Name = "txtSerieProd"
        Me.txtSerieProd.Size = New System.Drawing.Size(284, 20)
        Me.txtSerieProd.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Serie:"
        '
        'txtModeloProd
        '
        Me.txtModeloProd.Location = New System.Drawing.Point(119, 154)
        Me.txtModeloProd.Name = "txtModeloProd"
        Me.txtModeloProd.Size = New System.Drawing.Size(284, 20)
        Me.txtModeloProd.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Modelo:"
        '
        'txtMarcaProd
        '
        Me.txtMarcaProd.Location = New System.Drawing.Point(119, 114)
        Me.txtMarcaProd.Name = "txtMarcaProd"
        Me.txtMarcaProd.Size = New System.Drawing.Size(139, 20)
        Me.txtMarcaProd.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Marca:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        Me.btnGuardar.IconColor = System.Drawing.Color.Black
        Me.btnGuardar.IconSize = 30
        Me.btnGuardar.Location = New System.Drawing.Point(119, 248)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Rotation = 0R
        Me.btnGuardar.Size = New System.Drawing.Size(230, 40)
        Me.btnGuardar.TabIndex = 37
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblTituloProd
        '
        Me.lblTituloProd.AutoSize = True
        Me.lblTituloProd.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloProd.Location = New System.Drawing.Point(146, 22)
        Me.lblTituloProd.Name = "lblTituloProd"
        Me.lblTituloProd.Size = New System.Drawing.Size(0, 19)
        Me.lblTituloProd.TabIndex = 36
        '
        'txtStockProd
        '
        Me.txtStockProd.Location = New System.Drawing.Point(340, 74)
        Me.txtStockProd.Name = "txtStockProd"
        Me.txtStockProd.Size = New System.Drawing.Size(63, 20)
        Me.txtStockProd.TabIndex = 5
        '
        'txtNombreProd
        '
        Me.txtNombreProd.Location = New System.Drawing.Point(119, 74)
        Me.txtNombreProd.Name = "txtNombreProd"
        Me.txtNombreProd.Size = New System.Drawing.Size(139, 20)
        Me.txtNombreProd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Stock:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Producto:"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 312)
        Me.Controls.Add(Me.txtSerieProd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtModeloProd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMarcaProd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblTituloProd)
        Me.Controls.Add(Me.txtStockProd)
        Me.Controls.Add(Me.txtNombreProd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSerieProd As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtModeloProd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMarcaProd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents lblTituloProd As Label
    Friend WithEvents txtStockProd As TextBox
    Friend WithEvents txtNombreProd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
