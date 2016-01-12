Imports System.Data.OleDb


Public Class Devolucao
    Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Password="""";User ID=Admin;Data Source=" + Application.StartupPath & "\locadora.accdb" 'String de configuração com o Banco de dados'
    Dim ConectarBD As New OleDb.OleDbConnection(ConString) 'ConectarBD realiza o acesso ao banco de dados'Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Password ="""";User ID=Admin;Data Source=" + Application.StartupPath & "\cadastro.mdb" 'String de configuração com o Banco de dados'
    Private Sub GroupBoxRG_Enter(sender As Object, e As EventArgs) Handles GroupBoxPlaca.Enter

    End Sub

    Private Sub LabelCPF_Click(sender As Object, e As EventArgs) Handles LabelCPF.Click

    End Sub

    Private Sub TextBoxNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNome.TextChanged

    End Sub

    Private Sub LabelNome_Click(sender As Object, e As EventArgs) Handles LabelNome.Click

    End Sub

    Private Sub GroupBoxRGCliente_Enter(sender As Object, e As EventArgs) Handles GroupBoxRGCliente.Enter

    End Sub
    'Botão devolver 
    Private Sub ButtonDevolverVeiculo_Click(sender As Object, e As EventArgs) Handles ButtonDevolverVeiculo.Click
        Dim placa As String
        placa = TextBoxPlaca.Text
        Dim Rg As String
        Dim strsql As String = "select * from movimento where placa='" + placa + "'"
        Try
            ConectarBD.Open()

            Dim cmMovimento As New OleDbCommand(strsql, ConectarBD)
            Dim drMovimento As OleDb.OleDbDataReader
            drMovimento = cmMovimento.ExecuteReader()
            If drMovimento.HasRows Then
                While drMovimento.Read
                    TextBoxRG.Text = drMovimento.Item("rg")
                    Rg = drMovimento.Item("rg")
                    MaskedTextBoxDevolucao.Text = drMovimento.Item("data_retira")
                    MaskedTextBoxLocacao.Text = drMovimento.Item("data_dev")
                    LabelNumeroDiarias.Text = drMovimento.Item("diarias")
                End While



                strsql = "select * from cliente where rg='" + TextBoxRG.Text + "'"

                Dim cmCliente As New OleDbCommand(strsql, ConectarBD)
                Dim drCliente As OleDb.OleDbDataReader
                drCliente = cmCliente.ExecuteReader()
                If drCliente.HasRows Then
                    While drCliente.Read
                        TextBoxNome.Text = drCliente.Item("nome")
                        TextBoxCPF.Text = drCliente.Item("cpf")
                        MaskedTextBoxCelular.Text = drCliente.Item("cel")
                        TextBoxNCNH.Text = drCliente.Item("cnh")
                        TextBoxCategoriaCliente.Text = drCliente.Item("categoria")
                        MaskedTextBoxValidade.Text = drCliente.Item("data_validade")
                    End While
                End If

                'Criei a variavel placaPK do tipo inteiro para conseguir tabalhar com a chave primaria que se encontra 
                'na tabela movimento
                Dim placaPK As Integer
                placaPK = CInt(TextBoxPlaca.Text)
                'Existem dois tipos de concatenação em VB a '+' é muito utilizada porem em casos SQL ela fara chave primaria ser 
                'vista como double, quando uma chave primaria é Integer(tipo inteiro) existe o operador '&' ele é especifico
                'para concatenar Strings ou Inteiros
                strsql = "select * from carro where placa=" & placaPK
                'Acima foi a resolução que encontrei para o Bug na programação
                Dim cmCarro As New OleDbCommand(strsql, ConectarBD)
                Dim drCarro As OleDb.OleDbDataReader
                drCarro = cmCarro.ExecuteReader()

                If drCarro.HasRows Then
                    While drCarro.Read
                        TextBoxModelo.Text = drCarro.Item("modelo")
                        MaskedTextBoxAno.Text = drCarro.Item("ano_fabri")
                        TextBoxDiaria.Text = drCarro.Item("valor_diaria")
                        Dim dinheiro As Single
                        dinheiro = Val(TextBoxDiaria.Text) * Val(LabelNumeroDiarias.Text)
                        LabelDinheiro.Text = "R$  " + Format(dinheiro, "###,00")
                    End While
                End If
            End If
            ' "Devolvendo" o carro
            Dim delPK As Integer
            Dim del As String
            delPK = CInt(TextBoxPlaca.Text)

            del = "DELETE FROM movimento WHERE placa ='" & TextBoxPlaca.Text & "'"
            'problema acima no delete não esta funcionando 
            Try
                If MessageBox.Show("Deseja realmente devolver o carro?", "Devolução do automóvel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    'continuar daqui.....
                    Dim cm As New OleDb.OleDbCommand(del, ConectarBD)
                    Dim exclusao = cm.ExecuteNonQuery()
                    If (exclusao >= 1) Then
                        MessageBox.Show("Carro devolvido com sucesso", "Devolução do automóvel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cm.CommandText = "update carro set status = '0' where placa = " & TextBoxPlaca.Text
                        cm.ExecuteNonQuery()
                        Limpar()
                    Else
                        MessageBox.Show("O registro do carro está vazio", "Exclusão do automóvel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Limpar()
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            '------------------------------------------------------------------------------
            'alterando o status do carro na tabela do carro
            'update [nome da tabela] set [campo] = [valor]
            'update carro set status = '1' where placa = [textbox etc...]

            ConectarBD.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        '   strsql = "select * from movimento where placa='" + placa + "'"
        '   Dim cmCliente As New OleDbCommand(strsql, ConectarBD)



        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try



    End Sub
    'método limpar
    Private Sub Limpar()
        TextBoxPlaca.Text = ""
        TextBoxModelo.Text = ""
        MaskedTextBoxAno.Text = ""
        TextBoxDiaria.Text = ""
        TextBoxRG.Text = ""
        TextBoxNome.Text = ""
        TextBoxCPF.Text = ""
        MaskedTextBoxCelular.Text = ""
        TextBoxNCNH.Text = ""
        TextBoxCategoriaCliente.Text = ""
        MaskedTextBoxValidade.Text = ""
        MaskedTextBoxLocacao.Text = ""
        MaskedTextBoxDevolucao.Text = ""
        LabelNumeroDiarias.Text = "0"
        LabelDinheiro.Text = "0,00"

    End Sub
    Private Sub GroupBoxDadosDaLocacao_Enter(sender As Object, e As EventArgs) Handles GroupBoxDadosDaLocacao.Enter

    End Sub

    Private Sub Devolucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function ButtonLimpar() As Object
        Throw New NotImplementedException
    End Function

End Class