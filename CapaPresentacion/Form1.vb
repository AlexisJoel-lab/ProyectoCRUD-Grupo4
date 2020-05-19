Imports CapaNegocio
Imports CapaEntidad

Public Class Form1
    Dim num As Integer

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        num = 1
        MostrarEmpleados()
        HabilitarBotones()
    End Sub

    Private objetoCN_Empl As CN_Empleados = New CN_Empleados()
    Private objetoCN_Cli As CN_Clientes = New CN_Clientes()
    Private objetoCN_Prod As CN_Productos = New CN_Productos()
    Public idEmpleados As String = Nothing
    Public idClientes As String = Nothing
    Public idProducto As String = Nothing

    Public Editar As Boolean = False

    Public Sub New()
        InitializeComponent()
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False

    End Sub

    Private Sub MostrarEmpleados()
        Dim objeto As CN_Empleados = New CN_Empleados()
        DgvEmpleado.DataSource = objeto.MostrarEmple()
    End Sub
    Private Sub HabilitarBotones()
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If num.Equals(1) Then
            FrmEmpleados.lblTituloEmpl.Text = "AGREGAR EMPLEADO"
            LimpiarControlesEmpl()
            FrmEmpleados.ShowDialog()
        ElseIf num.Equals(2) Then
            frmClientes.lblTituloCli.Text = "AGREGAR CLIENTE"
            LimpiarControlesCli()
            frmClientes.ShowDialog()
        ElseIf num.Equals(3) Then
            frmProductos.lblTituloProd.Text = "AGREGAR PRODUCTO"
            LimpiarControlesProd()
            frmProductos.ShowDialog()
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If num.Equals(1) Then
            FrmEmpleados.lblTituloEmpl.Text = "EDITAR EMPLEADO"
            If DgvEmpleado.SelectedRows.Count > 0 Then
                Editar = True
                FrmEmpleados.txtNombre.Text = DgvEmpleado.CurrentRow.Cells("Nombre").Value.ToString()
                FrmEmpleados.txtEdad.Text = DgvEmpleado.CurrentRow.Cells("Edad").Value.ToString()
                FrmEmpleados.txtSexo.Text = DgvEmpleado.CurrentRow.Cells("Sexo").Value.ToString()
                FrmEmpleados.txtSueldo.Text = DgvEmpleado.CurrentRow.Cells("Sueldo").Value.ToString()
                idEmpleados = DgvEmpleado.CurrentRow.Cells("Codigo").Value.ToString()

                FrmEmpleados.ShowDialog()
            Else
                MessageBox.Show("Seleccione una fila por favor")
            End If
        End If
        If num.Equals(2) Then
            frmClientes.lblTituloCli.Text = "EDITAR CLIENTE"
            Editar = True
            If DgvEmpleado.SelectedRows.Count > 0 Then
                'Editar = True
                frmClientes.txtNombreCli.Text = DgvEmpleado.CurrentRow.Cells("Nombre").Value.ToString()
                frmClientes.txtApellidoCli.Text = DgvEmpleado.CurrentRow.Cells("Apellidos").Value.ToString()
                frmClientes.txtDniCli.Text = DgvEmpleado.CurrentRow.Cells("DNI").Value.ToString()
                frmClientes.txtSexoCli.Text = DgvEmpleado.CurrentRow.Cells("Sexo").Value.ToString()
                frmClientes.txtTelefonoCli.Text = DgvEmpleado.CurrentRow.Cells("Teléfono").Value.ToString()
                frmClientes.txtDireccionCli.Text = DgvEmpleado.CurrentRow.Cells("Dirección").Value.ToString()
                frmClientes.txtEmailCli.Text = DgvEmpleado.CurrentRow.Cells("Email").Value.ToString()
                idClientes = DgvEmpleado.CurrentRow.Cells("Código").Value.ToString()

                frmClientes.ShowDialog()
            Else
                MessageBox.Show("Seleccione una fila por favor")
            End If
        End If
        If num.Equals(3) Then
            frmProductos.lblTituloProd.Text = "EDITAR PRODUCTO"
            Editar = True
            If DgvEmpleado.SelectedRows.Count > 0 Then
                'Editar = True
                frmProductos.txtNombreProd.Text = DgvEmpleado.CurrentRow.Cells("Producto").Value.ToString()
                frmProductos.txtMarcaProd.Text = DgvEmpleado.CurrentRow.Cells("Marca").Value.ToString()
                frmProductos.txtModeloProd.Text = DgvEmpleado.CurrentRow.Cells("Modelo").Value.ToString()
                frmProductos.txtSerieProd.Text = DgvEmpleado.CurrentRow.Cells("Serie").Value.ToString()
                frmProductos.txtStockProd.Text = DgvEmpleado.CurrentRow.Cells("Stock").Value.ToString()
                idProducto = DgvEmpleado.CurrentRow.Cells("Código").Value.ToString()

                frmProductos.ShowDialog()
            Else
                MessageBox.Show("Seleccione una fila por favor")
            End If
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If num.Equals(1) Then
            If DgvEmpleado.SelectedRows.Count > 0 Then
                idEmpleados = DgvEmpleado.CurrentRow.Cells("Codigo").Value.ToString()
                objetoCN_Empl.EliminarEmple(idEmpleados)
                MessageBox.Show("Eliminado correctamente")
                MostrarEmpleados()
            Else
                MessageBox.Show("Seleccione una fila por favor")
            End If
        End If
        If num.Equals(2) Then
            If DgvEmpleado.SelectedRows.Count > 0 Then
                idClientes = DgvEmpleado.CurrentRow.Cells("Código").Value.ToString()
                objetoCN_Cli.N_EliminarCli(Convert.ToInt32(idClientes))
                MessageBox.Show("Eliminado correctamente")
                MostrarClientes()
            Else
                MessageBox.Show("Seleccione una fila por favor")
            End If
        End If
        If num.Equals(3) Then
            If DgvEmpleado.SelectedRows.Count > 0 Then
                idProducto = DgvEmpleado.CurrentRow.Cells("Código").Value.ToString()
                objetoCN_Prod.N_EliminarProd(idProducto)
                MessageBox.Show("Eliminado correctamente")
                MostrarProductos()
            Else
                MessageBox.Show("seleccione una fila por favor")
            End If
        End If
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        num = 2
        MostrarClientes()
        HabilitarBotones()
    End Sub

    Private Sub MostrarClientes()
        Dim objeto As CN_Clientes = New CN_Clientes()
        DgvEmpleado.DataSource = objeto.N_MostrarCli()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        num = 3
        MostrarProductos()
        HabilitarBotones()
    End Sub
    Private Sub MostrarProductos()
        Dim objeto As CN_Productos = New CN_Productos()
        DgvEmpleado.DataSource = objeto.N_MostrarProd()
    End Sub

    Private Sub LimpiarControlesEmpl()
        FrmEmpleados.txtNombre.Text = ""
        FrmEmpleados.txtEdad.Text = ""
        FrmEmpleados.txtSexo.Text = ""
        FrmEmpleados.txtSueldo.Text = ""
    End Sub
    Private Sub LimpiarControlesCli()
        frmClientes.txtNombreCli.Text = ""
        frmClientes.txtApellidoCli.Text = ""
        frmClientes.txtDniCli.Text = ""
        frmClientes.txtSexoCli.Text = ""
        frmClientes.txtTelefonoCli.Text = ""
        frmClientes.txtDireccionCli.Text = ""
        frmClientes.txtEmailCli.Text = ""
    End Sub

    Private Sub LimpiarControlesProd()
        frmProductos.txtNombreProd.Text = ""
        frmProductos.txtMarcaProd.Text = ""
        frmProductos.txtModeloProd.Text = ""
        frmProductos.txtSerieProd.Text = ""
        frmProductos.txtStockProd.Text = ""
    End Sub
End Class
