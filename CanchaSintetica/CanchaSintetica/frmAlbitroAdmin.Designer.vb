<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAlbitroAdmin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtbCed = New System.Windows.Forms.MaskedTextBox()
        Me.mtbEdad = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCodInsta = New System.Windows.Forms.MaskedTextBox()
        Me.txtCateg = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtbId2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mtbCedula2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbEdad2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCod_Instala2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCat2 = New System.Windows.Forms.TextBox()
        Me.txtNom2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtbId3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtbCed)
        Me.GroupBox1.Controls.Add(Me.mtbEdad)
        Me.GroupBox1.Controls.Add(Me.mtbCodInsta)
        Me.GroupBox1.Controls.Add(Me.txtCateg)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Albitro"
        '
        'mtbCed
        '
        Me.mtbCed.Location = New System.Drawing.Point(115, 74)
        Me.mtbCed.Mask = "999999999"
        Me.mtbCed.Name = "mtbCed"
        Me.mtbCed.Size = New System.Drawing.Size(63, 20)
        Me.mtbCed.TabIndex = 13
        '
        'mtbEdad
        '
        Me.mtbEdad.Location = New System.Drawing.Point(115, 201)
        Me.mtbEdad.Mask = "00"
        Me.mtbEdad.Name = "mtbEdad"
        Me.mtbEdad.Size = New System.Drawing.Size(22, 20)
        Me.mtbEdad.TabIndex = 12
        '
        'mtbCodInsta
        '
        Me.mtbCodInsta.Location = New System.Drawing.Point(115, 31)
        Me.mtbCodInsta.Mask = "99"
        Me.mtbCodInsta.Name = "mtbCodInsta"
        Me.mtbCodInsta.Size = New System.Drawing.Size(22, 20)
        Me.mtbCodInsta.TabIndex = 11
        '
        'txtCateg
        '
        Me.txtCateg.Location = New System.Drawing.Point(115, 160)
        Me.txtCateg.MaxLength = 1
        Me.txtCateg.Name = "txtCateg"
        Me.txtCateg.Size = New System.Drawing.Size(22, 20)
        Me.txtCateg.TabIndex = 10
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(115, 114)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(120, 20)
        Me.txtNom.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Edad :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Categoria :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cedula :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod_Instalacion :"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(271, 286)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(621, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtbId2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.mtbCedula2)
        Me.GroupBox2.Controls.Add(Me.mtbEdad2)
        Me.GroupBox2.Controls.Add(Me.mtbCod_Instala2)
        Me.GroupBox2.Controls.Add(Me.txtCat2)
        Me.GroupBox2.Controls.Add(Me.txtNom2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(377, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 268)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actualizar Albitro"
        '
        'mtbId2
        '
        Me.mtbId2.Location = New System.Drawing.Point(114, 31)
        Me.mtbId2.Mask = "99"
        Me.mtbId2.Name = "mtbId2"
        Me.mtbId2.Size = New System.Drawing.Size(22, 20)
        Me.mtbId2.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(51, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Id_Albitro :"
        '
        'mtbCedula2
        '
        Me.mtbCedula2.Location = New System.Drawing.Point(115, 113)
        Me.mtbCedula2.Mask = "999999999"
        Me.mtbCedula2.Name = "mtbCedula2"
        Me.mtbCedula2.Size = New System.Drawing.Size(63, 20)
        Me.mtbCedula2.TabIndex = 13
        '
        'mtbEdad2
        '
        Me.mtbEdad2.Location = New System.Drawing.Point(115, 240)
        Me.mtbEdad2.Mask = "00"
        Me.mtbEdad2.Name = "mtbEdad2"
        Me.mtbEdad2.Size = New System.Drawing.Size(22, 20)
        Me.mtbEdad2.TabIndex = 12
        '
        'mtbCod_Instala2
        '
        Me.mtbCod_Instala2.Location = New System.Drawing.Point(115, 70)
        Me.mtbCod_Instala2.Mask = "99"
        Me.mtbCod_Instala2.Name = "mtbCod_Instala2"
        Me.mtbCod_Instala2.Size = New System.Drawing.Size(22, 20)
        Me.mtbCod_Instala2.TabIndex = 11
        '
        'txtCat2
        '
        Me.txtCat2.Location = New System.Drawing.Point(115, 199)
        Me.txtCat2.MaxLength = 1
        Me.txtCat2.Name = "txtCat2"
        Me.txtCat2.Size = New System.Drawing.Size(22, 20)
        Me.txtCat2.TabIndex = 10
        '
        'txtNom2
        '
        Me.txtNom2.Location = New System.Drawing.Point(115, 153)
        Me.txtNom2.Name = "txtNom2"
        Me.txtNom2.Size = New System.Drawing.Size(120, 20)
        Me.txtNom2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Edad :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Categoria :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Nombre :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cedula :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Cod_Instalacion :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtbId3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Elimar Albitro"
        '
        'mtbId3
        '
        Me.mtbId3.Location = New System.Drawing.Point(194, 40)
        Me.mtbId3.Mask = "99"
        Me.mtbId3.Name = "mtbId3"
        Me.mtbId3.Size = New System.Drawing.Size(22, 20)
        Me.mtbId3.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(131, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Id_Albitro :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(349, 423)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmAlbitroAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 469)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAlbitroAdmin"
        Me.Text = "Administrador de Albitros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCateg As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents mtbEdad As MaskedTextBox
    Friend WithEvents mtbCodInsta As MaskedTextBox
    Friend WithEvents mtbCed As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents mtbCedula2 As MaskedTextBox
    Friend WithEvents mtbEdad2 As MaskedTextBox
    Friend WithEvents mtbCod_Instala2 As MaskedTextBox
    Friend WithEvents txtCat2 As TextBox
    Friend WithEvents txtNom2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents mtbId2 As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents mtbId3 As MaskedTextBox
    Friend WithEvents Label12 As Label
End Class
