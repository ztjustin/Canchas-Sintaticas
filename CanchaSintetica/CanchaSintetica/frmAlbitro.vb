Imports System.Data.SqlClient
Public Class frmAlbitro
    Private Sub searchByCode()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "select Id_Albitro,Cod_Instalacion,Nombre,Categoria,Edad from Albitro where Id_Albitro ='" + txtCodigoCancha.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            dgvLista.DataSource = ds.Tables(0)

            dgvLista.Columns(0).HeaderText = "Id del Albitro"
            dgvLista.Columns(1).HeaderText = "Codigo de Instalacion"
            dgvLista.Columns(2).HeaderText = "Nombre del Albitro"
            dgvLista.Columns(3).HeaderText = "Categoria"
            dgvLista.Columns(4).HeaderText = "Edad"


        Catch ex As Exception
            MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
    Private Sub searchByCodeInstalacion()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select Id_Albitro,Cod_Instalacion,Nombre,Categoria,Edad from Albitro where Cod_Instalacion ='" + txtCodigoInstalacion.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            dgvLista.DataSource = ds.Tables(0)

            dgvLista.Columns(0).HeaderText = "Id del Albitro"
            dgvLista.Columns(1).HeaderText = "Codigo de Instalacion"
            dgvLista.Columns(2).HeaderText = "Nombre del Albitro"
            dgvLista.Columns(3).HeaderText = "Categoria"
            dgvLista.Columns(4).HeaderText = "Edad"


        Catch ex As Exception
            MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub btnBuscarByCode_Click(sender As Object, e As EventArgs) Handles btnBuscarByCode.Click
        searchByCode()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnBuscarByInstalacion_Click(sender As Object, e As EventArgs) Handles btnBuscarByInstalacion.Click
        searchByCodeInstalacion()
    End Sub
End Class