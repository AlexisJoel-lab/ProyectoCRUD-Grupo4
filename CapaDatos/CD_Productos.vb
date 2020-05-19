Imports System.Data.SqlClient
Imports CapaEntidad

Public Class CD_Productos
    Private conexion As CD_Conexion = New CD_Conexion()
    Private leer As SqlDataReader
    Private tabla As DataTable = New DataTable()
    Private comando As SqlCommand = New SqlCommand()

    Public Function D_ListarProductos() As DataTable
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "MostrarProducto"
        comando.CommandType = CommandType.StoredProcedure
        leer = comando.ExecuteReader()
        tabla.Load(leer)
        conexion.CerrarConexion()
        Return tabla
    End Function

    'Insertar Clientes
    Public Sub D_InsertarProductos(enti As CE_Productos)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "InsertarProducto"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nomProd", enti.nomProd)
        comando.Parameters.AddWithValue("@marcaProd", enti.marcaProd)
        comando.Parameters.AddWithValue("@modeloProd", enti.modeloProd)
        comando.Parameters.AddWithValue("@serieProd", enti.serieProd)
        comando.Parameters.AddWithValue("@stockProd", enti.stockProd)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub

    Public Sub D_EditarProductos(enti As CE_Productos)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "EditarProducto"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nomProd", enti.nomProd)
        comando.Parameters.AddWithValue("@marcaProd", enti.marcaProd)
        comando.Parameters.AddWithValue("@modeloProd", enti.modeloProd)
        comando.Parameters.AddWithValue("@serieProd", enti.serieProd)
        comando.Parameters.AddWithValue("@stockProd", enti.stockProd)
        comando.Parameters.AddWithValue("@idProd", enti.idProd)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub

    Public Sub D_EliminarProductos(ByVal codigo As Integer)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "EliminarProducto"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idProd", codigo)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub
End Class
