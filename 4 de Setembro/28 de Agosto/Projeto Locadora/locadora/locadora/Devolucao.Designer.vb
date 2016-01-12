<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devolucao
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
        Me.GroupBoxPlaca = New System.Windows.Forms.GroupBox()
        Me.TextBoxPlaca = New System.Windows.Forms.TextBox()
        Me.ButtonDevolverVeiculo = New System.Windows.Forms.Button()
        Me.GroupBoxRGCliente = New System.Windows.Forms.GroupBox()
        Me.TextBoxPesquisa = New System.Windows.Forms.TextBox()
        Me.TextBoxCPF = New System.Windows.Forms.TextBox()
        Me.LabelCPF = New System.Windows.Forms.Label()
        Me.LabelCelular = New System.Windows.Forms.Label()
        Me.MaskedTextBoxValidade = New System.Windows.Forms.MaskedTextBox()
        Me.LabelValidade = New System.Windows.Forms.Label()
        Me.TextBoxCategoriaCliente = New System.Windows.Forms.TextBox()
        Me.LabelCategoriaCliente = New System.Windows.Forms.Label()
        Me.TextBoxNCNH = New System.Windows.Forms.TextBox()
        Me.LabelNCNH = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCelular = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxModelo = New System.Windows.Forms.TextBox()
        Me.LabelAno = New System.Windows.Forms.Label()
        Me.LabelDiaria = New System.Windows.Forms.Label()
        Me.TextBoxDiaria = New System.Windows.Forms.TextBox()
        Me.MaskedTextBoxAno = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBoxDadosVeiculo = New System.Windows.Forms.GroupBox()
        Me.LabelDiarias = New System.Windows.Forms.Label()
        Me.LabelValorDasDiarias = New System.Windows.Forms.Label()
        Me.LabelCifrao = New System.Windows.Forms.Label()
        Me.LabelDinheiro = New System.Windows.Forms.Label()
        Me.GroupBoxDadosDaLocacao = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelDataDaLocacao = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBoxPlaca.SuspendLayout()
        Me.GroupBoxRGCliente.SuspendLayout()
        Me.GroupBoxDadosVeiculo.SuspendLayout()
        Me.GroupBoxDadosDaLocacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxPlaca
        '
        Me.GroupBoxPlaca.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBoxPlaca.Controls.Add(Me.TextBoxPlaca)
        Me.GroupBoxPlaca.Controls.Add(Me.ButtonDevolverVeiculo)
        Me.GroupBoxPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPlaca.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxPlaca.Location = New System.Drawing.Point(27, 31)
        Me.GroupBoxPlaca.Name = "GroupBoxPlaca"
        Me.GroupBoxPlaca.Size = New System.Drawing.Size(664, 97)
        Me.GroupBoxPlaca.TabIndex = 1
        Me.GroupBoxPlaca.TabStop = False
        Me.GroupBoxPlaca.Text = "PLACA"
        '
        'TextBoxPlaca
        '
        Me.TextBoxPlaca.Location = New System.Drawing.Point(76, 40)
        Me.TextBoxPlaca.Name = "TextBoxPlaca"
        Me.TextBoxPlaca.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxPlaca.TabIndex = 1
        '
        'ButtonDevolverVeiculo
        '
        Me.ButtonDevolverVeiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonDevolverVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonDevolverVeiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDevolverVeiculo.ForeColor = System.Drawing.Color.White
        Me.ButtonDevolverVeiculo.Location = New System.Drawing.Point(380, 25)
        Me.ButtonDevolverVeiculo.Name = "ButtonDevolverVeiculo"
        Me.ButtonDevolverVeiculo.Size = New System.Drawing.Size(246, 55)
        Me.ButtonDevolverVeiculo.TabIndex = 0
        Me.ButtonDevolverVeiculo.Text = "Devolver Veiculo"
        Me.ButtonDevolverVeiculo.UseVisualStyleBackColor = False
        '
        'GroupBoxRGCliente
        '
        Me.GroupBoxRGCliente.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxPesquisa)
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxCPF)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelCPF)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelCelular)
        Me.GroupBoxRGCliente.Controls.Add(Me.MaskedTextBoxValidade)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelValidade)
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxCategoriaCliente)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelCategoriaCliente)
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxNCNH)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelNCNH)
        Me.GroupBoxRGCliente.Controls.Add(Me.MaskedTextBoxCelular)
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxNome)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelNome)
        Me.GroupBoxRGCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRGCliente.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxRGCliente.Location = New System.Drawing.Point(27, 284)
        Me.GroupBoxRGCliente.Name = "GroupBoxRGCliente"
        Me.GroupBoxRGCliente.Size = New System.Drawing.Size(554, 326)
        Me.GroupBoxRGCliente.TabIndex = 5
        Me.GroupBoxRGCliente.TabStop = False
        Me.GroupBoxRGCliente.Text = "RG Cliente"
        '
        'TextBoxPesquisa
        '
        Me.TextBoxPesquisa.Location = New System.Drawing.Point(94, 38)
        Me.TextBoxPesquisa.Name = "TextBoxPesquisa"
        Me.TextBoxPesquisa.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxPesquisa.TabIndex = 42
        '
        'TextBoxCPF
        '
        Me.TextBoxCPF.Location = New System.Drawing.Point(94, 142)
        Me.TextBoxCPF.Name = "TextBoxCPF"
        Me.TextBoxCPF.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxCPF.TabIndex = 41
        '
        'LabelCPF
        '
        Me.LabelCPF.AutoSize = True
        Me.LabelCPF.Location = New System.Drawing.Point(27, 145)
        Me.LabelCPF.Name = "LabelCPF"
        Me.LabelCPF.Size = New System.Drawing.Size(40, 20)
        Me.LabelCPF.TabIndex = 40
        Me.LabelCPF.Text = "CPF"
        '
        'LabelCelular
        '
        Me.LabelCelular.AutoSize = True
        Me.LabelCelular.Location = New System.Drawing.Point(26, 192)
        Me.LabelCelular.Name = "LabelCelular"
        Me.LabelCelular.Size = New System.Drawing.Size(58, 20)
        Me.LabelCelular.TabIndex = 39
        Me.LabelCelular.Text = "Celular"
        '
        'MaskedTextBoxValidade
        '
        Me.MaskedTextBoxValidade.Location = New System.Drawing.Point(391, 285)
        Me.MaskedTextBoxValidade.Mask = "00/00/0000"
        Me.MaskedTextBoxValidade.Name = "MaskedTextBoxValidade"
        Me.MaskedTextBoxValidade.Size = New System.Drawing.Size(100, 26)
        Me.MaskedTextBoxValidade.TabIndex = 38
        Me.MaskedTextBoxValidade.ValidatingType = GetType(Date)
        '
        'LabelValidade
        '
        Me.LabelValidade.AutoSize = True
        Me.LabelValidade.Location = New System.Drawing.Point(311, 288)
        Me.LabelValidade.Name = "LabelValidade"
        Me.LabelValidade.Size = New System.Drawing.Size(71, 20)
        Me.LabelValidade.TabIndex = 37
        Me.LabelValidade.Text = "Validade"
        '
        'TextBoxCategoriaCliente
        '
        Me.TextBoxCategoriaCliente.Location = New System.Drawing.Point(94, 282)
        Me.TextBoxCategoriaCliente.Name = "TextBoxCategoriaCliente"
        Me.TextBoxCategoriaCliente.Size = New System.Drawing.Size(202, 26)
        Me.TextBoxCategoriaCliente.TabIndex = 36
        '
        'LabelCategoriaCliente
        '
        Me.LabelCategoriaCliente.AutoSize = True
        Me.LabelCategoriaCliente.Location = New System.Drawing.Point(16, 282)
        Me.LabelCategoriaCliente.Name = "LabelCategoriaCliente"
        Me.LabelCategoriaCliente.Size = New System.Drawing.Size(78, 20)
        Me.LabelCategoriaCliente.TabIndex = 35
        Me.LabelCategoriaCliente.Text = "Categoria"
        '
        'TextBoxNCNH
        '
        Me.TextBoxNCNH.Location = New System.Drawing.Point(94, 241)
        Me.TextBoxNCNH.Name = "TextBoxNCNH"
        Me.TextBoxNCNH.Size = New System.Drawing.Size(202, 26)
        Me.TextBoxNCNH.TabIndex = 34
        '
        'LabelNCNH
        '
        Me.LabelNCNH.AutoSize = True
        Me.LabelNCNH.Location = New System.Drawing.Point(21, 244)
        Me.LabelNCNH.Name = "LabelNCNH"
        Me.LabelNCNH.Size = New System.Drawing.Size(63, 20)
        Me.LabelNCNH.TabIndex = 33
        Me.LabelNCNH.Text = "N° CNH"
        '
        'MaskedTextBoxCelular
        '
        Me.MaskedTextBoxCelular.Location = New System.Drawing.Point(94, 186)
        Me.MaskedTextBoxCelular.Mask = "(011) 0000-0000"
        Me.MaskedTextBoxCelular.Name = "MaskedTextBoxCelular"
        Me.MaskedTextBoxCelular.Size = New System.Drawing.Size(137, 26)
        Me.MaskedTextBoxCelular.TabIndex = 31
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(94, 92)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxNome.TabIndex = 3
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(27, 95)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(51, 20)
        Me.LabelNome.TabIndex = 2
        Me.LabelNome.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modelo"
        '
        'TextBoxModelo
        '
        Me.TextBoxModelo.Location = New System.Drawing.Point(90, 48)
        Me.TextBoxModelo.Name = "TextBoxModelo"
        Me.TextBoxModelo.Size = New System.Drawing.Size(237, 26)
        Me.TextBoxModelo.TabIndex = 2
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
        'LabelDiaria
        '
        Me.LabelDiaria.AutoSize = True
        Me.LabelDiaria.Location = New System.Drawing.Point(212, 102)
        Me.LabelDiaria.Name = "LabelDiaria"
        Me.LabelDiaria.Size = New System.Drawing.Size(50, 20)
        Me.LabelDiaria.TabIndex = 9
        Me.LabelDiaria.Text = "Diaria"
        '
        'TextBoxDiaria
        '
        Me.TextBoxDiaria.Location = New System.Drawing.Point(285, 102)
        Me.TextBoxDiaria.Name = "TextBoxDiaria"
        Me.TextBoxDiaria.Size = New System.Drawing.Size(237, 26)
        Me.TextBoxDiaria.TabIndex = 10
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
        'GroupBoxDadosVeiculo
        '
        Me.GroupBoxDadosVeiculo.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBoxDadosVeiculo.Controls.Add(Me.MaskedTextBoxAno)
        Me.GroupBoxDadosVeiculo.Controls.Add(Me.TextBoxDiaria)
        Me.GroupBoxDadosVeiculo.Controls.Add(Me.LabelDiaria)
        Me.GroupBoxDadosVeiculo.Controls.Add(Me.LabelAno)
        Me.GroupBoxDadosVeiculo.Controls.Add(Me.TextBoxModelo)
        Me.GroupBoxDadosVeiculo.Controls.Add(Me.Label1)
        Me.GroupBoxDadosVeiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDadosVeiculo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBoxDadosVeiculo.Location = New System.Drawing.Point(27, 134)
        Me.GroupBoxDadosVeiculo.Name = "GroupBoxDadosVeiculo"
        Me.GroupBoxDadosVeiculo.Size = New System.Drawing.Size(554, 144)
        Me.GroupBoxDadosVeiculo.TabIndex = 6
        Me.GroupBoxDadosVeiculo.TabStop = False
        Me.GroupBoxDadosVeiculo.Text = "Dados do Veiculo"
        '
        'LabelDiarias
        '
        Me.LabelDiarias.AutoSize = True
        Me.LabelDiarias.Location = New System.Drawing.Point(22, 103)
        Me.LabelDiarias.Name = "LabelDiarias"
        Me.LabelDiarias.Size = New System.Drawing.Size(62, 20)
        Me.LabelDiarias.TabIndex = 38
        Me.LabelDiarias.Text = "Diarias:"
        '
        'LabelValorDasDiarias
        '
        Me.LabelValorDasDiarias.AutoSize = True
        Me.LabelValorDasDiarias.Location = New System.Drawing.Point(376, 103)
        Me.LabelValorDasDiarias.Name = "LabelValorDasDiarias"
        Me.LabelValorDasDiarias.Size = New System.Drawing.Size(68, 20)
        Me.LabelValorDasDiarias.TabIndex = 40
        Me.LabelValorDasDiarias.Text = "VALOR:"
        '
        'LabelCifrao
        '
        Me.LabelCifrao.AutoSize = True
        Me.LabelCifrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCifrao.Location = New System.Drawing.Point(450, 103)
        Me.LabelCifrao.Name = "LabelCifrao"
        Me.LabelCifrao.Size = New System.Drawing.Size(37, 20)
        Me.LabelCifrao.TabIndex = 41
        Me.LabelCifrao.Text = "R$ "
        '
        'LabelDinheiro
        '
        Me.LabelDinheiro.AutoSize = True
        Me.LabelDinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDinheiro.Location = New System.Drawing.Point(480, 103)
        Me.LabelDinheiro.Name = "LabelDinheiro"
        Me.LabelDinheiro.Size = New System.Drawing.Size(44, 20)
        Me.LabelDinheiro.TabIndex = 42
        Me.LabelDinheiro.Text = "0,00"
        '
        'GroupBoxDadosDaLocacao
        '
        Me.GroupBoxDadosDaLocacao.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBoxDadosDaLocacao.Controls.Add(Me.Label2)
        Me.GroupBoxDadosDaLocacao.Controls.Add(Me.LabelDataDaLocacao)
        Me.GroupBoxDadosDaLocacao.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBoxDadosDaLocacao.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBoxDadosDaLocacao.Controls.Add(Me.LabelDinheiro)
        Me.GroupBoxDadosDaLocacao.Controls.Add(Me.LabelCifrao)
        Me.GroupBoxDadosDaLocacao.Controls.Add(Me.LabelValorDasDiarias)
        Me.GroupBoxDadosDaLocacao.Controls.Add(Me.LabelDiarias)
        Me.GroupBoxDadosDaLocacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDadosDaLocacao.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxDadosDaLocacao.Location = New System.Drawing.Point(27, 626)
        Me.GroupBoxDadosDaLocacao.Name = "GroupBoxDadosDaLocacao"
        Me.GroupBoxDadosDaLocacao.Size = New System.Drawing.Size(632, 139)
        Me.GroupBoxDadosDaLocacao.TabIndex = 7
        Me.GroupBoxDadosDaLocacao.TabStop = False
        Me.GroupBoxDadosDaLocacao.Text = "Dados da Locação"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Data da Devolução:"
        '
        'LabelDataDaLocacao
        '
        Me.LabelDataDaLocacao.AutoSize = True
        Me.LabelDataDaLocacao.Location = New System.Drawing.Point(21, 49)
        Me.LabelDataDaLocacao.Name = "LabelDataDaLocacao"
        Me.LabelDataDaLocacao.Size = New System.Drawing.Size(135, 20)
        Me.LabelDataDaLocacao.TabIndex = 45
        Me.LabelDataDaLocacao.Text = "Data da Locação:"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(464, 46)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 26)
        Me.MaskedTextBox2.TabIndex = 44
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(158, 43)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.MaskedTextBox1.TabIndex = 43
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Devolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(711, 777)
        Me.Controls.Add(Me.GroupBoxDadosDaLocacao)
        Me.Controls.Add(Me.GroupBoxDadosVeiculo)
        Me.Controls.Add(Me.GroupBoxRGCliente)
        Me.Controls.Add(Me.GroupBoxPlaca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Devolucao"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolucao"
        Me.GroupBoxPlaca.ResumeLayout(False)
        Me.GroupBoxPlaca.PerformLayout()
        Me.GroupBoxRGCliente.ResumeLayout(False)
        Me.GroupBoxRGCliente.PerformLayout()
        Me.GroupBoxDadosVeiculo.ResumeLayout(False)
        Me.GroupBoxDadosVeiculo.PerformLayout()
        Me.GroupBoxDadosDaLocacao.ResumeLayout(False)
        Me.GroupBoxDadosDaLocacao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxPlaca As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPlaca As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDevolverVeiculo As System.Windows.Forms.Button
    Friend WithEvents GroupBoxRGCliente As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCPF As System.Windows.Forms.TextBox
    Friend WithEvents LabelCPF As System.Windows.Forms.Label
    Friend WithEvents LabelCelular As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxValidade As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelValidade As System.Windows.Forms.Label
    Friend WithEvents TextBoxCategoriaCliente As System.Windows.Forms.TextBox
    Friend WithEvents LabelCategoriaCliente As System.Windows.Forms.Label
    Friend WithEvents TextBoxNCNH As System.Windows.Forms.TextBox
    Friend WithEvents LabelNCNH As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBoxNome As System.Windows.Forms.TextBox
    Friend WithEvents LabelNome As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxModelo As System.Windows.Forms.TextBox
    Friend WithEvents LabelAno As System.Windows.Forms.Label
    Friend WithEvents LabelDiaria As System.Windows.Forms.Label
    Friend WithEvents TextBoxDiaria As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBoxAno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBoxDadosVeiculo As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents LabelDiarias As System.Windows.Forms.Label
    Friend WithEvents LabelValorDasDiarias As System.Windows.Forms.Label
    Friend WithEvents LabelCifrao As System.Windows.Forms.Label
    Friend WithEvents LabelDinheiro As System.Windows.Forms.Label
    Friend WithEvents GroupBoxDadosDaLocacao As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelDataDaLocacao As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
End Class
