Imports System.Data.OleDb

Public Class FormCadastroDeClientes
    Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Password="""";User ID=Admin;Data Source=" + Application.StartupPath & "\locadora.accdb" 'String de configuração com o Banco de dados'
    Dim ConectarBD As New OleDb.OleDbConnection(ConString) 'ConectarBD realiza o acesso ao banco de dados'Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Password ="""";User ID=Admin;Data Source=" + Application.StartupPath & "\cadastro.mdb" 'String de configuração com o Banco de dados'


    Dim dr As OleDb.OleDbDataReader 'Criação do Data reader que receberá a consulta '



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelClientes.Click
        'abri sem querer :x
    End Sub

    Private Sub ButtonExcluir_Click(sender As Object, e As EventArgs) Handles ButtonExcluir.Click
        'botão excluir
        Dim strsql As String
        strsql = "delete from cliente where rg ='" + TextBoxRG.Text + "'"

        Try
            If MessageBox.Show("Confirmar exclusão", "Permissão para deletar", MessageBoxButtons.YesNo, _
                MessageBoxIcon.Question) Then
                ConectarBD.Open()
                Dim cm As New OleDbCommand(strsql, ConectarBD)
                Dim exclusao = cm.ExecuteNonQuery()
                If (exclusao >= 1) Then
                    MessageBox.Show("Contato excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ButtonLimpar.PerformClick()
                Else
                    MessageBox.Show("O campo de registro está vazio", "Registro vazio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                ConectarBD.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ButtonConsultar_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click


        If TextBoxRG.Text.Equals("") Then
            MessageBox.Show("Digite um código  para consulta", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxRG.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TextBoxRG.Text) Then
            MessageBox.Show("Digite um código para counsulta", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxRG.Focus()
            Exit Sub
        End If
        consulta()
        ConectarBD.Close()
    End Sub

    Private Sub consulta()
        Dim strsql = "select * from cliente where rg ='" + TextBoxRG.Text + "'"

        Dim cm As New OleDbCommand(strsql, ConectarBD)
        Try
            ConectarBD.Open()
            dr = cm.ExecuteReader()
            exibir()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub exibir()
        If dr.HasRows() Then
            While dr.Read
                TextBoxBairro.Text = dr.Item("bairro")
                TextBoxCategoria.Text = dr.Item("categoria")
                TextBoxCidade.Text = dr.Item("cidade")
                TextBoxCPF.Text = dr.Item("cpf")
                TextBoxEmail.Text = dr.Item("email")
                TextBoxEndereco.Text = dr.Item("endereco")
                TextBoxEstado.Text = dr.Item("estado")
                TextBoxNCNH.Text = dr.Item("cnh")
                TextBoxNome.Text = dr.Item("nome")
                MaskedTextBoxCelular.Text = dr.Item("cel")
                MaskedTextBoxCEP.Text = dr.Item("cep")
                MaskedTextBoxNascimento.Text = dr.Item("data_nasc")
                MaskedTextBoxTelefone.Text = dr.Item("tel")
                MaskedTextBoxValidade.Text = dr.Item("data_validade")

            End While

        Else
            MessageBox.Show("Não encontrado", "Registro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxRG.Focus()
        End If



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        'textBox do rg
    End Sub

    Private Sub ButtonIncluir_Click(sender As Object, e As EventArgs) Handles ButtonIncluir.Click
        Dim strsql As String
        strsql = "insert into cliente(rg, nome, cpf, tel, cel, cnh, categoria, data_validade, bairro, endereco, cep, estado, cidade, data_nasc, email)values(@rg, @nome, @cpf, @tel, @cel, @cnh, @categoria, @data_validade, @bairro, @endereco, @cep, @estado, @cidade, @data_nasc, @email)"
        Dim cm As New OleDb.OleDbCommand(strsql, ConectarBD)
        cm.Parameters.AddWithValue("@rg", TextBoxRG.Text)
        cm.Parameters.AddWithValue("@nome", TextBoxNome.Text)
        cm.Parameters.AddWithValue("@cpf", TextBoxCPF.Text)
        cm.Parameters.AddWithValue("@tel", MaskedTextBoxTelefone.Text)
        cm.Parameters.AddWithValue("@cel", MaskedTextBoxCelular.Text)
        cm.Parameters.AddWithValue("@cnh", TextBoxNCNH.Text)
        cm.Parameters.AddWithValue("@categoria", TextBoxCategoria.Text)
        cm.Parameters.AddWithValue("@data_validade", MaskedTextBoxValidade.Text)
        cm.Parameters.AddWithValue("@bairro", TextBoxBairro.Text)
        cm.Parameters.AddWithValue("@endereco", TextBoxEndereco.Text)
        cm.Parameters.AddWithValue("@cep", MaskedTextBoxCEP.Text)
        cm.Parameters.AddWithValue("@estado", TextBoxEstado.Text)
        cm.Parameters.AddWithValue("@cidade", TextBoxCidade.Text)
        cm.Parameters.AddWithValue("@data_nasc", MaskedTextBoxNascimento.Text)
        cm.Parameters.AddWithValue("@email", TextBoxEmail.Text)

        Try
            ConectarBD.Open()
            cm.ExecuteNonQuery()
            ConectarBD.Close()
            MessageBox.Show("Registro feito com sucesso")
            ButtonLimpar.PerformClick()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ConectarBD.Close()

    End Sub

    Private Sub ButtonAlterar_Click(sender As Object, e As EventArgs) Handles ButtonAlterar.Click
        Dim strsql As String
        strsql = "Update cliente set rg=@rg, nome=@nome, cpf=@cpf, tel=@tel, cel=@cel, cnh=@cnh, categoria=@categoria, data_validade=@data_validade, bairro=@bairro,endereco=@endereco, cep=@cep, estado=@estado, cidade=@cidade,data_nasc=@data_nasc,email=@email where rg='" + TextBoxRG.Text + "'"


        Dim cm As New OleDb.OleDbCommand(strsql, ConectarBD)
        cm.Parameters.AddWithValue("@rg", TextBoxRG.Text)
        cm.Parameters.AddWithValue("@nome", TextBoxNome.Text)
        cm.Parameters.AddWithValue("@cpf", TextBoxCPF.Text)
        cm.Parameters.AddWithValue("@tel", MaskedTextBoxTelefone.Text)
        cm.Parameters.AddWithValue("@cel", MaskedTextBoxCelular.Text)
        cm.Parameters.AddWithValue("@cnh", TextBoxNCNH.Text)
        cm.Parameters.AddWithValue("@categoria", TextBoxCategoria.Text)
        cm.Parameters.AddWithValue("@data_validade", MaskedTextBoxValidade.Text)
        cm.Parameters.AddWithValue("@bairro", TextBoxBairro.Text)
        cm.Parameters.AddWithValue("@endereco", TextBoxEndereco.Text)
        cm.Parameters.AddWithValue("@cep", MaskedTextBoxCEP.Text)
        cm.Parameters.AddWithValue("@estado", TextBoxEstado.Text)
        cm.Parameters.AddWithValue("@cidade", TextBoxCidade.Text)
        cm.Parameters.AddWithValue("@data_nasc", MaskedTextBoxNascimento.Text)
        cm.Parameters.AddWithValue("@email", TextBoxEmail.Text)


        Try
            ConectarBD.Open()
            cm.ExecuteNonQuery()
            ConectarBD.Close()
            MessageBox.Show("Alteração feita com sucesso")
            ButtonLimpar.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ConectarBD.Close()
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
        MaskedTextBoxNascimento.Text = ""
        MaskedTextBoxTelefone.Text = ""
        MaskedTextBoxValidade.Text = ""
        TextBoxEmail.Text = ""



    End Sub

    Private Sub TextBoxRG_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub ButtonCarro_Click(sender As Object, e As EventArgs)
        FormCadastroDeVeiculos.Show()
        Me.Hide()










    End Sub

    Private Sub FormCadastroDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class