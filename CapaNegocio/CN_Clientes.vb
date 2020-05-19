Imports CapaDatos
Imports CapaEntidad

Public Class CN_Clientes
    Private objetoCD As New CD_Clientes()

    Public Function N_MostrarCli() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = objetoCD.D_ListarClientes
        Return tabla
    End Function

    Public Sub N_InsertarCli(enti As CE_Clientes)
        objetoCD.D_InsertarClientes(enti)
    End Sub

    Public Sub N_EditarCli(enti As CE_Clientes)
        objetoCD.D_EditarClientes(enti)
    End Sub

    Public Sub N_EliminarCli(ByVal codigo As String)
        objetoCD.D_EliminarClientes(Convert.ToInt32(codigo))
    End Sub

End Class
