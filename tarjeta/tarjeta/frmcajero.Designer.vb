<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcajero
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodcajero = New System.Windows.Forms.TextBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(124, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 33)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Código  Cajero"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcodcajero
        '
        Me.txtcodcajero.Font = New System.Drawing.Font("Bauhaus 93", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcajero.Location = New System.Drawing.Point(199, 155)
        Me.txtcodcajero.Name = "txtcodcajero"
        Me.txtcodcajero.Size = New System.Drawing.Size(83, 66)
        Me.txtcodcajero.TabIndex = 37
        Me.txtcodcajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btningresar
        '
        Me.btningresar.BackColor = System.Drawing.Color.Transparent
        Me.btningresar.Image = Global.tarjeta.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btningresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btningresar.Location = New System.Drawing.Point(199, 244)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 66)
        Me.btningresar.TabIndex = 38
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btningresar.UseVisualStyleBackColor = False
        '
        'frmcajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.tarjeta.My.Resources.Resources.FONDO1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(475, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtcodcajero)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Name = "frmcajero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodcajero As System.Windows.Forms.TextBox
    Friend WithEvents btningresar As System.Windows.Forms.Button
End Class
