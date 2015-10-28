<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartidoAdmin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtbHora = New System.Windows.Forms.MaskedTextBox()
        Me.txtTeam2 = New System.Windows.Forms.TextBox()
        Me.txtTeam1 = New System.Windows.Forms.TextBox()
        Me.mtbCodigoCancha1 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCodAlbitro1 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCodCamp1 = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtbCodPartido3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtbCodgoPartido2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mtbHora2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTeam22 = New System.Windows.Forms.TextBox()
        Me.txtTeam12 = New System.Windows.Forms.TextBox()
        Me.mtbCodCancha2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCodAlbitro2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCodCampeo2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtbHora)
        Me.GroupBox1.Controls.Add(Me.txtTeam2)
        Me.GroupBox1.Controls.Add(Me.txtTeam1)
        Me.GroupBox1.Controls.Add(Me.mtbCodigoCancha1)
        Me.GroupBox1.Controls.Add(Me.mtbCodAlbitro1)
        Me.GroupBox1.Controls.Add(Me.mtbCodCamp1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Partido"
        '
        'mtbHora
        '
        Me.mtbHora.Location = New System.Drawing.Point(149, 172)
        Me.mtbHora.Mask = "00:00"
        Me.mtbHora.Name = "mtbHora"
        Me.mtbHora.Size = New System.Drawing.Size(38, 20)
        Me.mtbHora.TabIndex = 13
        Me.mtbHora.ValidatingType = GetType(Date)
        '
        'txtTeam2
        '
        Me.txtTeam2.Location = New System.Drawing.Point(149, 140)
        Me.txtTeam2.Name = "txtTeam2"
        Me.txtTeam2.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam2.TabIndex = 12
        '
        'txtTeam1
        '
        Me.txtTeam1.Location = New System.Drawing.Point(149, 115)
        Me.txtTeam1.Name = "txtTeam1"
        Me.txtTeam1.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam1.TabIndex = 11
        '
        'mtbCodigoCancha1
        '
        Me.mtbCodigoCancha1.Location = New System.Drawing.Point(149, 88)
        Me.mtbCodigoCancha1.Mask = "9999999"
        Me.mtbCodigoCancha1.Name = "mtbCodigoCancha1"
        Me.mtbCodigoCancha1.Size = New System.Drawing.Size(51, 20)
        Me.mtbCodigoCancha1.TabIndex = 10
        '
        'mtbCodAlbitro1
        '
        Me.mtbCodAlbitro1.Location = New System.Drawing.Point(149, 62)
        Me.mtbCodAlbitro1.Mask = "9999999"
        Me.mtbCodAlbitro1.Name = "mtbCodAlbitro1"
        Me.mtbCodAlbitro1.Size = New System.Drawing.Size(51, 20)
        Me.mtbCodAlbitro1.TabIndex = 9
        '
        'mtbCodCamp1
        '
        Me.mtbCodCamp1.Location = New System.Drawing.Point(149, 36)
        Me.mtbCodCamp1.Mask = "9999999"
        Me.mtbCodCamp1.Name = "mtbCodCamp1"
        Me.mtbCodCamp1.Size = New System.Drawing.Size(51, 20)
        Me.mtbCodCamp1.TabIndex = 8
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(149, 10)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(141, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(104, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hora :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Equipo 2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Equipo  1 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cod_Campeonato :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Codigo de Albitro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo de Cancha :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtbCodPartido3)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 98)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eliminar Partido"
        '
        'mtbCodPartido3
        '
        Me.mtbCodPartido3.Location = New System.Drawing.Point(202, 51)
        Me.mtbCodPartido3.Mask = "9999999"
        Me.mtbCodPartido3.Name = "mtbCodPartido3"
        Me.mtbCodPartido3.Size = New System.Drawing.Size(51, 20)
        Me.mtbCodPartido3.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(98, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Codigo del Partido :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtbCodgoPartido2)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.mtbHora2)
        Me.GroupBox3.Controls.Add(Me.txtTeam22)
        Me.GroupBox3.Controls.Add(Me.txtTeam12)
        Me.GroupBox3.Controls.Add(Me.mtbCodCancha2)
        Me.GroupBox3.Controls.Add(Me.mtbCodAlbitro2)
        Me.GroupBox3.Controls.Add(Me.mtbCodCampeo2)
        Me.GroupBox3.Controls.Add(Me.mtbFecha2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(379, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 266)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Actualizar Partido"
        '
        'mtbCodgoPartido2
        '
        Me.mtbCodgoPartido2.Location = New System.Drawing.Point(159, 33)
        Me.mtbCodgoPartido2.Mask = "9999999"
        Me.mtbCodgoPartido2.Name = "mtbCodgoPartido2"
        Me.mtbCodgoPartido2.Size = New System.Drawing.Size(51, 20)
        Me.mtbCodgoPartido2.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(55, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Codigo del Partido :"
        '
        'mtbHora2
        '
        Me.mtbHora2.Location = New System.Drawing.Point(159, 221)
        Me.mtbHora2.Mask = "00:00"
        Me.mtbHora2.Name = "mtbHora2"
        Me.mtbHora2.Size = New System.Drawing.Size(38, 20)
        Me.mtbHora2.TabIndex = 27
        Me.mtbHora2.ValidatingType = GetType(Date)
        '
        'txtTeam22
        '
        Me.txtTeam22.Location = New System.Drawing.Point(159, 189)
        Me.txtTeam22.Name = "txtTeam22"
        Me.txtTeam22.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam22.TabIndex = 26
        '
        'txtTeam12
        '
        Me.txtTeam12.Location = New System.Drawing.Point(159, 164)
        Me.txtTeam12.Name = "txtTeam12"
        Me.txtTeam12.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam12.TabIndex = 25
        '
        'mtbCodCancha2
        '
        Me.mtbCodCancha2.Location = New System.Drawing.Point(159, 137)
        Me.mtbCodCancha2.Mask = "9999999"
        Me.mtbCodCancha2.Name = "mtbCodCancha2"
        Me.mtbCodCancha2.Size = New System.Drawing.Size(51, 20)
        Me.mtbCodCancha2.TabIndex = 24
        '
        'mtbCodAlbitro2
        '
        Me.mtbCodAlbitro2.Location = New System.Drawing.Point(159, 111)
        Me.mtbCodAlbitro2.Mask = "9999999"
        Me.mtbCodAlbitro2.Name = "mtbCodAlbitro2"
        Me.mtbCodAlbitro2.Size = New System.Drawing.Size(51, 20)
        Me.mtbCodAlbitro2.TabIndex = 23
        '
        'mtbCodCampeo2
        '
        Me.mtbCodCampeo2.Location = New System.Drawing.Point(159, 85)
        Me.mtbCodCampeo2.Mask = "9999999"
        Me.mtbCodCampeo2.Name = "mtbCodCampeo2"
        Me.mtbCodCampeo2.Size = New System.Drawing.Size(51, 20)
        Me.mtbCodCampeo2.TabIndex = 22
        '
        'mtbFecha2
        '
        Me.mtbFecha2.Location = New System.Drawing.Point(159, 59)
        Me.mtbFecha2.Name = "mtbFecha2"
        Me.mtbFecha2.Size = New System.Drawing.Size(141, 20)
        Me.mtbFecha2.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(114, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Hora :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(95, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Equipo 2 :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(92, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Equipo  1 :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Cod_Campeonato :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Codigo de Albitro:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Codigo de Cancha :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(110, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Fecha :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(658, 284)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmPartidoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 388)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPartidoAdmin"
        Me.Text = "Administracion de Patidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents mtbHora As MaskedTextBox
    Friend WithEvents txtTeam2 As TextBox
    Friend WithEvents txtTeam1 As TextBox
    Friend WithEvents mtbCodigoCancha1 As MaskedTextBox
    Friend WithEvents mtbCodAlbitro1 As MaskedTextBox
    Friend WithEvents mtbCodCamp1 As MaskedTextBox
    Friend WithEvents mtbCodgoPartido2 As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents mtbHora2 As MaskedTextBox
    Friend WithEvents txtTeam22 As TextBox
    Friend WithEvents txtTeam12 As TextBox
    Friend WithEvents mtbCodCancha2 As MaskedTextBox
    Friend WithEvents mtbCodAlbitro2 As MaskedTextBox
    Friend WithEvents mtbCodCampeo2 As MaskedTextBox
    Friend WithEvents mtbFecha2 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents mtbCodPartido3 As MaskedTextBox
    Friend WithEvents Label16 As Label
End Class
