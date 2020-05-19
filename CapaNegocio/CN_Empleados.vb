Imports CapaDatos
Imports CapaEntidad

Public Class CN_Empleados
    Private objetoCD As New CD_Empleados()

    Public Function MostrarEmple() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = objetoCD.Mostrar
        Return tabla
    End Function

    Public Sub InsertarEmple(enti As CE_Empleados)
        objetoCD.Insertar(enti)
        'objetoCD.Insertar(nombre, Convert.ToInt32(edad), sexo, Convert.ToDouble(sueldo))
    End Sub

    Public Sub EditarEmple(enti As CE_Empleados)
        objetoCD.Editar(enti)
    End Sub

    Public Sub EliminarEmple(ByVal codigo As String)
        objetoCD.Eliminar(Convert.ToInt32(codigo))
    End Sub
End Class
