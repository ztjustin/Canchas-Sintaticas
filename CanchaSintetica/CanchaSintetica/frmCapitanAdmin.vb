Imports System.Data.SqlClient
Public Class frmCapitanAdmin


    Private Sub agregar()
        Try
            conectar()

            Dim query As String = "Insert into Capitan values('" + mtbCodigoEquipo1.Text + "','" + txtNombre1.Text +
                    "','" + txtNumeroCamiseta1.Text + "','" + mtbTel1.Text + "','" + txtCorreo1.Text + "')"
                Dim cmd As New SqlCommand(query, Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha ingresado un nuevo registro", "Nuevo equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show("No se ha podido ingresar el Capitan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try


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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroCamiseta1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If campos1() = False Then
            MessageBox.Show("Rellene todos los campos vacios", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            agregar()
        End If
    End Sub

    Private Sub eliminar()
        If mtbCodCapitan3.Text = "" Then
            MessageBox.Show("Debes de llenar Todos los Campos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                conectar()
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter("Select * from Capitan where Cod_Capitan='" + mtbCodCapitan3.Text + "'", Conexion)
                da.Fill(ds)


                If ds.Tables(0).Rows.Count > 0 Then
                    Dim cmd As New SqlCommand("delete from Partido where Cod_Partido='" + mtbCodCapitan3.Text + "'", Conexion)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("El registro fue eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("El registro no fue eliminado correctamente deido a que problamente el registro no existe", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("El registro no fue eliminado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                desconectar()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        eliminar()
    End Sub

    Private Sub Actualizar()
        Try

            Dim ds As New DataSet
            conectar()
            Dim da As New SqlDataAdapter("Select * from Capitan where Cod_Capitan='" + mtbCodCap2.Text + "'", Conexion)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim sql As String = "Update Capitan set Cod_Equipo='" + mtbCodEquipo2.Text + "',Nombre='" + txtNombre2.Text + "',Numero_Camiseta='" + txtCamiseta2.Text + "',Telefono='" + mtbTel2.Text + "',Correo='" + txtCorreo2.Text + "'  where Cod_Capitan='" + mtbCodCap2.Text + "'"

                Dim cmd As New SqlCommand(sql, Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha actualizado un registro seleccionado por codigo", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hubo un error por favor revisar los datos probablement no existe el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Hubo un error por favor revisar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If campos2() = False Then
            MessageBox.Show("Espacios vacios", "Espacios en Blanco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Actualizar()
        End If
    End Sub
End Class