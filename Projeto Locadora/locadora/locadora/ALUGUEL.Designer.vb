<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALUGUEL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALUGUEL))
        Me.GroupBoxPlaca = New System.Windows.Forms.GroupBox()
        Me.TextBoxPlaca = New System.Windows.Forms.TextBox()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBoxAno = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxStatus = New System.Windows.Forms.TextBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.TextBoxDiaria = New System.Windows.Forms.TextBox()
        Me.LabelDiaria = New System.Windows.Forms.Label()
        Me.LabelAno = New System.Windows.Forms.Label()
        Me.TextBoxModelo = New System.Windows.Forms.TextBox()
        Me.LabelModelo = New System.Windows.Forms.Label()
        Me.GroupBoxRGCliente = New System.Windows.Forms.GroupBox()
        Me.TextBoxCPF = New System.Windows.Forms.TextBox()
        Me.LabelCPF = New System.Windows.Forms.Label()
        Me.LabelCelular = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCelular = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxValidade = New System.Windows.Forms.MaskedTextBox()
        Me.LabelValidade = New System.Windows.Forms.Label()
        Me.TextBoxCategoriaCliente = New System.Windows.Forms.TextBox()
        Me.LabelCategoriaCliente = New System.Windows.Forms.Label()
        Me.TextBoxNCNH = New System.Windows.Forms.TextBox()
        Me.LabelNCNH = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.TextBoxRG = New System.Windows.Forms.TextBox()
        Me.ButtonConsultarCliente = New System.Windows.Forms.Button()
        Me.GroupBoxDatas = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerDevolve = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerRetira = New System.Windows.Forms.DateTimePicker()
        Me.ButtonImprimir = New System.Windows.Forms.Button()
        Me.ButtonConfirmarLocacao = New System.Windows.Forms.Button()
        Me.LabelDinheiro = New System.Windows.Forms.Label()
        Me.LabelCifrao = New System.Windows.Forms.Label()
        Me.LabelValorDasDiarias = New System.Windows.Forms.Label()
        Me.LabelNumeroDiarias = New System.Windows.Forms.Label()
        Me.LabelDiarias = New System.Windows.Forms.Label()
        Me.LabelDevolve = New System.Windows.Forms.Label()
        Me.LabelRetira = New System.Windows.Forms.Label()
        Me.PictureBoxDados = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBoxPlaca.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxRGCliente.SuspendLayout()
        Me.GroupBoxDatas.SuspendLayout()
        CType(Me.PictureBoxDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxPlaca
        '
        Me.GroupBoxPlaca.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBoxPlaca.Controls.Add(Me.TextBoxPlaca)
        Me.GroupBoxPlaca.Controls.Add(Me.ButtonConsultar)
        Me.GroupBoxPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPlaca.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxPlaca.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxPlaca.Name = "GroupBoxPlaca"
        Me.GroupBoxPlaca.Size = New System.Drawing.Size(602, 97)
        Me.GroupBoxPlaca.TabIndex = 1
        Me.GroupBoxPlaca.TabStop = False
        Me.GroupBoxPlaca.Text = "Placa"
        '
        'TextBoxPlaca
        '
        Me.TextBoxPlaca.Location = New System.Drawing.Point(37, 39)
        Me.TextBoxPlaca.Name = "TextBoxPlaca"
        Me.TextBoxPlaca.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxPlaca.TabIndex = 1
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultar.ForeColor = System.Drawing.Color.White
        Me.ButtonConsultar.Location = New System.Drawing.Point(379, 25)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(189, 55)
        Me.ButtonConsultar.TabIndex = 0
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxAno)
        Me.GroupBox1.Controls.Add(Me.TextBoxStatus)
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.TextBoxDiaria)
        Me.GroupBox1.Controls.Add(Me.LabelDiaria)
        Me.GroupBox1.Controls.Add(Me.LabelAno)
        Me.GroupBox1.Controls.Add(Me.TextBoxModelo)
        Me.GroupBox1.Controls.Add(Me.LabelModelo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 227)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'MaskedTextBoxAno
        '
        Me.MaskedTextBoxAno.Location = New System.Drawing.Point(106, 96)
        Me.MaskedTextBoxAno.Mask = "00/00/0000"
        Me.MaskedTextBoxAno.Name = "MaskedTextBoxAno"
        Me.MaskedTextBoxAno.Size = New System.Drawing.Size(100, 26)
        Me.MaskedTextBoxAno.TabIndex = 31
        Me.MaskedTextBoxAno.ValidatingType = GetType(Date)
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Location = New System.Drawing.Point(106, 182)
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.Size = New System.Drawing.Size(25, 26)
        Me.TextBoxStatus.TabIndex = 12
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(17, 185)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(56, 20)
        Me.LabelStatus.TabIndex = 11
        Me.LabelStatus.Text = "Status"
        '
        'TextBoxDiaria
        '
        Me.TextBoxDiaria.Location = New System.Drawing.Point(106, 138)
        Me.TextBoxDiaria.Name = "TextBoxDiaria"
        Me.TextBoxDiaria.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxDiaria.TabIndex = 10
        '
        'LabelDiaria
        '
        Me.LabelDiaria.AutoSize = True
        Me.LabelDiaria.Location = New System.Drawing.Point(17, 144)
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
        Me.LabelAno.Size = New System.Drawing.Size(43, 20)
        Me.LabelAno.TabIndex = 3
        Me.LabelAno.Text = "ANO"
        '
        'TextBoxModelo
        '
        Me.TextBoxModelo.Location = New System.Drawing.Point(106, 48)
        Me.TextBoxModelo.Name = "TextBoxModelo"
        Me.TextBoxModelo.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxModelo.TabIndex = 2
        '
        'LabelModelo
        '
        Me.LabelModelo.AutoSize = True
        Me.LabelModelo.Location = New System.Drawing.Point(17, 48)
        Me.LabelModelo.Name = "LabelModelo"
        Me.LabelModelo.Size = New System.Drawing.Size(61, 20)
        Me.LabelModelo.TabIndex = 0
        Me.LabelModelo.Text = "Modelo"
        '
        'GroupBoxRGCliente
        '
        Me.GroupBoxRGCliente.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxCPF)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelCPF)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelCelular)
        Me.GroupBoxRGCliente.Controls.Add(Me.MaskedTextBoxCelular)
        Me.GroupBoxRGCliente.Controls.Add(Me.MaskedTextBoxValidade)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelValidade)
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxCategoriaCliente)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelCategoriaCliente)
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxNCNH)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelNCNH)
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxNome)
        Me.GroupBoxRGCliente.Controls.Add(Me.LabelNome)
        Me.GroupBoxRGCliente.Controls.Add(Me.TextBoxRG)
        Me.GroupBoxRGCliente.Controls.Add(Me.ButtonConsultarCliente)
        Me.GroupBoxRGCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRGCliente.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxRGCliente.Location = New System.Drawing.Point(12, 361)
        Me.GroupBoxRGCliente.Name = "GroupBoxRGCliente"
        Me.GroupBoxRGCliente.Size = New System.Drawing.Size(632, 197)
        Me.GroupBoxRGCliente.TabIndex = 4
        Me.GroupBoxRGCliente.TabStop = False
        Me.GroupBoxRGCliente.Text = "RG Cliente"
        '
        'TextBoxCPF
        '
        Me.TextBoxCPF.Location = New System.Drawing.Point(381, 75)
        Me.TextBoxCPF.Name = "TextBoxCPF"
        Me.TextBoxCPF.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxCPF.TabIndex = 41
        '
        'LabelCPF
        '
        Me.LabelCPF.AutoSize = True
        Me.LabelCPF.Location = New System.Drawing.Point(314, 78)
        Me.LabelCPF.Name = "LabelCPF"
        Me.LabelCPF.Size = New System.Drawing.Size(40, 20)
        Me.LabelCPF.TabIndex = 40
        Me.LabelCPF.Text = "CPF"
        '
        'LabelCelular
        '
        Me.LabelCelular.AutoSize = True
        Me.LabelCelular.Location = New System.Drawing.Point(17, 116)
        Me.LabelCelular.Name = "LabelCelular"
        Me.LabelCelular.Size = New System.Drawing.Size(58, 20)
        Me.LabelCelular.TabIndex = 39
        Me.LabelCelular.Text = "Celular"
        '
        'MaskedTextBoxCelular
        '
        Me.MaskedTextBoxCelular.Location = New System.Drawing.Point(85, 110)
        Me.MaskedTextBoxCelular.Mask = "(011) 0000-0000"
        Me.MaskedTextBoxCelular.Name = "MaskedTextBoxCelular"
        Me.MaskedTextBoxCelular.Size = New System.Drawing.Size(137, 26)
        Me.MaskedTextBoxCelular.TabIndex = 31
        '
        'MaskedTextBoxValidade
        '
        Me.MaskedTextBoxValidade.Location = New System.Drawing.Point(383, 156)
        Me.MaskedTextBoxValidade.Mask = "00/00/0000"
        Me.MaskedTextBoxValidade.Name = "MaskedTextBoxValidade"
        Me.MaskedTextBoxValidade.Size = New System.Drawing.Size(100, 26)
        Me.MaskedTextBoxValidade.TabIndex = 38
        Me.MaskedTextBoxValidade.ValidatingType = GetType(Date)
        '
        'LabelValidade
        '
        Me.LabelValidade.AutoSize = True
        Me.LabelValidade.Location = New System.Drawing.Point(303, 159)
        Me.LabelValidade.Name = "LabelValidade"
        Me.LabelValidade.Size = New System.Drawing.Size(71, 20)
        Me.LabelValidade.TabIndex = 37
        Me.LabelValidade.Text = "Validade"
        '
        'TextBoxCategoriaCliente
        '
        Me.TextBoxCategoriaCliente.Location = New System.Drawing.Point(95, 153)
        Me.TextBoxCategoriaCliente.Name = "TextBoxCategoriaCliente"
        Me.TextBoxCategoriaCliente.Size = New System.Drawing.Size(202, 26)
        Me.TextBoxCategoriaCliente.TabIndex = 36
        '
        'LabelCategoriaCliente
        '
        Me.LabelCategoriaCliente.AutoSize = True
        Me.LabelCategoriaCliente.Location = New System.Drawing.Point(17, 153)
        Me.LabelCategoriaCliente.Name = "LabelCategoriaCliente"
        Me.LabelCategoriaCliente.Size = New System.Drawing.Size(78, 20)
        Me.LabelCategoriaCliente.TabIndex = 35
        Me.LabelCategoriaCliente.Text = "Categoria"
        '
        'TextBoxNCNH
        '
        Me.TextBoxNCNH.Location = New System.Drawing.Point(317, 113)
        Me.TextBoxNCNH.Name = "TextBoxNCNH"
        Me.TextBoxNCNH.Size = New System.Drawing.Size(202, 26)
        Me.TextBoxNCNH.TabIndex = 34
        '
        'LabelNCNH
        '
        Me.LabelNCNH.AutoSize = True
        Me.LabelNCNH.Location = New System.Drawing.Point(244, 116)
        Me.LabelNCNH.Name = "LabelNCNH"
        Me.LabelNCNH.Size = New System.Drawing.Size(63, 20)
        Me.LabelNCNH.TabIndex = 33
        Me.LabelNCNH.Text = "N° CNH"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(84, 74)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxNome.TabIndex = 3
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(17, 77)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(51, 20)
        Me.LabelNome.TabIndex = 2
        Me.LabelNome.Text = "Nome"
        '
        'TextBoxRG
        '
        Me.TextBoxRG.Location = New System.Drawing.Point(84, 33)
        Me.TextBoxRG.Name = "TextBoxRG"
        Me.TextBoxRG.Size = New System.Drawing.Size(223, 26)
        Me.TextBoxRG.TabIndex = 1
        '
        'ButtonConsultarCliente
        '
        Me.ButtonConsultarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonConsultarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonConsultarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultarCliente.ForeColor = System.Drawing.Color.White
        Me.ButtonConsultarCliente.Location = New System.Drawing.Point(348, 26)
        Me.ButtonConsultarCliente.Name = "ButtonConsultarCliente"
        Me.ButtonConsultarCliente.Size = New System.Drawing.Size(189, 40)
        Me.ButtonConsultarCliente.TabIndex = 0
        Me.ButtonConsultarCliente.Text = "Consultar"
        Me.ButtonConsultarCliente.UseVisualStyleBackColor = False
        '
        'GroupBoxDatas
        '
        Me.GroupBoxDatas.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBoxDatas.Controls.Add(Me.DateTimePickerDevolve)
        Me.GroupBoxDatas.Controls.Add(Me.DateTimePickerRetira)
        Me.GroupBoxDatas.Controls.Add(Me.ButtonImprimir)
        Me.GroupBoxDatas.Controls.Add(Me.ButtonConfirmarLocacao)
        Me.GroupBoxDatas.Controls.Add(Me.LabelDinheiro)
        Me.GroupBoxDatas.Controls.Add(Me.LabelCifrao)
        Me.GroupBoxDatas.Controls.Add(Me.LabelValorDasDiarias)
        Me.GroupBoxDatas.Controls.Add(Me.LabelNumeroDiarias)
        Me.GroupBoxDatas.Controls.Add(Me.LabelDiarias)
        Me.GroupBoxDatas.Controls.Add(Me.LabelDevolve)
        Me.GroupBoxDatas.Controls.Add(Me.LabelRetira)
        Me.GroupBoxDatas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatas.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxDatas.Location = New System.Drawing.Point(12, 564)
        Me.GroupBoxDatas.Name = "GroupBoxDatas"
        Me.GroupBoxDatas.Size = New System.Drawing.Size(632, 139)
        Me.GroupBoxDatas.TabIndex = 5
        Me.GroupBoxDatas.TabStop = False
        Me.GroupBoxDatas.Text = "DATAS"
        '
        'DateTimePickerDevolve
        '
        Me.DateTimePickerDevolve.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDevolve.Location = New System.Drawing.Point(83, 77)
        Me.DateTimePickerDevolve.Name = "DateTimePickerDevolve"
        Me.DateTimePickerDevolve.Size = New System.Drawing.Size(106, 26)
        Me.DateTimePickerDevolve.TabIndex = 46
        Me.DateTimePickerDevolve.Value = New Date(2014, 9, 4, 16, 50, 6, 0)
        '
        'DateTimePickerRetira
        '
        Me.DateTimePickerRetira.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerRetira.Location = New System.Drawing.Point(84, 40)
        Me.DateTimePickerRetira.Name = "DateTimePickerRetira"
        Me.DateTimePickerRetira.Size = New System.Drawing.Size(105, 26)
        Me.DateTimePickerRetira.TabIndex = 45
        '
        'ButtonImprimir
        '
        Me.ButtonImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImprimir.ForeColor = System.Drawing.Color.White
        Me.ButtonImprimir.Location = New System.Drawing.Point(429, 92)
        Me.ButtonImprimir.Name = "ButtonImprimir"
        Me.ButtonImprimir.Size = New System.Drawing.Size(165, 41)
        Me.ButtonImprimir.TabIndex = 44
        Me.ButtonImprimir.Text = "Imprimir"
        Me.ButtonImprimir.UseVisualStyleBackColor = False
        '
        'ButtonConfirmarLocacao
        '
        Me.ButtonConfirmarLocacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonConfirmarLocacao.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonConfirmarLocacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConfirmarLocacao.ForeColor = System.Drawing.Color.White
        Me.ButtonConfirmarLocacao.Location = New System.Drawing.Point(225, 92)
        Me.ButtonConfirmarLocacao.Name = "ButtonConfirmarLocacao"
        Me.ButtonConfirmarLocacao.Size = New System.Drawing.Size(176, 42)
        Me.ButtonConfirmarLocacao.TabIndex = 43
        Me.ButtonConfirmarLocacao.Text = "Confirmar Locação"
        Me.ButtonConfirmarLocacao.UseVisualStyleBackColor = False
        '
        'LabelDinheiro
        '
        Me.LabelDinheiro.AutoSize = True
        Me.LabelDinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDinheiro.Location = New System.Drawing.Point(455, 40)
        Me.LabelDinheiro.Name = "LabelDinheiro"
        Me.LabelDinheiro.Size = New System.Drawing.Size(44, 20)
        Me.LabelDinheiro.TabIndex = 42
        Me.LabelDinheiro.Text = "0,00"
        '
        'LabelCifrao
        '
        Me.LabelCifrao.AutoSize = True
        Me.LabelCifrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCifrao.Location = New System.Drawing.Point(425, 40)
        Me.LabelCifrao.Name = "LabelCifrao"
        Me.LabelCifrao.Size = New System.Drawing.Size(37, 20)
        Me.LabelCifrao.TabIndex = 41
        Me.LabelCifrao.Text = "R$ "
        '
        'LabelValorDasDiarias
        '
        Me.LabelValorDasDiarias.AutoSize = True
        Me.LabelValorDasDiarias.Location = New System.Drawing.Point(249, 40)
        Me.LabelValorDasDiarias.Name = "LabelValorDasDiarias"
        Me.LabelValorDasDiarias.Size = New System.Drawing.Size(177, 20)
        Me.LabelValorDasDiarias.TabIndex = 40
        Me.LabelValorDasDiarias.Text = "VALOR DAS DIARIAS:"
        '
        'LabelNumeroDiarias
        '
        Me.LabelNumeroDiarias.AutoSize = True
        Me.LabelNumeroDiarias.Location = New System.Drawing.Point(79, 114)
        Me.LabelNumeroDiarias.Name = "LabelNumeroDiarias"
        Me.LabelNumeroDiarias.Size = New System.Drawing.Size(18, 20)
        Me.LabelNumeroDiarias.TabIndex = 39
        Me.LabelNumeroDiarias.Text = "0"
        '
        'LabelDiarias
        '
        Me.LabelDiarias.AutoSize = True
        Me.LabelDiarias.Location = New System.Drawing.Point(11, 114)
        Me.LabelDiarias.Name = "LabelDiarias"
        Me.LabelDiarias.Size = New System.Drawing.Size(62, 20)
        Me.LabelDiarias.TabIndex = 38
        Me.LabelDiarias.Text = "Diarias:"
        '
        'LabelDevolve
        '
        Me.LabelDevolve.AutoSize = True
        Me.LabelDevolve.Location = New System.Drawing.Point(11, 77)
        Me.LabelDevolve.Name = "LabelDevolve"
        Me.LabelDevolve.Size = New System.Drawing.Size(65, 20)
        Me.LabelDevolve.TabIndex = 37
        Me.LabelDevolve.Text = "Devolve"
        '
        'LabelRetira
        '
        Me.LabelRetira.AutoSize = True
        Me.LabelRetira.Location = New System.Drawing.Point(11, 40)
        Me.LabelRetira.Name = "LabelRetira"
        Me.LabelRetira.Size = New System.Drawing.Size(52, 20)
        Me.LabelRetira.TabIndex = 36
        Me.LabelRetira.Text = "Retira"
        '
        'PictureBoxDados
        '
        Me.PictureBoxDados.Location = New System.Drawing.Point(430, 137)
        Me.PictureBoxDados.Name = "PictureBoxDados"
        Me.PictureBoxDados.Size = New System.Drawing.Size(214, 218)
        Me.PictureBoxDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxDados.TabIndex = 6
        Me.PictureBoxDados.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ALUGUEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(655, 713)
        Me.Controls.Add(Me.GroupBoxRGCliente)
        Me.Controls.Add(Me.PictureBoxDados)
        Me.Controls.Add(Me.GroupBoxDatas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxPlaca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ALUGUEL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALUGUEL"
        Me.GroupBoxPlaca.ResumeLayout(False)
        Me.GroupBoxPlaca.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxRGCliente.ResumeLayout(False)
        Me.GroupBoxRGCliente.PerformLayout()
        Me.GroupBoxDatas.ResumeLayout(False)
        Me.GroupBoxDatas.PerformLayout()
        CType(Me.PictureBoxDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxPlaca As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPlaca As System.Windows.Forms.TextBox
    Friend WithEvents ButtonConsultar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxStatus As System.Windows.Forms.TextBox
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents TextBoxDiaria As System.Windows.Forms.TextBox
    Friend WithEvents LabelDiaria As System.Windows.Forms.Label
    Friend WithEvents LabelAno As System.Windows.Forms.Label
    Friend WithEvents TextBoxModelo As System.Windows.Forms.TextBox
    Friend WithEvents LabelModelo As System.Windows.Forms.Label
    Friend WithEvents GroupBoxRGCliente As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxNome As System.Windows.Forms.TextBox
    Friend WithEvents LabelNome As System.Windows.Forms.Label
    Friend WithEvents TextBoxRG As System.Windows.Forms.TextBox
    Friend WithEvents ButtonConsultarCliente As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBoxValidade As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelValidade As System.Windows.Forms.Label
    Friend WithEvents TextBoxCategoriaCliente As System.Windows.Forms.TextBox
    Friend WithEvents LabelCategoriaCliente As System.Windows.Forms.Label
    Friend WithEvents TextBoxNCNH As System.Windows.Forms.TextBox
    Friend WithEvents LabelNCNH As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelCelular As System.Windows.Forms.Label
    Friend WithEvents TextBoxCPF As System.Windows.Forms.TextBox
    Friend WithEvents LabelCPF As System.Windows.Forms.Label
    Friend WithEvents GroupBoxDatas As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonImprimir As System.Windows.Forms.Button
    Friend WithEvents ButtonConfirmarLocacao As System.Windows.Forms.Button
    Friend WithEvents LabelDinheiro As System.Windows.Forms.Label
    Friend WithEvents LabelCifrao As System.Windows.Forms.Label
    Friend WithEvents LabelValorDasDiarias As System.Windows.Forms.Label
    Friend WithEvents LabelNumeroDiarias As System.Windows.Forms.Label
    Friend WithEvents LabelDiarias As System.Windows.Forms.Label
    Friend WithEvents LabelDevolve As System.Windows.Forms.Label
    Friend WithEvents LabelRetira As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxAno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DateTimePickerDevolve As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerRetira As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBoxDados As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
