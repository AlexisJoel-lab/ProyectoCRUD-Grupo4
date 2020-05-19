Imports CapaNegocio
Public Class FrmEmpleados
    Private objetoCN As CN_Empleados = New CN_Empleados()
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Form1.Editar = False Then
            Try
                objetoCN.InsertarEmple(txtNombre.Text, txtEdad.Text, txtSexo.Text, txtSueldo.Text)
                MessageBox.Show("Se Inserto correctamente")

            Catch ex As Exception
                MessageBox.Show("no se pudo insertar los datos por: " & ex.Message)
            End Try
        End If

        If Form1.Editar = True Then

            Try
                objetoCN.EditarEmple(txtNombre.Text, txtEdad.Text, txtSexo.Text, txtSueldo.Text, Form1.idEmpleados)
                MessageBox.Show("Se Edito correctamente")
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