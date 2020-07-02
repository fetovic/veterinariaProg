<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mascota
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
        Me.lblMascota = New System.Windows.Forms.Label()
        Me.btncancelarM = New System.Windows.Forms.Button()
        Me.btnaceptarM = New System.Windows.Forms.Button()
        Me.lblfechanac = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.tbxnombreM = New System.Windows.Forms.TextBox()
        Me.lblciDueño = New System.Windows.Forms.Label()
        Me.tbxciDueño = New System.Windows.Forms.TextBox()
        Me.tbxañoDeNac = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMascota
        '
        Me.lblMascota.AutoSize = True
        Me.lblMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMascota.Location = New System.Drawing.Point(287, 32)
        Me.lblMascota.Name = "lblMascota"
        Me.lblMascota.Size = New System.Drawing.Size(240, 64)
        Me.lblMascota.TabIndex = 0
        Me.lblMascota.Text = "Mascota"
        '
        'btncancelarM
        '
        Me.btncancelarM.Location = New System.Drawing.Point(110, 347)
        Me.btncancelarM.Name = "btncancelarM"
        Me.btncancelarM.Size = New System.Drawing.Size(175, 34)
        Me.btncancelarM.TabIndex = 20
        Me.btncancelarM.Text = "Cancelar"
        Me.btncancelarM.UseVisualStyleBackColor = True
        '
        'btnaceptarM
        '
        Me.btnaceptarM.Location = New System.Drawing.Point(502, 347)
        Me.btnaceptarM.Name = "btnaceptarM"
        Me.btnaceptarM.Size = New System.Drawing.Size(175, 34)
        Me.btnaceptarM.TabIndex = 19
        Me.btnaceptarM.Text = "Aceptar"
        Me.btnaceptarM.UseVisualStyleBackColor = True
        '
        'lblfechanac
        '
        Me.lblfechanac.AutoSize = True
        Me.lblfechanac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechanac.Location = New System.Drawing.Point(196, 180)
        Me.lblfechanac.Name = "lblfechanac"
        Me.lblfechanac.Size = New System.Drawing.Size(139, 20)
        Me.lblfechanac.TabIndex = 18
        Me.lblfechanac.Text = "año de nacimiento"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(196, 154)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(65, 20)
        Me.lblnombre.TabIndex = 15
        Me.lblnombre.Text = "Nombre"
        '
        'tbxnombreM
        '
        Me.tbxnombreM.Location = New System.Drawing.Point(354, 154)
        Me.tbxnombreM.Name = "tbxnombreM"
        Me.tbxnombreM.Size = New System.Drawing.Size(207, 20)
        Me.tbxnombreM.TabIndex = 11
        '
        'lblciDueño
        '
        Me.lblciDueño.AutoSize = True
        Me.lblciDueño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblciDueño.Location = New System.Drawing.Point(196, 206)
        Me.lblciDueño.Name = "lblciDueño"
        Me.lblciDueño.Size = New System.Drawing.Size(71, 20)
        Me.lblciDueño.TabIndex = 21
        Me.lblciDueño.Text = "CiDueño"
        '
        'tbxciDueño
        '
        Me.tbxciDueño.Location = New System.Drawing.Point(354, 206)
        Me.tbxciDueño.Name = "tbxciDueño"
        Me.tbxciDueño.Size = New System.Drawing.Size(207, 20)
        Me.tbxciDueño.TabIndex = 22
        '
        'tbxañoDeNac
        '
        Me.tbxañoDeNac.Location = New System.Drawing.Point(354, 180)
        Me.tbxañoDeNac.Name = "tbxañoDeNac"
        Me.tbxañoDeNac.Size = New System.Drawing.Size(207, 20)
        Me.tbxañoDeNac.TabIndex = 12
        '
        'Mascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbxciDueño)
        Me.Controls.Add(Me.lblciDueño)
        Me.Controls.Add(Me.btncancelarM)
        Me.Controls.Add(Me.btnaceptarM)
        Me.Controls.Add(Me.lblfechanac)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.tbxañoDeNac)
        Me.Controls.Add(Me.tbxnombreM)
        Me.Controls.Add(Me.lblMascota)
        Me.Name = "Mascota"
        Me.Text = "Mascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMascota As Label
    Friend WithEvents btncancelarM As Button
    Friend WithEvents btnaceptarM As Button
    Friend WithEvents lblfechanac As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents tbxnombreM As TextBox
    Friend WithEvents lblciDueño As Label
    Friend WithEvents tbxciDueño As TextBox
    Friend WithEvents tbxañoDeNac As TextBox
End Class
