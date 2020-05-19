Imports CapaNegocio

Public Class Form1
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        MostrarEmpleados()
        HabilitarBotones()
    End Sub
    Private objetoCN As CN_Empleados = New CN_Empleados()
    Public idEmpleados As String = Nothing
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
        FrmEmpleados.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If DgvEmpleado.SelectedRows.Count > 0 Then
            FrmEmpleados.Show()
            Editar = True
            FrmEmpleados.txtNombre.Text = DgvEmpleado.CurrentRow.Cells("Nombre").Value.ToString()
            FrmEmpleados.txtEdad.Text = DgvEmpleado.CurrentRow.Cells("Edad").Value.ToString()
            FrmEmpleados.txtSexo.Text = DgvEmpleado.CurrentRow.Cells("Sexo").Value.ToString()
            FrmEmpleados.txtSueldo.Text = DgvEmpleado.CurrentRow.Cells("Sueldo").Value.ToString()
            idEmpleados = DgvEmpleado.CurrentRow.Cells("Codigo").Value.ToString()
        Else
            MessageBox.Show("seleccione una fila por favor")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DgvEmpleado.SelectedRows.Count > 0 Then
            idEmpleados = DgvEmpleado.CurrentRow.Cells("Codigo").Value.ToString()
            objetoCN.EliminarEmple(idEmpleados)
            MessageBox.Show("Eliminado correctamente")
            MostrarEmpleados()
        Else
            MessageBox.Show("seleccione una fila por favor")
        End If
    End Sub
End Class
