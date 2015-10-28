Imports System.Data.SqlClient
Public Class frmInstalacionAdmin
    Private Function campos()
        Dim obj As New Object
        Dim valido As Boolean = True
        For Each obj In GroupBox1.Controls
            If obj.GetType.Name = "TextBox" Or obj.GetType.Name = "MaskedTextBox" Then
                If obj.Text = "" Then
                    valido = False
                End If
            End If
        Next
        Return valido
    End Function
    Private Function campos2()
        Dim obj As New Object
        Dim valido As Boolean = True
        For Each obj In GroupBox2.Controls
            If obj.GetType.Name = "TextBox" Or obj.GetType.Name = "MaskedTextBox" Then
                If obj.Text = "" Then
                    valido = False
                End If
            End If
        Next
        Return valido
    End Function

    Private Sub agregar()
        Try
            conectar()
            Dim ds As New DataSet
            Dim sql As String = "select * from InstalacionDeportiva where Nombre_Instalacion ='" + txtNombre.Text + "'"
            Dim da As New SqlDataAdapter(sql, Conexion)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MessageBox.Show("El nombre ya existe por favor ingrese un Nombre Valido o un Telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Dim query As String = "Insert into InstalacionDeportiva values('" + txtNombre.Text + "','" + txtUbicacion.Text +
                        "','" + mtbTelefono1.Text + "')"
                    Dim cmd As New SqlCommand(query, Conexion)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Se ingreso una nueva instalacion deportiva", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Hubo un problema al ingresar una nueva Instalacion Deportiva.Revise el telefono o Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    desconectar()
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If campos() = False Then
            MessageBox.Show("Hay espacios vacios", "Espacios vacios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            agregar()
        End If
    End Sub

    Private Sub actualizar()
        Try
            conectar()
            Dim ds As New DataSet
            Dim sql As String = "select * from InstalacionDeportiva where Cod_Instalacion='" + mtbcod1.Text + "'"
            Dim da As New SqlDataAdapter(sql, Conexion)

            da.Fill(ds)


            If ds.Tables(0).Rows.Count > 0 Then
                Dim query As String = "Update InstalacionDeportiva set Nombre_Instalacion='" + txtNombre2.Text +
                    "',Ubicacion='" + txtUbicacion2.Text + "',Telefono='" + mtbTelefono2.Text + "' where Cod_Instalacion='" + mtbcod1.Text + "'"
                Dim cmd As New SqlCommand(query, Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha actualizado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("no Se ha actualizado el registro problemente no existe", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If campos2() = False Then
            MessageBox.Show("Espacios en blanco", "Espacios vacios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            actualizar()
        End If
    End Sub

    Private Sub eliminar()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "select * from InstalacionDeportiva where Cod_Instalacion='" + mtbCod2.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As New SqlCommand("Delete from InstalacionDeportiva where Cod_Instalacion='" + mtbCod2.Text + "'", Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Un nuevo registro se ha eliminado", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Un nuevo registro no se ha eliminado porque no existe", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error debido que tiene campeonatos y partidos pendientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If mtbCod2.Text = "" Then
            MessageBox.Show("Espacios vacios", "Espacios en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            eliminar()
        End If
    End Sub
End Class