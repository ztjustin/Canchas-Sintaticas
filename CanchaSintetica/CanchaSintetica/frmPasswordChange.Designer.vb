﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordChange
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
        Me.txtContraNueva2 = New System.Windows.Forms.TextBox()
        Me.txtContraNueva1 = New System.Windows.Forms.TextBox()
        Me.txtContraAntigua = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtContraNueva2)
        Me.GroupBox1.Controls.Add(Me.txtContraNueva1)
        Me.GroupBox1.Controls.Add(Me.txtContraAntigua)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Usuario"
        '
        'txtContraNueva2
        '
        Me.txtContraNueva2.Location = New System.Drawing.Point(181, 119)
        Me.txtContraNueva2.Name = "txtContraNueva2"
        Me.txtContraNueva2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraNueva2.Size = New System.Drawing.Size(100, 20)
        Me.txtContraNueva2.TabIndex = 5
        '
        'txtContraNueva1
        '
        Me.txtContraNueva1.Location = New System.Drawing.Point(181, 78)
        Me.txtContraNueva1.Name = "txtContraNueva1"
        Me.txtContraNueva1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraNueva1.Size = New System.Drawing.Size(100, 20)
        Me.txtContraNueva1.TabIndex = 4
        '
        'txtContraAntigua
        '
        Me.txtContraAntigua.Location = New System.Drawing.Point(181, 39)
        Me.txtContraAntigua.Name = "txtContraAntigua"
        Me.txtContraAntigua.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraAntigua.Size = New System.Drawing.Size(100, 20)
        Me.txtContraAntigua.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repetir Contraseña :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nueva Contraseña :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Antigua :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cambiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 259)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPasswordChange"
        Me.Text = "Cambiar Contraseña"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtContraAntigua As TextBox
    Friend WithEvents txtContraNueva2 As TextBox
    Friend WithEvents txtContraNueva1 As TextBox
End Class
