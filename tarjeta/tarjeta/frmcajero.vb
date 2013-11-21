Public Class frmcajero
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim form As New operaciones
        form.Show()
        Me.Visible = False
    End Sub
End Class