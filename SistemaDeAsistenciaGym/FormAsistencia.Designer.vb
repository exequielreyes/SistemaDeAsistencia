<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAsistencia
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.vspQR = New AForge.Controls.VideoSourcePlayer()
        Me.lbAlumno = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.TimerActualizar = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione cámara: "
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.DarkSalmon
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(143, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Location = New System.Drawing.Point(143, 61)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(107, 23)
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'btnDetener
        '
        Me.btnDetener.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetener.Location = New System.Drawing.Point(256, 61)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(114, 23)
        Me.btnDetener.TabIndex = 2
        Me.btnDetener.Text = "Detener"
        Me.btnDetener.UseVisualStyleBackColor = False
        '
        'vspQR
        '
        Me.vspQR.Location = New System.Drawing.Point(36, 90)
        Me.vspQR.Name = "vspQR"
        Me.vspQR.Size = New System.Drawing.Size(480, 322)
        Me.vspQR.TabIndex = 3
        Me.vspQR.Text = "VideoSourcePlayer1"
        Me.vspQR.VideoSource = Nothing
        '
        'lbAlumno
        '
        Me.lbAlumno.FormattingEnabled = True
        Me.lbAlumno.Location = New System.Drawing.Point(527, 92)
        Me.lbAlumno.Name = "lbAlumno"
        Me.lbAlumno.Size = New System.Drawing.Size(173, 316)
        Me.lbAlumno.TabIndex = 4
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
        Me.Panel2.Size = New System.Drawing.Size(1137, 25)
        Me.Panel2.TabIndex = 42
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1050, 0)
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
        Me.btnMax.Location = New System.Drawing.Point(1050, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1096, 1)
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
        Me.btnMin.Location = New System.Drawing.Point(1002, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(39, 25)
        Me.btnMin.TabIndex = 41
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Location = New System.Drawing.Point(36, 439)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.Size = New System.Drawing.Size(664, 150)
        Me.dgvAlumnos.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(740, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nombre"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(743, 76)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(184, 20)
        Me.tbNombre.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(937, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Apellido"
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(940, 76)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(184, 20)
        Me.tbApellido.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(740, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "DNI"
        '
        'tbDNI
        '
        Me.tbDNI.Location = New System.Drawing.Point(743, 145)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(184, 20)
        Me.tbDNI.TabIndex = 45
        '
        'TimerActualizar
        '
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(652, 213)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(39, 13)
        Me.lblTimer.TabIndex = 46
        Me.lblTimer.Text = "Label5"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(940, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 167)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'FormAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 598)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.tbDNI)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbAlumno)
        Me.Controls.Add(Me.vspQR)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTimer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAsistencia"
        Me.Text = "FormAsistencia"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnDetener As Button
    Friend WithEvents vspQR As AForge.Controls.VideoSourcePlayer
    Friend WithEvents lbAlumno As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents TimerActualizar As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
