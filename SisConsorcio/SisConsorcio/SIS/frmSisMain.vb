Public Class frmSisMain
    Public idbanco As Decimal = 0
    Private Sub frmSisMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Enabled = False
        Dim ventana As New frmSisLogin
        ventana.MdiParent = Me
        ventana.StartPosition = FormStartPosition.CenterScreen


        ventana.Show()
    End Sub

    Private Sub BANCOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BANCOSToolStripMenuItem.Click
        Dim ventana As New frmSisBanco
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub CAJEROSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CAJEROSToolStripMenuItem.Click
        Dim ventana As New frmSisCajero
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub USUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOSToolStripMenuItem.Click
        Dim ventana As New frmSisUsuario
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

   
    Private Sub CERRARSESIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARSESIONToolStripMenuItem.Click
        BANCOSToolStripMenuItem.Enabled = False
        CAJEROSToolStripMenuItem.Enabled = False
        USUARIOSToolStripMenuItem.Enabled = False
        AUDITORIAToolStripMenuItem.Enabled = False
        CERRARSESIONToolStripMenuItem.Enabled = False


        Dim ventana As New frmSisLogin
        ventana.MdiParent = Me
        ventana.StartPosition = FormStartPosition.CenterScreen
        ventana.Show()
    End Sub

    Private Sub AUDITORIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AUDITORIAToolStripMenuItem.Click
        Dim ventana As New frmSisAuditoria
        ventana.MdiParent = Me
        ventana.StartPosition = FormStartPosition.CenterScreen
        ventana.Show()
    End Sub
End Class
