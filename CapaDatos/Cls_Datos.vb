Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class Cls_Datos
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("").ConnectionString)

    'Mostrar tabla
    Public Function D_Listar() As DataTable
        Dim cmd As New SqlCommand("Select * from ", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function

End Class