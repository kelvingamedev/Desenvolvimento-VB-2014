Public Class Locacao_Menu_Principal

    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Me.Close()

    End Sub

    Private Sub ButtonModuloCliente_Click(sender As Object, e As EventArgs) Handles ButtonModuloCliente.Click
        FormCadastroDeClientes.Show()

    End Sub

    Private Sub ButtonModuloCarro_Click(sender As Object, e As EventArgs) Handles ButtonModuloCarro.Click
        FormCadastroDeVeiculos.Show()
    End Sub

    Private Sub ButtonLocacao_Click(sender As Object, e As EventArgs) Handles ButtonLocacao.Click
        ALUGUEL.Show()
    End Sub

    Private Sub ButtonDevolucao_Click(sender As Object, e As EventArgs) Handles ButtonDevolucao.Click
        Devolucao.Show()
    End Sub
End Class