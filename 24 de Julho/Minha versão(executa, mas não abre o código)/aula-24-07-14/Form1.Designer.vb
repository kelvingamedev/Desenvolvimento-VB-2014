<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Usuario = New System.Windows.Forms.TextBox()
        Me.TextBox_Senha = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Button_Sair = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'TextBox_Usuario
        '
        Me.TextBox_Usuario.Location = New System.Drawing.Point(96, 63)
        Me.TextBox_Usuario.Name = "TextBox_Usuario"
        Me.TextBox_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Usuario.TabIndex = 2
        '
        'TextBox_Senha
        '
        Me.TextBox_Senha.Location = New System.Drawing.Point(96, 89)
        Me.TextBox_Senha.Name = "TextBox_Senha"
        Me.TextBox_Senha.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Senha.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(202, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 93)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button_Login
        '
        Me.Button_Login.Location = New System.Drawing.Point(22, 139)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(75, 23)
        Me.Button_Login.TabIndex = 5
        Me.Button_Login.Text = "Login"
        Me.Button_Login.UseVisualStyleBackColor = True
        '
        'Button_Sair
        '
        Me.Button_Sair.Location = New System.Drawing.Point(121, 139)
        Me.Button_Sair.Name = "Button_Sair"
        Me.Button_Sair.Size = New System.Drawing.Size(75, 23)
        Me.Button_Sair.TabIndex = 6
        Me.Button_Sair.Text = "Sair"
        Me.Button_Sair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 174)
        Me.Controls.Add(Me.Button_Sair)
        Me.Controls.Add(Me.Button_Login)
        Me.Controls.Add(Me.TextBox_Usuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox_Senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Senha As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Login As System.Windows.Forms.Button
    Friend WithEvents Button_Sair As System.Windows.Forms.Button

End Class
