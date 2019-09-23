<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btcancelar = New System.Windows.Forms.Button()
        Me.txusuario = New System.Windows.Forms.TextBox()
        Me.txpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btcancelar
        '
        Me.btcancelar.Image = CType(resources.GetObject("btcancelar.Image"), System.Drawing.Image)
        Me.btcancelar.Location = New System.Drawing.Point(308, 336)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(140, 140)
        Me.btcancelar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btcancelar, "Salir")
        Me.btcancelar.UseVisualStyleBackColor = True
        '
        'txusuario
        '
        Me.txusuario.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.txusuario.Location = New System.Drawing.Point(90, 110)
        Me.txusuario.Name = "txusuario"
        Me.txusuario.Size = New System.Drawing.Size(400, 40)
        Me.txusuario.TabIndex = 0
        '
        'txpassword
        '
        Me.txpassword.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.txpassword.Location = New System.Drawing.Point(90, 240)
        Me.txpassword.Name = "txpassword"
        Me.txpassword.Size = New System.Drawing.Size(400, 40)
        Me.txpassword.TabIndex = 1
        Me.txpassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(200, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(220, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Clave:"
        '
        'btlogin
        '
        Me.btlogin.Image = CType(resources.GetObject("btlogin.Image"), System.Drawing.Image)
        Me.btlogin.Location = New System.Drawing.Point(138, 336)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(140, 140)
        Me.btlogin.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btlogin, "Login")
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txpassword)
        Me.Controls.Add(Me.txusuario)
        Me.Controls.Add(Me.btcancelar)
        Me.Controls.Add(Me.btlogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btlogin As Button
    Friend WithEvents btcancelar As Button
    Friend WithEvents txusuario As TextBox
    Friend WithEvents txpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
