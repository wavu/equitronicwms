
Imports System.Data.SqlClient

Public Class EntradaSerLot
    Dim sql As New SqlCommand
    Dim util As New utilidades
    Dim ds As DataSet
    Dim resinset As Boolean
    Private Sub EntradaSerLot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)

        If cblote.Checked = True Then
            dgv1.Columns(0).Visible = False
            dgv1.Columns(1).Visible = True
            dgv1.Columns(2).Visible = True
            sql.CommandText = "SELECT CAST (Quantity AS INTEGER) AS Quantity, DistNumber FROM dbo.wms_lote WHERE DocEntry = " + lbdocentry.Text + " AND LineNum = " + lblinenum.Text + ""
            ds = util.consultarrep(sql)
            dgv1.DataSource = ds.Tables(0)
            lbcompuesto.Visible = True
            lbcblong.Visible = True

        ElseIf cbserial.Checked = True Then
            dgv1.Columns(0).Visible = True
            dgv1.Columns(1).Visible = False
            dgv1.Columns(2).Visible = False
            sql.CommandText = "SELECT DistNumber FROM dbo.wms_serial WHERE DocEntry = " + lbdocentry.Text + " AND LineNum = " + lblinenum.Text + ""
            ds = util.consultarrep(sql)
            dgv1.DataSource = ds.Tables(0)
            lbcompuesto.Visible = False
            lbcblong.Visible = False
        End If

    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If cbserial.Checked = True Then
            If dgv1.Rows.Count - 1 = lbcant.Text Then
                For i = 0 To dgv1.Rows.Count - 2

                    sql.CommandText = "INSERT INTO dbo.wms_serial (DocEntry, ItemCode, LineNum, DistNumber)
                                    VALUES (" + lbdocentry.Text + ", '" + lbitemcode.Text + "', " + lblinenum.Text + ", '" + dgv1.Rows(i).Cells("Serial").Value.ToString + "')"
                    resinset = util.insertarrep(sql)
                    If resinset = False Then
                        MsgBox("Error al guardar")
                    End If
                Next
                If resinset = True Then
                    MsgBox("Seriales almacenados correctamente")
                    Me.Close()
                End If
            Else
                MsgBox("Los seriales no coinciden con la cantidad")

            End If



        ElseIf cblote.Checked = True Then
            Dim totalcant As Integer
            totalcant = 0
            For i = 0 To dgv1.Rows.Count - 2
                totalcant = totalcant + Integer.Parse(dgv1.Rows(i).Cells("Cant").Value.ToString)
            Next
            If totalcant = lbcant.Text Then
                For i = 0 To dgv1.Rows.Count - 2

                    sql.CommandText = "INSERT INTO dbo.wms_lote (DocEntry, ItemCode, LineNum, Quantity, DistNumber)
                                VALUES (" + lbdocentry.Text + ", '" + lbitemcode.Text + "', " + lblinenum.Text + ", " + dgv1.Rows(i).Cells("Cant").Value.ToString + ", '" + dgv1.Rows(i).Cells("Lote").Value.ToString + "')"
                    resinset = util.insertarrep(sql)
                    If resinset = False Then
                        MsgBox("Error al guardar")
                    End If
                Next
                If resinset = True Then
                    MsgBox("Lotes almacenados correctamente")
                    Me.Close()
                End If
            Else
                MsgBox("Faltan lotes por ingresar")
            End If


        End If


    End Sub

    Private Sub dgv1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellEndEdit

        If e.ColumnIndex = 2 Then
            If cblote.Checked = True Then

                If lbcompuesto.Text = "Si" Then

                    dgv1.Rows(e.RowIndex).Cells("Lote").Value = dgv1.Rows(e.RowIndex).Cells("Lote").Value.ToString.Substring(lbcblong.Text, (dgv1.Rows(e.RowIndex).Cells("Lote").Value.ToString.Length - Integer.Parse(lbcblong.Text)))

                End If

            End If
        End If


    End Sub

End Class