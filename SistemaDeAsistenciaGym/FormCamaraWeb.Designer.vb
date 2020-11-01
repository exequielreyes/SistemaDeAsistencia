<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCamaraWeb
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
        Me.components = New System.ComponentModel.Container()
        Me.Apagar = New System.Windows.Forms.Button()
        Me.ButtonELIMINAR = New System.Windows.Forms.Button()
        Me.ButtonFINSERIEDIARIA = New System.Windows.Forms.Button()
        Me.ButtonSERIEDIARIA = New System.Windows.Forms.Button()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.PCAPTURA = New System.Windows.Forms.PictureBox()
        Me.FORMATO = New System.Windows.Forms.Button()
        Me.FSERIE = New System.Windows.Forms.Button()
        Me.SERIE = New System.Windows.Forms.Button()
        Me.FGRABAR = New System.Windows.Forms.Button()
        Me.GRABAR = New System.Windows.Forms.Button()
        Me.CAPTURAR = New System.Windows.Forms.Button()
        Me.INICIAR = New System.Windows.Forms.Button()
        Me.VISOR = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Reloj = New System.Windows.Forms.Timer(Me.components)
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Apagar
        '
        Me.Apagar.Location = New System.Drawing.Point(494, 399)
        Me.Apagar.Name = "Apagar"
        Me.Apagar.Size = New System.Drawing.Size(114, 23)
        Me.Apagar.TabIndex = 98
        Me.Apagar.Text = "Apagar"
        Me.Apagar.UseVisualStyleBackColor = True
        '
        'ButtonELIMINAR
        '
        Me.ButtonELIMINAR.Location = New System.Drawing.Point(494, 370)
        Me.ButtonELIMINAR.Name = "ButtonELIMINAR"
        Me.ButtonELIMINAR.Size = New System.Drawing.Size(162, 23)
        Me.ButtonELIMINAR.TabIndex = 97
        Me.ButtonELIMINAR.Text = "Eliminar carpetas"
        Me.ButtonELIMINAR.UseVisualStyleBackColor = True
        '
        'ButtonFINSERIEDIARIA
        '
        Me.ButtonFINSERIEDIARIA.Location = New System.Drawing.Point(353, 399)
        Me.ButtonFINSERIEDIARIA.Name = "ButtonFINSERIEDIARIA"
        Me.ButtonFINSERIEDIARIA.Size = New System.Drawing.Size(114, 23)
        Me.ButtonFINSERIEDIARIA.TabIndex = 96
        Me.ButtonFINSERIEDIARIA.Text = "Fin serie diaria"
        Me.ButtonFINSERIEDIARIA.UseVisualStyleBackColor = True
        '
        'ButtonSERIEDIARIA
        '
        Me.ButtonSERIEDIARIA.Location = New System.Drawing.Point(353, 370)
        Me.ButtonSERIEDIARIA.Name = "ButtonSERIEDIARIA"
        Me.ButtonSERIEDIARIA.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSERIEDIARIA.TabIndex = 95
        Me.ButtonSERIEDIARIA.Text = "Serie diaria"
        Me.ButtonSERIEDIARIA.UseVisualStyleBackColor = True
        '
        'GUARDAR
        '
        Me.GUARDAR.Location = New System.Drawing.Point(261, 399)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(75, 23)
        Me.GUARDAR.TabIndex = 94
        Me.GUARDAR.Text = "Guardar"
        Me.GUARDAR.UseVisualStyleBackColor = True
        '
        'PCAPTURA
        '
        Me.PCAPTURA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PCAPTURA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCAPTURA.Location = New System.Drawing.Point(506, 29)
        Me.PCAPTURA.Name = "PCAPTURA"
        Me.PCAPTURA.Size = New System.Drawing.Size(276, 209)
        Me.PCAPTURA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCAPTURA.TabIndex = 93
        Me.PCAPTURA.TabStop = False
        '
        'FORMATO
        '
        Me.FORMATO.Location = New System.Drawing.Point(180, 399)
        Me.FORMATO.Name = "FORMATO"
        Me.FORMATO.Size = New System.Drawing.Size(75, 23)
        Me.FORMATO.TabIndex = 92
        Me.FORMATO.Text = "Formato"
        Me.FORMATO.UseVisualStyleBackColor = True
        '
        'FSERIE
        '
        Me.FSERIE.Location = New System.Drawing.Point(99, 399)
        Me.FSERIE.Name = "FSERIE"
        Me.FSERIE.Size = New System.Drawing.Size(75, 23)
        Me.FSERIE.TabIndex = 91
        Me.FSERIE.Text = "Fserie"
        Me.FSERIE.UseVisualStyleBackColor = True
        '
        'SERIE
        '
        Me.SERIE.Location = New System.Drawing.Point(18, 399)
        Me.SERIE.Name = "SERIE"
        Me.SERIE.Size = New System.Drawing.Size(75, 23)
        Me.SERIE.TabIndex = 90
        Me.SERIE.Text = "Serie"
        Me.SERIE.UseVisualStyleBackColor = True
        '
        'FGRABAR
        '
        Me.FGRABAR.Location = New System.Drawing.Point(261, 370)
        Me.FGRABAR.Name = "FGRABAR"
        Me.FGRABAR.Size = New System.Drawing.Size(75, 23)
        Me.FGRABAR.TabIndex = 89
        Me.FGRABAR.Text = "Fgrabar"
        Me.FGRABAR.UseVisualStyleBackColor = True
        '
        'GRABAR
        '
        Me.GRABAR.Location = New System.Drawing.Point(180, 370)
        Me.GRABAR.Name = "GRABAR"
        Me.GRABAR.Size = New System.Drawing.Size(75, 23)
        Me.GRABAR.TabIndex = 88
        Me.GRABAR.Text = "Grabar"
        Me.GRABAR.UseVisualStyleBackColor = True
        '
        'CAPTURAR
        '
        Me.CAPTURAR.Location = New System.Drawing.Point(99, 370)
        Me.CAPTURAR.Name = "CAPTURAR"
        Me.CAPTURAR.Size = New System.Drawing.Size(75, 23)
        Me.CAPTURAR.TabIndex = 87
        Me.CAPTURAR.Text = "Capturar"
        Me.CAPTURAR.UseVisualStyleBackColor = True
        '
        'INICIAR
        '
        Me.INICIAR.Location = New System.Drawing.Point(18, 370)
        Me.INICIAR.Name = "INICIAR"
        Me.INICIAR.Size = New System.Drawing.Size(75, 23)
        Me.INICIAR.TabIndex = 86
        Me.INICIAR.Text = "Iniciar"
        Me.INICIAR.UseVisualStyleBackColor = True
        '
        'VISOR
        '
        Me.VISOR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.VISOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VISOR.Location = New System.Drawing.Point(39, 29)
        Me.VISOR.Name = "VISOR"
        Me.VISOR.Size = New System.Drawing.Size(449, 335)
        Me.VISOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VISOR.TabIndex = 85
        Me.VISOR.TabStop = False
        '
        'FormCamaraWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Apagar)
        Me.Controls.Add(Me.ButtonELIMINAR)
        Me.Controls.Add(Me.ButtonFINSERIEDIARIA)
        Me.Controls.Add(Me.ButtonSERIEDIARIA)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.PCAPTURA)
        Me.Controls.Add(Me.FORMATO)
        Me.Controls.Add(Me.FSERIE)
        Me.Controls.Add(Me.SERIE)
        Me.Controls.Add(Me.FGRABAR)
        Me.Controls.Add(Me.GRABAR)
        Me.Controls.Add(Me.CAPTURAR)
        Me.Controls.Add(Me.INICIAR)
        Me.Controls.Add(Me.VISOR)
        Me.Name = "FormCamaraWeb"
        Me.Text = "FormCamaraWeb"
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Apagar As Button
    Friend WithEvents ButtonELIMINAR As Button
    Friend WithEvents ButtonFINSERIEDIARIA As Button
    Friend WithEvents ButtonSERIEDIARIA As Button
    Friend WithEvents GUARDAR As Button
    Friend WithEvents PCAPTURA As PictureBox
    Friend WithEvents FORMATO As Button
    Friend WithEvents FSERIE As Button
    Friend WithEvents SERIE As Button
    Friend WithEvents FGRABAR As Button
    Friend WithEvents GRABAR As Button
    Friend WithEvents CAPTURAR As Button
    Friend WithEvents INICIAR As Button
    Friend WithEvents VISOR As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Reloj As Timer
    Friend WithEvents FBD As FolderBrowserDialog
    Friend WithEvents SFD As SaveFileDialog
End Class
