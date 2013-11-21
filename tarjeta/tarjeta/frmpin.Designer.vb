<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpin
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
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.txtxconfirma = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Image = Global.tarjeta.My.Resources.Resources.delete1
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.Location = New System.Drawing.Point(281, 287)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Padding = New System.Windows.Forms.Padding(2)
        Me.btnsalir.Size = New System.Drawing.Size(102, 43)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(45, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 33)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nuevo Pin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpin
        '
        Me.txtpin.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpin.Location = New System.Drawing.Point(255, 110)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpin.Size = New System.Drawing.Size(207, 37)
        Me.txtpin.TabIndex = 32
        '
        'txtxconfirma
        '
        Me.txtxconfirma.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtxconfirma.Location = New System.Drawing.Point(255, 173)
        Me.txtxconfirma.Name = "txtxconfirma"
        Me.txtxconfirma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtxconfirma.Size = New System.Drawing.Size(207, 37)
        Me.txtxconfirma.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(45, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 33)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Confirmar Pin"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(148, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 33)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Cambio De Pin"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardar.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Image = Global.tarjeta.My.Resources.Resources._3floppy_guardar_el_desmantelamiento_icono_4124_32
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.Location = New System.Drawing.Point(131, 287)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Padding = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Size = New System.Drawing.Size(129, 43)
        Me.btnguardar.TabIndex = 36
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'frmpin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.tarjeta.My.Resources.Resources.FONDO1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(520, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtxconfirma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.DoubleBuffered = True
        Me.Name = "frmpin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpin As System.Windows.Forms.TextBox
    Friend WithEvents txtxconfirma As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnguardar As System.Windows.Forms.Button
End Class
