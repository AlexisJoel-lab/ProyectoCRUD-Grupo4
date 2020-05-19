Imports System.Data.SqlClient
Imports CapaEntidad
Public Class CD_Clientes
    Private conexion As CD_Conexion = New CD_Conexion()
    Private leer As SqlDataReader
    Private tabla As DataTable = New DataTable()
    Private comando As SqlCommand = New SqlCommand()

    'Mostrar Clientes
    Public Function D_ListarClientes() As DataTable
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "MostrarCliente"
        comando.CommandType = CommandType.StoredProcedure
        leer = comando.ExecuteReader()
        tabla.Load(leer)
        conexion.CerrarConexion()
        Return tabla
    End Function

    'Insertar Clientes
    Public Sub D_InsertarClientes(enti As CE_Clientes)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "InsertarCliente"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nomCli", enti.nomCli)
        comando.Parameters.AddWithValue("@apeCli", enti.apeCli)
        comando.Parameters.AddWithValue("@dniCli", enti.dniCli)
        comando.Parameters.AddWithValue("@sexCli", enti.sexCli)
        comando.Parameters.AddWithValue("@telfCli", enti.telfCli)
        comando.Parameters.AddWithValue("@dirCli", enti.dirCli)
        comando.Parameters.AddWithValue("@emailCli", enti.emailCli)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub
    Public Sub D_EditarClientes(enti As CE_Clientes)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "EditarCliente"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nomCli", enti.nomCli)
        comando.Parameters.AddWithValue("@apeCli", enti.apeCli)
        comando.Parameters.AddWithValue("@dniCli", enti.dniCli)
        comando.Parameters.AddWithValue("@sexCli", enti.sexCli)
        comando.Parameters.AddWithValue("@telfCli", enti.telfCli)
        comando.Parameters.AddWithValue("@dirCli", enti.dirCli)
        comando.Parameters.AddWithValue("@emailCli", enti.emailCli)
        comando.Parameters.AddWithValue("@idCli", enti.idCli)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub

    Public Sub D_EliminarClientes(ByVal codigo As Integer)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "EliminarCliente"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idCli", codigo)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub
End Class
