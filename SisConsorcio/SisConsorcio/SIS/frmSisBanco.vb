Public Class frmSisBanco

    Private Sub BANCOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BANCOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._DSConsorcio)

    End Sub

    Private Sub frmSisBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_DSConsorcio.BANCO' Puede moverla o quitarla según sea necesario.
        Me.BANCOTableAdapter.Fill(Me._DSConsorcio.BANCO)
        'TODO: esta línea de código carga datos en la tabla '_DSConsorcio.BANCO' Puede moverla o quitarla según sea necesario.
        Me.BANCOTableAdapter.Fill(Me._DSConsorcio.BANCO)

    End Sub

    Private Sub BANCOBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles BANCOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BANCOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._DSConsorcio)

    End Sub
End Class