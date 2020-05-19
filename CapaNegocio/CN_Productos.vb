Imports CapaDatos
Imports CapaEntidad

Public Class CN_Productos
    Private objetoCD As New CD_Productos()

    Public Function N_MostrarProd() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = objetoCD.D_ListarProductos
        Return tabla
    End Function

    Public Sub N_InsertarProd(enti As CE_Productos)
        objetoCD.D_InsertarProductos(enti)
    End Sub

    Public Sub N_EditarProd(enti As CE_Productos)
        objetoCD.D_EditarProductos(enti)
    End Sub

    Public Sub N_EliminarProd(ByVal codigo As String)
        objetoCD.D_EliminarProductos(Convert.ToInt32(codigo))
    End Sub
End Class
