'0- BIBLIOTECA - IMPORTAR'
'1- CONSTRING - DADOS NO BANCO'
'2-DBCON - OBJETO P/ CONEXÃO'
'3- SQL - INSTRUÇÃO'
'4- CRIAR COMNADO - CM'
'5- DATA READER'
Imports System.Data.OleDb 'Importa o conjunto de classes e métodos de conexões com o banco de dados'

Public Class Form1
    '--------------------------------------------------------------------------------------------------------------------'
    'Dim é utilizado na criação de uma variável'
    'As é a especificação do tipo'
    'Sintaxe:'
    'Dim [nome da variavel] As [Tipo da variável]'
    '--------------------------------------------------------------------------------------------------------------------'
    Dim ConString As String =
    "provider=Microsoft.ACE.OLEDB.12.0;Password="""";User ID=Admin;Data Source=" + Application.StartupPath & "acesso.accdb"
    'A instrução acima especifica a conexão de banco de dados em uma string'
    'Sintaxe'
    'provider=[nome do banco de dados] Password=[senha] User ID=[nível de conexão] Data Souce =[caminho do banco de dados]'
    '--------------------------------------------------------------------------------------------------------------------'

    Dim DBCon As New OleDb.OleDbConnection(ConString)
    
    Dim conta As Integer
    '--------------------------------------------------------------------------------------------------------------------'



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Sair.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim login, senha As String

        login = TextBox_Usuario.Text
        senha = TextBox_Senha.Text

        If login = "" Or senha = "" Then

            MessageBox.Show("Informação Incompleta.Preenha os campos com o nome do usuário e senhha,""Informação Incompleta")

            TextBox_Usuario.Focus()
            Exit Sub
        End If

        Dim SQL As String = "SELECT UsuarioID,Senha FROM Usuarios WHERE UsuarioID='" & login & "' "
        Dim cm As New OleDbCommand(SQL, DBCon)
        Dim dr As OleDb.OleDbDataReader
        Dim flag As Boolean
        Try
            DBCon.Open()
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If (dr.Item("Senha") = senha And (dr.Item("UsuarioId") = login)) Then
                        flag = True
                    End If
                End While
            End If
            If flag = True Then
                MessageBox.Show("Dados incorretos")
                conta += 1
            End If
            If conta = 3 Then
                MessageBox.Show("Limite das tentativas alcançado")
            End If
            DBCon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message,"Erro genérico",MessageBoxButtons.OK,MessageBoxIcon.Error)
        End Try

    End Sub
End Class
