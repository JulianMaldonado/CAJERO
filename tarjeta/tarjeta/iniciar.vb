Public Class iniciar

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btningresar.Click

        Dim form As New operaciones
        txttarjeta.Text = ""
        txtpin.Text = ""

        form.Show()
        Me.Visible = False


    End Sub
End Class