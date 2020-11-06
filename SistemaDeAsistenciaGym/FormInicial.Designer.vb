<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicial
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnAsistencia)
        Me.Panel1.Controls.Add(Me.btnRegistro)
        Me.Panel1.Location = New System.Drawing.Point(0, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 294)
        Me.Panel1.TabIndex = 2
        '
        'tmOcultar
        '
        '
        'tmMostrar
        '
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
        Me.Panel2.Size = New System.Drawing.Size(800, 25)
        Me.Panel2.TabIndex = 40
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(713, 0)
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
        Me.btnMax.Location = New System.Drawing.Point(713, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(759, 1)
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
        Me.btnMin.Location = New System.Drawing.Point(665, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(39, 25)
        Me.btnMin.TabIndex = 41
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.menu4
        Me.btnMenu.Location = New System.Drawing.Point(151, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(28, 39)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 12
        Me.btnMenu.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Castellar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.Cancel24
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(3, 197)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(176, 41)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAsistencia
        '
        Me.btnAsistencia.BackColor = System.Drawing.Color.Transparent
        Me.btnAsistencia.FlatAppearance.BorderSize = 0
        Me.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia.Font = New System.Drawing.Font("Castellar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsistencia.ForeColor = System.Drawing.Color.White
        Me.btnAsistencia.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.qr
        Me.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsistencia.Location = New System.Drawing.Point(-13, 134)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Size = New System.Drawing.Size(192, 44)
        Me.btnAsistencia.TabIndex = 7
        Me.btnAsistencia.Text = "        ASISTENCIAS"
        Me.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsistencia.UseVisualStyleBackColor = False
        '
        'btnRegistro
        '
        Me.btnRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistro.FlatAppearance.BorderSize = 0
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.Font = New System.Drawing.Font("Castellar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.ForeColor = System.Drawing.Color.White
        Me.btnRegistro.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.alacarte
        Me.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistro.Location = New System.Drawing.Point(0, 77)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(179, 37)
        Me.btnRegistro.TabIndex = 3
        Me.btnRegistro.Text = "     REGISTRO"
        Me.btnRegistro.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.Logo0
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(799, 158)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FormInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormInicial"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tmOcultar As Timer
    Friend WithEvents tmMostrar As Timer
    Friend WithEvents btnRegistro As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAsistencia As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMenu As PictureBox
End Class
