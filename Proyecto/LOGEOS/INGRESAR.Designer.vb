<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INGRESAR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INGRESAR))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txt_Usuario = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_Contraseña = New Guna.UI.WinForms.GunaTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(726, 618)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(245, 509)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(237, 46)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "REGISTRAR NUEVO USUARIO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(228, 360)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 36)
        Me.Label2.TabIndex = 24
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(451, 407)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 29)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "QUITAR DATOS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(144, 407)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 29)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "REGRESAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txt_Usuario
        '
        Me.txt_Usuario.BaseColor = System.Drawing.Color.Navy
        Me.txt_Usuario.BorderColor = System.Drawing.Color.Transparent
        Me.txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Usuario.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Usuario.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Usuario.FocusedForeColor = System.Drawing.Color.Black
        Me.txt_Usuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Usuario.ForeColor = System.Drawing.Color.Black
        Me.txt_Usuario.Location = New System.Drawing.Point(197, 278)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Usuario.Size = New System.Drawing.Size(382, 48)
        Me.txt_Usuario.TabIndex = 31
        Me.txt_Usuario.Text = "INGRESE SU USUARIO"
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.BaseColor = System.Drawing.Color.Navy
        Me.txt_Contraseña.BorderColor = System.Drawing.Color.Transparent
        Me.txt_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Contraseña.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Contraseña.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Contraseña.FocusedForeColor = System.Drawing.Color.Black
        Me.txt_Contraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Contraseña.ForeColor = System.Drawing.Color.Black
        Me.txt_Contraseña.Location = New System.Drawing.Point(197, 346)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Contraseña.Size = New System.Drawing.Size(382, 50)
        Me.txt_Contraseña.TabIndex = 32
        Me.txt_Contraseña.Text = "INGRESE SU CODIGO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(245, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 44)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'INGRESAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 618)
        Me.Controls.Add(Me.txt_Contraseña)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "INGRESAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formusuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Contraseña As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_Usuario As Guna.UI.WinForms.GunaTextBox
End Class
