Imports System.Data
Imports System.Data.SqlClient

Public Class Entrada
    Dim sql As New SqlCommand
    Dim ds As DataSet
    Public util As New utilidades
    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        sql.CommandText = "SELECT DocNum, DocDate, CardName, 'Pedido' AS TipoDoc  FROM opor WHERE DocStatus = 'O' " &
                            "Union " &
                            "SELECT DocNum, DocDate, CardName, 'Factura' AS TipoDoc FROM OPCH WHERE DocStatus = 'O' AND DocType = 'I'"
        ds = util.consultar(sql)
        dgv1.DataSource = ds.Tables(0)

    End Sub

    Private Sub txbuscar_TextChanged(sender As Object, e As EventArgs) Handles txbuscar.TextChanged
        Dim filtro As String
        If cbbusqueda.Text = "Proveedor" Then
            filtro = " and CardName like '%" + txbuscar.Text + "%'"
        End If
        If cbbusqueda.Text = "Numero" Then
            filtro = " and DocNum like '%" + txbuscar.Text + "%'"
        End If
        If cbbusqueda.Text = "Fecha" Then
            filtro = " and DocDate like '%" + txbuscar.Text + "%'"
        End If
        sql.CommandText = "SELECT DocNum, DocDate, CardName, 'Pedido' AS TipoDoc  FROM opor WHERE DocStatus = 'O' " + filtro + "" &
                    "Union " &
                    "SELECT DocNum, DocDate, CardName, 'Factura' AS TipoDoc FROM OPCH WHERE DocStatus = 'O' AND DocType = 'I' " + filtro + ""
        ds = util.consultar(sql)
        dgv1.DataSource = ds.Tables(0)
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Dim entradadoc As New EntradaDoc
        If e.ColumnIndex = 0 Then
            entradadoc.lbnumero.Text = dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
            entradadoc.lbtipodoc.Text = dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value.ToString
            entradadoc.Show()
        End If

    End Sub

    Private Sub txbuscar_Leave(sender As Object, e As EventArgs) Handles txbuscar.Leave
        txbuscar.BackColor = Color.White
        Dim objFont As System.Drawing.Font
        objFont = New System.Drawing.Font("Tahoma", 8, FontStyle.Regular)
        txbuscar.Font = objFont
        txbuscar.ForeColor = Color.Black
    End Sub

    Private Sub txbuscar_Enter(sender As Object, e As EventArgs) Handles txbuscar.Enter
        txbuscar.BackColor = Color.Aqua
        Dim objFont As System.Drawing.Font
        objFont = New System.Drawing.Font("Tahoma", 8, FontStyle.Bold)
        txbuscar.Font = objFont
        txbuscar.ForeColor = Color.Blue
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class