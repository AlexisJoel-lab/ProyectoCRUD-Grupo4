Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class CD_Conexion

    Private Conexion As SqlConnection = New SqlConnection("Server=ALEXIS-PC\SQLEXPRESS;DataBase= CursoMVC;Integrated Security=true")

    Public Function AbrirConexion() As SqlConnection
        If Conexion.State = ConnectionState.Closed Then
            Conexion.Open()
        End If
        Return Conexion
    End Function

    Public Function CerrarConexion() As SqlConnection
        If Conexion.State = ConnectionState.Open Then
            Conexion.Close()
        End If
        Return Conexion
    End Function

End Class