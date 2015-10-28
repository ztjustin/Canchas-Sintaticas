Imports System.Data.SqlClient
Public Class frmUsuarioAdmin
    Private Sub Actualizar()
        Try

            Dim ds As New DataSet
            conectar()
            Dim da As New SqlDataAdapter("Select * from Usuario where Cod_Usuario='" + mtbCodUser2.Text + "'", Conexion)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim sql As String = "Update Usuario set Cod_Instalacion='" + mtbCodInsta2.Text + "',Nombre='" + txtNombre2.Text + "',Nick='" + txtNick2.Text + "',Email='" + txtEmail2.Text + "',Phone='" + mtbPhone2.Text + "',Direccion='" + txtDir2.Text + "',Password='" + txtPass2.Text + "' where Cod_Usuario='" + mtbCodUser2.Text + "'"

                Dim cmd As New SqlCommand(sql, Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha actualizado un registro seleccionado por codigo", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hubo un error por favor revisar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Hubo un error por favor revisar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If campos2() = True Then
            Actualizar()
        Else
            MessageBox.Show("Completa los espacios en blanco", "Espacios En blanco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub eliminar()
        If mtbCodUser3.Text = "" Then
            MessageBox.Show("Debes de llenar Todos los Campos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                conectar()
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter("Select * from Usuario where Cod_Usuario='" + mtbCodUser3.Text + "'", Conexion)
                da.Fill(ds)


                If ds.Tables(0).Rows.Count > 0 Then
                    Dim cmd As New SqlCommand("delete from Usuario where Cod_Usuario='" + mtbCodUser3.Text + "'", Conexion)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        eliminar()
    End Sub

    Private Sub agregar()
        Try
            conectar()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("Select * from Usuario where Nick='" + txtNick1.Text + "'", Conexion)
            da.Fill(ds)


            If ds.Tables(0).Rows.Count > 0 Then
                MessageBox.Show("El nick ya se encuentra en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim cmd As New SqlCommand("Insert into Usuario values('" + mtbCodigoInsta1.Text +
                                          "','" + txtNombre1.Text + "','" + txtNick1.Text +
                                          "','" + txtEmail1.Text + "','" + mtbPhone1.Text + "','" + txtDir1.Text + "','" + txtPass1.Text + "')", Conexion)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha ingresado un nuevo equipo", "Nuevo equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("No se ha podido ingresar el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If campos1() = True Then
            agregar()
        Else
            MessageBox.Show("Espacios en blanco", "Espacios vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class