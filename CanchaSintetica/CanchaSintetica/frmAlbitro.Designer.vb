<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlbitro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscarByInstalacion = New System.Windows.Forms.Button()
        Me.btnBuscarByCode = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCodigoInstalacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigoCancha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(774, 258)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscarByInstalacion
        '
        Me.btnBuscarByInstalacion.Location = New System.Drawing.Point(267, 258)
        Me.btnBuscarByInstalacion.Name = "btnBuscarByInstalacion"
        Me.btnBuscarByInstalacion.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarByInstalacion.TabIndex = 9
        Me.btnBuscarByInstalacion.Text = "Buscar"
        Me.btnBuscarByInstalacion.UseVisualStyleBackColor = True
        '
        'btnBuscarByCode
        '
        Me.btnBuscarByCode.Location = New System.Drawing.Point(267, 118)
        Me.btnBuscarByCode.Name = "btnBuscarByCode"
        Me.btnBuscarByCode.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarByCode.TabIndex = 8
        Me.btnBuscarByCode.Text = "Buscar"
        Me.btnBuscarByCode.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvLista)
        Me.GroupBox3.Location = New System.Drawing.Point(362, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(493, 240)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Albitros"
        '
        'dgvLista
        '
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Location = New System.Drawing.Point(15, 19)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(472, 215)
        Me.dgvLista.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCodigoInstalacion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 103)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda por Instalacion Deortiva"
        '
        'txtCodigoInstalacion
        '
        Me.txtCodigoInstalacion.Location = New System.Drawing.Point(168, 49)
        Me.txtCodigoInstalacion.Name = "txtCodigoInstalacion"
        Me.txtCodigoInstalacion.Size = New System.Drawing.Size(134, 20)
        Me.txtCodigoInstalacion.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo Instalacion Deportiva:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigoCancha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda por Codigo de Albitro"
        '
        'txtCodigoCancha
        '
        Me.txtCodigoCancha.Location = New System.Drawing.Point(168, 47)
        Me.txtCodigoCancha.Name = "txtCodigoCancha"
        Me.txtCodigoCancha.Size = New System.Drawing.Size(134, 20)
        Me.txtCodigoCancha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'frmAlbitro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 292)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscarByInstalacion)
        Me.Controls.Add(Me.btnBuscarByCode)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAlbitro"
        Me.Text = "Busqueda de Albitro"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBuscarByInstalacion As Button
    Friend WithEvents btnBuscarByCode As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCodigoInstalacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCodigoCancha As TextBox
    Friend WithEvents Label1 As Label
End Class
