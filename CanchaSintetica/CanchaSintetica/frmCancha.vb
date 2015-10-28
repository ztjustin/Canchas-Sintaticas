Imports System.Data.SqlClient
Public Class frmCancha
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        SistemaMain.Visible = True
        Me.Visible = False
    End Sub
    Private Sub searchByCode()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select Cod_Cancha,Cod_Instalacion,Tipo_Malla,Metros_Cuadrados from Cancha where Cod_Cancha='" + txtCodigoCancha.Text + "'"
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
        dgvLista.Columns(0).HeaderText = "Codigo de Cancha"
        dgvLista.Columns(1).HeaderText = "Codigo de Instalacion"
        dgvLista.Columns(2).HeaderText = "Tipo de Malla"
        dgvLista.Columns(3).HeaderText = "Metros Cuadrados"
    End Sub


    Private Sub btnBuscarByCode_Click(sender As Object, e As EventArgs) Handles btnBuscarByCode.Click
        searchByCode()
    End Sub
    Private Sub searchByCodeInstalation()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select Cod_Cancha,Cod_Instalacion,Tipo_Malla,Metros_Cuadrados from Cancha where Cod_Instalacion='" + txtCodigoInstalacion.Text + "'"
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

    Private Sub btnBuscarByInstalacion_Click(sender As Object, e As EventArgs) Handles btnBuscarByInstalacion.Click
        searchByCodeInstalation()
    End Sub
End Class