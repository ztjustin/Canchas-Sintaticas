Imports System.Data.SqlClient
Public Class frmPartido
    Private Sub SearchByCode()
        Try
            conectar()
            Dim query As String = "Select Cod_Partido,Cod_Campeonato,Cod_Albitro,Fecha,Equipo_1,Equipo_2,Hora from Partido where Cod_Partido ='" + txtCodigo.Text + "'"
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            dgvLista.DataSource = ds.Tables(0)
            fillDataGrid()
        Catch ex As Exception
            MessageBox.Show("Hubo un error en la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub btnBuscarCodigo_Click(sender As Object, e As EventArgs) Handles btnBuscarCodigo.Click
        SearchByCode()
    End Sub
    Private Sub SearchByName()
        Try
            conectar()
            Dim query As String = "Select Cod_Partido,Cod_Campeonato,Cod_Albitro,Fecha,Equipo_1,Equipo_2,Hora from Partido where Fecha ='" + dtpFecha.Value + "'"
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            dgvLista.DataSource = ds.Tables(0)
            fillDataGrid()
        Catch ex As Exception
            MessageBox.Show("Hubo un error en la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
    Private Sub fillDataGrid()
        dgvLista.Columns(0).HeaderText = "Codigo Partido"
        dgvLista.Columns(1).HeaderText = "Codigo Campeonato"
        dgvLista.Columns(2).HeaderText = "Codigo Albitro"
        dgvLista.Columns(3).HeaderText = "Fecha"
        dgvLista.Columns(4).HeaderText = "Primer Equipo"
        dgvLista.Columns(5).HeaderText = "Segundo Equipo"
        dgvLista.Columns(6).HeaderText = "Hora"

    End Sub

    Private Sub btnBuscarFecha_Click(sender As Object, e As EventArgs) Handles btnBuscarFecha.Click
        SearchByName()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        SistemaMain.Visible = True
        Me.Visible = False
    End Sub

End Class