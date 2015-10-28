Imports System.Data.SqlClient
Public Class frmEquipo

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        SistemaMain.Visible = True
    End Sub
    Private Sub searchByCode()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select Cod_Equipo,Cod_Campeonato,Cant_Jugadores,Nombre_Equipo  from Equipo where Cod_Equipo ='" + txtCodigo.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            dgvLista.DataSource = ds.Tables(0)

            dgvLista.Columns(0).HeaderText = "Codigo del Equipo"
            dgvLista.Columns(1).HeaderText = "Codigo del Campeonato"
            dgvLista.Columns(2).HeaderText = "Cantidad de Jugadores"
            dgvLista.Columns(3).HeaderText = "Nombre del Equipo"

        Catch ex As Exception
            MessageBox.Show("Hubo un error", "Error")
        Finally
            desconectar()
        End Try
    End Sub
    Private Sub searchByCodeCampeonato()
        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select Cod_Equipo,Cod_Campeonato,Cant_Jugadores,Nombre_Equipo  from Equipo where Cod_Campeonato ='" + txtCodigoInsta.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)

            dgvLista.DataSource = ds.Tables(0)

            dgvLista.Columns(0).HeaderText = "Codigo del Equipo"
            dgvLista.Columns(1).HeaderText = "Codigo del Campeonato"
            dgvLista.Columns(2).HeaderText = "Cantidad de Jugadores"
            dgvLista.Columns(3).HeaderText = "Nombre del Equipo"

        Catch ex As Exception
            MessageBox.Show("Hubo un error", "Error")
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub btnBuscarCodigo_Click(sender As Object, e As EventArgs) Handles btnBuscarCodigo.Click
        searchByCode()
    End Sub

    Private Sub btnBuscarInsta_Click(sender As Object, e As EventArgs) Handles btnBuscarInsta.Click
        searchByCodeCampeonato()
    End Sub
End Class