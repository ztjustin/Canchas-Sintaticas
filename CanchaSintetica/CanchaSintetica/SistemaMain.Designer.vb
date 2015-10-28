<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SistemaMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanchaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstalacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlbitroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CampeonatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapitanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlbitroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanchaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapitanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EuipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CampeonatoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstalacionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListaCampeonatos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnBuscarCodigo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscarNombre = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListaCampeonatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 288)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(939, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusLabel1.Text = "Hora"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(262, 17)
        Me.ToolStripStatusLabel2.Text = "Sistema de Control de Campeonatos de Futbol 5"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AdministracionToolStripMenuItem, Me.BusquedasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(939, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SToolStripMenuItem.Text = "Cambiar Password"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartidoToolStripMenuItem, Me.CanchaToolStripMenuItem1, Me.InstalacionToolStripMenuItem, Me.EquipoToolStripMenuItem, Me.AlbitroToolStripMenuItem1, Me.CampeonatoToolStripMenuItem, Me.CapitanToolStripMenuItem1, Me.UsuariosToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'PartidoToolStripMenuItem
        '
        Me.PartidoToolStripMenuItem.Name = "PartidoToolStripMenuItem"
        Me.PartidoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PartidoToolStripMenuItem.Text = "Partido"
        '
        'CanchaToolStripMenuItem1
        '
        Me.CanchaToolStripMenuItem1.Name = "CanchaToolStripMenuItem1"
        Me.CanchaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CanchaToolStripMenuItem1.Text = "Cancha"
        '
        'InstalacionToolStripMenuItem
        '
        Me.InstalacionToolStripMenuItem.Name = "InstalacionToolStripMenuItem"
        Me.InstalacionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InstalacionToolStripMenuItem.Text = "Instalacion"
        '
        'EquipoToolStripMenuItem
        '
        Me.EquipoToolStripMenuItem.Name = "EquipoToolStripMenuItem"
        Me.EquipoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EquipoToolStripMenuItem.Text = "Equipo"
        '
        'AlbitroToolStripMenuItem1
        '
        Me.AlbitroToolStripMenuItem1.Name = "AlbitroToolStripMenuItem1"
        Me.AlbitroToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AlbitroToolStripMenuItem1.Text = "Albitro"
        '
        'CampeonatoToolStripMenuItem
        '
        Me.CampeonatoToolStripMenuItem.Name = "CampeonatoToolStripMenuItem"
        Me.CampeonatoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CampeonatoToolStripMenuItem.Text = "Campeonato"
        '
        'CapitanToolStripMenuItem1
        '
        Me.CapitanToolStripMenuItem1.Name = "CapitanToolStripMenuItem1"
        Me.CapitanToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CapitanToolStripMenuItem1.Text = "Capitan"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'BusquedasToolStripMenuItem
        '
        Me.BusquedasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartidoToolStripMenuItem1, Me.AlbitroToolStripMenuItem, Me.CanchaToolStripMenuItem, Me.CapitanToolStripMenuItem, Me.EuipoToolStripMenuItem, Me.CampeonatoToolStripMenuItem1, Me.UsuarioToolStripMenuItem, Me.InstalacionToolStripMenuItem1})
        Me.BusquedasToolStripMenuItem.Name = "BusquedasToolStripMenuItem"
        Me.BusquedasToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.BusquedasToolStripMenuItem.Text = "Busquedas"
        '
        'PartidoToolStripMenuItem1
        '
        Me.PartidoToolStripMenuItem1.Name = "PartidoToolStripMenuItem1"
        Me.PartidoToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.PartidoToolStripMenuItem1.Text = "Partido"
        '
        'AlbitroToolStripMenuItem
        '
        Me.AlbitroToolStripMenuItem.Name = "AlbitroToolStripMenuItem"
        Me.AlbitroToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AlbitroToolStripMenuItem.Text = "Albitro"
        '
        'CanchaToolStripMenuItem
        '
        Me.CanchaToolStripMenuItem.Name = "CanchaToolStripMenuItem"
        Me.CanchaToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CanchaToolStripMenuItem.Text = "Cancha"
        '
        'CapitanToolStripMenuItem
        '
        Me.CapitanToolStripMenuItem.Name = "CapitanToolStripMenuItem"
        Me.CapitanToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CapitanToolStripMenuItem.Text = "Capitan"
        '
        'EuipoToolStripMenuItem
        '
        Me.EuipoToolStripMenuItem.Name = "EuipoToolStripMenuItem"
        Me.EuipoToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EuipoToolStripMenuItem.Text = "Equipo"
        '
        'CampeonatoToolStripMenuItem1
        '
        Me.CampeonatoToolStripMenuItem1.Name = "CampeonatoToolStripMenuItem1"
        Me.CampeonatoToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.CampeonatoToolStripMenuItem1.Text = "Campeonato"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'InstalacionToolStripMenuItem1
        '
        Me.InstalacionToolStripMenuItem1.Name = "InstalacionToolStripMenuItem1"
        Me.InstalacionToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.InstalacionToolStripMenuItem1.Text = "Instalacion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvListaCampeonatos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 213)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Campeonatos"
        '
        'dgvListaCampeonatos
        '
        Me.dgvListaCampeonatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCampeonatos.Location = New System.Drawing.Point(6, 19)
        Me.dgvListaCampeonatos.Name = "dgvListaCampeonatos"
        Me.dgvListaCampeonatos.Size = New System.Drawing.Size(579, 180)
        Me.dgvListaCampeonatos.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(609, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 73)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda por Codigo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(103, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(158, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'btnBuscarCodigo
        '
        Me.btnBuscarCodigo.Location = New System.Drawing.Point(852, 115)
        Me.btnBuscarCodigo.Name = "btnBuscarCodigo"
        Me.btnBuscarCodigo.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCodigo.TabIndex = 4
        Me.btnBuscarCodigo.Text = "Buscar"
        Me.btnBuscarCodigo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Location = New System.Drawing.Point(609, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 73)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Busqueda por Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(158, 20)
        Me.txtNombre.TabIndex = 0
        '
        'btnBuscarNombre
        '
        Me.btnBuscarNombre.Location = New System.Drawing.Point(852, 226)
        Me.btnBuscarNombre.Name = "btnBuscarNombre"
        Me.btnBuscarNombre.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarNombre.TabIndex = 6
        Me.btnBuscarNombre.Text = "Buscar"
        Me.btnBuscarNombre.UseVisualStyleBackColor = True
        '
        'SistemaMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 310)
        Me.Controls.Add(Me.btnBuscarNombre)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnBuscarCodigo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SistemaMain"
        Me.Text = "General"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListaCampeonatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CanchaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InstalacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquipoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartidoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AlbitroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CanchaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CapitanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EuipoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlbitroToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListaCampeonatos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnBuscarCodigo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnBuscarNombre As Button
    Friend WithEvents CampeonatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CapitanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CampeonatoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstalacionToolStripMenuItem1 As ToolStripMenuItem
End Class
