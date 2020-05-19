<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelMenuIzq = New System.Windows.Forms.Panel()
        Me.btnProductos = New FontAwesome.Sharp.IconButton()
        Me.btnClientes = New FontAwesome.Sharp.IconButton()
        Me.btnEmpleados = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnEditar = New FontAwesome.Sharp.IconButton()
        Me.btnNuevo = New FontAwesome.Sharp.IconButton()
        Me.DgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.PanelMenuIzq.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuIzq
        '
        Me.PanelMenuIzq.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelMenuIzq.Controls.Add(Me.btnProductos)
        Me.PanelMenuIzq.Controls.Add(Me.btnClientes)
        Me.PanelMenuIzq.Controls.Add(Me.btnEmpleados)
        Me.PanelMenuIzq.Controls.Add(Me.PanelLogo)
        Me.PanelMenuIzq.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuIzq.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuIzq.Name = "PanelMenuIzq"
        Me.PanelMenuIzq.Size = New System.Drawing.Size(811, 53)
        Me.PanelMenuIzq.TabIndex = 1
        '
        'btnProductos
        '
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.btnProductos.IconColor = System.Drawing.Color.Black
        Me.btnProductos.IconSize = 35
        Me.btnProductos.Location = New System.Drawing.Point(464, 0)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Rotation = 0R
        Me.btnProductos.Size = New System.Drawing.Size(120, 53)
        Me.btnProductos.TabIndex = 3
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btnClientes.IconColor = System.Drawing.Color.Black
        Me.btnClientes.IconSize = 35
        Me.btnClientes.Location = New System.Drawing.Point(344, 0)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Rotation = 0R
        Me.btnClientes.Size = New System.Drawing.Size(120, 53)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEmpleados.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnEmpleados.IconColor = System.Drawing.Color.Black
        Me.btnEmpleados.IconSize = 35
        Me.btnEmpleados.Location = New System.Drawing.Point(224, 0)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Rotation = 0R
        Me.btnEmpleados.Size = New System.Drawing.Size(120, 53)
        Me.btnEmpleados.TabIndex = 1
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(224, 53)
        Me.PanelLogo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 52)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 50)
        Me.Panel1.TabIndex = 2
        '
        'btnEliminar
        '
        Me.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserTimes
        Me.btnEliminar.IconColor = System.Drawing.Color.Black
        Me.btnEliminar.IconSize = 25
        Me.btnEliminar.Location = New System.Drawing.Point(674, 8)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Rotation = 0R
        Me.btnEliminar.Size = New System.Drawing.Size(84, 34)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnEditar.IconColor = System.Drawing.Color.Black
        Me.btnEditar.IconSize = 25
        Me.btnEditar.Location = New System.Drawing.Point(344, 8)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Rotation = 0R
        Me.btnEditar.Size = New System.Drawing.Size(84, 34)
        Me.btnEditar.TabIndex = 7
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnNuevo.IconColor = System.Drawing.Color.Black
        Me.btnNuevo.IconSize = 25
        Me.btnNuevo.Location = New System.Drawing.Point(67, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Rotation = 0R
        Me.btnNuevo.Size = New System.Drawing.Size(84, 34)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Location = New System.Drawing.Point(12, 109)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.Size = New System.Drawing.Size(787, 329)
        Me.DgvEmpleado.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 450)
        Me.Controls.Add(Me.DgvEmpleado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenuIzq)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD Básico"
        Me.PanelMenuIzq.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenuIzq As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvEmpleado As DataGridView
    Friend WithEvents btnEmpleados As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProductos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditar As FontAwesome.Sharp.IconButton
End Class
