Imports CapaNegocio
Imports CapaEntidad
Public Class FrmNuevo
    Dim objNeg As New Cls_Negocio
    Dim objEnt As New Cls_Entidad
    Private Sub FrmNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objEnt.nomEmp = TextBox1.Text
        objEnt.edadEmp = TextBox2.Text
        objEnt.sexoEmp = TextBox3.Text
        objEnt.sueldoEmp = TextBox4.Text
        objNeg.N_insertEmpleados(objEnt)
        MessageBox.Show("Datos insertados correctamente")
        Me.Close()
    End Sub
End Class