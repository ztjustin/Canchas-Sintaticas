<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipoAdmin
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
        Me.mtbCodCampeo1 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCantJuga1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtbCodCampeo2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCodEquipo2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.mtbCantJuga2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtbCodigoEquipo3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.mtbCodCampeo1)
        Me.GroupBox1.Controls.Add(Me.mtbCantJuga1)
        Me.GroupBox1.Controls.Add(Me.txtNombre1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Equipo"
        '
        'mtbCodCampeo1
        '
        Me.mtbCodCampeo1.Location = New System.Drawing.Point(163, 36)
        Me.mtbCodCampeo1.Mask = "999999999"
        Me.mtbCodCampeo1.Name = "mtbCodCampeo1"
        Me.mtbCodCampeo1.Size = New System.Drawing.Size(77, 20)
        Me.mtbCodCampeo1.TabIndex = 6
        '
        'mtbCantJuga1
        '
        Me.mtbCantJuga1.Location = New System.Drawing.Point(163, 60)
        Me.mtbCantJuga1.Mask = "99"
        Me.mtbCantJuga1.Name = "mtbCantJuga1"
        Me.mtbCantJuga1.Size = New System.Drawing.Size(21, 20)
        Me.mtbCantJuga1.TabIndex = 5
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(163, 92)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad de Jugadores:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del Equipo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Campenato :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtbCodCampeo2)
        Me.GroupBox2.Controls.Add(Me.mtbCodEquipo2)
        Me.GroupBox2.Controls.Add(Me.txtNombre2)
        Me.GroupBox2.Controls.Add(Me.mtbCantJuga2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 163)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actualizar Equipo"
        '
        'mtbCodCampeo2
        '
        Me.mtbCodCampeo2.Location = New System.Drawing.Point(153, 62)
        Me.mtbCodCampeo2.Mask = "999999999"
        Me.mtbCodCampeo2.Name = "mtbCodCampeo2"
        Me.mtbCodCampeo2.Size = New System.Drawing.Size(66, 20)
        Me.mtbCodCampeo2.TabIndex = 7
        '
        'mtbCodEquipo2
        '
        Me.mtbCodEquipo2.Location = New System.Drawing.Point(153, 33)
        Me.mtbCodEquipo2.Mask = "99999999"
        Me.mtbCodEquipo2.Name = "mtbCodEquipo2"
        Me.mtbCodEquipo2.Size = New System.Drawing.Size(66, 20)
        Me.mtbCodEquipo2.TabIndex = 7
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(153, 116)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre2.TabIndex = 6
        '
        'mtbCantJuga2
        '
        Me.mtbCantJuga2.Location = New System.Drawing.Point(154, 88)
        Me.mtbCantJuga2.Mask = "99"
        Me.mtbCantJuga2.Name = "mtbCantJuga2"
        Me.mtbCantJuga2.Size = New System.Drawing.Size(21, 20)
        Me.mtbCantJuga2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cantidad de Jugadores:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo de Equipo :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nombre del Equipo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Codigo de Campenato :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtbCodigoEquipo3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 64)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Eliminar Equipo"
        '
        'mtbCodigoEquipo3
        '
        Me.mtbCodigoEquipo3.Location = New System.Drawing.Point(163, 22)
        Me.mtbCodigoEquipo3.Mask = "99999999"
        Me.mtbCodigoEquipo3.Name = "mtbCodigoEquipo3"
        Me.mtbCodigoEquipo3.Size = New System.Drawing.Size(66, 20)
        Me.mtbCodigoEquipo3.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Codigo de Equipo :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(226, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(522, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmEquipoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 301)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEquipoAdmin"
        Me.Text = "Administracion de Equipo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mtbCodCampeo1 As MaskedTextBox
    Friend WithEvents mtbCantJuga1 As MaskedTextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents mtbCodEquipo2 As MaskedTextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents mtbCantJuga2 As MaskedTextBox
    Friend WithEvents mtbCodigoEquipo3 As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mtbCodCampeo2 As MaskedTextBox
End Class
