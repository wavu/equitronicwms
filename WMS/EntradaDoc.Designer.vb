<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntradaDoc
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntradaDoc))
        Me.lbnumero = New System.Windows.Forms.Label()
        Me.lbtipodoc = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.txitem = New System.Windows.Forms.TextBox()
        Me.lbidrow = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btguardar = New System.Windows.Forms.Button()
        Me.cbcode = New System.Windows.Forms.CheckBox()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocEntry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhsCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SlpCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManSerNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManBtchNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbnumero
        '
        Me.lbnumero.AutoSize = True
        Me.lbnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbnumero.Location = New System.Drawing.Point(360, 18)
        Me.lbnumero.Name = "lbnumero"
        Me.lbnumero.Size = New System.Drawing.Size(126, 31)
        Me.lbnumero.TabIndex = 3
        Me.lbnumero.Text = "lbnumero"
        '
        'lbtipodoc
        '
        Me.lbtipodoc.AutoSize = True
        Me.lbtipodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbtipodoc.Location = New System.Drawing.Point(147, 15)
        Me.lbtipodoc.Name = "lbtipodoc"
        Me.lbtipodoc.Size = New System.Drawing.Size(123, 31)
        Me.lbtipodoc.TabIndex = 2
        Me.lbtipodoc.Text = "lbtipodoc"
        Me.lbtipodoc.Visible = False
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.ItemName, Me.Cantidad, Me.OpenQty, Me.ObjType, Me.DocEntry, Me.LineNum, Me.WhsCode, Me.Price, Me.CardCode, Me.Currency, Me.SlpCode, Me.ManSerNum, Me.ManBtchNum})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv1.Location = New System.Drawing.Point(12, 98)
        Me.dgv1.Name = "dgv1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!)
        Me.dgv1.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv1.Size = New System.Drawing.Size(560, 451)
        Me.dgv1.TabIndex = 4
        '
        'txitem
        '
        Me.txitem.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.txitem.Location = New System.Drawing.Point(12, 52)
        Me.txitem.Name = "txitem"
        Me.txitem.Size = New System.Drawing.Size(474, 40)
        Me.txitem.TabIndex = 0
        '
        'lbidrow
        '
        Me.lbidrow.AutoSize = True
        Me.lbidrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbidrow.Location = New System.Drawing.Point(275, 15)
        Me.lbidrow.Name = "lbidrow"
        Me.lbidrow.Size = New System.Drawing.Size(79, 31)
        Me.lbidrow.TabIndex = 5
        Me.lbidrow.Text = "idrow"
        Me.lbidrow.Visible = False
        '
        'btguardar
        '
        Me.btguardar.Image = Global.WMS.My.Resources.Resources.guardar
        Me.btguardar.Location = New System.Drawing.Point(492, 12)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(80, 80)
        Me.btguardar.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btguardar, "Guardar")
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'cbcode
        '
        Me.cbcode.AutoSize = True
        Me.cbcode.Checked = True
        Me.cbcode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.cbcode.Location = New System.Drawing.Point(12, 12)
        Me.cbcode.Name = "cbcode"
        Me.cbcode.Size = New System.Drawing.Size(140, 35)
        Me.cbcode.TabIndex = 7
        Me.cbcode.Text = "CodeBar"
        Me.cbcode.UseVisualStyleBackColor = True
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Item.DataPropertyName = "Item"
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 5
        '
        'ItemName
        '
        Me.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ItemName.DataPropertyName = "ItemName"
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 121
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 109
        '
        'OpenQty
        '
        Me.OpenQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.OpenQty.DataPropertyName = "OpenQty"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.OpenQty.DefaultCellStyle = DataGridViewCellStyle4
        Me.OpenQty.HeaderText = "OpenQty"
        Me.OpenQty.Name = "OpenQty"
        Me.OpenQty.ReadOnly = True
        Me.OpenQty.Width = 111
        '
        'ObjType
        '
        Me.ObjType.DataPropertyName = "ObjType"
        Me.ObjType.HeaderText = "ObjType"
        Me.ObjType.Name = "ObjType"
        Me.ObjType.Visible = False
        '
        'DocEntry
        '
        Me.DocEntry.DataPropertyName = "DocEntry"
        Me.DocEntry.HeaderText = "DocEntry"
        Me.DocEntry.Name = "DocEntry"
        Me.DocEntry.Visible = False
        '
        'LineNum
        '
        Me.LineNum.DataPropertyName = "LineNum"
        Me.LineNum.HeaderText = "LineNum"
        Me.LineNum.Name = "LineNum"
        '
        'WhsCode
        '
        Me.WhsCode.DataPropertyName = "WhsCode"
        Me.WhsCode.HeaderText = "WhsCode"
        Me.WhsCode.Name = "WhsCode"
        Me.WhsCode.Visible = False
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.Visible = False
        '
        'CardCode
        '
        Me.CardCode.DataPropertyName = "CardCode"
        Me.CardCode.HeaderText = "CardCode"
        Me.CardCode.Name = "CardCode"
        Me.CardCode.Visible = False
        '
        'Currency
        '
        Me.Currency.DataPropertyName = "Currency"
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Name = "Currency"
        Me.Currency.Visible = False
        '
        'SlpCode
        '
        Me.SlpCode.DataPropertyName = "SlpCode"
        Me.SlpCode.HeaderText = "SlpCode"
        Me.SlpCode.Name = "SlpCode"
        Me.SlpCode.Visible = False
        '
        'ManSerNum
        '
        Me.ManSerNum.DataPropertyName = "ManSerNum"
        Me.ManSerNum.HeaderText = "ManSerNum"
        Me.ManSerNum.Name = "ManSerNum"
        '
        'ManBtchNum
        '
        Me.ManBtchNum.DataPropertyName = "ManBtchNum"
        Me.ManBtchNum.HeaderText = "ManBtchNum"
        Me.ManBtchNum.Name = "ManBtchNum"
        '
        'EntradaDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.cbcode)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.lbidrow)
        Me.Controls.Add(Me.txitem)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lbnumero)
        Me.Controls.Add(Me.lbtipodoc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EntradaDoc"
        Me.Text = "EntradaDoc"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbnumero As Label
    Friend WithEvents lbtipodoc As Label
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents txitem As TextBox
    Friend WithEvents lbidrow As Label
    Friend WithEvents btguardar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cbcode As CheckBox
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents OpenQty As DataGridViewTextBoxColumn
    Friend WithEvents ObjType As DataGridViewTextBoxColumn
    Friend WithEvents DocEntry As DataGridViewTextBoxColumn
    Friend WithEvents LineNum As DataGridViewTextBoxColumn
    Friend WithEvents WhsCode As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents CardCode As DataGridViewTextBoxColumn
    Friend WithEvents Currency As DataGridViewTextBoxColumn
    Friend WithEvents SlpCode As DataGridViewTextBoxColumn
    Friend WithEvents ManSerNum As DataGridViewTextBoxColumn
    Friend WithEvents ManBtchNum As DataGridViewTextBoxColumn
End Class
