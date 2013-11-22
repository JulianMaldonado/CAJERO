Imports System.Security.Cryptography
Imports System.Configuration
Imports Oracle.ManagedDataAccess.Client




Public Class frmcajero
    Public _strcnn As String = "DATA SOURCE=localhost; PASSWORD=CONSORCIO; USER ID=CONSORCIO"
    '"DATA SOURCE=192.168.1.8:1521/XE; PASSWORD=consorcio; USER ID=CONSORCIO"
    Public _cnn As New OracleConnection(_strcnn)
    ' Public _cnn As New OracleConnection
    Public _cmd As New OracleCommand

    Public idcajero As Decimal


    Public pin As String
    Public nombre As String = ""
    Public cuenta As String = ""
    Public idcliente As String = ""
    Public idcuenta As String = ""
    Public estado As String = ""



    Public _ctrbanco As String = ""
    Public _ctrnombrebanco As String = ""
    Public _cnnbanco As New OracleConnection(_ctrbanco)




    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        If txtcodcajero.Text <> "" Then
            Try
                _cmd = New OracleCommand
                _cnn.Open()
                _cmd.CommandText = "select idcajero from cajero where idcajero=" & txtcodcajero.Text
                _cmd.Connection = _cnn
                Dim r As OracleDataReader = _cmd.ExecuteReader()
                If r.HasRows Then
                    While r.Read
                        idcajero = r.GetDecimal(0)
                    End While
                    r.Close()

                    Dim form As New iniciar
                    form.Show()
                    Me.Visible = False


                Else
                    Beep()
                    MsgBox("EL CAJERO NO EXISTE")
                End If


            Catch ex As Exception

                MsgBox(ex.Message, vbCritical)
            Finally
                _cnn.Close()
            End Try

        End If



       
    End Sub
End Class