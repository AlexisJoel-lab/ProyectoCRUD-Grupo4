Imports CapaDatos
Imports CapaEntidad
Public Class CN_Empleados
    Private objetoCD As CD_Empleados = New CD_Empleados()

    Public Function MostrarEmple() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = objetoCD.Mostrar()
        Return tabla
    End Function

    Public Sub InsertarEmple(ByVal nombre As String, ByVal edad As String, ByVal sexo As String, ByVal sueldo As String)
        objetoCD.Insertar(nombre, Convert.ToInt32(edad), sexo, Convert.ToDouble(sueldo))
    End Sub

    Public Sub EditarEmple(ByVal nombre As String, ByVal edad As String, ByVal sexo As String, ByVal sueldo As String, ByVal codigo As String)
        objetoCD.Editar(nombre, Convert.ToInt32(edad), sexo, Convert.ToDouble(sueldo), Convert.ToInt32(codigo))
    End Sub

    Public Sub EliminarEmple(ByVal codigo As String)
        objetoCD.Eliminar(Convert.ToInt32(codigo))
    End Sub
End Class
