<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastroDeVeiculos
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
        Me.GroupBoxRG = New System.Windows.Forms.GroupBox()
        Me.TextBoxPlaca = New System.Windows.Forms.TextBox()
        Me.ButtonConsultarPlaca = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBoxAno = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonSelecionarCarro = New System.Windows.Forms.Button()
        Me.TextBoxImagem = New System.Windows.Forms.TextBox()
        Me.LabelImagem = New System.Windows.Forms.Label()
        Me.TextBoxStatus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDiaria = New System.Windows.Forms.TextBox()
        Me.LabelDiaria = New System.Windows.Forms.Label()
        Me.LabelAno = New System.Windows.Forms.Label()
        Me.TextBoxModelo = New System.Windows.Forms.TextBox()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        Me.ButtonAlterar = New System.Windows.Forms.Button()
        Me.ButtonExcluir = New System.Windows.Forms.Button()
        Me.ButtonIncluir = New System.Windows.Forms.Button()
        Me.PictureBoxCarroImagem = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBoxRG.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxCarroImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxRG
        '
        Me.GroupBoxRG.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBoxRG.Controls.Add(Me.TextBoxPlaca)
        Me.GroupBoxRG.Controls.Add(Me.ButtonConsultarPlaca)
        Me.GroupBoxRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRG.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxRG.Location = New System.Drawing.Point(35, 42)
        Me.GroupBoxRG.Name = "GroupBoxRG"
        Me.GroupBoxRG.Size = New System.Drawing.Size(608, 97)
        Me.GroupBoxRG.TabIndex = 1
        Me.GroupBoxRG.TabStop = False
        Me.GroupBoxRG.Text = "PLACA"
        '
        'TextBoxPlaca
        '
        Me.TextBoxPlaca.Location = New System.Drawing.Point(76, 40)
        Me.TextBoxPlaca.Name = "TextBoxPlaca"
        Me.TextBoxPlaca.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxPlaca.TabIndex = 1
        '
        'ButtonConsultarPlaca
        '
        Me.ButtonConsultarPlaca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonConsultarPlaca.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonConsultarPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultarPlaca.ForeColor = System.Drawing.Color.White
        Me.ButtonConsultarPlaca.Location = New System.Drawing.Point(375, 25)
        Me.ButtonConsultarPlaca.Name = "ButtonConsultarPlaca"
        Me.ButtonConsultarPlaca.Size = New System.Drawing.Size(189, 55)
        Me.ButtonConsultarPlaca.TabIndex = 0
        Me.ButtonConsultarPlaca.Text = "Consultar"
        Me.ButtonConsultarPlaca.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.PictureBoxCarroImagem)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxAno)
        Me.GroupBox1.Controls.Add(Me.ButtonSelecionarCarro)
        Me.GroupBox1.Controls.Add(Me.TextBoxImagem)
        Me.GroupBox1.Controls.Add(Me.LabelImagem)
        Me.GroupBox1.Controls.Add(Me.TextBoxStatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxDiaria)
        Me.GroupBox1.Controls.Add(Me.LabelDiaria)
        Me.GroupBox1.Controls.Add(Me.LabelAno)
        Me.GroupBox1.Controls.Add(Me.TextBoxModelo)
        Me.GroupBox1.Controls.Add(Me.LabelNome)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 583)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'MaskedTextBoxAno
        '
        Me.MaskedTextBoxAno.Location = New System.Drawing.Point(90, 96)
        Me.MaskedTextBoxAno.Mask = "00/00/0000"
        Me.MaskedTextBoxAno.Name = "MaskedTextBoxAno"
        Me.MaskedTextBoxAno.Size = New System.Drawing.Size(100, 26)
        Me.MaskedTextBoxAno.TabIndex = 30
        Me.MaskedTextBoxAno.ValidatingType = GetType(Date)
        '
        'ButtonSelecionarCarro
        '
        Me.ButtonSelecionarCarro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonSelecionarCarro.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonSelecionarCarro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelecionarCarro.ForeColor = System.Drawing.Color.White
        Me.ButtonSelecionarCarro.Location = New System.Drawing.Point(21, 524)
        Me.ButtonSelecionarCarro.Name = "ButtonSelecionarCarro"
        Me.ButtonSelecionarCarro.Size = New System.Drawing.Size(296, 44)
        Me.ButtonSelecionarCarro.TabIndex = 17
        Me.ButtonSelecionarCarro.Text = "Selecionar Carro"
        Me.ButtonSelecionarCarro.UseVisualStyleBackColor = False
        '
        'TextBoxImagem
        '
        Me.TextBoxImagem.Location = New System.Drawing.Point(90, 233)
        Me.TextBoxImagem.Name = "TextBoxImagem"
        Me.TextBoxImagem.Size = New System.Drawing.Size(237, 26)
        Me.TextBoxImagem.TabIndex = 16
        '
        'LabelImagem
        '
        Me.LabelImagem.AutoSize = True
        Me.LabelImagem.Location = New System.Drawing.Point(17, 233)
        Me.LabelImagem.Name = "LabelImagem"
        Me.LabelImagem.Size = New System.Drawing.Size(67, 20)
        Me.LabelImagem.TabIndex = 15
        Me.LabelImagem.Text = "Imagem"
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Location = New System.Drawing.Point(90, 182)
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.Size = New System.Drawing.Size(238, 26)
        Me.TextBoxStatus.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Status"
        '
        'TextBoxDiaria
        '
        Me.TextBoxDiaria.Location = New System.Drawing.Point(90, 138)
        Me.TextBoxDiaria.Name = "TextBoxDiaria"
        Me.TextBoxDiaria.Size = New System.Drawing.Size(237, 26)
        Me.TextBoxDiaria.TabIndex = 10
        '
        'LabelDiaria
        '
        Me.LabelDiaria.AutoSize = True
        Me.LabelDiaria.Location = New System.Drawing.Point(17, 138)
        Me.LabelDiaria.Name = "LabelDiaria"
        Me.LabelDiaria.Size = New System.Drawing.Size(50, 20)
        Me.LabelDiaria.TabIndex = 9
        Me.LabelDiaria.Text = "Diaria"
        '
        'LabelAno
        '
        Me.LabelAno.AutoSize = True
        Me.LabelAno.Location = New System.Drawing.Point(17, 96)
        Me.LabelAno.Name = "LabelAno"
        Me.LabelAno.Size = New System.Drawing.Size(38, 20)
        Me.LabelAno.TabIndex = 3
        Me.LabelAno.Text = "Ano"
        '
        'TextBoxModelo
        '
        Me.TextBoxModelo.Location = New System.Drawing.Point(90, 48)
        Me.TextBoxModelo.Name = "TextBoxModelo"
        Me.TextBoxModelo.Size = New System.Drawing.Size(237, 26)
        Me.TextBoxModelo.TabIndex = 2
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(17, 48)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(61, 20)
        Me.LabelNome.TabIndex = 0
        Me.LabelNome.Text = "Modelo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButtonSair)
        Me.Panel1.Controls.Add(Me.ButtonLimpar)
        Me.Panel1.Controls.Add(Me.ButtonAlterar)
        Me.Panel1.Controls.Add(Me.ButtonExcluir)
        Me.Panel1.Controls.Add(Me.ButtonIncluir)
        Me.Panel1.Location = New System.Drawing.Point(410, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 583)
        Me.Panel1.TabIndex = 17
        '
        'ButtonSair
        '
        Me.ButtonSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonSair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSair.ForeColor = System.Drawing.Color.White
        Me.ButtonSair.Location = New System.Drawing.Point(22, 442)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(189, 125)
        Me.ButtonSair.TabIndex = 5
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = False
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpar.ForeColor = System.Drawing.Color.White
        Me.ButtonLimpar.Location = New System.Drawing.Point(22, 337)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(189, 94)
        Me.ButtonLimpar.TabIndex = 4
        Me.ButtonLimpar.Text = "Limpar"
        Me.ButtonLimpar.UseVisualStyleBackColor = False
        '
        'ButtonAlterar
        '
        Me.ButtonAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAlterar.ForeColor = System.Drawing.Color.White
        Me.ButtonAlterar.Location = New System.Drawing.Point(22, 232)
        Me.ButtonAlterar.Name = "ButtonAlterar"
        Me.ButtonAlterar.Size = New System.Drawing.Size(189, 99)
        Me.ButtonAlterar.TabIndex = 3
        Me.ButtonAlterar.Text = "Alterar"
        Me.ButtonAlterar.UseVisualStyleBackColor = False
        '
        'ButtonExcluir
        '
        Me.ButtonExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExcluir.ForeColor = System.Drawing.Color.White
        Me.ButtonExcluir.Location = New System.Drawing.Point(22, 137)
        Me.ButtonExcluir.Name = "ButtonExcluir"
        Me.ButtonExcluir.Size = New System.Drawing.Size(189, 89)
        Me.ButtonExcluir.TabIndex = 2
        Me.ButtonExcluir.Text = "Excluir"
        Me.ButtonExcluir.UseVisualStyleBackColor = False
        '
        'ButtonIncluir
        '
        Me.ButtonIncluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonIncluir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonIncluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIncluir.ForeColor = System.Drawing.Color.White
        Me.ButtonIncluir.Location = New System.Drawing.Point(22, 25)
        Me.ButtonIncluir.Name = "ButtonIncluir"
        Me.ButtonIncluir.Size = New System.Drawing.Size(189, 106)
        Me.ButtonIncluir.TabIndex = 1
        Me.ButtonIncluir.Text = "Incluir"
        Me.ButtonIncluir.UseVisualStyleBackColor = False
        '
        'PictureBoxCarroImagem
        '
        Me.PictureBoxCarroImagem.Location = New System.Drawing.Point(21, 277)
        Me.PictureBoxCarroImagem.Name = "PictureBoxCarroImagem"
        Me.PictureBoxCarroImagem.Size = New System.Drawing.Size(307, 215)
        Me.PictureBoxCarroImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCarroImagem.TabIndex = 31
        Me.PictureBoxCarroImagem.TabStop = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'FormCadastroDeVeiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(678, 761)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxRG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FormCadastroDeVeiculos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE VEICULOS"
        Me.GroupBoxRG.ResumeLayout(False)
        Me.GroupBoxRG.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBoxCarroImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxRG As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPlaca As System.Windows.Forms.TextBox
    Friend WithEvents ButtonConsultarPlaca As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxImagem As System.Windows.Forms.TextBox
    Friend WithEvents LabelImagem As System.Windows.Forms.Label
    Friend WithEvents TextBoxStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDiaria As System.Windows.Forms.TextBox
    Friend WithEvents LabelDiaria As System.Windows.Forms.Label
    Friend WithEvents LabelAno As System.Windows.Forms.Label
    Friend WithEvents TextBoxModelo As System.Windows.Forms.TextBox
    Friend WithEvents LabelNome As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonSair As System.Windows.Forms.Button
    Friend WithEvents ButtonLimpar As System.Windows.Forms.Button
    Friend WithEvents ButtonAlterar As System.Windows.Forms.Button
    Friend WithEvents ButtonExcluir As System.Windows.Forms.Button
    Friend WithEvents ButtonIncluir As System.Windows.Forms.Button
    Friend WithEvents ButtonSelecionarCarro As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBoxAno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBoxCarroImagem As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
