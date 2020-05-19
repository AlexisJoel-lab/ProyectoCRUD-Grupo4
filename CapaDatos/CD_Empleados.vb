Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
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

    Public Sub Insertar(ByVal nombre As String, ByVal edad As Integer, ByVal sexo As String, ByVal sueldo As Double)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "InsertarEmpleados"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nomEmp", nombre)
        comando.Parameters.AddWithValue("@edadEmp", edad)
        comando.Parameters.AddWithValue("@sexoEmp", sexo)
        comando.Parameters.AddWithValue("@sueldoEmp", sueldo)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub

    Public Sub Editar(ByVal nombre As String, ByVal edad As Integer, ByVal sexo As String, ByVal sueldo As Double, ByVal codigo As Integer)
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "EditarEmpleados"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nomEmp", nombre)
        comando.Parameters.AddWithValue("@edadEmp", edad)
        comando.Parameters.AddWithValue("@sexoEmp", sexo)
        comando.Parameters.AddWithValue("@sueldoEmp", sueldo)
        comando.Parameters.AddWithValue("@codEmp", codigo)
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
