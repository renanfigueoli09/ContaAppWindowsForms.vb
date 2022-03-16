Public Class Conta
    Private nome As String
    Private Conta As Decimal
    Private Saldo As Decimal

    Public Sub New(nome As String, conta As Decimal, saldo As Decimal)
        Me.nome = nome
        Me.Conta = conta
        Me.Saldo = saldo
    End Sub

    Public Sub New()

    End Sub



    Public Property pConta As Decimal
        Get
            Return Conta
        End Get
        Set(value As Decimal)
            Conta = value
        End Set
    End Property

    Public Property pSaldo As Decimal
        Get
            Return Saldo
        End Get
        Set(value As Decimal)
            Saldo = value
        End Set
    End Property

    Public Property pNome As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

    Public Sub Sacar(valor As Decimal)
        'Se refere a um atributo que está na mema classe 
        If (valor <= Me.Saldo) Then
            Me.Saldo = Saldo - valor

        Else
            MsgBox("Valor solicitado maior que o sakdo !!")
        End If

    End Sub

    Public Sub Depositar(valor As Decimal)
        If (valor >= 1) Then
            Me.Saldo = Saldo + valor
        Else
            MsgBox("Valor a ser depositado deve ser maior que 1!!")
        End If

    End Sub

End Class
