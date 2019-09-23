

Public Class Login
    Public util As New utilidades
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        Me.Close()

    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        util.conectar(txusuario.Text, txpassword.Text)
        If util.oCompany.Connected = True Then
            Dim menu As New Menu
            Me.Hide()
            menu.Show()
        End If
    End Sub

    Private Sub txusuario_Leave(sender As Object, e As EventArgs) Handles txusuario.Leave
        txusuario.BackColor = Color.White
        Dim objFont As System.Drawing.Font
        objFont = New System.Drawing.Font("Tahoma", 20, FontStyle.Regular)
        txusuario.Font = objFont
        txusuario.ForeColor = Color.Black
    End Sub

    Private Sub txusuario_Enter(sender As Object, e As EventArgs) Handles txusuario.Enter
        txusuario.BackColor = Color.Aqua
        Dim objFont As System.Drawing.Font
        objFont = New System.Drawing.Font("Tahoma", 20, FontStyle.Bold)
        txusuario.Font = objFont
        txusuario.ForeColor = Color.Blue
    End Sub

    Private Sub txpassword_Enter(sender As Object, e As EventArgs) Handles txpassword.Enter
        txpassword.BackColor = Color.Aqua
        Dim objFont As System.Drawing.Font
        objFont = New System.Drawing.Font("Tahoma", 20, FontStyle.Bold)
        txpassword.Font = objFont
        txpassword.ForeColor = Color.Blue
    End Sub

    Private Sub txpassword_Leave(sender As Object, e As EventArgs) Handles txpassword.Leave
        txpassword.BackColor = Color.White
        Dim objFont As System.Drawing.Font
        objFont = New System.Drawing.Font("Tahoma", 20, FontStyle.Regular)
        txpassword.Font = objFont
        txpassword.ForeColor = Color.Black
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
    End Sub
End Class