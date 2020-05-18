Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class Cls_Datos
    'Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("CursoMVC").ConnectionString)

    Public cn As New SqlConnection("DataBase=CursoMVC; Server=(local) ; Integrated Security=yes")

    'Public Sub Conectar()
    '    If cn.State = 0 Then cn.Open()
    'End Sub

    '    Public Sub Desconectar()
    '    If cn.State = 1 Then cn.Close()
    'End Sub

    Public Function D_Listar() As DataTable
        Dim cmd As New SqlCommand("Select * from empleados", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function

End Class