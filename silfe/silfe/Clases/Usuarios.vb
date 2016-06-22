Public Class Usuarios

    Public ID As Integer
    Public Nombre As String


    Function Listado() As DataTable

        'DEVUELVE EL LISTADO DE USUARIOS
        Return ConsultaSQL("SELECT * FROM USUARIOS")

    End Function
End Class
