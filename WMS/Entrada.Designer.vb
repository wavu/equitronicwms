<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entrada
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada))
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.DocNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txbuscar = New System.Windows.Forms.TextBox()
        Me.cbbusqueda = New System.Windows.Forms.ComboBox()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 13.5!)
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocNum, Me.Proveedor, Me.Fecha, Me.TipoDoc})
        Me.dgv1.Location = New System.Drawing.Point(7, 13)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!)
        Me.dgv1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv1.Size = New System.Drawing.Size(569, 496)
        Me.dgv1.TabIndex = 0
        '
        'DocNum
        '
        Me.DocNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DocNum.DataPropertyName = "DocNum"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocNum.DefaultCellStyle = DataGridViewCellStyle3
        Me.DocNum.HeaderText = "#"
        Me.DocNum.Name = "DocNum"
        Me.DocNum.ReadOnly = True
        Me.DocNum.Width = 5
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "CardName"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proveedor.DefaultCellStyle = DataGridViewCellStyle4
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.MinimumWidth = 250
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 250
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Fecha.DataPropertyName = "DocDate"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 5
        '
        'TipoDoc
        '
        Me.TipoDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.TipoDoc.DataPropertyName = "TipoDoc"
        Me.TipoDoc.HeaderText = "Documento"
        Me.TipoDoc.Name = "TipoDoc"
        Me.TipoDoc.ReadOnly = True
        Me.TipoDoc.Width = 5
        '
        'txbuscar
        '
        Me.txbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!)
        Me.txbuscar.Location = New System.Drawing.Point(184, 515)
        Me.txbuscar.Name = "txbuscar"
        Me.txbuscar.Size = New System.Drawing.Size(392, 32)
        Me.txbuscar.TabIndex = 2
        '
        'cbbusqueda
        '
        Me.cbbusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbusqueda.Font = New System.Drawing.Font("Tahoma", 16.5!, System.Drawing.FontStyle.Bold)
        Me.cbbusqueda.FormattingEnabled = True
        Me.cbbusqueda.Items.AddRange(New Object() {"Numero", "Proveedor", "Fecha"})
        Me.cbbusqueda.Location = New System.Drawing.Point(7, 515)
        Me.cbbusqueda.Name = "cbbusqueda"
        Me.cbbusqueda.Size = New System.Drawing.Size(171, 35)
        Me.cbbusqueda.TabIndex = 3
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.cbbusqueda)
        Me.Controls.Add(Me.txbuscar)
        Me.Controls.Add(Me.dgv1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Entrada"
        Me.Text = "Entrada"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents txbuscar As TextBox
    Friend WithEvents cbbusqueda As ComboBox
    Friend WithEvents DocNum As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents TipoDoc As DataGridViewTextBoxColumn
End Class
