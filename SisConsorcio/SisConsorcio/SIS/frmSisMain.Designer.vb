<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSisMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BANCOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CAJEROSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AUDITORIAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARSESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BANCOSToolStripMenuItem, Me.CAJEROSToolStripMenuItem, Me.USUARIOSToolStripMenuItem, Me.AUDITORIAToolStripMenuItem, Me.CERRARSESIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BANCOSToolStripMenuItem
        '
        Me.BANCOSToolStripMenuItem.Image = Global.SisConsorcio.My.Resources.Resources.Building
        Me.BANCOSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BANCOSToolStripMenuItem.Name = "BANCOSToolStripMenuItem"
        Me.BANCOSToolStripMenuItem.Size = New System.Drawing.Size(98, 36)
        Me.BANCOSToolStripMenuItem.Text = "BANCOS"
        '
        'CAJEROSToolStripMenuItem
        '
        Me.CAJEROSToolStripMenuItem.Image = Global.SisConsorcio.My.Resources.Resources.Atm
        Me.CAJEROSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CAJEROSToolStripMenuItem.Name = "CAJEROSToolStripMenuItem"
        Me.CAJEROSToolStripMenuItem.Size = New System.Drawing.Size(99, 36)
        Me.CAJEROSToolStripMenuItem.Text = "CAJEROS"
        '
        'USUARIOSToolStripMenuItem
        '
        Me.USUARIOSToolStripMenuItem.Image = Global.SisConsorcio.My.Resources.Resources.User
        Me.USUARIOSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.USUARIOSToolStripMenuItem.Name = "USUARIOSToolStripMenuItem"
        Me.USUARIOSToolStripMenuItem.Size = New System.Drawing.Size(106, 36)
        Me.USUARIOSToolStripMenuItem.Text = "USUARIOS"
        '
        'AUDITORIAToolStripMenuItem
        '
        Me.AUDITORIAToolStripMenuItem.Image = Global.SisConsorcio.My.Resources.Resources.Transmit_Blue
        Me.AUDITORIAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AUDITORIAToolStripMenuItem.Name = "AUDITORIAToolStripMenuItem"
        Me.AUDITORIAToolStripMenuItem.Size = New System.Drawing.Size(112, 36)
        Me.AUDITORIAToolStripMenuItem.Text = "AUDITORIA"
        '
        'CERRARSESIONToolStripMenuItem
        '
        Me.CERRARSESIONToolStripMenuItem.Image = Global.SisConsorcio.My.Resources.Resources.Cross
        Me.CERRARSESIONToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CERRARSESIONToolStripMenuItem.Name = "CERRARSESIONToolStripMenuItem"
        Me.CERRARSESIONToolStripMenuItem.Size = New System.Drawing.Size(136, 36)
        Me.CERRARSESIONToolStripMenuItem.Text = "CERRAR SESION"
        '
        'frmSisMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 366)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSisMain"
        Me.Text = "SISTEMA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BANCOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USUARIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAJEROSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AUDITORIAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CERRARSESIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
