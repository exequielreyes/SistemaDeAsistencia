﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdjuntarArchivo = New System.Windows.Forms.Button()
        Me.lblArchivoCargado = New System.Windows.Forms.Label()
        Me.Tbrutaarchivo = New System.Windows.Forms.TextBox()
        Me.CBMotivo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPara = New System.Windows.Forms.TextBox()
        Me.TbAsunto = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PbArchivo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        CType(Me.PbArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Adjuntar:"
        '
        'btnAdjuntarArchivo
        '
        Me.btnAdjuntarArchivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdjuntarArchivo.Location = New System.Drawing.Point(116, 190)
        Me.btnAdjuntarArchivo.Name = "btnAdjuntarArchivo"
        Me.btnAdjuntarArchivo.Size = New System.Drawing.Size(36, 23)
        Me.btnAdjuntarArchivo.TabIndex = 65
        Me.btnAdjuntarArchivo.Text = ". . ."
        Me.btnAdjuntarArchivo.UseVisualStyleBackColor = True
        '
        'lblArchivoCargado
        '
        Me.lblArchivoCargado.AutoSize = True
        Me.lblArchivoCargado.Location = New System.Drawing.Point(149, 213)
        Me.lblArchivoCargado.Name = "lblArchivoCargado"
        Me.lblArchivoCargado.Size = New System.Drawing.Size(86, 13)
        Me.lblArchivoCargado.TabIndex = 64
        Me.lblArchivoCargado.Text = "Archivo Cargado"
        Me.lblArchivoCargado.Visible = False
        '
        'Tbrutaarchivo
        '
        Me.Tbrutaarchivo.Location = New System.Drawing.Point(361, 215)
        Me.Tbrutaarchivo.Name = "Tbrutaarchivo"
        Me.Tbrutaarchivo.Size = New System.Drawing.Size(100, 20)
        Me.Tbrutaarchivo.TabIndex = 62
        Me.Tbrutaarchivo.Visible = False
        '
        'CBMotivo
        '
        Me.CBMotivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBMotivo.FormattingEnabled = True
        Me.CBMotivo.Items.AddRange(New Object() {"[Notificacion]", "[Importante]", "[Urgente]"})
        Me.CBMotivo.Location = New System.Drawing.Point(130, 87)
        Me.CBMotivo.Name = "CBMotivo"
        Me.CBMotivo.Size = New System.Drawing.Size(122, 28)
        Me.CBMotivo.TabIndex = 61
        Me.CBMotivo.Text = "[Notificacion]"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Motivo:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Destinatario:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Asunto:"
        '
        'TbPara
        '
        Me.TbPara.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbPara.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbPara.Location = New System.Drawing.Point(130, 55)
        Me.TbPara.Name = "TbPara"
        Me.TbPara.Size = New System.Drawing.Size(272, 26)
        Me.TbPara.TabIndex = 57
        '
        'TbAsunto
        '
        Me.TbAsunto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbAsunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbAsunto.Location = New System.Drawing.Point(130, 121)
        Me.TbAsunto.Name = "TbAsunto"
        Me.TbAsunto.Size = New System.Drawing.Size(178, 26)
        Me.TbAsunto.TabIndex = 56
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(17, 241)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(464, 123)
        Me.RichTextBox1.TabIndex = 67
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(201, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PbArchivo
        '
        Me.PbArchivo.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.logo
        Me.PbArchivo.Location = New System.Drawing.Point(177, 164)
        Me.PbArchivo.Name = "PbArchivo"
        Me.PbArchivo.Size = New System.Drawing.Size(59, 46)
        Me.PbArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbArchivo.TabIndex = 63
        Me.PbArchivo.TabStop = False
        Me.PbArchivo.Visible = False
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
        Me.Panel2.Size = New System.Drawing.Size(508, 25)
        Me.Panel2.TabIndex = 69
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.SistemaDeAsistenciaGym.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(421, 0)
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
        Me.btnMax.Location = New System.Drawing.Point(421, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(467, 1)
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
        Me.btnMin.Location = New System.Drawing.Point(373, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(39, 25)
        Me.btnMin.TabIndex = 41
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'FormEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 412)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdjuntarArchivo)
        Me.Controls.Add(Me.lblArchivoCargado)
        Me.Controls.Add(Me.PbArchivo)
        Me.Controls.Add(Me.Tbrutaarchivo)
        Me.Controls.Add(Me.CBMotivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbPara)
        Me.Controls.Add(Me.TbAsunto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEmail"
        Me.Text = "FormEmail"
        CType(Me.PbArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdjuntarArchivo As Button
    Friend WithEvents lblArchivoCargado As Label
    Friend WithEvents PbArchivo As PictureBox
    Friend WithEvents Tbrutaarchivo As TextBox
    Friend WithEvents CBMotivo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPara As TextBox
    Friend WithEvents TbAsunto As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMin As Button
End Class
