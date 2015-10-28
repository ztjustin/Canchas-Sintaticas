Imports System.Data.SqlClient
Public Class SistemaMain
    Private Sub setHour()
        ToolStripStatusLabel1.Text = DateTime.Now
    End Sub

    Private Sub SistemaMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setHour()
    End Sub
    Public Sub searchByCode()

        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select Cod_Campeonato,Cod_Instalacion,Nombre_Campeonato,Fecha_Inicio,Fecha_Final,Premio from Campeonato where Cod_Campeonato ='" + txtCodigo.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)
            dgvListaCampeonatos.DataSource = ds.Tables(0)
            llenarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Hubo un problema con la busqueda por favor intente mas tarde")
        Finally
            desconectar()
        End Try
    End Sub
    Public Sub searchByName()

        Try
            conectar()
            Dim ds As New DataSet
            Dim query As String = "Select Cod_Campeonato,Cod_Instalacion,Nombre_Campeonato,Fecha_Inicio,Fecha_Final,Premio from Campeonato where Nombre_Campeonato ='" + txtNombre.Text + "'"
            Dim da As New SqlDataAdapter(query, Conexion)
            da.Fill(ds)
            dgvListaCampeonatos.DataSource = ds.Tables(0)
            llenarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Hubo un problema con la busqueda por favor intente mas tarde")
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub btnBuscarCodigo_Click(sender As Object, e As EventArgs) Handles btnBuscarCodigo.Click
        searchByCode()
    End Sub
    Private Sub llenarDataGridView()

        dgvListaCampeonatos.Columns(0).HeaderText = "Codigo Campeonato"
        dgvListaCampeonatos.Columns(1).HeaderText = "Codigo Instalacion Deportiva"
        dgvListaCampeonatos.Columns(2).HeaderText = "Nombre del Campeonato"
        dgvListaCampeonatos.Columns(3).HeaderText = "Fecha Inicial"
        dgvListaCampeonatos.Columns(4).HeaderText = "Fecha Final"
        dgvListaCampeonatos.Columns(5).HeaderText = "Premio"

    End Sub

    Private Sub btnBuscarNombre_Click(sender As Object, e As EventArgs) Handles btnBuscarNombre.Click
        searchByName()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PartidoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PartidoToolStripMenuItem1.Click
        frmPartido.Visible = True
    End Sub

    Private Sub AlbitroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlbitroToolStripMenuItem.Click
        frmAlbitro.Visible = True

    End Sub

    Private Sub CanchaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanchaToolStripMenuItem.Click
        frmCancha.Visible = True
    End Sub

    Private Sub CapitanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapitanToolStripMenuItem.Click
        frmCapitan.Visible = True
    End Sub

    Private Sub EuipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EuipoToolStripMenuItem.Click
        frmEquipo.Visible = True
    End Sub

    Private Sub PartidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartidoToolStripMenuItem.Click
        frmPartidoAdmin.Visible = True
    End Sub

    Private Sub CanchaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CanchaToolStripMenuItem1.Click
        frmCanchaAdmin.Visible = True
    End Sub

    Private Sub InstalacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstalacionToolStripMenuItem.Click
        frmInstalacionAdmin.Visible = True
    End Sub

    Private Sub EquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipoToolStripMenuItem.Click
        frmEquipoAdmin.Visible = True
    End Sub

    Private Sub AlbitroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlbitroToolStripMenuItem1.Click
        frmAlbitroAdmin.Visible = True
    End Sub

    Private Sub CampeonatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CampeonatoToolStripMenuItem.Click
        frmCampeonatoAdmin.Visible = True
    End Sub

    Private Sub CapitanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CapitanToolStripMenuItem1.Click
        frmCapitanAdmin.Visible = True
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuarioAdmin.Visible = True
    End Sub

    Private Sub CampeonatoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CampeonatoToolStripMenuItem1.Click

    End Sub

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        frmPasswordChange.Visible = True
    End Sub
End Class