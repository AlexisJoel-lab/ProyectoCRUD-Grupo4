Imports CapaNegocio
Imports CapaEntidad
Public Class frmClientes
    Private objetoCN As CN_Clientes = New CN_Clientes()
    Private objetoCE As CE_Clientes = New CE_Clientes()
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Form1.Editar = False Then
            Try
                objetoCE.nomCli = txtNombreCli.Text
                objetoCE.apeCli = txtApellidoCli.Text
                objetoCE.dniCli = txtDniCli.Text
                objetoCE.sexCli = txtSexoCli.Text
                objetoCE.telfCli = txtTelefonoCli.Text
                objetoCE.dirCli = txtDireccionCli.Text
                objetoCE.emailCli = txtEmailCli.Text
                objetoCN.N_InsertarCli(objetoCE)
                MessageBox.Show("Se Guardó correctamente")

            Catch ex As Exception
                MessageBox.Show("no se pudo guardar los datos por: " & ex.Message)
            End Try
        End If

        If Form1.Editar = True Then
            Try
                objetoCE.nomCli = txtNombreCli.Text
                objetoCE.apeCli = txtApellidoCli.Text
                objetoCE.dniCli = txtDniCli.Text
                objetoCE.sexCli = txtSexoCli.Text
                objetoCE.telfCli = txtTelefonoCli.Text
                objetoCE.dirCli = txtDireccionCli.Text
                objetoCE.emailCli = txtEmailCli.Text
                objetoCE.idCli = Convert.ToInt32(Form1.idClientes)
                objetoCN.N_EditarCli(objetoCE)
                MessageBox.Show("Se Editó correctamente")
                Form1.Editar = False
            Catch ex As Exception
                MessageBox.Show("no se pudo editar los datos por: " & ex.Message)
            End Try
        End If
        Me.Close()
        MostrarClientes()
    End Sub

    Private Sub MostrarClientes()
        Dim objeto As CN_Clientes = New CN_Clientes()
        Form1.DgvEmpleado.DataSource = objeto.N_MostrarCli()
    End Sub
End Class