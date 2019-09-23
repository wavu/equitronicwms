Public Class Menu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Login.util.desconectar()

        Me.Close()

    End Sub

    Private Sub btentrada_Click(sender As Object, e As EventArgs) Handles btentrada.Click
        Dim entrada As New Entrada
        entrada.Show()
    End Sub

    Private Sub btentrega_Click(sender As Object, e As EventArgs) Handles btentrega.Click
        Dim entrega As New Entrega
        entrega.Show()
    End Sub

    Private Sub btconteo_Click(sender As Object, e As EventArgs) Handles btconteo.Click
        Dim conteo As New Conteo
        conteo.Show()

    End Sub


End Class
