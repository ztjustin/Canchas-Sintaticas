Imports System.Data.SqlClient

Public Class LogUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Validar()
    End Sub

    Private Sub Validar()
        Try

            conectar()
            Dim ejecutador As SqlDataReader
            Dim query As New SqlCommand("Select * from Usuario where Cod_Usuario='" + txtUser.Text + "' COLLATE  SQL_Latin1_General_CP1_CS_AS and Password='" + txtPass.Text + "' COLLATE  SQL_Latin1_General_CP1_CS_AS", Conexion)
            ejecutador = query.ExecuteReader

            If ejecutador.HasRows Then
                Me.Visible = False
                SistemaMain.Visible = True
                MessageBox.Show("Has iniciado Sesion")
            Else
                MessageBox.Show("The User Name or the Password is wrong.Please try Again", "Error with Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            desconectar()
        Catch ex As Exception
            MessageBox.Show("There is a problem with the query", "Trouble with the sql server query", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class