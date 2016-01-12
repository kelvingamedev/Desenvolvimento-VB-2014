<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastroDeClientes
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
        Me.TextBoxRG = New System.Windows.Forms.TextBox()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBoxNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxValidade = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxEmail = New System.Windows.Forms.MaskedTextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelNascimento = New System.Windows.Forms.Label()
        Me.TextBoxCidade = New System.Windows.Forms.TextBox()
        Me.LabelCidade = New System.Windows.Forms.Label()
        Me.TextBoxEstado = New System.Windows.Forms.TextBox()
        Me.LabelEstado = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCEP = New System.Windows.Forms.MaskedTextBox()
        Me.LabelCEP = New System.Windows.Forms.Label()
        Me.TextBoxBairro = New System.Windows.Forms.TextBox()
        Me.LabelBairro = New System.Windows.Forms.Label()
        Me.TextBoxEndereco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelValidade = New System.Windows.Forms.Label()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNCNH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCelular = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCelular = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.LabelTeleone = New System.Windows.Forms.Label()
        Me.TextBoxCPF = New System.Windows.Forms.TextBox()
        Me.LabelCPF = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        Me.ButtonAlterar = New System.Windows.Forms.Button()
        Me.ButtonExcluir = New System.Windows.Forms.Button()
        Me.ButtonIncluir = New System.Windows.Forms.Button()
        Me.GroupBoxRG.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxRG
        '
        Me.GroupBoxRG.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBoxRG.Controls.Add(Me.TextBoxRG)
        Me.GroupBoxRG.Controls.Add(Me.ButtonConsultar)
        Me.GroupBoxRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRG.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxRG.Location = New System.Drawing.Point(34, 38)
        Me.GroupBoxRG.Name = "GroupBoxRG"
        Me.GroupBoxRG.Size = New System.Drawing.Size(555, 97)
        Me.GroupBoxRG.TabIndex = 0
        Me.GroupBoxRG.TabStop = False
        Me.GroupBoxRG.Text = "RG"
        '
        'TextBoxRG
        '
        Me.TextBoxRG.Location = New System.Drawing.Point(67, 40)
        Me.TextBoxRG.Name = "TextBoxRG"
        Me.TextBoxRG.Size = New System.Drawing.Size(235, 26)
        Me.TextBoxRG.TabIndex = 1
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultar.ForeColor = System.Drawing.Color.White
        Me.ButtonConsultar.Location = New System.Drawing.Point(348, 26)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(189, 55)
        Me.ButtonConsultar.TabIndex = 0
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = False
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientes.ForeColor = System.Drawing.Color.Navy
        Me.LabelClientes.Location = New System.Drawing.Point(260, 9)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(98, 25)
        Me.LabelClientes.TabIndex = 1
        Me.LabelClientes.Text = "Clientes"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxNascimento)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxValidade)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxEmail)
        Me.GroupBox1.Controls.Add(Me.LabelEmail)
        Me.GroupBox1.Controls.Add(Me.LabelNascimento)
        Me.GroupBox1.Controls.Add(Me.TextBoxCidade)
        Me.GroupBox1.Controls.Add(Me.LabelCidade)
        Me.GroupBox1.Controls.Add(Me.TextBoxEstado)
        Me.GroupBox1.Controls.Add(Me.LabelEstado)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxCEP)
        Me.GroupBox1.Controls.Add(Me.LabelCEP)
        Me.GroupBox1.Controls.Add(Me.TextBoxBairro)
        Me.GroupBox1.Controls.Add(Me.LabelBairro)
        Me.GroupBox1.Controls.Add(Me.TextBoxEndereco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LabelValidade)
        Me.GroupBox1.Controls.Add(Me.TextBoxCategoria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxNCNH)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LabelCelular)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxCelular)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxTelefone)
        Me.GroupBox1.Controls.Add(Me.LabelTeleone)
        Me.GroupBox1.Controls.Add(Me.TextBoxCPF)
        Me.GroupBox1.Controls.Add(Me.LabelCPF)
        Me.GroupBox1.Controls.Add(Me.TextBoxNome)
        Me.GroupBox1.Controls.Add(Me.LabelNome)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 583)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'MaskedTextBoxNascimento
        '
        Me.MaskedTextBoxNascimento.Location = New System.Drawing.Point(118, 507)
        Me.MaskedTextBoxNascimento.Mask = "00/00/0000"
        Me.MaskedTextBoxNascimento.Name = "MaskedTextBoxNascimento"
        Me.MaskedTextBoxNascimento.Size = New System.Drawing.Size(100, 26)
        Me.MaskedTextBoxNascimento.TabIndex = 30
        Me.MaskedTextBoxNascimento.ValidatingType = GetType(Date)
        '
        'MaskedTextBoxValidade
        '
        Me.MaskedTextBoxValidade.Location = New System.Drawing.Point(97, 298)
        Me.MaskedTextBoxValidade.Mask = "00/00/0000"
        Me.MaskedTextBoxValidade.Name = "MaskedTextBoxValidade"
        Me.MaskedTextBoxValidade.Size = New System.Drawing.Size(100, 26)
        Me.MaskedTextBoxValidade.TabIndex = 29
        Me.MaskedTextBoxValidade.ValidatingType = GetType(Date)
        '
        'MaskedTextBoxEmail
        '
        Me.MaskedTextBoxEmail.Location = New System.Drawing.Point(118, 541)
        Me.MaskedTextBoxEmail.Mask = "@"
        Me.MaskedTextBoxEmail.Name = "MaskedTextBoxEmail"
        Me.MaskedTextBoxEmail.Size = New System.Drawing.Size(181, 26)
        Me.MaskedTextBoxEmail.TabIndex = 28
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(17, 541)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(53, 20)
        Me.LabelEmail.TabIndex = 27
        Me.LabelEmail.Text = "E-mail"
        '
        'LabelNascimento
        '
        Me.LabelNascimento.AutoSize = True
        Me.LabelNascimento.Location = New System.Drawing.Point(17, 510)
        Me.LabelNascimento.Name = "LabelNascimento"
        Me.LabelNascimento.Size = New System.Drawing.Size(93, 20)
        Me.LabelNascimento.TabIndex = 25
        Me.LabelNascimento.Text = "Nascimento"
        '
        'TextBoxCidade
        '
        Me.TextBoxCidade.Location = New System.Drawing.Point(97, 475)
        Me.TextBoxCidade.Name = "TextBoxCidade"
        Me.TextBoxCidade.Size = New System.Drawing.Size(146, 26)
        Me.TextBoxCidade.TabIndex = 24
        '
        'LabelCidade
        '
        Me.LabelCidade.AutoSize = True
        Me.LabelCidade.Location = New System.Drawing.Point(17, 478)
        Me.LabelCidade.Name = "LabelCidade"
        Me.LabelCidade.Size = New System.Drawing.Size(59, 20)
        Me.LabelCidade.TabIndex = 23
        Me.LabelCidade.Text = "Cidade"
        '
        'TextBoxEstado
        '
        Me.TextBoxEstado.Location = New System.Drawing.Point(97, 440)
        Me.TextBoxEstado.Name = "TextBoxEstado"
        Me.TextBoxEstado.Size = New System.Drawing.Size(33, 26)
        Me.TextBoxEstado.TabIndex = 22
        '
        'LabelEstado
        '
        Me.LabelEstado.AutoSize = True
        Me.LabelEstado.Location = New System.Drawing.Point(20, 447)
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(60, 20)
        Me.LabelEstado.TabIndex = 21
        Me.LabelEstado.Text = "Estado"
        '
        'MaskedTextBoxCEP
        '
        Me.MaskedTextBoxCEP.Location = New System.Drawing.Point(97, 408)
        Me.MaskedTextBoxCEP.Mask = "00000-999"
        Me.MaskedTextBoxCEP.Name = "MaskedTextBoxCEP"
        Me.MaskedTextBoxCEP.Size = New System.Drawing.Size(83, 26)
        Me.MaskedTextBoxCEP.TabIndex = 20
        '
        'LabelCEP
        '
        Me.LabelCEP.AutoSize = True
        Me.LabelCEP.Location = New System.Drawing.Point(20, 414)
        Me.LabelCEP.Name = "LabelCEP"
        Me.LabelCEP.Size = New System.Drawing.Size(41, 20)
        Me.LabelCEP.TabIndex = 19
        Me.LabelCEP.Text = "CEP"
        '
        'TextBoxBairro
        '
        Me.TextBoxBairro.Location = New System.Drawing.Point(97, 375)
        Me.TextBoxBairro.Name = "TextBoxBairro"
        Me.TextBoxBairro.Size = New System.Drawing.Size(202, 26)
        Me.TextBoxBairro.TabIndex = 18
        '
        'LabelBairro
        '
        Me.LabelBairro.AutoSize = True
        Me.LabelBairro.Location = New System.Drawing.Point(20, 375)
        Me.LabelBairro.Name = "LabelBairro"
        Me.LabelBairro.Size = New System.Drawing.Size(51, 20)
        Me.LabelBairro.TabIndex = 17
        Me.LabelBairro.Text = "Bairro"
        '
        'TextBoxEndereco
        '
        Me.TextBoxEndereco.Location = New System.Drawing.Point(82, 463)
        Me.TextBoxEndereco.Name = "TextBoxEndereco"
        Me.TextBoxEndereco.Size = New System.Drawing.Size(202, 26)
        Me.TextBoxEndereco.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Endereço"
        '
        'LabelValidade
        '
        Me.LabelValidade.AutoSize = True
        Me.LabelValidade.Location = New System.Drawing.Point(17, 301)
        Me.LabelValidade.Name = "LabelValidade"
        Me.LabelValidade.Size = New System.Drawing.Size(71, 20)
        Me.LabelValidade.TabIndex = 13
        Me.LabelValidade.Text = "Validade"
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.Location = New System.Drawing.Point(97, 260)
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.Size = New System.Drawing.Size(202, 26)
        Me.TextBoxCategoria.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Categoria"
        '
        'TextBoxNCNH
        '
        Me.TextBoxNCNH.Location = New System.Drawing.Point(97, 219)
        Me.TextBoxNCNH.Name = "TextBoxNCNH"
        Me.TextBoxNCNH.Size = New System.Drawing.Size(202, 26)
        Me.TextBoxNCNH.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "N° CNH"
        '
        'LabelCelular
        '
        Me.LabelCelular.AutoSize = True
        Me.LabelCelular.Location = New System.Drawing.Point(17, 185)
        Me.LabelCelular.Name = "LabelCelular"
        Me.LabelCelular.Size = New System.Drawing.Size(58, 20)
        Me.LabelCelular.TabIndex = 8
        Me.LabelCelular.Text = "Celular"
        '
        'MaskedTextBoxCelular
        '
        Me.MaskedTextBoxCelular.Location = New System.Drawing.Point(107, 178)
        Me.MaskedTextBoxCelular.Mask = "(011) 0000-0000"
        Me.MaskedTextBoxCelular.Name = "MaskedTextBoxCelular"
        Me.MaskedTextBoxCelular.Size = New System.Drawing.Size(137, 26)
        Me.MaskedTextBoxCelular.TabIndex = 7
        '
        'MaskedTextBoxTelefone
        '
        Me.MaskedTextBoxTelefone.Location = New System.Drawing.Point(107, 144)
        Me.MaskedTextBoxTelefone.Mask = "(011) 0000-0000"
        Me.MaskedTextBoxTelefone.Name = "MaskedTextBoxTelefone"
        Me.MaskedTextBoxTelefone.Size = New System.Drawing.Size(137, 26)
        Me.MaskedTextBoxTelefone.TabIndex = 6
        '
        'LabelTeleone
        '
        Me.LabelTeleone.AutoSize = True
        Me.LabelTeleone.Location = New System.Drawing.Point(17, 145)
        Me.LabelTeleone.Name = "LabelTeleone"
        Me.LabelTeleone.Size = New System.Drawing.Size(71, 20)
        Me.LabelTeleone.TabIndex = 5
        Me.LabelTeleone.Text = "Telefone"
        '
        'TextBoxCPF
        '
        Me.TextBoxCPF.Location = New System.Drawing.Point(76, 93)
        Me.TextBoxCPF.Name = "TextBoxCPF"
        Me.TextBoxCPF.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxCPF.TabIndex = 4
        '
        'LabelCPF
        '
        Me.LabelCPF.AutoSize = True
        Me.LabelCPF.Location = New System.Drawing.Point(17, 96)
        Me.LabelCPF.Name = "LabelCPF"
        Me.LabelCPF.Size = New System.Drawing.Size(40, 20)
        Me.LabelCPF.TabIndex = 3
        Me.LabelCPF.Text = "CPF"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(76, 45)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxNome.TabIndex = 2
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(17, 48)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(51, 20)
        Me.LabelNome.TabIndex = 0
        Me.LabelNome.Text = "Nome"
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
        Me.Panel1.Location = New System.Drawing.Point(371, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 498)
        Me.Panel1.TabIndex = 3
        '
        'ButtonSair
        '
        Me.ButtonSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonSair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSair.ForeColor = System.Drawing.Color.White
        Me.ButtonSair.Location = New System.Drawing.Point(11, 387)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(189, 97)
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
        Me.ButtonLimpar.Location = New System.Drawing.Point(10, 287)
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
        Me.ButtonAlterar.Location = New System.Drawing.Point(11, 177)
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
        Me.ButtonExcluir.Location = New System.Drawing.Point(11, 92)
        Me.ButtonExcluir.Name = "ButtonExcluir"
        Me.ButtonExcluir.Size = New System.Drawing.Size(189, 79)
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
        Me.ButtonIncluir.Location = New System.Drawing.Point(11, 16)
        Me.ButtonIncluir.Name = "ButtonIncluir"
        Me.ButtonIncluir.Size = New System.Drawing.Size(189, 70)
        Me.ButtonIncluir.TabIndex = 1
        Me.ButtonIncluir.Text = "Incluir"
        Me.ButtonIncluir.UseVisualStyleBackColor = False
        '
        'FormCadastroDeClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(624, 745)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelClientes)
        Me.Controls.Add(Me.GroupBoxRG)
        Me.Name = "FormCadastroDeClientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CLIENTES"
        Me.GroupBoxRG.ResumeLayout(False)
        Me.GroupBoxRG.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxRG As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxRG As System.Windows.Forms.TextBox
    Friend WithEvents ButtonConsultar As System.Windows.Forms.Button
    Friend WithEvents LabelClientes As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonAlterar As System.Windows.Forms.Button
    Friend WithEvents ButtonExcluir As System.Windows.Forms.Button
    Friend WithEvents ButtonIncluir As System.Windows.Forms.Button
    Friend WithEvents ButtonLimpar As System.Windows.Forms.Button
    Friend WithEvents ButtonSair As System.Windows.Forms.Button
    Friend WithEvents LabelCPF As System.Windows.Forms.Label
    Friend WithEvents TextBoxNome As System.Windows.Forms.TextBox
    Friend WithEvents LabelNome As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelTeleone As System.Windows.Forms.Label
    Friend WithEvents TextBoxCPF As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelCelular As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBoxNCNH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelBairro As System.Windows.Forms.Label
    Friend WithEvents TextBoxEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelValidade As System.Windows.Forms.Label
    Friend WithEvents TextBoxCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCidade As System.Windows.Forms.TextBox
    Friend WithEvents LabelCidade As System.Windows.Forms.Label
    Friend WithEvents TextBoxEstado As System.Windows.Forms.TextBox
    Friend WithEvents LabelEstado As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelCEP As System.Windows.Forms.Label
    Friend WithEvents TextBoxBairro As System.Windows.Forms.TextBox
    Friend WithEvents LabelNascimento As System.Windows.Forms.Label
    Friend WithEvents LabelEmail As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxEmail As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxNascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxValidade As System.Windows.Forms.MaskedTextBox

End Class
