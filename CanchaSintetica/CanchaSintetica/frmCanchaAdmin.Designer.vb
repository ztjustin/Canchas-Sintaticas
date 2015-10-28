<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCanchaAdmin
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
        Me.mtbCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.txtMalla = New System.Windows.Forms.TextBox()
        Me.txtMetros = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtbCodCancha = New System.Windows.Forms.MaskedTextBox()
        Me.mtbMalla2 = New System.Windows.Forms.TextBox()
        Me.mtbMetros2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtbCodCancha3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtCesped = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCesped2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mtbCodInsta2 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCesped)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.mtbCodigo)
        Me.GroupBox1.Controls.Add(Me.txtMalla)
        Me.GroupBox1.Controls.Add(Me.txtMetros)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Nueva Cancha"
        '
        'mtbCodigo
        '
        Me.mtbCodigo.Location = New System.Drawing.Point(164, 66)
        Me.mtbCodigo.Mask = "99999"
        Me.mtbCodigo.Name = "mtbCodigo"
        Me.mtbCodigo.Size = New System.Drawing.Size(39, 20)
        Me.mtbCodigo.TabIndex = 7
        Me.mtbCodigo.ValidatingType = GetType(Integer)
        '
        'txtMalla
        '
        Me.txtMalla.Location = New System.Drawing.Point(164, 99)
        Me.txtMalla.Name = "txtMalla"
        Me.txtMalla.Size = New System.Drawing.Size(100, 20)
        Me.txtMalla.TabIndex = 6
        '
        'txtMetros
        '
        Me.txtMetros.Location = New System.Drawing.Point(164, 129)
        Me.txtMetros.Name = "txtMetros"
        Me.txtMetros.Size = New System.Drawing.Size(100, 20)
        Me.txtMetros.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cod_Instalacion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo de Malla:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Metros Cuadrados:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtbCodInsta2)
        Me.GroupBox2.Controls.Add(Me.txtCesped2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.mtbCodCancha)
        Me.GroupBox2.Controls.Add(Me.mtbMalla2)
        Me.GroupBox2.Controls.Add(Me.mtbMetros2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(392, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 232)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actualizar Cancha"
        '
        'mtbCodCancha
        '
        Me.mtbCodCancha.Location = New System.Drawing.Point(138, 37)
        Me.mtbCodCancha.Mask = "99999"
        Me.mtbCodCancha.Name = "mtbCodCancha"
        Me.mtbCodCancha.Size = New System.Drawing.Size(39, 20)
        Me.mtbCodCancha.TabIndex = 8
        Me.mtbCodCancha.ValidatingType = GetType(Integer)
        '
        'mtbMalla2
        '
        Me.mtbMalla2.Location = New System.Drawing.Point(138, 103)
        Me.mtbMalla2.Name = "mtbMalla2"
        Me.mtbMalla2.Size = New System.Drawing.Size(100, 20)
        Me.mtbMalla2.TabIndex = 12
        '
        'mtbMetros2
        '
        Me.mtbMetros2.Location = New System.Drawing.Point(138, 133)
        Me.mtbMetros2.Name = "mtbMetros2"
        Me.mtbMetros2.Size = New System.Drawing.Size(100, 20)
        Me.mtbMetros2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cod_Instalacion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo de Malla:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Metros Cuadrados:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod_Cancha:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtbCodCancha3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 62)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Eliminar Cancha"
        '
        'mtbCodCancha3
        '
        Me.mtbCodCancha3.Location = New System.Drawing.Point(158, 21)
        Me.mtbCodCancha3.Mask = "99999"
        Me.mtbCodCancha3.Name = "mtbCodCancha3"
        Me.mtbCodCancha3.Size = New System.Drawing.Size(39, 20)
        Me.mtbCodCancha3.TabIndex = 9
        Me.mtbCodCancha3.ValidatingType = GetType(Integer)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(83, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Cod_Cancha:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(671, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(291, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(291, 380)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtCesped
        '
        Me.txtCesped.Location = New System.Drawing.Point(164, 164)
        Me.txtCesped.Name = "txtCesped"
        Me.txtCesped.Size = New System.Drawing.Size(100, 20)
        Me.txtCesped.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tipo de Cesped:"
        '
        'txtCesped2
        '
        Me.txtCesped2.Location = New System.Drawing.Point(138, 164)
        Me.txtCesped2.Name = "txtCesped2"
        Me.txtCesped2.Size = New System.Drawing.Size(100, 20)
        Me.txtCesped2.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Tipo de Cesped:"
        '
        'mtbCodInsta2
        '
        Me.mtbCodInsta2.Location = New System.Drawing.Point(138, 70)
        Me.mtbCodInsta2.Mask = "99999"
        Me.mtbCodInsta2.Name = "mtbCodInsta2"
        Me.mtbCodInsta2.Size = New System.Drawing.Size(39, 20)
        Me.mtbCodInsta2.TabIndex = 15
        Me.mtbCodInsta2.ValidatingType = GetType(Integer)
        '
        'frmCanchaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 427)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCanchaAdmin"
        Me.Text = "Administracion de Canchas"
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
    Friend WithEvents txtMalla As TextBox
    Friend WithEvents txtMetros As TextBox
    Friend WithEvents mtbMalla2 As TextBox
    Friend WithEvents mtbMetros2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents mtbCodigo As MaskedTextBox
    Friend WithEvents mtbCodCancha As MaskedTextBox
    Friend WithEvents mtbCodCancha3 As MaskedTextBox
    Friend WithEvents txtCesped As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCesped2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents mtbCodInsta2 As MaskedTextBox
End Class
