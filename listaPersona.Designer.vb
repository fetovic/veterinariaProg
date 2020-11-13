<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaPersona
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
        Me.lvListarPersona = New System.Windows.Forms.ListView()
        Me.Ci = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Direccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblListarPersona = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lvTelefono = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnModificarM = New System.Windows.Forms.Button()
        Me.btnEliminarM = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvListarPersona
        '
        Me.lvListarPersona.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Ci, Me.Nombre, Me.Direccion})
        Me.lvListarPersona.FullRowSelect = True
        Me.lvListarPersona.HideSelection = False
        Me.lvListarPersona.Location = New System.Drawing.Point(28, 92)
        Me.lvListarPersona.Name = "lvListarPersona"
        Me.lvListarPersona.ShowItemToolTips = True
        Me.lvListarPersona.Size = New System.Drawing.Size(483, 211)
        Me.lvListarPersona.TabIndex = 0
        Me.lvListarPersona.UseCompatibleStateImageBehavior = False
        Me.lvListarPersona.View = System.Windows.Forms.View.Details
        '
        'Ci
        '
        Me.Ci.Text = "CI"
        Me.Ci.Width = 107
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 87
        '
        'Direccion
        '
        Me.Direccion.Text = "Direccion"
        Me.Direccion.Width = 137
        '
        'lblListarPersona
        '
        Me.lblListarPersona.AutoSize = True
        Me.lblListarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListarPersona.Location = New System.Drawing.Point(211, 24)
        Me.lblListarPersona.Name = "lblListarPersona"
        Me.lblListarPersona.Size = New System.Drawing.Size(477, 39)
        Me.lblListarPersona.TabIndex = 1
        Me.lblListarPersona.Text = "Lista de personas y mascotas"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(70, 358)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(137, 50)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar Persona"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lvTelefono
        '
        Me.lvTelefono.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvTelefono.FullRowSelect = True
        Me.lvTelefono.HideSelection = False
        Me.lvTelefono.Location = New System.Drawing.Point(517, 92)
        Me.lvTelefono.Name = "lvTelefono"
        Me.lvTelefono.Size = New System.Drawing.Size(271, 211)
        Me.lvTelefono.TabIndex = 3
        Me.lvTelefono.UseCompatibleStateImageBehavior = False
        Me.lvTelefono.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "nombre"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "añonacimiento"
        '
        'btnModificarM
        '
        Me.btnModificarM.Location = New System.Drawing.Point(651, 358)
        Me.btnModificarM.Name = "btnModificarM"
        Me.btnModificarM.Size = New System.Drawing.Size(137, 50)
        Me.btnModificarM.TabIndex = 7
        Me.btnModificarM.Text = "Modificar Mascota"
        Me.btnModificarM.UseVisualStyleBackColor = True
        '
        'btnEliminarM
        '
        Me.btnEliminarM.Location = New System.Drawing.Point(473, 358)
        Me.btnEliminarM.Name = "btnEliminarM"
        Me.btnEliminarM.Size = New System.Drawing.Size(137, 50)
        Me.btnEliminarM.TabIndex = 8
        Me.btnEliminarM.Text = "Eliminar Mascota"
        Me.btnEliminarM.UseVisualStyleBackColor = True
        '
        'listaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEliminarM)
        Me.Controls.Add(Me.btnModificarM)
        Me.Controls.Add(Me.lvTelefono)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblListarPersona)
        Me.Controls.Add(Me.lvListarPersona)
        Me.Name = "listaPersona"
        Me.Text = "listaPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvListarPersona As ListView
    Friend WithEvents lblListarPersona As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Ci As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Direccion As ColumnHeader
    Friend WithEvents lvTelefono As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnModificarM As Button
    Friend WithEvents btnEliminarM As Button
End Class
