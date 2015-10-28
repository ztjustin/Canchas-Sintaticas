Imports System.Data.SqlClient
Public Class frmCampeonatoAdmin
    Private Sub Actualizar()
        Try

            Dim ds As New DataSet
            conectar()
            Dim da As New SqlDataAdapter("Select * from Campeonato where Cod_Campeonato='" + mtbCodCamp2.Text + "'", Conexion)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim sql As String = "Update Campeonato set Cod_Instalacion='" + mtbCodInsta2.Text + "',Nombre_Campeonato='" + txtNombre2.Text + "',Fecha_Inicio='" + dtpFechaInicio2.Value + "',Fecha_Final='" + dtpFechaFinal2.Value + "',Premio='" + txtPremioCamp2.Text + "' where Cod_Campeonato='" + mtbCodCamp2.Text + "'"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not campos2() = False Then
            Actualizar()
        Else
            MessageBox.Show("Espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Agregar()
        If Not campos1() = False Then
            Try
                conectar()
                Dim cmd As New SqlCommand("Insert into Campeonato values('" + mtbCodInsta.Text +
                                          "','" + txtNombre.Text + "','" + dtpFechaInicio.Value +
                                          "','" + dtpFechaFinal.Value + "','" + txtPremioCamp.Text + "')", Conexion)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Un nuevo registro ha sido introducida", "nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Hubo un error revisa los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                desconectar()
            End Try



        Else
            MessageBox.Show("Debes de llenar todos lo campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If campos1() = True Then
            Agregar()
        Else
            MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub eliminar()
        If mtbCod3.Text = "" Then
            MessageBox.Show("Debes de llenar Todos los Campos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                conectar()
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter("Select * from Campeonato where Cod_Campeonato='" + mtbCod3.Text + "'", Conexion)
                da.Fill(ds)


                If ds.Tables(0).Rows.Count > 0 Then
                    Dim cmd As New SqlCommand("Delete from Campeonato where Cod_Campeonato ='" + mtbCod3.Text + "'", Conexion)
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