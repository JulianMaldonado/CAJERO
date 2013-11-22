Imports Oracle.ManagedDataAccess.Client

Public Class frmconsultasaldo

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
        operaciones.Visible = True
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub frmconsultasaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            frmcajero._cmd = New OracleCommand
            frmcajero._cnnbanco.Open()
            frmcajero._cmd.CommandText = "SELECT CU.SALDO, CU.IDCUENTA, CL.NOMBRE, CL.APELLIDO, TIP.TIPOCUENTA FROM BANCO.CLIENTE CL INNER JOIN BANCO.CUENTA CU ON CU.IDCLIENTE = CL.IDCLIENTE INNER JOIN BANCO.TIPOCUENTA TIP ON CU.IDTIPOCUENTA = TIP.IDTIPOCUENTA WHERE CL.IDCLIENTE = " + frmcajero.idcliente + " AND cu.IDCUENTA = " + frmcajero.idcuenta + ""
            frmcajero._cmd.Connection = frmcajero._cnnbanco
            Dim r As OracleDataReader = frmcajero._cmd.ExecuteReader()
            If r.HasRows Then

                While r.Read
                    txtsaldo.Text = r.GetDecimal(0)
                    txtcuenta.Text = r.GetDecimal(1)
                    txtnombre.Text = r.GetString(2)
                    txtapellido.Text = r.GetString(3)
                    txttipo.Text = r.GetString(4)

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