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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaskedTextBoxPlaca = New System.Windows.Forms.MaskedTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MaskedTextBoxModelo = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonPesquisar = New System.Windows.Forms.Button()
        Me.ButtonConsultarCarro = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MaskedTextBoxAno = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxDiaria = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.CheckBoxStatus = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxRGCliente = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxCPF = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.Celular = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.MaskedTextBoxCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxNumeroCNH = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxValidade = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBoxRetira = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDevolver = New System.Windows.Forms.ComboBox()
        Me.LabelDiarias = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LabelValorDiarias = New System.Windows.Forms.Label()
        Me.ButtonConfirmarLocacao = New System.Windows.Forms.Button()
        Me.ButtonImprimir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLACA:"
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.ButtonConsultarCarro)
        Me.Panel1.Controls.Add(Me.ButtonPesquisar)
        Me.Panel1.Controls.Add(Me.MaskedTextBoxPlaca)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 119)
        Me.Panel1.TabIndex = 2
        '
        'MaskedTextBoxPlaca
        '
        Me.MaskedTextBoxPlaca.Location = New System.Drawing.Point(60, 68)
        Me.MaskedTextBoxPlaca.Name = "MaskedTextBoxPlaca"
        Me.MaskedTextBoxPlaca.Size = New System.Drawing.Size(237, 20)
        Me.MaskedTextBoxPlaca.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.CheckBoxStatus)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.MaskedTextBoxDiaria)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.MaskedTextBoxAno)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.MaskedTextBoxModelo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 187)
        Me.Panel2.TabIndex = 3
        '
        'MaskedTextBoxModelo
        '
        Me.MaskedTextBoxModelo.Location = New System.Drawing.Point(77, 36)
        Me.MaskedTextBoxModelo.Name = "MaskedTextBoxModelo"
        Me.MaskedTextBoxModelo.Size = New System.Drawing.Size(237, 20)
        Me.MaskedTextBoxModelo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DADOS:"
        '
        'ButtonPesquisar
        '
        Me.ButtonPesquisar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonPesquisar.BackgroundImage = Global.Aula_31_07_14.My.Resources.Resources._1408516857_search
        Me.ButtonPesquisar.Location = New System.Drawing.Point(361, 68)
        Me.ButtonPesquisar.Name = "ButtonPesquisar"
        Me.ButtonPesquisar.Size = New System.Drawing.Size(26, 29)
        Me.ButtonPesquisar.TabIndex = 4
        Me.ButtonPesquisar.UseVisualStyleBackColor = False
        '
        'ButtonConsultarCarro
        '
        Me.ButtonConsultarCarro.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonConsultarCarro.Location = New System.Drawing.Point(401, 59)
        Me.ButtonConsultarCarro.Name = "ButtonConsultarCarro"
        Me.ButtonConsultarCarro.Size = New System.Drawing.Size(133, 36)
        Me.ButtonConsultarCarro.TabIndex = 5
        Me.ButtonConsultarCarro.Text = "CONSULTAR CARRO"
        Me.ButtonConsultarCarro.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MODELO:"
        '
        'MaskedTextBoxAno
        '
        Me.MaskedTextBoxAno.Location = New System.Drawing.Point(77, 75)
        Me.MaskedTextBoxAno.Name = "MaskedTextBoxAno"
        Me.MaskedTextBoxAno.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxAno.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ANO:"
        '
        'MaskedTextBoxDiaria
        '
        Me.MaskedTextBoxDiaria.Location = New System.Drawing.Point(77, 113)
        Me.MaskedTextBoxDiaria.Name = "MaskedTextBoxDiaria"
        Me.MaskedTextBoxDiaria.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxDiaria.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DIÁRIA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "STATUS:"
        '
        'CheckBoxStatus
        '
        Me.CheckBoxStatus.AutoSize = True
        Me.CheckBoxStatus.Location = New System.Drawing.Point(77, 152)
        Me.CheckBoxStatus.Name = "CheckBoxStatus"
        Me.CheckBoxStatus.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxStatus.TabIndex = 10
        Me.CheckBoxStatus.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.MaskedTextBoxValidade)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.TextBoxCategoria)
        Me.Panel3.Controls.Add(Me.MaskedTextBoxNumeroCNH)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.MaskedTextBoxCelular)
        Me.Panel3.Controls.Add(Me.TextBoxNome)
        Me.Panel3.Controls.Add(Me.Celular)
        Me.Panel3.Controls.Add(Me.ButtonConsultar)
        Me.Panel3.Controls.Add(Me.MaskedTextBoxCPF)
        Me.Panel3.Controls.Add(Me.MaskedTextBoxRGCliente)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(12, 354)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(534, 266)
        Me.Panel3.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "CPF:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "NOME:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "RG Cliente:"
        '
        'MaskedTextBoxRGCliente
        '
        Me.MaskedTextBoxRGCliente.Location = New System.Drawing.Point(77, 30)
        Me.MaskedTextBoxRGCliente.Name = "MaskedTextBoxRGCliente"
        Me.MaskedTextBoxRGCliente.Size = New System.Drawing.Size(162, 20)
        Me.MaskedTextBoxRGCliente.TabIndex = 11
        '
        'MaskedTextBoxCPF
        '
        Me.MaskedTextBoxCPF.Location = New System.Drawing.Point(77, 120)
        Me.MaskedTextBoxCPF.Name = "MaskedTextBoxCPF"
        Me.MaskedTextBoxCPF.Size = New System.Drawing.Size(162, 20)
        Me.MaskedTextBoxCPF.TabIndex = 12
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonConsultar.Location = New System.Drawing.Point(384, 21)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(133, 36)
        Me.ButtonConsultar.TabIndex = 6
        Me.ButtonConsultar.Text = "CONSULTAR "
        Me.ButtonConsultar.UseVisualStyleBackColor = False
        '
        'Celular
        '
        Me.Celular.AutoSize = True
        Me.Celular.Location = New System.Drawing.Point(19, 167)
        Me.Celular.Name = "Celular"
        Me.Celular.Size = New System.Drawing.Size(59, 13)
        Me.Celular.TabIndex = 13
        Me.Celular.Text = "CELULAR:"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(77, 78)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxNome.TabIndex = 14
        '
        'MaskedTextBoxCelular
        '
        Me.MaskedTextBoxCelular.Location = New System.Drawing.Point(77, 164)
        Me.MaskedTextBoxCelular.Name = "MaskedTextBoxCelular"
        Me.MaskedTextBoxCelular.Size = New System.Drawing.Size(162, 20)
        Me.MaskedTextBoxCelular.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nº CNH:"
        '
        'MaskedTextBoxNumeroCNH
        '
        Me.MaskedTextBoxNumeroCNH.Location = New System.Drawing.Point(77, 203)
        Me.MaskedTextBoxNumeroCNH.Name = "MaskedTextBoxNumeroCNH"
        Me.MaskedTextBoxNumeroCNH.Size = New System.Drawing.Size(162, 20)
        Me.MaskedTextBoxNumeroCNH.TabIndex = 17
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.Location = New System.Drawing.Point(77, 236)
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCategoria.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "CATEGORIA:"
        '
        'MaskedTextBoxValidade
        '
        Me.MaskedTextBoxValidade.Location = New System.Drawing.Point(287, 236)
        Me.MaskedTextBoxValidade.Name = "MaskedTextBoxValidade"
        Me.MaskedTextBoxValidade.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxValidade.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(218, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "VALIDADE:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.ButtonImprimir)
        Me.Panel4.Controls.Add(Me.ButtonConfirmarLocacao)
        Me.Panel4.Controls.Add(Me.LabelValorDiarias)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.LabelDiarias)
        Me.Panel4.Controls.Add(Me.ComboBoxDevolver)
        Me.Panel4.Controls.Add(Me.ComboBoxRetira)
        Me.Panel4.Controls.Add(Me.CheckBox2)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Location = New System.Drawing.Point(12, 626)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(562, 149)
        Me.Panel4.TabIndex = 5
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(77, 152)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "STATUS:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "DIÁRIAS:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "DEVOLVER:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "RETIRA:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "DATAS:"
        '
        'ComboBoxRetira
        '
        Me.ComboBoxRetira.FormattingEnabled = True
        Me.ComboBoxRetira.Location = New System.Drawing.Point(75, 40)
        Me.ComboBoxRetira.Name = "ComboBoxRetira"
        Me.ComboBoxRetira.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxRetira.TabIndex = 11
        '
        'ComboBoxDevolver
        '
        Me.ComboBoxDevolver.FormattingEnabled = True
        Me.ComboBoxDevolver.Location = New System.Drawing.Point(74, 78)
        Me.ComboBoxDevolver.Name = "ComboBoxDevolver"
        Me.ComboBoxDevolver.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDevolver.TabIndex = 12
        '
        'LabelDiarias
        '
        Me.LabelDiarias.AutoSize = True
        Me.LabelDiarias.Location = New System.Drawing.Point(78, 120)
        Me.LabelDiarias.Name = "LabelDiarias"
        Me.LabelDiarias.Size = New System.Drawing.Size(19, 13)
        Me.LabelDiarias.TabIndex = 9
        Me.LabelDiarias.Text = "__"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(224, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 13)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "VALOR DAS DIÁRIAS:"
        '
        'LabelValorDiarias
        '
        Me.LabelValorDiarias.AutoSize = True
        Me.LabelValorDiarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValorDiarias.Location = New System.Drawing.Point(357, 43)
        Me.LabelValorDiarias.Name = "LabelValorDiarias"
        Me.LabelValorDiarias.Size = New System.Drawing.Size(27, 20)
        Me.LabelValorDiarias.TabIndex = 10
        Me.LabelValorDiarias.Text = "__"
        '
        'ButtonConfirmarLocacao
        '
        Me.ButtonConfirmarLocacao.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonConfirmarLocacao.Location = New System.Drawing.Point(269, 108)
        Me.ButtonConfirmarLocacao.Name = "ButtonConfirmarLocacao"
        Me.ButtonConfirmarLocacao.Size = New System.Drawing.Size(133, 36)
        Me.ButtonConfirmarLocacao.TabIndex = 7
        Me.ButtonConfirmarLocacao.Text = "CONFIRMAR LOCAÇÃO"
        Me.ButtonConfirmarLocacao.UseVisualStyleBackColor = False
        '
        'ButtonImprimir
        '
        Me.ButtonImprimir.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonImprimir.Location = New System.Drawing.Point(408, 108)
        Me.ButtonImprimir.Name = "ButtonImprimir"
        Me.ButtonImprimir.Size = New System.Drawing.Size(133, 36)
        Me.ButtonImprimir.TabIndex = 8
        Me.ButtonImprimir.Text = "IMPRIMIR"
        Me.ButtonImprimir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 786)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MaskedTextBoxPlaca As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MaskedTextBoxModelo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonConsultarCarro As System.Windows.Forms.Button
    Friend WithEvents ButtonPesquisar As System.Windows.Forms.Button
    Friend WithEvents CheckBoxStatus As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxDiaria As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxAno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxRGCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonConsultar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxValidade As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCategoria As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBoxNumeroCNH As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBoxNome As System.Windows.Forms.TextBox
    Friend WithEvents Celular As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ComboBoxDevolver As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxRetira As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LabelDiarias As System.Windows.Forms.Label
    Friend WithEvents ButtonImprimir As System.Windows.Forms.Button
    Friend WithEvents ButtonConfirmarLocacao As System.Windows.Forms.Button
    Friend WithEvents LabelValorDiarias As System.Windows.Forms.Label

End Class
