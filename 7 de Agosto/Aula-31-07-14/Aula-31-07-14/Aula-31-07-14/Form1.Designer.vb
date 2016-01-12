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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaskedTextBoxCEP = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxEstado = New System.Windows.Forms.TextBox()
        Me.TextBoxBairro = New System.Windows.Forms.TextBox()
        Me.TextBoxCidade = New System.Windows.Forms.TextBox()
        Me.TextBoxEndereco = New System.Windows.Forms.TextBox()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxNumeroCliente = New System.Windows.Forms.TextBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(517, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(517, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 51)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "LIMPAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(517, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 50)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "NOVO"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(517, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 52)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "CADASTRAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(517, 388)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 53)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "EXCLUIR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(517, 486)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 52)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "ALTERAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 46)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CIDADE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 46)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ENDEREÇO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 46)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "NOME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 46)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "BAIRRO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 46)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ESTADO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 46)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CEP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 46)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "TELEFONE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 480)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 46)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "E-MAIL:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 526)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(255, 39)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "NASCIMENTO:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(314, 31)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "NÚMERO DO CLIENTE:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.MaskedTextBoxCEP)
        Me.Panel1.Controls.Add(Me.MaskedTextBoxTelefone)
        Me.Panel1.Controls.Add(Me.MaskedTextBoxNascimento)
        Me.Panel1.Controls.Add(Me.TextBoxEmail)
        Me.Panel1.Controls.Add(Me.TextBoxEstado)
        Me.Panel1.Controls.Add(Me.TextBoxBairro)
        Me.Panel1.Controls.Add(Me.TextBoxCidade)
        Me.Panel1.Controls.Add(Me.TextBoxEndereco)
        Me.Panel1.Controls.Add(Me.TextBoxNome)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 727)
        Me.Panel1.TabIndex = 18
        '
        'MaskedTextBoxCEP
        '
        Me.MaskedTextBoxCEP.Location = New System.Drawing.Point(264, 388)
        Me.MaskedTextBoxCEP.Mask = "00000-000"
        Me.MaskedTextBoxCEP.Name = "MaskedTextBoxCEP"
        Me.MaskedTextBoxCEP.Size = New System.Drawing.Size(246, 20)
        Me.MaskedTextBoxCEP.TabIndex = 31
        '
        'MaskedTextBoxTelefone
        '
        Me.MaskedTextBoxTelefone.Location = New System.Drawing.Point(265, 442)
        Me.MaskedTextBoxTelefone.Mask = "(00)0000-0000"
        Me.MaskedTextBoxTelefone.Name = "MaskedTextBoxTelefone"
        Me.MaskedTextBoxTelefone.Size = New System.Drawing.Size(246, 20)
        Me.MaskedTextBoxTelefone.TabIndex = 30
        '
        'MaskedTextBoxNascimento
        '
        Me.MaskedTextBoxNascimento.Location = New System.Drawing.Point(265, 543)
        Me.MaskedTextBoxNascimento.Mask = "00/00/0000"
        Me.MaskedTextBoxNascimento.Name = "MaskedTextBoxNascimento"
        Me.MaskedTextBoxNascimento.Size = New System.Drawing.Size(246, 20)
        Me.MaskedTextBoxNascimento.TabIndex = 29
        Me.MaskedTextBoxNascimento.ValidatingType = GetType(Date)
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(264, 480)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(247, 32)
        Me.TextBoxEmail.TabIndex = 25
        '
        'TextBoxEstado
        '
        Me.TextBoxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEstado.Location = New System.Drawing.Point(264, 322)
        Me.TextBoxEstado.Name = "TextBoxEstado"
        Me.TextBoxEstado.Size = New System.Drawing.Size(247, 32)
        Me.TextBoxEstado.TabIndex = 22
        '
        'TextBoxBairro
        '
        Me.TextBoxBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBairro.Location = New System.Drawing.Point(264, 271)
        Me.TextBoxBairro.Name = "TextBoxBairro"
        Me.TextBoxBairro.Size = New System.Drawing.Size(247, 32)
        Me.TextBoxBairro.TabIndex = 21
        '
        'TextBoxCidade
        '
        Me.TextBoxCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCidade.Location = New System.Drawing.Point(264, 216)
        Me.TextBoxCidade.Name = "TextBoxCidade"
        Me.TextBoxCidade.Size = New System.Drawing.Size(247, 32)
        Me.TextBoxCidade.TabIndex = 20
        '
        'TextBoxEndereco
        '
        Me.TextBoxEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEndereco.Location = New System.Drawing.Point(264, 164)
        Me.TextBoxEndereco.Name = "TextBoxEndereco"
        Me.TextBoxEndereco.Size = New System.Drawing.Size(247, 32)
        Me.TextBoxEndereco.TabIndex = 19
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNome.Location = New System.Drawing.Point(264, 108)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(247, 32)
        Me.TextBoxNome.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.cidade, Me.email, Me.Telefone})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 577)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(660, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.TextBoxNumeroCliente)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(11, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(507, 81)
        Me.Panel2.TabIndex = 28
        '
        'TextBoxNumeroCliente
        '
        Me.TextBoxNumeroCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumeroCliente.Location = New System.Drawing.Point(312, 22)
        Me.TextBoxNumeroCliente.Name = "TextBoxNumeroCliente"
        Me.TextBoxNumeroCliente.Size = New System.Drawing.Size(188, 32)
        Me.TextBoxNumeroCliente.TabIndex = 27
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        '
        'cidade
        '
        Me.cidade.HeaderText = "Cidade"
        Me.cidade.Name = "cidade"
        '
        'email
        '
        Me.email.HeaderText = "E-mail"
        Me.email.Name = "email"
        '
        'Telefone
        '
        Me.Telefone.HeaderText = "Telefone"
        Me.Telefone.Name = "Telefone"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 740)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxEndereco As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNome As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEstado As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBairro As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCidade As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBoxNascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefone As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
