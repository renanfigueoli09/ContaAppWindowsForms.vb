Public Class Form1

    Dim obj_poupanca As New Poupança
    Private Sub ButtonCriar_Click(sender As Object, e As EventArgs) Handles ButtonCriar.Click
        obj_poupanca.pConta = TextBoxConta.Text
        obj_poupanca.pNome = TextBoxNome.Text
        'CDec é a função para converter texto em número decimal
        obj_poupanca.pSaldo = CDec(TextBoxSaldo.Text)
        'CInt é a função para converter texto em número inteiro
        obj_poupanca.pAniversario = CInt(TextBoxAniversario.Text)

        'para exibir o saldo final
        AtualizaSaldo()

    End Sub

    Private Sub ButtonDepositar_Click(sender As Object, e As EventArgs) Handles ButtonDepositar.Click
        obj_poupanca.Depositar(CDec(TextBoxValor.Text))
        AtualizaSaldo()
    End Sub


    Private Sub ButtonSacar_Click(sender As Object, e As EventArgs) Handles ButtonSacar.Click
        obj_poupanca.Sacar(CDec(TextBoxValor.Text))
        AtualizaSaldo()

    End Sub


    Private Sub AtualizaSaldo()
        TextBoxSaldo2.Text = obj_poupanca.pSaldo
    End Sub
End Class
'