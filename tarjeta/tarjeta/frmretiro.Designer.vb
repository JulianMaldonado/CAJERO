<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmretiro
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btn300 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn2000 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(240, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 33)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Retiro de Efectivo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcuenta
        '
        Me.txtcuenta.Enabled = False
        Me.txtcuenta.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcuenta.Location = New System.Drawing.Point(248, 148)
        Me.txtcuenta.Name = "txtcuenta"
        Me.txtcuenta.Size = New System.Drawing.Size(374, 37)
        Me.txtcuenta.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(188, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 33)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "No."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(194, 89)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(428, 37)
        Me.txtnombre.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(70, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 33)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Cuenta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(70, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 33)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(160, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 33)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Seleccione Monto a Retirar"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn100
        '
        Me.btn100.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.Location = New System.Drawing.Point(109, 252)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(130, 42)
        Me.btn100.TabIndex = 35
        Me.btn100.Text = "Q. 100.00"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btn200
        '
        Me.btn200.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200.Location = New System.Drawing.Point(109, 319)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(130, 42)
        Me.btn200.TabIndex = 36
        Me.btn200.Text = "Q. 200.00"
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btn300
        '
        Me.btn300.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn300.Location = New System.Drawing.Point(282, 252)
        Me.btn300.Name = "btn300"
        Me.btn300.Size = New System.Drawing.Size(130, 42)
        Me.btn300.TabIndex = 37
        Me.btn300.Text = "Q. 300.00"
        Me.btn300.UseVisualStyleBackColor = True
        '
        'btn500
        '
        Me.btn500.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn500.Location = New System.Drawing.Point(282, 319)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(130, 42)
        Me.btn500.TabIndex = 38
        Me.btn500.Text = "Q. 500.00"
        Me.btn500.UseVisualStyleBackColor = True
        '
        'btn1000
        '
        Me.btn1000.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000.Location = New System.Drawing.Point(453, 252)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(130, 42)
        Me.btn1000.TabIndex = 39
        Me.btn1000.Text = "Q. 1000.00"
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn2000
        '
        Me.btn2000.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2000.Location = New System.Drawing.Point(453, 319)
        Me.btn2000.Name = "btn2000"
        Me.btn2000.Size = New System.Drawing.Size(130, 42)
        Me.btn2000.TabIndex = 40
        Me.btn2000.Text = "Q. 2000.00"
        Me.btn2000.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(109, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 37)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Monto Variable"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtmonto
        '
        Me.txtmonto.Enabled = False
        Me.txtmonto.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.Location = New System.Drawing.Point(351, 389)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(134, 37)
        Me.txtmonto.TabIndex = 42
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(257, 475)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 44)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Confirma Retiro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Image = Global.tarjeta.My.Resources.Resources.Icono_escoba
        Me.btnlimpiar.Location = New System.Drawing.Point(519, 381)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(64, 52)
        Me.btnlimpiar.TabIndex = 44
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(304, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 33)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Q."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmretiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.tarjeta.My.Resources.Resources.FONDO1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(706, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn2000)
        Me.Controls.Add(Me.btn1000)
        Me.Controls.Add(Me.btn500)
        Me.Controls.Add(Me.btn300)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcuenta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.DoubleBuffered = True
        Me.Name = "frmretiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn100 As System.Windows.Forms.Button
    Friend WithEvents btn200 As System.Windows.Forms.Button
    Friend WithEvents btn300 As System.Windows.Forms.Button
    Friend WithEvents btn500 As System.Windows.Forms.Button
    Friend WithEvents btn1000 As System.Windows.Forms.Button
    Friend WithEvents btn2000 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
