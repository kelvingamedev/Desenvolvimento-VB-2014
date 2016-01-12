Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class ALUGUEL
    Dim Constring As String = "provider=Microsoft.ACE.OLEDB.12.0;Password="""";User ID=Admin;Data Source=" + Application.StartupPath & "\locadora.accdb" 'String de configuração com o Banco de dados'
    Dim ConectarBD As New OleDb.OleDbConnection(Constring) 'ConectarBD realiza o acesso ao banco de dados'Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Password ="""";User ID=Admin;Data Source=" + Application.StartupPath & "\cadastro.mdb" 'String de configuração com o Banco de dados'
    Dim meuDataReader As OleDb.OleDbDataReader

    Dim dr As OleDb.OleDbDataReader 'Criação do Data reader que receberá a consulta '

    Private Sub ALUGUEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonConsultar_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        Dim strsql = "SELECT * FROM carro WHERE placa =" + TextBoxPlaca.Text

        If TextBoxPlaca.Text.Equals("") Then
            MessageBox.Show("Campo de consulta vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cm As New OleDb.OleDbCommand(strsql, ConectarBD)
            Try
                ConectarBD.Open()
                meuDataReader = cm.ExecuteReader
                If meuDataReader.HasRows Then
                    While meuDataReader.Read
                        TextBoxModelo.Text = meuDataReader.Item("modelo")
                        MaskedTextBoxAno.Text = meuDataReader.Item("ano_fabri")
                        TextBoxDiaria.Text = meuDataReader.Item("valor_diaria")
                        TextBoxStatus.Text = meuDataReader.Item("status")
                        PictureBoxDados.Load(meuDataReader.Item("imagem"))


                    End While
                Else
                    MessageBox.Show("Não foi encontrado nenhum registro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Pesquisa não retornou resultados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ConectarBD.Close()

        End If
    End Sub
    'consulta RG Cliente
    Private Sub ButtonConsultarCliente_Click(sender As Object, e As EventArgs) Handles ButtonConsultarCliente.Click

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
    'método para exibir dentro dos textBoxs
    Private Sub exibir()
        If dr.HasRows() Then
            While dr.Read
                TextBoxNome.Text = dr.Item("nome")
                TextBoxCPF.Text = dr.Item("cpf")
                MaskedTextBoxCelular.Text = dr.Item("cel")
                TextBoxNCNH.Text = dr.Item("cnh")
                TextBoxCategoriaCliente.Text = dr.Item("categoria")
                MaskedTextBoxValidade.Text = dr.Item("data_validade")





            End While

        Else
            MessageBox.Show("Não encontrado", "Registro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxRG.Focus()
        End If



    End Sub

    Private Sub LabelNumeroDiarias_Click(sender As Object, e As EventArgs) Handles LabelNumeroDiarias.Click

    End Sub

    Private Sub DateTimePickerRetira_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerRetira.ValueChanged


    End Sub

    Private Sub DateTimePickerDevolve_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerDevolve.ValueChanged

        LabelNumeroDiarias.Text = DateDiff(DateInterval.Day, DateTimePickerRetira.Value, DateTimePickerDevolve.Value)
        LabelDinheiro.Text = Val(TextBoxDiaria.Text) * Val(LabelNumeroDiarias.Text)
    End Sub

    Private Sub ButtonConfirmarLocacao_Click(sender As Object, e As EventArgs) Handles ButtonConfirmarLocacao.Click
        If TextBoxStatus.Text.Equals("0") Then
            Dim strsql As String
            strsql = "insert into movimento(placa, rg, data_retira, data_dev, diarias) values (@placa, @rg, @data_retira, @data_dev, @diarias)"
            Dim cm As New OleDbCommand(strsql, ConectarBD)
            cm.Parameters.AddWithValue("@placa", TextBoxPlaca.Text)
            cm.Parameters.AddWithValue("@rg", TextBoxRG.Text)
            cm.Parameters.AddWithValue("@data_retira", DateTimePickerRetira.Text)
            cm.Parameters.AddWithValue("@data_dev", DateTimePickerDevolve.Text)
            cm.Parameters.AddWithValue("@diarias", LabelNumeroDiarias.Text)


            Try
                ConectarBD.Open()
                cm.ExecuteNonQuery()

                cm.CommandText = "update carro set status = '1' where placa = " & TextBoxPlaca.Text
                cm.ExecuteNonQuery()
                MessageBox.Show("Locação feita com sucesso")


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ConectarBD.Close()

        Else
            MessageBox.Show("O carro não esta disponivel!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub LabelDinheiro_Click(sender As Object, e As EventArgs) Handles LabelDinheiro.Click

    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonImprimir.Click

        'usar o printform e colocar nas propriedades como print to printer
        PrintForm1.Print()
    End Sub

End Class