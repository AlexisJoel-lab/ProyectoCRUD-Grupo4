Imports CapaNegocio
Public Class FrmFormulario
    Dim objNego As New Cls_Negocio
    Private Sub FrmFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEmpleados()
    End Sub
    Sub ListarEmpleados()
        Dim dt As DataTable = objNego.N_Listar
        DgvEmpleado.DataSource = dt
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        Me.Close()
        Dim frmnuevo As New FrmNuevo
        frmnuevo.ShowDialog()


    End Sub
End Class