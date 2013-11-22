Imports System.Security.Cryptography
Imports System.Configuration
Imports Oracle.ManagedDataAccess.Client

Public Class frmSisLogin
    Dim _strcnn As String = ConfigurationManager.ConnectionStrings("SisConsorcio.My.MySettings.cnnStrSisConsorcio").ConnectionString
    Dim _cnn As New OracleConnection(_strcnn)
    ' Public _cnn As New OracleConnection
    Dim _cmd As New OracleCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txU.Text = "admin" And txP.Text = "admin" Then
            frmSisMain.BANCOSToolStripMenuItem.Enabled = True
            frmSisMain.CAJEROSToolStripMenuItem.Enabled = True
            frmSisMain.USUARIOSToolStripMenuItem.Enabled = True
            frmSisMain.AUDITORIAToolStripMenuItem.Enabled = True
            frmSisMain.CERRARSESIONToolStripMenuItem.Enabled = True


            frmSisMain.MenuStrip1.Enabled = True
            Me.Dispose()
        ElseIf txU.Text <> "" And txP.Text <> "" Then
            Dim query
            Using md5Hash As MD5 = MD5.Create()
                Dim hash As String = _ObtieneMd5Hash(md5Hash, txP.Text)
                query = "SElect idbanco from usuario where usuario = '" & txU.Text & "' AND pass = '" & hash & "'"
            End Using
            'MsgBox(query)
            Try
                _cmd = New OracleCommand
                _cnn.Open()
                _cmd.CommandText = query
                _cmd.Connection = _cnn
                Dim r As OracleDataReader = _cmd.ExecuteReader()
                If r.HasRows Then
                    While r.Read
                        frmSisMain.idbanco = r.GetDecimal(0)
                    End While
                    r.Close()


                    frmSisMain.BANCOSToolStripMenuItem.Enabled = False
                    frmSisMain.CAJEROSToolStripMenuItem.Enabled = False
                    frmSisMain.USUARIOSToolStripMenuItem.Enabled = True
                    frmSisMain.AUDITORIAToolStripMenuItem.Enabled = True
                    frmSisMain.CERRARSESIONToolStripMenuItem.Enabled = True
                    frmSisMain.MenuStrip1.Enabled = True

                    Me.Dispose()
                Else
                    Beep()
                    MsgBox("Combinacion de usuario y contraseña incorrecta.... ", vbCritical)
                End If



            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                _cnn.Close()
            End Try

        Else
            MsgBox("Datos invalidos", vbCritical)
            txP.Focus()

        End If
    End Sub
End Class