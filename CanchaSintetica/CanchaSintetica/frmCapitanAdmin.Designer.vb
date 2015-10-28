<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapitanAdmin
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
        Me.mtbCodigoEquipo1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCorreo1 = New System.Windows.Forms.TextBox()
        Me.mtbTel1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumeroCamiseta1 = New System.Windows.Forms.TextBox()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtbCodCap2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mtbCodEquipo2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCorreo2 = New System.Windows.Forms.TextBox()
        Me.mtbTel2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCamiseta2 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtbCodCapitan3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.mtbCodigoEquipo1)
        Me.GroupBox1.Controls.Add(Me.txtCorreo1)
        Me.GroupBox1.Controls.Add(Me.mtbTel1)
        Me.GroupBox1.Controls.Add(Me.txtNumeroCamiseta1)
        Me.GroupBox1.Controls.Add(Me.txtNombre1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Capitan"
        '
        'mtbCodigoEquipo1
        '
        Me.mtbCodigoEquipo1.Location = New System.Drawing.Point(198, 36)
        Me.mtbCodigoEquipo1.Mask = "99999999"
        Me.mtbCodigoEquipo1.Name = "mtbCodigoEquipo1"
        Me.mtbCodigoEquipo1.Size = New System.Drawing.Size(59, 20)
        Me.mtbCodigoEquipo1.TabIndex = 9
        '
        'txtCorreo1
        '
        Me.txtCorreo1.Location = New System.Drawing.Point(198, 169)
        Me.txtCorreo1.Name = "txtCorreo1"
        Me.txtCorreo1.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreo1.TabIndex = 8
        '
        'mtbTel1
        '
        Me.mtbTel1.Location = New System.Drawing.Point(198, 138)
        Me.mtbTel1.Mask = "99999999"
        Me.mtbTel1.Name = "mtbTel1"
        Me.mtbTel1.Size = New System.Drawing.Size(59, 20)
        Me.mtbTel1.TabIndex = 7
        '
        'txtNumeroCamiseta1
        '
        Me.txtNumeroCamiseta1.Location = New System.Drawing.Point(198, 104)
        Me.txtNumeroCamiseta1.Name = "txtNumeroCamiseta1"
        Me.txtNumeroCamiseta1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroCamiseta1.TabIndex = 6
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(198, 70)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero de Camiseta :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Equipo :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtbCodCap2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.mtbCodEquipo2)
        Me.GroupBox2.Controls.Add(Me.txtCorreo2)
        Me.GroupBox2.Controls.Add(Me.mtbTel2)
        Me.GroupBox2.Controls.Add(Me.txtCamiseta2)
        Me.GroupBox2.Controls.Add(Me.txtNombre2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(414, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 225)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actualizar Capitan"
        '
        'mtbCodCap2
        '
        Me.mtbCodCap2.Location = New System.Drawing.Point(202, 19)
        Me.mtbCodCap2.Mask = "99999999"
        Me.mtbCodCap2.Name = "mtbCodCap2"
        Me.mtbCodCap2.Size = New System.Drawing.Size(59, 20)
        Me.mtbCodCap2.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Codigo de Capitan  :"
        '
        'mtbCodEquipo2
        '
        Me.mtbCodEquipo2.Location = New System.Drawing.Point(202, 45)
        Me.mtbCodEquipo2.Mask = "99999999"
        Me.mtbCodEquipo2.Name = "mtbCodEquipo2"
        Me.mtbCodEquipo2.Size = New System.Drawing.Size(59, 20)
        Me.mtbCodEquipo2.TabIndex = 19
        '
        'txtCorreo2
        '
        Me.txtCorreo2.Location = New System.Drawing.Point(202, 178)
        Me.txtCorreo2.Name = "txtCorreo2"
        Me.txtCorreo2.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreo2.TabIndex = 18
        '
        'mtbTel2
        '
        Me.mtbTel2.Location = New System.Drawing.Point(202, 147)
        Me.mtbTel2.Mask = "99999999"
        Me.mtbTel2.Name = "mtbTel2"
        Me.mtbTel2.Size = New System.Drawing.Size(59, 20)
        Me.mtbTel2.TabIndex = 17
        '
        'txtCamiseta2
        '
        Me.txtCamiseta2.Location = New System.Drawing.Point(202, 113)
        Me.txtCamiseta2.Name = "txtCamiseta2"
        Me.txtCamiseta2.Size = New System.Drawing.Size(100, 20)
        Me.txtCamiseta2.TabIndex = 16
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(202, 79)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(152, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Correo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(141, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Telefono :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Numero de Camiseta :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(146, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nombre :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(99, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Codigo de Equipo :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtbCodCapitan3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(390, 112)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Eliminar Capitan"
        '
        'mtbCodCapitan3
        '
        Me.mtbCodCapitan3.Location = New System.Drawing.Point(217, 46)
        Me.mtbCodCapitan3.Mask = "99999999"
        Me.mtbCodCapitan3.Name = "mtbCodCapitan3"
        Me.mtbCodCapitan3.Size = New System.Drawing.Size(59, 20)
        Me.mtbCodCapitan3.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(114, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Codigo de Capitan  :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(327, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(723, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(327, 390)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmCapitanAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 417)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCapitanAdmin"
        Me.Text = "Administrador de Capitan"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumeroCamiseta1 As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents txtCorreo1 As TextBox
    Friend WithEvents mtbTel1 As MaskedTextBox
    Friend WithEvents mtbCodigoEquipo1 As MaskedTextBox
    Friend WithEvents mtbCodCap2 As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents mtbCodEquipo2 As MaskedTextBox
    Friend WithEvents txtCorreo2 As TextBox
    Friend WithEvents mtbTel2 As MaskedTextBox
    Friend WithEvents txtCamiseta2 As TextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents mtbCodCapitan3 As MaskedTextBox
    Friend WithEvents Label12 As Label
End Class
