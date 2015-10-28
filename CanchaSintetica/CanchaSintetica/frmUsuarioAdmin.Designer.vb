<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarioAdmin
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
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDir1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.mtbPhone1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail1 = New System.Windows.Forms.TextBox()
        Me.txtNick1 = New System.Windows.Forms.TextBox()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.mtbCodigoInsta1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDir2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mtbCodUser2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mtbPhone2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.txtNick2 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.mtbCodInsta2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtbCodUser3 = New System.Windows.Forms.MaskedTextBox()
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
        Me.GroupBox1.Controls.Add(Me.txtPass1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtDir1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.mtbPhone1)
        Me.GroupBox1.Controls.Add(Me.txtEmail1)
        Me.GroupBox1.Controls.Add(Me.txtNick1)
        Me.GroupBox1.Controls.Add(Me.txtNombre1)
        Me.GroupBox1.Controls.Add(Me.mtbCodigoInsta1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Usuario"
        '
        'txtPass1
        '
        Me.txtPass1.Location = New System.Drawing.Point(159, 176)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(88, 20)
        Me.txtPass1.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(64, 179)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Password :"
        '
        'txtDir1
        '
        Me.txtDir1.Location = New System.Drawing.Point(160, 150)
        Me.txtDir1.Name = "txtDir1"
        Me.txtDir1.Size = New System.Drawing.Size(88, 20)
        Me.txtDir1.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(65, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Direccion :"
        '
        'mtbPhone1
        '
        Me.mtbPhone1.Location = New System.Drawing.Point(160, 127)
        Me.mtbPhone1.Mask = "99999999"
        Me.mtbPhone1.Name = "mtbPhone1"
        Me.mtbPhone1.Size = New System.Drawing.Size(65, 20)
        Me.mtbPhone1.TabIndex = 9
        '
        'txtEmail1
        '
        Me.txtEmail1.Location = New System.Drawing.Point(160, 103)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(88, 20)
        Me.txtEmail1.TabIndex = 8
        '
        'txtNick1
        '
        Me.txtNick1.Location = New System.Drawing.Point(160, 76)
        Me.txtNick1.Name = "txtNick1"
        Me.txtNick1.Size = New System.Drawing.Size(88, 20)
        Me.txtNick1.TabIndex = 7
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(160, 50)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(88, 20)
        Me.txtNombre1.TabIndex = 6
        '
        'mtbCodigoInsta1
        '
        Me.mtbCodigoInsta1.Location = New System.Drawing.Point(160, 26)
        Me.mtbCodigoInsta1.Mask = "99999"
        Me.mtbCodigoInsta1.Name = "mtbCodigoInsta1"
        Me.mtbCodigoInsta1.Size = New System.Drawing.Size(43, 20)
        Me.mtbCodigoInsta1.TabIndex = 5
        Me.mtbCodigoInsta1.ValidatingType = GetType(Integer)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nick :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Instalacion :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPass2)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtDir2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.mtbCodUser2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.mtbPhone2)
        Me.GroupBox2.Controls.Add(Me.txtEmail2)
        Me.GroupBox2.Controls.Add(Me.txtNick2)
        Me.GroupBox2.Controls.Add(Me.txtNombre2)
        Me.GroupBox2.Controls.Add(Me.mtbCodInsta2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 238)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actualizar Usuario"
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(210, 198)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(88, 20)
        Me.txtPass2.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(115, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Password :"
        '
        'txtDir2
        '
        Me.txtDir2.Location = New System.Drawing.Point(211, 172)
        Me.txtDir2.Name = "txtDir2"
        Me.txtDir2.Size = New System.Drawing.Size(88, 20)
        Me.txtDir2.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(116, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Direccion :"
        '
        'mtbCodUser2
        '
        Me.mtbCodUser2.Location = New System.Drawing.Point(210, 13)
        Me.mtbCodUser2.Mask = "99999"
        Me.mtbCodUser2.Name = "mtbCodUser2"
        Me.mtbCodUser2.Size = New System.Drawing.Size(43, 20)
        Me.mtbCodUser2.TabIndex = 21
        Me.mtbCodUser2.ValidatingType = GetType(Integer)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(104, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Codigo de Usuario :"
        '
        'mtbPhone2
        '
        Me.mtbPhone2.Location = New System.Drawing.Point(210, 147)
        Me.mtbPhone2.Mask = "99999999"
        Me.mtbPhone2.Name = "mtbPhone2"
        Me.mtbPhone2.Size = New System.Drawing.Size(65, 20)
        Me.mtbPhone2.TabIndex = 19
        '
        'txtEmail2
        '
        Me.txtEmail2.Location = New System.Drawing.Point(210, 123)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(88, 20)
        Me.txtEmail2.TabIndex = 18
        '
        'txtNick2
        '
        Me.txtNick2.Location = New System.Drawing.Point(210, 96)
        Me.txtNick2.Name = "txtNick2"
        Me.txtNick2.Size = New System.Drawing.Size(88, 20)
        Me.txtNick2.TabIndex = 17
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(210, 70)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(88, 20)
        Me.txtNombre2.TabIndex = 16
        '
        'mtbCodInsta2
        '
        Me.mtbCodInsta2.Location = New System.Drawing.Point(210, 46)
        Me.mtbCodInsta2.Mask = "99999"
        Me.mtbCodInsta2.Name = "mtbCodInsta2"
        Me.mtbCodInsta2.Size = New System.Drawing.Size(43, 20)
        Me.mtbCodInsta2.TabIndex = 15
        Me.mtbCodInsta2.ValidatingType = GetType(Integer)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(116, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Phone :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(104, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nombre :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nick :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(115, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Email :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(104, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Codigo Instalacion :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtbCodUser3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 85)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Eliminar Usuario"
        '
        'mtbCodUser3
        '
        Me.mtbCodUser3.Location = New System.Drawing.Point(232, 32)
        Me.mtbCodUser3.Mask = "99999"
        Me.mtbCodUser3.Name = "mtbCodUser3"
        Me.mtbCodUser3.Size = New System.Drawing.Size(43, 20)
        Me.mtbCodUser3.TabIndex = 23
        Me.mtbCodUser3.ValidatingType = GetType(Integer)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(126, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Codigo de Usuario :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(337, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(337, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(743, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmUsuarioAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 398)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUsuarioAdmin"
        Me.Text = "Administrador de Usuario"
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
    Friend WithEvents mtbPhone1 As MaskedTextBox
    Friend WithEvents txtEmail1 As TextBox
    Friend WithEvents txtNick1 As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents mtbCodigoInsta1 As MaskedTextBox
    Friend WithEvents mtbPhone2 As MaskedTextBox
    Friend WithEvents txtEmail2 As TextBox
    Friend WithEvents txtNick2 As TextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents mtbCodInsta2 As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents mtbCodUser2 As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents mtbCodUser3 As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDir2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPass1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDir1 As TextBox
    Friend WithEvents Label16 As Label
End Class
