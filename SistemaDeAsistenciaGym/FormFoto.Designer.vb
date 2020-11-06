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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 187
        Me.Label4.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(18, 282)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(327, 20)
        Me.txtNombre.TabIndex = 186
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 188
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGuardarFotoArchivo
        '
        Me.btnGuardarFotoArchivo.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnGuardarFotoArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarFotoArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarFotoArchivo.Image = CType(resources.GetObject("btnGuardarFotoArchivo.Image"), System.Drawing.Image)
        Me.btnGuardarFotoArchivo.Location = New System.Drawing.Point(199, 386)
        Me.btnGuardarFotoArchivo.Name = "btnGuardarFotoArchivo"
        Me.btnGuardarFotoArchivo.Size = New System.Drawing.Size(146, 31)
        Me.btnGuardarFotoArchivo.TabIndex = 185
        Me.btnGuardarFotoArchivo.Text = "Guardar en archivo"
        Me.btnGuardarFotoArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarFotoArchivo.UseVisualStyleBackColor = False
        '
        'cmdcamara
        '
        Me.cmdcamara.BackColor = System.Drawing.Color.DarkSalmon
        Me.cmdcamara.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdcamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdcamara.Image = CType(resources.GetObject("cmdcamara.Image"), System.Drawing.Image)
        Me.cmdcamara.Location = New System.Drawing.Point(18, 308)
        Me.cmdcamara.Name = "cmdcamara"
        Me.cmdcamara.Size = New System.Drawing.Size(107, 31)
        Me.cmdcamara.TabIndex = 182
        Me.cmdcamara.Text = "Camara"
        Me.cmdcamara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdcamara.UseVisualStyleBackColor = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.BackColor = System.Drawing.Color.DarkSalmon
        Me.cmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(236, 308)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(93, 31)
        Me.cmdBorrar.TabIndex = 184
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdBorrar.UseVisualStyleBackColor = False
        '
        'cmdCapturar
        '
        Me.cmdCapturar.BackColor = System.Drawing.Color.DarkSalmon
        Me.cmdCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCapturar.Image = CType(resources.GetObject("cmdCapturar.Image"), System.Drawing.Image)
        Me.cmdCapturar.Location = New System.Drawing.Point(131, 308)
        Me.cmdCapturar.Name = "cmdCapturar"
        Me.cmdCapturar.Size = New System.Drawing.Size(99, 31)
        Me.cmdCapturar.TabIndex = 183
        Me.cmdCapturar.Text = "Capturar"
        Me.cmdCapturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCapturar.UseVisualStyleBackColor = False
        '
        'pbFoto
        '
        Me.pbFoto.Location = New System.Drawing.Point(22, 41)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(304, 209)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 6
        Me.pbFoto.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.Controls.Add(Me.btnRestaurar)
        Me.Panel2.Controls.Add(Me.btnMax)
        Me.Panel2.Controls.Add(Me.btnCerrar)
        Me.Panel2.Controls.Add(Me.btnMin)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 25)
        Me.Panel2.TabIndex = 189
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(264, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 25)
        Me.btnRestaurar.TabIndex = 43
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.Coral
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.Icono_Maximizar
        Me.btnMax.Location = New System.Drawing.Point(264, 0)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(40, 25)
        Me.btnMax.TabIndex = 41
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.ICON_CERRARF
        Me.btnCerrar.Location = New System.Drawing.Point(310, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 24)
        Me.btnCerrar.TabIndex = 42
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.Icono_Minimizar
        Me.btnMin.Location = New System.Drawing.Point(216, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(39, 25)
        Me.btnMin.TabIndex = 41
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'FormFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 425)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnGuardarFotoArchivo)
        Me.Controls.Add(Me.cmdcamara)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdCapturar)
        Me.Controls.Add(Me.pbFoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormFoto"
        Me.Text = "FormFoto"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMin As Button
End Class
