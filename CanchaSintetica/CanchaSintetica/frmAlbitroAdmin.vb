Imports System.Data.SqlClient
Public Class frmAlbitroAdmin
    Private Sub Actualizar()
        Try

            Dim ds As New DataSet
            conectar()
            Dim da As New SqlDataAdapter("Select * from Albitro where Id_Albitro='" + mtbId2.Text + "'", Conexion)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim sql As String = "Update Albitro set Cod_Instalacion='" + mtbCod_Instala2.Text +
                    "',Cedula='" + mtbCedula2.Text + "',Nombre='" + txtNom2.Text +
                    "',Categoria='" + txtCat2.Text + "',Edad='" + mtbEdad2.Text + "' where Id_Albitro='" + mtbId2.Text + "'"

                Dim cmd As New SqlCommand(sql, Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha actualizado el Albitro seleccionado por codigo", "Acualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hubo un error por favor revisar los datos probablemente el Albitro no se encuentra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Hubo un error por favor revisar los datos probablemente el Albitro no se encuentra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
    Private Function mysql() As String

        Dim sql As String
        Dim ds As New DataSet
        conectar()
        Dim da As New SqlDataAdapter("Select * from Albitro where Cedula='" + mtbCed.Text + "'", Conexion)
        da.Fill(ds)
        desconectar()

        If ds.Tables(0).Rows.Count > 0 Then
            Exit Function
        Else
            sql = "Insert into Albitro values('" + mtbCodInsta.Text +
                "','" + mtbCed.Text + "','" + txtNom.Text +
                "','" + txtCateg.Text + "','" + mtbEdad.Text + "')"
        End If
        Return sql
    End Function
    Private Sub addOrUpdate()

        If campos() = False Then
            MessageBox.Show("Debes de llenar Todos los Campos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim sql As String = mysql()
                conectar()
                Dim cmd As New SqlCommand(sql, Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Un Albitro ha sido introducio o actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Hubo un error por favor revisar los datos probablemente el Albitro ya se encuentra registrado O debes de asignarlo a una Instalacion existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                desconectar()
            End Try

        End If

    End Sub
    Private Function campos()
        Dim valido As Boolean = True
        Dim obj As New Object
        For Each obj In GroupBox1.Controls
            If obj.GetType.Name = "TextBox" Then
                If obj.text = "" Then
                    valido = False
                End If
            End If
        Next
        Return valido
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addOrUpdate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If campos2() = False Then
            MessageBox.Show("Debes de llenar Todos los Campos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Actualizar()
        End If
    End Sub
    Private Function campos2()
        Dim valido As Boolean = True
        Dim obj As New Object
        For Each obj In GroupBox2.Controls
            If obj.GetType.Name = "TextBox" Then
                If obj.text = "" Then
                    valido = False
                End If
            End If
        Next
        Return valido
    End Function
    Private Sub eliminar()
        If mtbId3.Text = "" Then
            MessageBox.Show("Debes de llenar Todos los Campos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                conectar()
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter("Select * from Albitro where Id_Albitro='" + mtbId3.Text + "'", Conexion)
                da.Fill(ds)


                If ds.Tables(0).Rows.Count > 0 Then
                    Dim cmd As New SqlCommand("delete from Albitro where Id_Albitro='" + mtbId3.Text + "'", Conexion)
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

End Class