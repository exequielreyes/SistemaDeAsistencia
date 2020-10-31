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
        Me.components = New System.ComponentModel.Container()
        Me.vspFoto = New AForge.Controls.VideoSourcePlayer()
        Me.btnTomar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vspFoto
        '
        Me.vspFoto.Location = New System.Drawing.Point(6, 75)
        Me.vspFoto.Name = "vspFoto"
        Me.vspFoto.Size = New System.Drawing.Size(666, 361)
        Me.vspFoto.TabIndex = 0
        Me.vspFoto.Text = "VideoSourcePlayer1"
        Me.vspFoto.VideoSource = Nothing
        '
        'btnTomar
        '
        Me.btnTomar.Location = New System.Drawing.Point(6, 442)
        Me.btnTomar.Name = "btnTomar"
        Me.btnTomar.Size = New System.Drawing.Size(666, 40)
        Me.btnTomar.TabIndex = 1
        Me.btnTomar.Text = "Tomar Foto"
        Me.btnTomar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(151, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccione Cámara: "
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(421, 23)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 4
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnDetener
        '
        Me.btnDetener.Location = New System.Drawing.Point(502, 23)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(75, 23)
        Me.btnDetener.TabIndex = 4
        Me.btnDetener.Text = "Detener"
        Me.btnDetener.UseVisualStyleBackColor = True
        '
        'pbFoto
        '
        Me.pbFoto.Location = New System.Drawing.Point(6, 75)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(666, 361)
        Me.pbFoto.TabIndex = 5
        Me.pbFoto.TabStop = False
        '
        'FormFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 482)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnTomar)
        Me.Controls.Add(Me.vspFoto)
        Me.Name = "FormFoto"
        Me.Text = "FormFoto"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vspFoto As AForge.Controls.VideoSourcePlayer
    Friend WithEvents btnTomar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnDetener As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pbFoto As PictureBox
End Class
