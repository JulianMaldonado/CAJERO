Public Class frmretiro


    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True


        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtmonto.TextChanged

    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        txtmonto.Text = "100.00"
        txtmonto.Enabled = False


    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
        txtmonto.Text = "200.00"
        txtmonto.Enabled = False
    End Sub

    Private Sub btn300_Click(sender As Object, e As EventArgs) Handles btn300.Click
        txtmonto.Text = "300.00"
        txtmonto.Enabled = False
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        txtmonto.Text = "500.00"
        txtmonto.Enabled = False
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        txtmonto.Text = "1000.00"
        txtmonto.Enabled = False
    End Sub

    Private Sub btn2000_Click(sender As Object, e As EventArgs) Handles btn2000.Click
        txtmonto.Text = "2000.00"
        txtmonto.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtmonto.Text = ""
        txtmonto.Enabled = True

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtmonto.Text = "0.00"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '  MsgBox("RETIRO REALIZADO")
        Me.Close()
        operaciones.Visible = True

    End Sub
End Class