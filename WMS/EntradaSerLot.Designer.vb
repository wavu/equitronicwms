<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaSerLot
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txitemname = New System.Windows.Forms.TextBox()
        Me.cbserial = New System.Windows.Forms.CheckBox()
        Me.cblote = New System.Windows.Forms.CheckBox()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbdocentry = New System.Windows.Forms.Label()
        Me.lbcant = New System.Windows.Forms.Label()
        Me.lblinenum = New System.Windows.Forms.Label()
        Me.lbitemcode = New System.Windows.Forms.Label()
        Me.lbcompuesto = New System.Windows.Forms.Label()
        Me.lbcblong = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txitemname
        '
        Me.txitemname.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.txitemname.Location = New System.Drawing.Point(12, 12)
        Me.txitemname.Multiline = True
        Me.txitemname.Name = "txitemname"
        Me.txitemname.Size = New System.Drawing.Size(560, 69)
        Me.txitemname.TabIndex = 1
        '
        'cbserial
        '
        Me.cbserial.AutoSize = True
        Me.cbserial.Enabled = False
        Me.cbserial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.cbserial.Location = New System.Drawing.Point(12, 469)
        Me.cbserial.Name = "cbserial"
        Me.cbserial.Size = New System.Drawing.Size(102, 35)
        Me.cbserial.TabIndex = 8
        Me.cbserial.Text = "Serial"
        Me.cbserial.UseVisualStyleBackColor = True
        '
        'cblote
        '
        Me.cblote.AutoSize = True
        Me.cblote.Enabled = False
        Me.cblote.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.cblote.Location = New System.Drawing.Point(12, 510)
        Me.cblote.Name = "cblote"
        Me.cblote.Size = New System.Drawing.Size(86, 35)
        Me.cblote.TabIndex = 9
        Me.cblote.Text = "Lote"
        Me.cblote.UseVisualStyleBackColor = True
        '
        'btguardar
        '
        Me.btguardar.Image = Global.WMS.My.Resources.Resources.guardar
        Me.btguardar.Location = New System.Drawing.Point(492, 469)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(80, 80)
        Me.btguardar.TabIndex = 10
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Serial, Me.Lote, Me.Cant})
        Me.dgv1.Location = New System.Drawing.Point(12, 87)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidth = 44
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.dgv1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.dgv1.RowTemplate.Height = 40
        Me.dgv1.Size = New System.Drawing.Size(560, 376)
        Me.dgv1.TabIndex = 11
        '
        'Serial
        '
        Me.Serial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Serial.DataPropertyName = "DistNumber"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Serial.DefaultCellStyle = DataGridViewCellStyle2
        Me.Serial.FillWeight = 200.0!
        Me.Serial.HeaderText = "Serial"
        Me.Serial.Name = "Serial"
        Me.Serial.Width = 105
        '
        'Lote
        '
        Me.Lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Lote.DataPropertyName = "DistNumber"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lote.DefaultCellStyle = DataGridViewCellStyle3
        Me.Lote.FillWeight = 200.0!
        Me.Lote.HeaderText = "Lote"
        Me.Lote.Name = "Lote"
        Me.Lote.Width = 91
        '
        'Cant
        '
        Me.Cant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cant.DataPropertyName = "Quantity"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Cant.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cant.FillWeight = 200.0!
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        Me.Cant.Width = 94
        '
        'lbdocentry
        '
        Me.lbdocentry.AutoSize = True
        Me.lbdocentry.Location = New System.Drawing.Point(120, 512)
        Me.lbdocentry.Name = "lbdocentry"
        Me.lbdocentry.Size = New System.Drawing.Size(139, 33)
        Me.lbdocentry.TabIndex = 12
        Me.lbdocentry.Text = "lbdocentry"
        '
        'lbcant
        '
        Me.lbcant.AutoSize = True
        Me.lbcant.Location = New System.Drawing.Point(270, 477)
        Me.lbcant.Name = "lbcant"
        Me.lbcant.Size = New System.Drawing.Size(86, 33)
        Me.lbcant.TabIndex = 13
        Me.lbcant.Text = "lbcant"
        '
        'lblinenum
        '
        Me.lblinenum.AutoSize = True
        Me.lblinenum.Location = New System.Drawing.Point(270, 510)
        Me.lblinenum.Name = "lblinenum"
        Me.lblinenum.Size = New System.Drawing.Size(130, 33)
        Me.lblinenum.TabIndex = 14
        Me.lblinenum.Text = "lblinenum"
        '
        'lbitemcode
        '
        Me.lbitemcode.AutoSize = True
        Me.lbitemcode.Location = New System.Drawing.Point(120, 477)
        Me.lbitemcode.Name = "lbitemcode"
        Me.lbitemcode.Size = New System.Drawing.Size(144, 33)
        Me.lbitemcode.TabIndex = 15
        Me.lbitemcode.Text = "lbitemcode"
        '
        'lbcompuesto
        '
        Me.lbcompuesto.AutoSize = True
        Me.lbcompuesto.Location = New System.Drawing.Point(362, 477)
        Me.lbcompuesto.Name = "lbcompuesto"
        Me.lbcompuesto.Size = New System.Drawing.Size(101, 33)
        Me.lbcompuesto.TabIndex = 16
        Me.lbcompuesto.Text = "lbcomp"
        '
        'lbcblong
        '
        Me.lbcblong.AutoSize = True
        Me.lbcblong.Location = New System.Drawing.Point(399, 510)
        Me.lbcblong.Name = "lbcblong"
        Me.lbcblong.Size = New System.Drawing.Size(87, 33)
        Me.lbcblong.TabIndex = 17
        Me.lbcblong.Text = "lblong"
        '
        'EntradaSerLot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.lbcblong)
        Me.Controls.Add(Me.lbcompuesto)
        Me.Controls.Add(Me.lbitemcode)
        Me.Controls.Add(Me.lblinenum)
        Me.Controls.Add(Me.lbcant)
        Me.Controls.Add(Me.lbdocentry)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.cblote)
        Me.Controls.Add(Me.cbserial)
        Me.Controls.Add(Me.txitemname)
        Me.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "EntradaSerLot"
        Me.Text = "EntradaSerLot"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txitemname As TextBox
    Friend WithEvents cbserial As CheckBox
    Friend WithEvents cblote As CheckBox
    Friend WithEvents btguardar As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents lbdocentry As Label
    Friend WithEvents lbcant As Label
    Friend WithEvents lblinenum As Label
    Friend WithEvents lbitemcode As Label
    Friend WithEvents Serial As DataGridViewTextBoxColumn
    Friend WithEvents Lote As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents lbcompuesto As Label
    Friend WithEvents lbcblong As Label
End Class
