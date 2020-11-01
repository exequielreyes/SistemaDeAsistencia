<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFoto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFoto))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardarFotoArchivo = New System.Windows.Forms.Button()
        Me.cmdcamara = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdCapturar = New System.Windows.Forms.Button()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 187
        Me.Label4.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(12, 253)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(327, 20)
        Me.txtNombre.TabIndex = 186
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(125, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 188
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGuardarFotoArchivo
        '
        Me.btnGuardarFotoArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarFotoArchivo.Image = CType(resources.GetObject("btnGuardarFotoArchivo.Image"), System.Drawing.Image)
        Me.btnGuardarFotoArchivo.Location = New System.Drawing.Point(198, 357)
        Me.btnGuardarFotoArchivo.Name = "btnGuardarFotoArchivo"
        Me.btnGuardarFotoArchivo.Size = New System.Drawing.Size(141, 31)
        Me.btnGuardarFotoArchivo.TabIndex = 185
        Me.btnGuardarFotoArchivo.Text = "Guardar en archivo"
        Me.btnGuardarFotoArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarFotoArchivo.UseVisualStyleBackColor = True
        '
        'cmdcamara
        '
        Me.cmdcamara.Image = CType(resources.GetObject("cmdcamara.Image"), System.Drawing.Image)
        Me.cmdcamara.Location = New System.Drawing.Point(12, 279)
        Me.cmdcamara.Name = "cmdcamara"
        Me.cmdcamara.Size = New System.Drawing.Size(107, 31)
        Me.cmdcamara.TabIndex = 182
        Me.cmdcamara.Text = "Camara"
        Me.cmdcamara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdcamara.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(246, 279)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(93, 31)
        Me.cmdBorrar.TabIndex = 184
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdCapturar
        '
        Me.cmdCapturar.Image = CType(resources.GetObject("cmdCapturar.Image"), System.Drawing.Image)
        Me.cmdCapturar.Location = New System.Drawing.Point(125, 279)
        Me.cmdCapturar.Name = "cmdCapturar"
        Me.cmdCapturar.Size = New System.Drawing.Size(115, 31)
        Me.cmdCapturar.TabIndex = 183
        Me.cmdCapturar.Text = "Capturar"
        Me.cmdCapturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCapturar.UseVisualStyleBackColor = True
        '
        'pbFoto
        '
        Me.pbFoto.Location = New System.Drawing.Point(16, 12)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(304, 209)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 6
        Me.pbFoto.TabStop = False
        '
        'FormFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 400)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnGuardarFotoArchivo)
        Me.Controls.Add(Me.cmdcamara)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdCapturar)
        Me.Controls.Add(Me.pbFoto)
        Me.Name = "FormFoto"
        Me.Text = "FormFoto"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnGuardarFotoArchivo As Button
    Friend WithEvents cmdcamara As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmdCapturar As Button
    Friend WithEvents Button1 As Button
End Class
