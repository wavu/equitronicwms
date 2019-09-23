<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntregaDoc
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
        Me.lbtipodoc = New System.Windows.Forms.Label()
        Me.lbnumero = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbtipodoc
        '
        Me.lbtipodoc.AutoSize = True
        Me.lbtipodoc.Location = New System.Drawing.Point(12, 9)
        Me.lbtipodoc.Name = "lbtipodoc"
        Me.lbtipodoc.Size = New System.Drawing.Size(50, 13)
        Me.lbtipodoc.TabIndex = 0
        Me.lbtipodoc.Text = "lbtipodoc"
        '
        'lbnumero
        '
        Me.lbnumero.AutoSize = True
        Me.lbnumero.Location = New System.Drawing.Point(68, 9)
        Me.lbnumero.Name = "lbnumero"
        Me.lbnumero.Size = New System.Drawing.Size(50, 13)
        Me.lbnumero.TabIndex = 1
        Me.lbnumero.Text = "lbnumero"
        '
        'EntregaDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbnumero)
        Me.Controls.Add(Me.lbtipodoc)
        Me.Name = "EntregaDoc"
        Me.Text = "EntregaDoc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbtipodoc As Label
    Friend WithEvents lbnumero As Label
End Class
