<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class operaciones
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
        Me.btnsaldo = New System.Windows.Forms.Button()
        Me.btnmov = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnretiro = New System.Windows.Forms.Button()
        Me.btnpin = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsaldo
        '
        Me.btnsaldo.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaldo.Image = Global.tarjeta.My.Resources.Resources._next
        Me.btnsaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsaldo.Location = New System.Drawing.Point(27, 149)
        Me.btnsaldo.Name = "btnsaldo"
        Me.btnsaldo.Size = New System.Drawing.Size(279, 50)
        Me.btnsaldo.TabIndex = 0
        Me.btnsaldo.Text = "Consulta de Saldo"
        Me.btnsaldo.UseVisualStyleBackColor = True
        '
        'btnmov
        '
        Me.btnmov.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmov.Image = Global.tarjeta.My.Resources.Resources._next
        Me.btnmov.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmov.Location = New System.Drawing.Point(334, 149)
        Me.btnmov.Name = "btnmov"
        Me.btnmov.Size = New System.Drawing.Size(278, 50)
        Me.btnmov.TabIndex = 1
        Me.btnmov.Text = "Ultimos Movimientos"
        Me.btnmov.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Image = Global.tarjeta.My.Resources.Resources.delete1
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.Location = New System.Drawing.Point(234, 366)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Padding = New System.Windows.Forms.Padding(2)
        Me.btnsalir.Size = New System.Drawing.Size(182, 43)
        Me.btnsalir.TabIndex = 2
        Me.btnsalir.Text = "Cerrar Sesión"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnretiro
        '
        Me.btnretiro.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnretiro.Image = Global.tarjeta.My.Resources.Resources._next
        Me.btnretiro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnretiro.Location = New System.Drawing.Point(27, 252)
        Me.btnretiro.Name = "btnretiro"
        Me.btnretiro.Size = New System.Drawing.Size(279, 50)
        Me.btnretiro.TabIndex = 3
        Me.btnretiro.Text = "Retiro Efectivo"
        Me.btnretiro.UseVisualStyleBackColor = True
        '
        'btnpin
        '
        Me.btnpin.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpin.Image = Global.tarjeta.My.Resources.Resources._next
        Me.btnpin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnpin.Location = New System.Drawing.Point(334, 252)
        Me.btnpin.Name = "btnpin"
        Me.btnpin.Size = New System.Drawing.Size(278, 50)
        Me.btnpin.TabIndex = 4
        Me.btnpin.Text = "Cambiar Pin"
        Me.btnpin.UseVisualStyleBackColor = True
        '
        'lblnombre
        '
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblnombre.Location = New System.Drawing.Point(72, 24)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(487, 66)
        Me.lblnombre.TabIndex = 6
        Me.lblnombre.Text = "Bienvenido"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(156, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Seleccione Operación"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'operaciones
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.tarjeta.My.Resources.Resources.FONDO1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.btnpin)
        Me.Controls.Add(Me.btnretiro)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnmov)
        Me.Controls.Add(Me.btnsaldo)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "operaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsaldo As System.Windows.Forms.Button
    Friend WithEvents btnmov As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnretiro As System.Windows.Forms.Button
    Friend WithEvents btnpin As System.Windows.Forms.Button
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
