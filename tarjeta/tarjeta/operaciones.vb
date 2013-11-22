Public Class operaciones

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click



        Me.Close()
        iniciar.Visible = True


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnsaldo_Click(sender As Object, e As EventArgs) Handles btnsaldo.Click
        Me.Close()
        frmconsultasaldo.Visible = True

    End Sub

    Private Sub btnmov_Click(sender As Object, e As EventArgs) Handles btnmov.Click
        Me.Close()
        frmmov.Visible = True
    End Sub

    Private Sub btnpin_Click(sender As Object, e As EventArgs) Handles btnpin.Click
        Me.Close()
        frmpin.Visible = True
    End Sub

    Private Sub btnretiro_Click(sender As Object, e As EventArgs) Handles btnretiro.Click
        Me.Close()
        frmretiro.Visible = True
    End Sub
End Class