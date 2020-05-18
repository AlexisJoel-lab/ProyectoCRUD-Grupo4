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
End Class