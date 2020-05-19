Imports CapaNegocio
Imports CapaEntidad

Public Class frmProductos
    Private objetoCN As CN_Productos = New CN_Productos()
    Private objetoCE As CE_Productos = New CE_Productos()
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Form1.Editar = False Then
            Try
                objetoCE.nomProd = txtNombreProd.Text
                objetoCE.marcaProd = txtMarcaProd.Text
                objetoCE.modeloProd = txtModeloProd.Text
                objetoCE.serieProd = txtSerieProd.Text
                objetoCE.stockProd = txtStockProd.Text
                objetoCN.N_InsertarProd(objetoCE)
                MessageBox.Show("Se Guardó correctamente")

            Catch ex As Exception
                MessageBox.Show("no se pudo guardar los datos por: " & ex.Message)
            End Try
        End If

        If Form1.Editar = True Then
            Try
                objetoCE.nomProd = txtNombreProd.Text
                objetoCE.marcaProd = txtMarcaProd.Text
                objetoCE.modeloProd = txtModeloProd.Text
                objetoCE.serieProd = txtSerieProd.Text
                objetoCE.stockProd = txtStockProd.Text
                objetoCE.idProd = Convert.ToInt32(Form1.idProducto)
                objetoCN.N_EditarProd(objetoCE)
                MessageBox.Show("Se Editó correctamente")
                Form1.Editar = False
            Catch ex As Exception
                MessageBox.Show("no se pudo editar los datos por: " & ex.Message)
            End Try
        End If
        Me.Close()
        MostrarProductos()
    End Sub

    Private Sub MostrarProductos()
        Dim objeto As CN_Productos = New CN_Productos()
        Form1.DgvEmpleado.DataSource = objeto.N_MostrarProd()
    End Sub
End Class