Imports System.Data.OleDb 'Primeiramente, importa-se a classe que trabalha com conexões do Banco de dados'



Public Class Form1

    Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Password ="""";User ID=Admin;Data Source=" + Application.StartupPath & "\cadastro.accdb" 'String de configuração com o Banco de dados'
    Dim DBCon As New OleDb.OleDbConnection(ConString) 'DbCon realiza o acesso ao banco de dados'

    Dim registro As String 'Variável que contém o número do cliente'



    Dim dr As OleDb.OleDbDataReader 'Criação do Data reader que receberá a consulta '


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Botão Consulta'

        registro = TextBoxNumeroCliente.Text 'O campo registro recebe o número do cliente'

        If registro = "" Then 'Se o campo não estiver preenchido'
            MessageBox.Show("DIGITE UM CÓDIGO PARA CONSULTA", "ATENÇÃO", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information) 'Imprime uma mensagem de erro'
            TextBoxNumeroCliente.Focus()
            Exit Sub
        End If
        If Not IsNumeric(registro) Then 'Se o campo não estiver preenchido numericamente'
            MessageBox.Show("DIGITE UM CÓDIGO NÚMERICO PARA A CONSULTA") 'Imprime uma mensagem de erro'
            TextBoxNumeroCliente.Focus()
            Exit Sub
        End If
        CONSULTA()  'Chama a consulta'
        DBCon.Close()

    End Sub

    Private Sub CONSULTA() 'Comando que realiza uma consulta no banco de dados'
        Dim strsql As String = "SELECT * FROM CLIENTE WHERE CODIGOCLIENTE =" _
                               + TextBoxNumeroCliente.Text 'Consulta os dados conforme o numero do cliente'

        Dim cm As New OleDb.OleDbCommand(strsql, DBCon) 'Cria uma variável de consulta ao banco de dados'

        Try 'O Try é utilizado sempre que é necessário realizar uma consulta ao BD'
            DBCon.Open() 'Abre a conexão'
            dr = cm.ExecuteReader 'Executa o comando'
            EXIBIR() 'Chama o método de exibição de dados no BD'
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information) 'Imprime mensagem de erro de consulta ao BD'

        End Try

    End Sub

    Private Sub EXIBIR() 'Método que exibe os dados disponíveis do número do cliente no banco de dados'
        If dr.HasRows Then 'Se dados forem retornados'
            While dr.Read
                TextBoxBairro.Text = dr.Item("BAIRRO") 'Insere o dados nos campos de texto'
                MaskedTextBoxCEP.Text = dr.Item("CEP")
                TextBoxCidade.Text = dr.Item("CIDADE")
                TextBoxEmail.Text = dr.Item("EMAIL")
                TextBoxEndereco.Text = dr.Item("ENDERECO")
                MaskedTextBoxTelefone.Text = dr.Item("TELEFONE")
                MaskedTextBoxTelefone.Text = dr.Item("NASCIMENTO")
                TextBoxEstado.Text = dr.Item("ESTADO")
                TextBoxNome.Text = dr.Item("NOME")
            End While
        Else
            MessageBox.Show("NÃO ENCONTRADO")
            TextBoxNumeroCliente.Clear()
            TextBoxNumeroCliente.Focus()
        End If
        DBCon.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim strsql As String
        strsql = "insert into cliente(codigocliente,nome,endereco,cidade,bairro,estado,cep,telefone,email,nascimento)values(@codcliente,@nome,@endereco,@bairro,@estado,@cidade,@cep,@telefone,@email,@nascimento)"
        Dim cm As New OleDb.OleDbCommand(strsql, DBCon)
        cm.Parameters.AddWithValue("@codcliente", TextBoxNumeroCliente.Text)
        cm.Parameters.AddWithValue("@nome", TextBoxNome.Text)
        cm.Parameters.AddWithValue("@endereco", TextBoxEndereco.Text)
        cm.Parameters.AddWithValue("@cidade", TextBoxCidade.Text)
        cm.Parameters.AddWithValue("@bairro", TextBoxBairro.Text)
        cm.Parameters.AddWithValue("@estado", TextBoxEstado.Text)
        cm.Parameters.AddWithValue("@cep", MaskedTextBoxCEP.Text)
        cm.Parameters.AddWithValue("@telefone", MaskedTextBoxTelefone.Text)
        cm.Parameters.AddWithValue("@email", TextBoxEmail.Text)
        cm.Parameters.AddWithValue("@nascimento", MaskedTextBoxNascimento.Text)
        Try
            DBCon.Open()
            cm.ExecuteNonQuery()
            DBCon.Close()
            MessageBox.Show("Registro feito com sucesso")
            Button2.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "atenção")
        End Try
        If Not IsDate(MaskedTextBoxTelefone.Text) Then

        End If
        DBCon.Close()
        atualiza()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub


    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumeroCliente.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strsql As String
        strsql = "select max(codigocliente) as cod_cli from cliente"
        Dim cm As New OleDb.OleDbCommand(strsql, DBCon)
        Try
            DBCon.Open()
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    TextBoxNumeroCliente.Text = dr.Item("cod_cli") + 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção")
        End Try
        DBCon.Close()



    End Sub

    Private Sub MaskedTextBoxTelefone_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBoxNascimento.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBoxTelefone.MaskInputRejected

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim strsql As String
        strsql = "delete from cliente where codigocliente =" + TextBoxNumeroCliente.Text
        Try
            Dim cm As New OleDbCommand(strsql, DBCon)
            If MessageBox.Show("Confirmar exclusão", _
                "Permissão para deletar", MessageBoxButtons.YesNo, _
                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DBCon.State = ConnectionState.Closed Then
                    DBCon.Open()
                End If
                cm.ExecuteNonQuery()
                DBCon.Close()
                Form3.Show()
            End If
            Button2.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        atualiza()

    End Sub
    Private Sub Clear()
        TextBoxNumeroCliente.Text = ""
        TextBoxNome.Text = ""
        TextBoxBairro.Text = ""
        TextBoxCidade.Text = ""
        TextBoxEmail.Text = ""
        TextBoxEstado.Text = ""
        MaskedTextBoxCEP.Text = ""
        MaskedTextBoxNascimento.Text = ""
        MaskedTextBoxTelefone.Text = ""
        TextBoxEndereco.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()
        DBCon.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim strsql As String
        strsql = "Update cliente set Nome=@nome, Endereco=@endereco, Cidade=@cidade, Bairro=@bairro, Estado=@estado, CEP=@cep, Telefone=@telefone, Email=@email, Nascimento=@nascimento where Codigocliente=" + TextBoxNumeroCliente.Text
        Dim cm As New OleDb.OleDbCommand(strsql, DBCon)
        cm.Parameters.AddWithValue("@nome", TextBoxNome.Text)
        cm.Parameters.AddWithValue("@endereco", TextBoxEndereco.Text)
        cm.Parameters.AddWithValue("@cidade", TextBoxCidade.Text)
        cm.Parameters.AddWithValue("@bairro", TextBoxBairro.Text)
        cm.Parameters.AddWithValue("@estado", TextBoxEstado.Text)
        cm.Parameters.AddWithValue("@cep", MaskedTextBoxCEP.Text)
        cm.Parameters.AddWithValue("@telefone", MaskedTextBoxTelefone.Text)
        cm.Parameters.AddWithValue("@email", TextBoxEmail.Text)
        cm.Parameters.AddWithValue("@nascimento", MaskedTextBoxNascimento.Text)
        Try
            DBCon.Open()
            cm.ExecuteNonQuery()
            DBCon.Close()
            MessageBox.Show("Alteração feita com sucesso")
            Button2.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção")
        End Try
        DBCon.Close()
        atualiza()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub atualiza()
        Me.DataGridView1.Rows.Clear()
        Dim strsql As String = "select * from cliente"
        Dim cm As New OleDb.OleDbCommand(strsql, DBCon)
        DBCon.Open()
        dr = cm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Me.DataGridView1.Rows.Add(dr.Item("CodigoCliente"), dr.Item("Nome"), dr.Item("cidade") _
                                          , dr.Item("Email"), dr.Item("telefone"))

            End While
        End If
        DBCon.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualiza()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If IsNumeric(DataGridView1.CurrentRow.Cells(0).Value) Then
            TextBoxNumeroCliente.Text = DataGridView1.CurrentRow.Cells(0).Value
            CONSULTA()
        End If
    End Sub
End Class
