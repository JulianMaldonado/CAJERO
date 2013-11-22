Imports System.Configuration
Imports Oracle.ManagedDataAccess.Client
Imports System.Security.Cryptography

Public Class frmSisUsuario
    Dim _strcnn As String = ConfigurationManager.ConnectionStrings("SisConsorcio.My.MySettings.cnnStrSisConsorcio").ConnectionString
    Dim _cnn As New OracleConnection(_strcnn)
    ' Public _cnn As New OracleConnection
    Dim _cmd As New OracleCommand
    Private Sub btCrear_Click(sender As Object, e As EventArgs) Handles btCrear.Click
        If txUsuario.Text = "" Or txPass.Text = "" Then
            MsgBox("Los campos no pueden estar vacios")
        Else
            Dim passH, query As String
            Using umgmazate As MD5 = MD5.Create()
                passH = _ObtieneMd5Hash(umgmazate, txPass.Text)
            End Using

            query = "insert into usuario(id, usuario, pass, idbanco) values(seq_idusuario.nextval,'" & txUsuario.Text & "', '" & passH & "','" & cbBanco.SelectedValue & "')"
            Try
                _cnn.Open()
                _cmd = New OracleCommand
                _cmd.CommandText = query
                _cmd.Connection = _cnn
                _cmd.ExecuteNonQuery()

                txUsuario.Text = ""
                txPass.Text = ""
                MsgBox("Usuario Creado", vbInformation)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                _cnn.Close()
            End Try


        End If



    End Sub
    Public Sub _LLENAR_CMB(ByVal sql As String, ByRef _cmb As ComboBox)
        Dim Dt As DataTable
        Dim Da As New OracleDataAdapter
        With _cmd
            .CommandType = CommandType.Text
            .CommandText = sql
            .Connection = _cnn
        End With
        Da.SelectCommand = _cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With _cmb
            .DataSource = Dt
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
    End Sub
    Private Sub frmSisUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmSisMain.idbanco > 0 Then
            _LLENAR_CMB("SELECT idbanco as id, nombre||' - '||direccion as nombre from banco where idbanco = " & frmSisMain.idbanco, cbBanco)
        Else
            _LLENAR_CMB("SELECT idbanco as id, nombre||' - '||direccion as nombre from banco", cbBanco)
        End If

    End Sub
End Class