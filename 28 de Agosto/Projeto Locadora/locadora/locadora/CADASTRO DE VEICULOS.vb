Public Class FormCadastroDeVeiculos

    Dim varConexao As String = "provider=Microsoft.ACE.OLEDB.12.0;Password="""";User ID=Admin;Data Source=" + Application.StartupPath & "\locadora.accdb"
    Dim ConectarBD As New OleDb.OleDbConnection(varConexao)
    Dim meuDataReader As OleDb.OleDbDataReader

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        'abri sem querer
    End Sub

    Private Sub FormCadastroDeVeiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonIncluir_Click(sender As Object, e As EventArgs) Handles ButtonIncluir.Click
        Dim strsql As String
        strsql = "INSERT INTO carro (placa , modelo , ano_fabri , valor_diaria , status , imagem) VALUES(@placa , @modelo , @ano_fabri , @valor_diaria , @status , @imagem)"
        Dim cm As New OleDb.OleDbCommand(strsql, ConectarBD)

        cm.Parameters.AddWithValue("@placa", TextBoxPlaca.Text)
        cm.Parameters.AddWithValue("@modelo", TextBoxModelo.Text)
        cm.Parameters.AddWithValue("@ano_fabri", MaskedTextBoxAno.Text)
        cm.Parameters.AddWithValue("@valor_diaria", TextBoxDiaria.Text)
        cm.Parameters.AddWithValue("@status", TextBoxStatus.Text)
        cm.Parameters.AddWithValue("@imagem", TextBoxImagem.Text)

        Try
            ConectarBD.Open()
            cm.ExecuteNonQuery()

            MessageBox.Show("Carro cadastrado com sucesso,", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonLimpar.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ConectarBD.Close()


    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        TextBoxPlaca.Text = ""
        TextBoxModelo.Text = ""
        MaskedTextBoxAno.Text = ""
        TextBoxDiaria.Text = ""
        TextBoxStatus.Text = ""
        TextBoxImagem.Text = ""


    End Sub

    Private Sub ButtonConsultarPlaca_Click(sender As Object, e As EventArgs) Handles ButtonConsultarPlaca.Click
        Dim strsql = "SELECT * FROM carro WHERE placa =" + TextBoxPlaca.Text

        If TextBoxPlaca.Text.Equals("") Then
        Else
            Dim cm As New OleDb.OleDbCommand(strsql, ConectarBD)
            Try
                ConectarBD.Open()
                meuDataReader = cm.ExecuteReader
                If meuDataReader.HasRows Then
                    While meuDataReader.Read
                        TextBoxDiaria.Text = meuDataReader.Item("placa")
                        TextBoxImagem.Text = meuDataReader.Item("imagem")
                        TextBoxModelo.Text = meuDataReader.Item("modelo")
                        TextBoxStatus.Text = meuDataReader.Item("status")
                        MaskedTextBoxAno.Text = meuDataReader.Item("ano_fabri")
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

    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Me.Close()

    End Sub

    Private Sub ButtonAlterar_Click(sender As Object, e As EventArgs) Handles ButtonAlterar.Click
        Dim strsql As String
        strsql = "UPDATE carro  SET modelo=@modelo ,ano_fabri=@ano_fabri ,valor_diaria=@valor_diaria,status=@status, imagem=@imagem where placa=" + TextBoxPlaca.Text
        Dim cm As New OleDb.OleDbCommand(strsql, ConectarBD)

        cm.Parameters.AddWithValue("@modelo", TextBoxModelo.Text)
        cm.Parameters.AddWithValue("@ano_fabri", MaskedTextBoxAno.Text)
        cm.Parameters.AddWithValue("@valor_diaria", TextBoxDiaria.Text)
        cm.Parameters.AddWithValue("@status", TextBoxStatus.Text)
        cm.Parameters.AddWithValue("@imagem", TextBoxImagem.Text)






        Try
            ConectarBD.Open()
            cm.ExecuteNonQuery()
            ConectarBD.Close()
            MessageBox.Show("Alteração feita com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonLimpar.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ConectarBD.Close()
    End Sub

    Private Sub ButtonExcluir_Click(sender As Object, e As EventArgs) Handles ButtonExcluir.Click
        Dim strsql As String
        strsql = "DELETE FROM carro WHERE placa =" + TextBoxPlaca.Text

        Try
            If MessageBox.Show("Deseja realmente excluir o carro?", "Exclusão do automóvel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                ConectarBD.Open()
                Dim cm As New OleDb.OleDbCommand(strsql, ConectarBD)
                Dim exclusao = cm.ExecuteNonQuery
                If exclusao >= 1 Then
                    MessageBox.Show("Carro excluído com sucesso", "Exclusão do automóvel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ButtonLimpar.PerformClick()
                Else
                    MessageBox.Show("O registro do carro está vazio", "Exclusão do automóvel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                ConectarBD.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class