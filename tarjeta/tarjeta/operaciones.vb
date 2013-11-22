Imports Oracle.ManagedDataAccess.Client

Public Class operaciones

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click



        Me.Close()
        iniciar.Visible = True


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

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

    Private Sub lblnombre_Click(sender As Object, e As EventArgs) Handles lblnombre.Click

    End Sub

    Private Sub operaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        
        frmcajero._cmd = New OracleCommand
            frmcajero._cnnbanco.Open()
            frmcajero._cmd.CommandText = "select nombre ||' '||apellido as nombre from cliente where idcliente = " + frmcajero.idcliente
            frmcajero._cmd.Connection = frmcajero._cnnbanco
        Dim r As OracleDataReader = frmcajero._cmd.ExecuteReader()
        If r.HasRows Then

            While r.Read
                    lblnombre.Text = "Bienvenido " + r.GetString(0)

            End While
            r.Close()

        End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frmcajero._cnnbanco.Close()
        End Try

    End Sub
End Class