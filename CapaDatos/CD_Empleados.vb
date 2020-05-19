Imports System.Data.SqlClient
Imports CapaEntidad

Public Class CD_Empleados
    Private conexion As CD_Conexion = New CD_Conexion()
    Private leer As SqlDataReader
    Private tabla As DataTable = New DataTable()
    Private comando As SqlCommand = New SqlCommand()

    Public Function Mostrar() As DataTable
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "MostrarEmpleados"
        comando.CommandType = CommandType.StoredProcedure
        leer = comando.ExecuteReader()
        tabla.Load(leer)
        conexion.CerrarConexion()
        Return tabla
    End Function

    Public Sub Insertar(enti As CE_Empleados)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "InsertarEmpleados"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nomEmp", enti.nomEmp)
        comando.Parameters.AddWithValue("@edadEmp", enti.edadEmp)
        comando.Parameters.AddWithValue("@sexoEmp", enti.sexoEmp)
        comando.Parameters.AddWithValue("@sueldoEmp", enti.sueldoEmp)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub

    Public Sub Editar(enti As CE_Empleados)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "EditarEmpleados"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nomEmp", enti.nomEmp)
        comando.Parameters.AddWithValue("@edadEmp", enti.edadEmp)
        comando.Parameters.AddWithValue("@sexoEmp", enti.sexoEmp)
        comando.Parameters.AddWithValue("@sueldoEmp", enti.sueldoEmp)
        comando.Parameters.AddWithValue("@codEmp", enti.codEmp)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub

    Public Sub Eliminar(ByVal codigo As Integer)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "EliminarEmpleados"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@codEmp", codigo)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub
End Class
