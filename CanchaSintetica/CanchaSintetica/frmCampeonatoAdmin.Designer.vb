<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampeonatoAdmin
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtbCodInsta = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPremioCamp = New System.Windows.Forms.TextBox()
        Me.txtPremio = New System.Windows.Forms.Label()
        Me.txtPremioCamp2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio2 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.mtbCodInsta2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCodCamp2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCod3 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(334, 423)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtbCod3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 100)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Elimar Campeonato"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(93, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Codigo de Camponato:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(606, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtbCodCamp2)
        Me.GroupBox2.Controls.Add(Me.mtbCodInsta2)
        Me.GroupBox2.Controls.Add(Me.txtNombre2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtPremioCamp2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFinal2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicio2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 268)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actualizar Camepeonato"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(256, 286)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtPremioCamp)
        Me.GroupBox1.Controls.Add(Me.txtPremio)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.mtbCodInsta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 268)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Campeonato"
        '
        'mtbCodInsta
        '
        Me.mtbCodInsta.Location = New System.Drawing.Point(147, 35)
        Me.mtbCodInsta.Mask = "999999"
        Me.mtbCodInsta.Name = "mtbCodInsta"
        Me.mtbCodInsta.Size = New System.Drawing.Size(48, 20)
        Me.mtbCodInsta.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del Campeonato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod_Instalacion :"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(147, 94)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(141, 20)
        Me.dtpFechaInicio.TabIndex = 14
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Location = New System.Drawing.Point(147, 130)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(141, 20)
        Me.dtpFechaFinal.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Fecha de Final:"
        '
        'txtPremioCamp
        '
        Me.txtPremioCamp.Location = New System.Drawing.Point(147, 168)
        Me.txtPremioCamp.Name = "txtPremioCamp"
        Me.txtPremioCamp.Size = New System.Drawing.Size(120, 20)
        Me.txtPremioCamp.TabIndex = 18
        '
        'txtPremio
        '
        Me.txtPremio.AutoSize = True
        Me.txtPremio.Location = New System.Drawing.Point(93, 171)
        Me.txtPremio.Name = "txtPremio"
        Me.txtPremio.Size = New System.Drawing.Size(45, 13)
        Me.txtPremio.TabIndex = 17
        Me.txtPremio.Text = "Premio :"
        '
        'txtPremioCamp2
        '
        Me.txtPremioCamp2.Location = New System.Drawing.Point(155, 194)
        Me.txtPremioCamp2.Name = "txtPremioCamp2"
        Me.txtPremioCamp2.Size = New System.Drawing.Size(120, 20)
        Me.txtPremioCamp2.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Premio :"
        '
        'dtpFechaFinal2
        '
        Me.dtpFechaFinal2.Location = New System.Drawing.Point(155, 156)
        Me.dtpFechaFinal2.Name = "dtpFechaFinal2"
        Me.dtpFechaFinal2.Size = New System.Drawing.Size(141, 20)
        Me.dtpFechaFinal2.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Fecha de Final:"
        '
        'dtpFechaInicio2
        '
        Me.dtpFechaInicio2.Location = New System.Drawing.Point(155, 120)
        Me.dtpFechaInicio2.Name = "dtpFechaInicio2"
        Me.dtpFechaInicio2.Size = New System.Drawing.Size(141, 20)
        Me.dtpFechaInicio2.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Fecha de Inicio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nombre del Campeonato:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(60, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Cod_Instalacion :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Codigo de Campeonato:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(147, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(120, 20)
        Me.txtNombre.TabIndex = 19
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(155, 87)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(120, 20)
        Me.txtNombre2.TabIndex = 33
        '
        'mtbCodInsta2
        '
        Me.mtbCodInsta2.Location = New System.Drawing.Point(155, 57)
        Me.mtbCodInsta2.Mask = "999999"
        Me.mtbCodInsta2.Name = "mtbCodInsta2"
        Me.mtbCodInsta2.Size = New System.Drawing.Size(48, 20)
        Me.mtbCodInsta2.TabIndex = 34
        '
        'mtbCodCamp2
        '
        Me.mtbCodCamp2.Location = New System.Drawing.Point(155, 29)
        Me.mtbCodCamp2.Mask = "999999"
        Me.mtbCodCamp2.Name = "mtbCodCamp2"
        Me.mtbCodCamp2.Size = New System.Drawing.Size(48, 20)
        Me.mtbCodCamp2.TabIndex = 35
        '
        'mtbCod3
        '
        Me.mtbCod3.Location = New System.Drawing.Point(219, 40)
        Me.mtbCod3.Mask = "999999"
        Me.mtbCod3.Name = "mtbCod3"
        Me.mtbCod3.Size = New System.Drawing.Size(48, 20)
        Me.mtbCod3.TabIndex = 17
        '
        'frmCampeonatoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 458)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCampeonatoAdmin"
        Me.Text = "Administracion de Campeonato"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mtbCodInsta As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPremioCamp As TextBox
    Friend WithEvents txtPremio As Label
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPremioCamp2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaFinal2 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFechaInicio2 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents mtbCodCamp2 As MaskedTextBox
    Friend WithEvents mtbCodInsta2 As MaskedTextBox
    Friend WithEvents mtbCod3 As MaskedTextBox
End Class
