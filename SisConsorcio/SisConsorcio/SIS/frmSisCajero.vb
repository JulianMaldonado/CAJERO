Public Class frmSisCajero

    Private Sub CAJEROBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CAJEROBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CAJEROBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._DSConsorcio)

    End Sub

    Private Sub frmSisCajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_DSConsorcio.CAJERO' Puede moverla o quitarla según sea necesario.
        Me.CAJEROTableAdapter.Fill(Me._DSConsorcio.CAJERO)

    End Sub
End Class