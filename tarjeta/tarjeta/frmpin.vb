Public Class frmpin

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        txtpin.Text = ""
        txtxconfirma.Text = ""
        Me.Close()
        operaciones.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtxconfirma.TextChanged

    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtpin.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        txtpin.Text = ""
        txtxconfirma.Text = ""
    End Sub
End Class