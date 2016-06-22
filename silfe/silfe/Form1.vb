Public Class Form1


    Dim user As Usuarios = New Usuarios


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        cmbListadoUser.DataSource = user.Listado
        cmbListadoUser.DisplayMember = "nombre"
        cmbListadoUser.ValueMember = "id"



    End Sub
End Class
