Imports System.Data.SqlClient
Public Class frmCapitan
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        SistemaMain.Visible = True
        Me.Visible = False
    End Sub
    Private Sub searchByCode()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select Cod_Capitan,Cod_Equipo,Nombre,Telefono,Numero_Camiseta from Capitan where Cod_Capitan='" + txtCodigo.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            dgvLista.DataSource = ds.Tables(0)
            fillGrid()

        Catch ex As Exception
            MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
    Private Sub searchByCodeEquipo()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select Cod_Capitan,Cod_Equipo,Nombre,Telefono,Numero_Camiseta from Capitan where Cod_Equipo='" + txtCodigoEquipo.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            dgvLista.DataSource = ds.Tables(0)
            fillGrid()

        Catch ex As Exception
            MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
    Private Sub fillGrid()
        dgvLista.Columns(0).HeaderText = "Codigo del Capitan"
        dgvLista.Columns(0).HeaderText = "Codigo del Equipo"
        dgvLista.Columns(0).HeaderText = "Telefono"
        dgvLista.Columns(0).HeaderText = "Numero de Camiseta"
    End Sub

    Private Sub btnCodigo_Click(sender As Object, e As EventArgs) Handles btnCodigo.Click
        searchByCode()
    End Sub

    Private Sub btnCodigoEquipo_Click(sender As Object, e As EventArgs) Handles btnCodigoEquipo.Click
        searchByCodeEquipo()
    End Sub
End Class