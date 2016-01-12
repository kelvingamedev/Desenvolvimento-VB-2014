Public Class FormCadastroDeClientes
    Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Password ="""";User ID=Admin;Data Source=" + Application.StartupPath & "\locadora.mdb" 'String de configuração com o Banco de dados'
    Dim DBCon As New OleDb.OleDbConnection(ConString) 'DbCon realiza o acesso ao banco de dados'Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Password ="""";User ID=Admin;Data Source=" + Application.StartupPath & "\cadastro.mdb" 'String de configuração com o Banco de dados'

    Dim dr As OleDb.OleDbDataReader 'Criação do Data reader que receberá a consulta '



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelClientes.Click
        'abri sem querer :x
    End Sub

    Private Sub CONSULTA() 'Comando que realiza uma consulta no banco de dados'
        Dim strsql As String = "SELECT * FROM CLIENTE WHERE CODIGOCLIENTE =" _
                               + TextBoxRG.Text 'Consulta os dados conforme o numero do cliente'

        Dim cm As New OleDb.OleDbCommand(strsql, DBCon) 'Cria uma variável de consulta ao banco de dados'

        Try 'O Try é utilizado sempre que é necessário realizar uma consulta ao BD'
            DBCon.Open() 'Abre a conexão'
            dr = cm.ExecuteReader 'Executa o comando'
            EXIBIR() 'Chama o método de exibição de dados no BD'
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information) 'Imprime mensagem de erro de consulta ao BD'

        End Try


    Private Sub ButtonExcluir_Click(sender As Object, e As EventArgs) Handles ButtonExcluir.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Botão limpar
    End Sub

    Private Sub ButtonConsultar_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        'Botão consultar
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRG.TextChanged
        'textBox do rg
    End Sub

    Private Sub ButtonIncluir_Click(sender As Object, e As EventArgs) Handles ButtonIncluir.Click
        Dim strsql As String
        strsql = "insert into locadora(rg, nome, cpf, tel, cel, cnh, categoria, data_validade, bairro, endereco, cep)values(@rg, @nome, @cpf, @tel, @cel, @cnh, @categoria, @data_validade, @bairro, @endereco, @cep)"
        Dim cm As New OleDb.OleDbCommand(strsql, DBCon)
        cm.Parameters.AddWithValue("@rg", TextBoxRG.Text)
        cm.Parameters.AddWithValue("@nome", TextBoxNome.Text)
        cm.Parameters.AddWithValue("@cpf", TextBoxCPF.Text)
        cm.Parameters.AddWithValue("@tel", MaskedTextBoxTelefone.Text)
        cm.Parameters.AddWithValue("@cel", MaskedTextBoxCelular.Text)
        cm.Parameters.AddWithValue("@cnh", TextBoxNCNH.Text)
        cm.Parameters.AddWithValue("@categoria", TextBoxCategoria.Text)
        cm.Parameters.AddWithValue("@data_validade", MaskedTextBoxValidade.Text)

    End Sub

    Private Sub ButtonAlterar_Click(sender As Object, e As EventArgs) Handles ButtonAlterar.Click
        Dim strsql As String
        strsql = "Update cliente set rg=@rg, nome=@nome, cpf=@cpf, tel=@tel, cel=@cel, cnh=@cnh, categoria=@categoria, data_validade=@data_validade, bairro=@bairro where rg=" + TextBoxRG.Text


        Dim cm As New OleDb.OleDbCommand(strsql, DBCon)
        cm.Parameters.AddWithValue("@rg", TextBoxRG.Text)
        cm.Parameters.AddWithValue("@nome", TextBoxNome.Text)
        cm.Parameters.AddWithValue("@cpf", TextBoxCPF.Text)
        cm.Parameters.AddWithValue("@tel", MaskedTextBoxTelefone)
        cm.Parameters.AddWithValue("@cel", MaskedTextBoxCelular.Text)
        cm.Parameters.AddWithValue("@cnh", TextBoxNCNH.Text)
        cm.Parameters.AddWithValue("@categoria", TextBoxCategoria.Text)
        cm.Parameters.AddWithValue("@data_validade", MaskedTextBoxValidade.Text)
        cm.Parameters.AddWithValue("@bairro", TextBoxBairro.Text)
        Try
            DBCon.Open()
            cm.ExecuteNonQuery()
            DBCon.Close()
            MessageBox.Show("Alteração feita com sucesso")
            'BOTÃO LIMPAR'
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção")
        End Try
        DBCon.Close()


    End Sub

    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Me.Close()

    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        TextBoxBairro.Text = ""
        TextBoxCategoria.Text = ""
        TextBoxCidade.Text = ""
        TextBoxCPF.Text = ""
        TextBoxEndereco.Text = ""
        TextBoxEstado.Text = ""
        TextBoxNCNH.Text = ""
        TextBoxNome.Text = ""
        TextBoxRG.Text = ""
        MaskedTextBoxCelular.Text = ""
        MaskedTextBoxCEP.Text = ""
        MaskedTextBoxEmail.Text = ""
        MaskedTextBoxNascimento.Text = ""
        MaskedTextBoxTelefone.Text = ""
        MaskedTextBoxValidade.Text = ""






    End Sub

End Class