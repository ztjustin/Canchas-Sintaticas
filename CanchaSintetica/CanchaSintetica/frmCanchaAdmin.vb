Imports System.Data.SqlClient
Public Class frmCanchaAdmin
    Private Sub Agregar()
        If Not campos() = False Then
            Try
                conectar()
                Dim cmd As New SqlCommand("Insert into Cancha values('" + mtbCodigo.Text +
                                          "','" + txtMalla.Text + "','" + txtMetros.Text +
                                          "','" + txtCesped.Text + "')", Conexion)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Una nueva Cancha ha sido introducida", "nueva Cancha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Hubo un error problamente debido al codigo De Instalacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                desconectar()
            End Try



        Else
            MessageBox.Show("Debes de llenar todos lo campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Agregar()
    End Sub
    Private Sub eliminar()
        Try

            If mtbCodCancha3.Text = "" Then
                MessageBox.Show("Debes de ingresar el codigo de Cancha para poder Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    conectar()
                    Dim ds As New DataSet
                    Dim sql As String = "select * from Cancha where Cod_Cancha='" + mtbCodCancha3.Text + "'"
                    Dim da As New SqlDataAdapter(sql, Conexion)
                    da.Fill(ds)
                    If ds.Tables(0).Rows.Count > 0 Then

                        Dim query As String = "delete from Cancha where Cod_Cancha='" + mtbCodCancha3.Text + "'"
                        Dim cmd As New SqlCommand(query, Conexion)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Un registro ha sido eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Huvo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    desconectar()
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Huvo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        eliminar()
    End Sub

    Private Sub actualizar()
        Try
            conectar()
            Dim ds As New DataSet
            Dim sql As String = "Select * from Cancha where Cod_Cancha ='" + mtbCodCancha.Text + "'"
            Dim da As New SqlDataAdapter(sql, Conexion)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim query As String = "Update Cancha set Cod_Instalacion='" + mtbCodInsta2.Text +
                    "',Tipo_Malla='" + mtbMalla2.Text + "',Metros_Cuadrados='" + mtbMetros2.Text +
                    "',Tipo_Cesped='" + txtCesped2.Text + "' where Cod_Cancha='" + mtbCodCancha.Text + "'"

                Dim cmd As New SqlCommand(query, Conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("El registro fue actualizado con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("No se pudo Actualizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


        Catch ex As Exception
            MessageBox.Show("Huvo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not campos2() = False Then
            actualizar()
        Else
            MessageBox.Show("Debes de llenar todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class