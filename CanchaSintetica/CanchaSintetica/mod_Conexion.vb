Imports System.Data.SqlClient
Module mod_Conexion

    Public stringCadena = "Data Source=FAMILIA\JUSTIN;Initial Catalog=Sintetica;user =SA,Password= justin9ucr;MultipleActiveResultSets=True;Integrated security=SSPI"
    Public Conexion As New SqlConnection(stringCadena)

    Public Sub conectar()
        Try
            Conexion.Open()
        Catch ex As Exception
            MessageBox.Show("there is a problem with to connect with the Data Base ", "Error with conexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub desconectar()
        Try
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show("there is a problem with to desconnect with the Data Base ", "Error with desconexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Module
