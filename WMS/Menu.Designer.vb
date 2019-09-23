<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.btentrada = New System.Windows.Forms.Button()
        Me.btentrega = New System.Windows.Forms.Button()
        Me.btconteo = New System.Windows.Forms.Button()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btentrada
        '
        Me.btentrada.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btentrada.Location = New System.Drawing.Point(122, 60)
        Me.btentrada.Name = "btentrada"
        Me.btentrada.Size = New System.Drawing.Size(340, 100)
        Me.btentrada.TabIndex = 0
        Me.btentrada.Text = "ENTRADA MERCANCIA"
        Me.btentrada.UseVisualStyleBackColor = True
        '
        'btentrega
        '
        Me.btentrega.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btentrega.Location = New System.Drawing.Point(122, 166)
        Me.btentrega.Name = "btentrega"
        Me.btentrega.Size = New System.Drawing.Size(340, 100)
        Me.btentrega.TabIndex = 1
        Me.btentrega.Text = "ENTREGA MERCANCIA"
        Me.btentrega.UseVisualStyleBackColor = True
        '
        'btconteo
        '
        Me.btconteo.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btconteo.Location = New System.Drawing.Point(122, 272)
        Me.btconteo.Name = "btconteo"
        Me.btconteo.Size = New System.Drawing.Size(340, 100)
        Me.btconteo.TabIndex = 2
        Me.btconteo.Text = "CONTEO MERCANCIA"
        Me.btconteo.UseVisualStyleBackColor = True
        '
        'btsalir
        '
        Me.btsalir.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btsalir.Location = New System.Drawing.Point(122, 378)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(340, 100)
        Me.btsalir.TabIndex = 3
        Me.btsalir.Text = "SALIR"
        Me.btsalir.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.btsalir)
        Me.Controls.Add(Me.btconteo)
        Me.Controls.Add(Me.btentrega)
        Me.Controls.Add(Me.btentrada)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.Text = "MENU"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btentrada As Button
    Friend WithEvents btentrega As Button
    Friend WithEvents btconteo As Button
    Friend WithEvents btsalir As Button
End Class
