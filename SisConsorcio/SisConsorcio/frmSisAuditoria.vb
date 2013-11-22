Imports Oracle.ManagedDataAccess.Client
Imports System.Configuration

Public Class frmSisAuditoria

    Dim bs As New BindingSource
    Dim _strcnn As String = ConfigurationManager.ConnectionStrings("SisConsorcio.My.MySettings.cnnStrSisConsorcio").ConnectionString
    Dim _cnn As New OracleConnection(_strcnn)
    ' Public _cnn As New OracleConnection
    Dim _cmd As New OracleCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btTransmitir.Click
        setBSProducto(dg)
        dg.Refresh()
    End Sub

    Sub setBSProducto(ByRef dg As DataGridView)
        Dim query As String

        If frmSisMain.idbanco > 0 Then

            query = "SELECT TR.FECHA, BA.NOMBRE AS BANCO, CA.NOMBRE || ' ' || CA.DIRECCION AS CAJERO, TR.IDTRANSACCION AS TRANSACCION, TR.NOTARJETA AS TARJETA, TI.DETALLE, TR.MONTO FROM TRANSACCION TR INNER JOIN TIPO TI ON TI.IDTIPO = TR.TIPO INNER JOIN CAJERO CA ON TR.IDCAJERO = CA.IDCAJERO INNER JOIN BANCO BA ON TR.IDBANCO = BA.IDBANCO WHERE  (TR.FECHA BETWEEN '" & dti.Value.ToShortDateString & "' AND '" & dtf.Value.ToShortDateString & "') and BA.IDBANCO = " & frmSisMain.idbanco
        Else
            query = "SELECT TR.FECHA, BA.NOMBRE AS BANCO, CA.NOMBRE || ' ' || CA.DIRECCION AS CAJERO, TR.IDTRANSACCION AS TRANSACCION, TR.NOTARJETA AS TARJETA, TI.DETALLE, TR.MONTO FROM TRANSACCION TR INNER JOIN TIPO TI ON TI.IDTIPO = TR.TIPO INNER JOIN CAJERO CA ON TR.IDCAJERO = CA.IDCAJERO INNER JOIN BANCO BA ON TR.IDBANCO = BA.IDBANCO WHERE TR.FECHA BETWEEN '" & dti.Value.ToShortDateString & "' AND '" & dtf.Value.ToShortDateString & "'"
        End If
        _cnn.Open()
        Dim dt = New DataTable
        Dim da = New OracleDataAdapter(query, _cnn)
        da.Fill(dt)
        bs.DataSource = dt
        dg.DataSource = bs.DataSource

        _cnn.Close()

    End Sub

    Private Sub dtf_ValueChanged(sender As Object, e As EventArgs) Handles dtf.ValueChanged
        If dti.Value > dtf.Value Then
            MsgBox("Rango de fechas invalido", vbCritical)
            dtf.Value = dti.Value
            dtf.Focus()
        End If
    End Sub
End Class