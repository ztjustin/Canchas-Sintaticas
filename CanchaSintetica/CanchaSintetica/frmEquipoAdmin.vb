Imports System.Data.SqlClient
Public Class frmEquipoAdmin
    Private Sub agregar()
        Try
            conectar()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("Select * from Equipo where Nombre_Equipo='" + txtNombre1.Text + "'", Conexion)
            da.Fill(ds)


            If ds.Tables(0).Rows.Count > 0 Then
                MessageBox.Show("El nombre ya se encuentra en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim query As String = "Insert into Equipo values('" + mtbCodCampeo1.Text + "','" + mtbCantJuga1.Text +
                    "','" + txtNombre1.Text + "')"
                Dim cmd As New SqlCommand(query, Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha ingresado un nuevo equipo", "Nuevo equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("No se ha podido ingresar el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try


    End Sub
    Private Function campos1()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If campos1() = False Then
            MessageBox.Show("Espacios vacios", "Espacios en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            agregar()
        End If
    End Sub
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
    Private Sub actualizar()
        Try
            conectar()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("Select * from Equipo where Cod_Equipo='" + mtbCodEquipo2.Text + "'", Conexion)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim query As String = "Update Equipo set Cod_Campeonato='" + mtbCodCampeo2.Text + "',Cant_Jugadores='" + mtbCantJuga2.Text +
                    "',Nombre_Equipo='" + txtNombre2.Text + "' where Cod_Equipo='" + mtbCodEquipo2.Text + "'"
                Dim cmd As New SqlCommand(query, Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha actualizado un nuevo equipo", "Nuevo equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se encuentra el registro para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error problamente el campeonato no existe.Por favor verifica los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If campos2() = True Then
            actualizar()
        Else
            MessageBox.Show("Lena todos los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub eliminar()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select * from Equipo where Cod_Equipo ='" + mtbCodigoEquipo3.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As New SqlCommand("Delete from Equipo where Cod_Equipo = '" + mtbCodigoEquipo3.Text + "'", Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Un equipo ha sido eliminado", "Equipo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hubo un error problamente no existe el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mtbCodigoEquipo3.Text = "" Then
            MessageBox.Show("Llena todos los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            eliminar()
        End If
    End Sub
End Class