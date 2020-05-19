Imports CapaNegocio
Imports CapaEntidad
Public Class FrmEmpleados

    Private objetoCN As CN_Empleados = New CN_Empleados()
    Private objetoCE As CE_Empleados = New CE_Empleados()

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Form1.Editar = False Then
            Try
                objetoCE.nomEmp = txtNombre.Text
                objetoCE.edadEmp = txtEdad.Text
                objetoCE.sexoEmp = txtSexo.Text
                objetoCE.sueldoEmp = Convert.ToDouble(txtSueldo.Text)
                objetoCE.codEmp = Convert.ToInt32(Form1.idEmpleados)
                objetoCN.InsertarEmple(objetoCE)
                MessageBox.Show("Se guadó correctamente")

            Catch ex As Exception
                MessageBox.Show("no se pudo guardó los datos por: " & ex.Message)
            End Try
        End If

        If Form1.Editar = True Then
            Try
                objetoCE.nomEmp = txtNombre.Text
                objetoCE.edadEmp = txtEdad.Text
                objetoCE.sexoEmp = txtSexo.Text
                objetoCE.sueldoEmp = Convert.ToDouble(txtSueldo.Text)
                objetoCE.codEmp = Convert.ToInt32(Form1.idEmpleados)
                objetoCN.EditarEmple(objetoCE)
                MessageBox.Show("Se Editó correctamente")
                Form1.Editar = False
            Catch ex As Exception
                MessageBox.Show("no se pudo editar los datos por: " & ex.Message)
            End Try
        End If
        Me.Close()
        MostrarEmpleados()
    End Sub
    Private Sub MostrarEmpleados()
        Dim objeto As CN_Empleados = New CN_Empleados()
        Form1.DgvEmpleado.DataSource = objeto.MostrarEmple()
    End Sub
End Class