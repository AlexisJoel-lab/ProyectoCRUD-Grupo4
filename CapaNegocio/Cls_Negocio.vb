Imports CapaDatos
Imports CapaEntidad
Public Class Cls_Negocio
    Private objDatos As New Cls_Datos
    Public Function N_Listar() As DataTable
        Return objDatos.D_Listar
    End Function

    Public Sub N_insertEmpleados(enti As Cls_Entidad)
        objDatos.D_InsertarEmpleado(enti)
    End Sub
End Class
