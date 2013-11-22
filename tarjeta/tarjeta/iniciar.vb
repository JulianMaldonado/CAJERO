Imports Oracle.ManagedDataAccess.Client
Imports System.Security.Cryptography

Public Class iniciar

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        If txttarjeta.Text <> "" And
            txtpin.Text <> "" Then


            Try
                frmcajero._cmd = New OracleCommand
                frmcajero._cnn.Open()
                frmcajero._cmd.CommandText = "select conn, nombre FROM banco WHERE rangoi <= '" & txttarjeta.Text & "' and rangof>='" & txttarjeta.Text & "'"
                frmcajero._cmd.Connection = frmcajero._cnn
                Dim r As OracleDataReader = frmcajero._cmd.ExecuteReader()
                If r.HasRows Then
                    While r.Read
                        frmcajero._ctrbanco = r.GetString(0)
                        frmcajero._ctrnombrebanco = r.GetString(1)
                    End While
                    r.Close()


                    Dim hash As String
                    Using umgmazate As MD5 = MD5.Create()
                        hash = _ObtieneMd5Hash(umgmazate, txtpin.Text)
                    End Using
                    frmcajero._cnnbanco = New OracleConnection(frmcajero._ctrbanco)

                    frmcajero._cnnbanco.Open()

                    frmcajero._cmd = New OracleCommand()
                    frmcajero._cmd.Connection = frmcajero._cnnbanco
                    With frmcajero._cmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "AUTH_PIN"
                        .Parameters.Add(New OracleParameter("vtarjeta", OracleDbType.Int32)).Value = CInt(txttarjeta.Text)
                        .Parameters.Add(New OracleParameter("vpin", OracleDbType.Varchar2)).Value = hash.ToString
                        .Parameters.Add(New OracleParameter("vidcliente", OracleDbType.Int32, ParameterDirection.Output))
                        .Parameters.Add(New OracleParameter("vidcuenta", OracleDbType.Int32, ParameterDirection.Output))
                        .Parameters.Add(New OracleParameter("vestado", OracleDbType.Int32, ParameterDirection.Output))

                    End With
                    frmcajero._cmd.ExecuteNonQuery()



                    frmcajero.idcliente = frmcajero._cmd.Parameters("vidcliente").Value.ToString
                    frmcajero.idcuenta = frmcajero._cmd.Parameters("vidcuenta").Value.ToString

                    If frmcajero._cmd.Parameters("vestado").Value > 0 Then
                        frmcajero._cnnbanco.Close()
                        Dim form As New operaciones
                        txttarjeta.Text = ""
                        txtpin.Text = ""

                        form.Show()
                        Me.Visible = False
                        '  MsgBox(frmcajero._cmd.Parameters("vidcliente").Value.ToString)
                        '  MsgBox(frmcajero._cmd.Parameters("vidcuenta").Value.ToString)

                    Else
                        MsgBox("LA TARJETA NO EXISTE", vbCritical)
                    End If

                Else
                    Beep()
                    MsgBox("RANGO DE TARJETA INVALIDO", vbCritical)
                End If


            Catch ex As Exception

                MsgBox(ex.Message, vbCritical)
            Finally
                frmcajero._cnn.Close()
            End Try

        End If



    End Sub
End Class