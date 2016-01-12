'importando a biblioteca para usar o banco de dados
Imports System.Data.OleDb

Public Class Form1
    'Para se declarar uma variavel se usa o comando "Dim", seguindo de seu nome e depois se declara 
    'seu tipo com o comando "As", exemplo "Dim ConString As String", e se atribui um valor com o sinal
    'de igual "="
    Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Password=""""; User Id=Admin;Data Source=" +
            Application.StartupPath & "\ACESSO.accdb"

    Dim DBCon As New OleDb.OleDbConnection(ConString)

    Dim conta As Integer

    Private Sub Acessar_Click(sender As Object, e As EventArgs) Handles Acessar.Click
        Dim login, senha As String

        login = TextBox1.Text
        senha = TextBox2.Text
        'o comando if em VB 
        If login = "" Or senha = "" Then
            'o comando abaixo mostra a uma janela 
            MessageBox.Show("Entrada invalida")

            TextBox1.Focus()
            'este comando posiciona o curso no local certo para que o usuario possa digitar corretamente
            ' o comando exit sub sai do if e não continua o código quando encontra um erro
            Exit Sub
            'o comando end if fecha o if substituindo o {} das linguagens comuns
        End If
        'Atribuindo o comando em SQL para variavel sql
        Dim slq As String = "SELECT nomeUser, senhaUser FROM Users Where nomeUser = '" & login & "' "

        'Define um comando sobre a conexão para selecionar o usuário e a senha 
        Dim cm As New OleDb.OleDbCommand(slq, DBCon)
        'cm é um objeto para se dar comandos dentro do banco de dados 

        'cria um objeto datareader
        'esta variavel ela consulta as informações ela vai receber as informações do banco de dados
        '
        Dim dr As OleDb.OleDbDataReader
        'define uma variavel de controle
        Dim Flag As Boolean


        Try
            'abre a conexão
            DBCon.Open() 'Abriu a conexão
            'Executa um comando e gera um datareader(dr)
            dr = cm.ExecuteReader 'cm é o comando que vai acessar o banco de dados.

            'se houver dados retornados/encontrados
            If dr.HasRows Then
                'percorre o datareader
                While dr.Read
                    'Se a senha informada for igual a senha do banco de dados define variavel FLAG como True
                    If (dr.Item("senhaUser") = senha) And (dr.Item("nomeUser") = login) Then 'verifica se senha e login estão corretos
                        Flag = True
                    End If
                End While
            End If
            If Flag = True Then
                ret.Text = "Acesso permitido!"
            Else
                ret.Text = "Dados Incorretos!"
                'incrementa o contador de tentativas
                conta = conta + 1
            End If
            If conta = 3 Then
                MessageBox.Show("Limite das tentativas alcançadas")
                End
            End If
            DBCon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro génerico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'botão sair 
        Me.Close()
        'comando para encerrar o programa
    End Sub
End Class


