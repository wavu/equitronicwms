Imports System.Data
Imports System.Data.SqlClient
Imports SAPbobsCOM
Public Class EntradaDoc
    Dim sql As New SqlCommand
    Dim ds As DataSet
    Dim idrow As Integer
    Public util As New utilidades
    Dim proveedor, codebarcompuesto, lote As String
    Dim codebarlong, j As Integer
    Dim dtlote, dtserial, dt As New System.Data.DataTable

    Private Sub EntradaDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        codebarcompuesto = "No"
        If lbtipodoc.Text = "Pedido" Then
            sql.CommandText = "SELECT T1.ItemCode AS Item, T1.Dscription AS Itemname, '' AS Cantidad , T1.OpenQty, T1.ObjType , T1.DocEntry, T1.LineNum, T1.WhsCode, T1.Price, T0.CardCode, T1.Currency, T1.SlpCode, T2.ManSerNum, T2.ManBtchNum  
                            FROM OPOR AS T0 
                            INNER JOIN POR1 AS T1 ON T0.DocEntry = t1.DocEntry
                            INNER JOIN OITM AS T2 ON T1.ItemCode = T2.ItemCode
                            WHERE T1.OpenQty >0 and T0.DocNum = " + lbnumero.Text
        ElseIf lbtipodoc.Text = "Factura" Then

        End If
        ds = util.consultar(sql)
        dgv1.DataSource = ds.Tables(0)
        proveedor = ds.Tables(0).Rows(0)("CardCode").ToString
        sql.CommandText = "SELECT isnull(U_codebarcomp, 'No') AS U_codebarcomp , isnull (U_CodeBar, 0) AS U_CodeBar FROM OCRD WHERE CardCode = '" + proveedor + "'"
        ds = util.consultar(sql)
        codebarcompuesto = ds.Tables(0).Rows(0)("U_codebarcomp").ToString
        codebarlong = Integer.Parse(ds.Tables(0).Rows(0)("U_CodeBar").ToString)

        dtlote.Columns.Add("DocEntry")
        dtlote.Columns.Add("ItemCode")
        dtlote.Columns.Add("Seq")
        dtlote.Columns.Add("Cant")
        dtlote.Columns.Add("Lote")
        j = 0
    End Sub

    Private Sub txitem_TextChanged(sender As Object, e As EventArgs) Handles txitem.TextChanged
        Dim codebar As String
        Dim tamano As Integer
        Try
            tamano = txitem.Text.Length
            If cbcode.Checked = True Then
                If codebarcompuesto = "No" Then
                    codebar = txitem.Text
                Else
                    codebar = txitem.Text.Substring(0, codebarlong)
                    If tamano > codebarlong Then
                        lote = txitem.Text.Substring(codebarlong, (tamano - codebarlong))
                    End If
                End If
                sql.CommandText = "SELECT ItemCode FROM obcd WHERE BcdCode = '" + codebar + "'"
                ds = util.consultar(sql)
                Buscar(ds.Tables(0).Rows(0)("ItemCode").ToString, "Item", dgv1)
            Else
                codebar = txitem.Text
                Buscar(codebar, "Item", dgv1)
            End If




            dgv1.CurrentCell = dgv1.Rows(idrow).Cells(2)
            dgv1.BeginEdit(True)
            Me.TabIndex = 0

            MsgBox("Maneja serial: " + ds.Tables(0).Rows(0)("ManSerNum").ToString + " Maneja lote: " + ds.Tables(0).Rows(0)("ManBtchNum").ToString)

        Catch ex As Exception

        End Try

    End Sub

    Function Buscar(ByVal TextoABuscar As String, ByVal Columna As String, ByRef grid As DataGridView) As Boolean
        Dim encontrado As Boolean = False

        If TextoABuscar = String.Empty Then Return False
        If grid.RowCount = 0 Then Return False
        grid.ClearSelection()
        If Columna = String.Empty Then
            For Each row As DataGridViewRow In grid.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value.ToString() = TextoABuscar Then
                        row.Selected = True

                        Return True
                    End If
                Next
            Next
        Else
            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Return False
                If row.Cells(Columna).Value.ToString() = TextoABuscar Then
                    row.Selected = True
                    idrow = row.Index
                    lbidrow.Text = idrow.ToString
                    Return True
                End If

            Next
        End If
        Return encontrado
    End Function



    Private Sub dgv1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellEndEdit
        If Double.Parse(dgv1.Rows(idrow).Cells(2).Value.ToString) < Double.Parse(dgv1.Rows(idrow).Cells(3).Value.ToString) Then
            dgv1.Rows(idrow).DefaultCellStyle.BackColor = Color.LightSalmon
        ElseIf Double.Parse(dgv1.Rows(idrow).Cells(2).Value.ToString) > Double.Parse(dgv1.Rows(idrow).Cells(3).Value.ToString) Then
            dgv1.Rows(idrow).DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
        End If



        If dgv1.Rows(e.RowIndex).Cells(13).Value = "Y" Then
            EntradaSerLot.lbcant.Text = dgv1.Rows(e.RowIndex).Cells(2).Value.ToString()
            EntradaSerLot.lbdocentry.Text = dgv1.Rows(e.RowIndex).Cells(5).Value.ToString
            EntradaSerLot.lblinenum.Text = dgv1.Rows(e.RowIndex).Cells(6).Value.ToString()
            EntradaSerLot.txitemname.Text = dgv1.Rows(e.RowIndex).Cells(1).Value.ToString()
            EntradaSerLot.lbitemcode.Text = dgv1.Rows(e.RowIndex).Cells(0).Value.ToString()

            EntradaSerLot.lbcompuesto.Text = codebarcompuesto
            EntradaSerLot.lbcblong.Text = codebarlong
            EntradaSerLot.cblote.Checked = True
            txitem.Text = ""
            EntradaSerLot.Show()
        ElseIf dgv1.Rows(e.RowIndex).Cells(12).Value = "Y" Then
            EntradaSerLot.lbcant.Text = dgv1.Rows(e.RowIndex).Cells(2).Value.ToString()
            EntradaSerLot.lbdocentry.Text = dgv1.Rows(e.RowIndex).Cells(5).Value.ToString
            EntradaSerLot.lblinenum.Text = dgv1.Rows(e.RowIndex).Cells(6).Value.ToString()
            EntradaSerLot.txitemname.Text = dgv1.Rows(e.RowIndex).Cells(1).Value.ToString()
            EntradaSerLot.lbitemcode.Text = dgv1.Rows(e.RowIndex).Cells(0).Value.ToString()
            EntradaSerLot.cbserial.Checked = True
            txitem.Text = ""
            EntradaSerLot.Show()

        End If



    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        Dim oEntrada As SAPbobsCOM.Documents
        Dim i, w As Integer
        i = 0
        oEntrada = Login.util.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseDeliveryNotes)
        oEntrada.CardCode = dgv1.Rows(0).Cells(9).Value.ToString
        oEntrada.SalesPersonCode = 11
        '        oEntrada.Lines.Add()
        For i = 0 To dgv1.Rows.Count - 1
            If Integer.Parse(dgv1.Rows(i).Cells(2).Value.ToString) > 0 Then
                oEntrada.Lines.Add()
                oEntrada.Lines.SetCurrentLine(i)
                oEntrada.Lines.BaseType = dgv1.Rows(i).Cells(4).Value.ToString
                oEntrada.Lines.BaseEntry = dgv1.Rows(i).Cells(5).Value.ToString
                oEntrada.Lines.BaseLine = dgv1.Rows(i).Cells(6).Value.ToString
                oEntrada.Lines.WarehouseCode = dgv1.Rows(i).Cells(7).Value.ToString
                oEntrada.Lines.ItemCode = dgv1.Rows(i).Cells(0).Value.ToString
                oEntrada.Lines.Quantity = Integer.Parse(dgv1.Rows(i).Cells(2).Value.ToString)
                oEntrada.Lines.Price = dgv1.Rows(i).Cells(8).Value.ToString
                oEntrada.Lines.Currency = dgv1.Rows(i).Cells(10).Value.ToString
                'oEntrada.Lines.SalesPersonCode = 11

                If dgv1.Rows(i).Cells(13).Value = "Y" Then
                    sql.CommandText = "SELECT DocEntry, ItemCode, LineNum, CAST (Quantity AS INTEGER) AS Quantity, DistNumber FROM dbo.wms_lote WHERE DocEntry = " + dgv1.Rows(i).Cells(5).Value.ToString + " AND LineNum = " + dgv1.Rows(i).Cells(6).Value.ToString + ""
                    ds = util.consultarrep(sql)

                    For w = 0 To ds.Tables(0).Rows.Count - 1
                        oEntrada.Lines.BatchNumbers.Add()
                        oEntrada.Lines.BatchNumbers.SetCurrentLine(w)
                        oEntrada.Lines.BatchNumbers.BatchNumber = ds.Tables(0).Rows(w)("DistNumber").ToString
                        oEntrada.Lines.BatchNumbers.Quantity = ds.Tables(0).Rows(w)("Quantity").ToString

                    Next

                ElseIf dgv1.Rows(i).Cells(12).Value = "Y" Then
                    sql.CommandText = "SELECT DocEntry, ItemCode, LineNum, DistNumber FROM dbo.wms_serial WHERE DocEntry = " + dgv1.Rows(i).Cells(5).Value.ToString + " AND LineNum = " + dgv1.Rows(i).Cells(6).Value.ToString + ""
                    ds = util.consultarrep(sql)

                    For w = 0 To ds.Tables(0).Rows.Count - 1
                        oEntrada.Lines.SerialNumbers.Add()
                        oEntrada.Lines.SerialNumbers.SetCurrentLine(w)
                        oEntrada.Lines.SerialNumbers.InternalSerialNumber = ds.Tables(0).Rows(w)("DistNumber").ToString

                    Next

                End If





            End If
        Next

        If oEntrada.Add() <> 0 Then
            MessageBox.Show("Error: " + Login.util.oCompany.GetLastErrorDescription())
        Else
            MessageBox.Show("Entrada creada correctamente: " + Login.util.oCompany.GetNewObjectKey())
            Me.Close()
        End If



    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txitem_Leave(sender As Object, e As EventArgs) Handles txitem.Leave
        txitem.BackColor = Color.White
        Dim objFont As System.Drawing.Font
        objFont = New System.Drawing.Font("Tahoma", 16, FontStyle.Regular)
        txitem.Font = objFont
        txitem.ForeColor = Color.Black
    End Sub

    Private Sub txitem_Enter(sender As Object, e As EventArgs) Handles txitem.Enter
        txitem.BackColor = Color.Aqua
        Dim objFont As System.Drawing.Font
        objFont = New System.Drawing.Font("Tahoma", 16, FontStyle.Bold)
        txitem.Font = objFont
        txitem.ForeColor = Color.Blue
    End Sub


End Class