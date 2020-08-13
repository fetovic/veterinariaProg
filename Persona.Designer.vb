<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Persona
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxci = New System.Windows.Forms.TextBox()
        Me.tbxnombre = New System.Windows.Forms.TextBox()
        Me.tbxtelefono = New System.Windows.Forms.TextBox()
        Me.tbxdireccion = New System.Windows.Forms.TextBox()
        Me.lblci = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnaceptarP = New System.Windows.Forms.Button()
        Me.btncancelarp = New System.Windows.Forms.Button()
        Me.lblfin = New System.Windows.Forms.Label()
        Me.lVTelefonos = New System.Windows.Forms.ListView()
        Me.BtnTelefono = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Persona"
        '
        'tbxci
        '
        Me.tbxci.Location = New System.Drawing.Point(370, 151)
        Me.tbxci.Name = "tbxci"
        Me.tbxci.Size = New System.Drawing.Size(207, 20)
        Me.tbxci.TabIndex = 1
        '
        'tbxnombre
        '
        Me.tbxnombre.Location = New System.Drawing.Point(370, 177)
        Me.tbxnombre.Name = "tbxnombre"
        Me.tbxnombre.Size = New System.Drawing.Size(207, 20)
        Me.tbxnombre.TabIndex = 2
        '
        'tbxtelefono
        '
        Me.tbxtelefono.Location = New System.Drawing.Point(370, 203)
        Me.tbxtelefono.Name = "tbxtelefono"
        Me.tbxtelefono.Size = New System.Drawing.Size(207, 20)
        Me.tbxtelefono.TabIndex = 3
        '
        'tbxdireccion
        '
        Me.tbxdireccion.Location = New System.Drawing.Point(370, 229)
        Me.tbxdireccion.Name = "tbxdireccion"
        Me.tbxdireccion.Size = New System.Drawing.Size(207, 20)
        Me.tbxdireccion.TabIndex = 4
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblci.Location = New System.Drawing.Point(287, 151)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(25, 20)
        Me.lblci.TabIndex = 5
        Me.lblci.Text = "CI"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(287, 227)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(75, 20)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Direccion"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(287, 201)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefono.TabIndex = 7
        Me.lblTelefono.Text = "Telefono"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(287, 177)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(65, 20)
        Me.lblnombre.TabIndex = 8
        Me.lblnombre.Text = "Nombre"
        '
        'btnaceptarP
        '
        Me.btnaceptarP.Location = New System.Drawing.Point(518, 344)
        Me.btnaceptarP.Name = "btnaceptarP"
        Me.btnaceptarP.Size = New System.Drawing.Size(175, 34)
        Me.btnaceptarP.TabIndex = 9
        Me.btnaceptarP.Text = "Aceptar"
        Me.btnaceptarP.UseVisualStyleBackColor = True
        '
        'btncancelarp
        '
        Me.btncancelarp.Location = New System.Drawing.Point(126, 344)
        Me.btncancelarp.Name = "btncancelarp"
        Me.btncancelarp.Size = New System.Drawing.Size(175, 34)
        Me.btncancelarp.TabIndex = 10
        Me.btncancelarp.Text = "Cancelar"
        Me.btncancelarp.UseVisualStyleBackColor = True
        '
        'lblfin
        '
        Me.lblfin.AutoSize = True
        Me.lblfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfin.Location = New System.Drawing.Point(109, 121)
        Me.lblfin.Name = "lblfin"
        Me.lblfin.Size = New System.Drawing.Size(25, 20)
        Me.lblfin.TabIndex = 14
        Me.lblfin.Text = "CI"
        '
        'lVTelefonos
        '
        Me.lVTelefonos.HideSelection = False
        Me.lVTelefonos.Location = New System.Drawing.Point(12, 152)
        Me.lVTelefonos.Name = "lVTelefonos"
        Me.lVTelefonos.Size = New System.Drawing.Size(195, 138)
        Me.lVTelefonos.TabIndex = 15
        Me.lVTelefonos.UseCompatibleStateImageBehavior = False
        Me.lVTelefonos.View = System.Windows.Forms.View.List
        '
        'BtnTelefono
        '
        Me.BtnTelefono.Location = New System.Drawing.Point(225, 224)
        Me.BtnTelefono.Name = "BtnTelefono"
        Me.BtnTelefono.Size = New System.Drawing.Size(56, 23)
        Me.BtnTelefono.TabIndex = 16
        Me.BtnTelefono.Text = "btnTelefono"
        Me.BtnTelefono.UseVisualStyleBackColor = True
        '
        'Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 469)
        Me.Controls.Add(Me.BtnTelefono)
        Me.Controls.Add(Me.lVTelefonos)
        Me.Controls.Add(Me.lblfin)
        Me.Controls.Add(Me.btncancelarp)
        Me.Controls.Add(Me.btnaceptarP)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblci)
        Me.Controls.Add(Me.tbxdireccion)
        Me.Controls.Add(Me.tbxtelefono)
        Me.Controls.Add(Me.tbxnombre)
        Me.Controls.Add(Me.tbxci)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Persona"
        Me.Text = "Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbxci As TextBox
    Friend WithEvents tbxnombre As TextBox
    Friend WithEvents tbxtelefono As TextBox
    Friend WithEvents tbxdireccion As TextBox
    Friend WithEvents lblci As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents btnaceptarP As Button
    Friend WithEvents btncancelarp As Button
    Friend WithEvents lblfin As Label
    Friend WithEvents lVTelefonos As ListView
    Friend WithEvents BtnTelefono As Button
End Class
