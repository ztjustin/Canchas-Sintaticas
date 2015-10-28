Imports System.Data.SqlClient
Public Class frmPasswordChange

    Private Function verificarDatos()
        Dim valido As Boolean
        Dim sql As String
        Dim ds As New DataSet
        sql = "Select * from Usuario where Password='" + txtContraAntigua.Text + "' COLLATE  SQL_Latin1_General_CP1_CS_AS"
        conectar()
        Dim da As New SqlDataAdapter(sql, Conexion)
        da.Fill(ds)
        desconectar()
        If ds.Tables(0).Rows.Count > 0 Then
            valido = True
        Else
            valido = False
        End If
        Return valido
    End Function

    Private Sub change()
        Dim valido As Boolean = False
        If txtContraNueva1.Text = txtContraNueva2.Text Then
            Try
                conectar()
                Dim cmd As New SqlCommand("Update Usuario set Password='" + txtContraNueva1.Text + "' where Cod_Usuario ='" + LogUser.txtUser.Text + "'", Conexion)
                MessageBox.Show("Se cambio la contraseña correctamente", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Hubo un error al cambiar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                desconectar()
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If verificarDatos() = True Then
            change()
        Else
            MessageBox.Show("Las contraseñas no son las mismas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class