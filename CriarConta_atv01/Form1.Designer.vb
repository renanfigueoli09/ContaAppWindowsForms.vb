<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelConta = New System.Windows.Forms.Label()
        Me.LabelCliente = New System.Windows.Forms.Label()
        Me.LabelSaldo = New System.Windows.Forms.Label()
        Me.LabelAniversario = New System.Windows.Forms.Label()
        Me.TextBoxConta = New System.Windows.Forms.TextBox()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.TextBoxSaldo = New System.Windows.Forms.TextBox()
        Me.TextBoxAniversario = New System.Windows.Forms.TextBox()
        Me.ButtonCriar = New System.Windows.Forms.Button()
        Me.LabelValor = New System.Windows.Forms.Label()
        Me.TextBoxValor = New System.Windows.Forms.TextBox()
        Me.ButtonDepositar = New System.Windows.Forms.Button()
        Me.ButtonSacar = New System.Windows.Forms.Button()
        Me.LabelSaldo2 = New System.Windows.Forms.Label()
        Me.TextBoxSaldo2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelConta
        '
        Me.LabelConta.AutoSize = True
        Me.LabelConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConta.Location = New System.Drawing.Point(35, 79)
        Me.LabelConta.Name = "LabelConta"
        Me.LabelConta.Size = New System.Drawing.Size(57, 20)
        Me.LabelConta.TabIndex = 0
        Me.LabelConta.Text = "Conta"
        '
        'LabelCliente
        '
        Me.LabelCliente.AutoSize = True
        Me.LabelCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCliente.Location = New System.Drawing.Point(35, 127)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(65, 20)
        Me.LabelCliente.TabIndex = 1
        Me.LabelCliente.Text = "Cliente"
        '
        'LabelSaldo
        '
        Me.LabelSaldo.AutoSize = True
        Me.LabelSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaldo.Location = New System.Drawing.Point(35, 174)
        Me.LabelSaldo.Name = "LabelSaldo"
        Me.LabelSaldo.Size = New System.Drawing.Size(55, 20)
        Me.LabelSaldo.TabIndex = 2
        Me.LabelSaldo.Text = "Saldo"
        '
        'LabelAniversario
        '
        Me.LabelAniversario.AutoSize = True
        Me.LabelAniversario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAniversario.Location = New System.Drawing.Point(35, 228)
        Me.LabelAniversario.Name = "LabelAniversario"
        Me.LabelAniversario.Size = New System.Drawing.Size(98, 20)
        Me.LabelAniversario.TabIndex = 3
        Me.LabelAniversario.Text = "Aniversário"
        '
        'TextBoxConta
        '
        Me.TextBoxConta.Location = New System.Drawing.Point(142, 81)
        Me.TextBoxConta.Name = "TextBoxConta"
        Me.TextBoxConta.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxConta.TabIndex = 4
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(142, 129)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxNome.TabIndex = 5
        '
        'TextBoxSaldo
        '
        Me.TextBoxSaldo.Location = New System.Drawing.Point(142, 176)
        Me.TextBoxSaldo.Name = "TextBoxSaldo"
        Me.TextBoxSaldo.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxSaldo.TabIndex = 6
        '
        'TextBoxAniversario
        '
        Me.TextBoxAniversario.Location = New System.Drawing.Point(142, 228)
        Me.TextBoxAniversario.Name = "TextBoxAniversario"
        Me.TextBoxAniversario.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxAniversario.TabIndex = 7
        '
        'ButtonCriar
        '
        Me.ButtonCriar.Location = New System.Drawing.Point(334, 153)
        Me.ButtonCriar.Name = "ButtonCriar"
        Me.ButtonCriar.Size = New System.Drawing.Size(87, 27)
        Me.ButtonCriar.TabIndex = 8
        Me.ButtonCriar.Text = "Criar"
        Me.ButtonCriar.UseVisualStyleBackColor = True
        '
        'LabelValor
        '
        Me.LabelValor.AutoSize = True
        Me.LabelValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValor.Location = New System.Drawing.Point(76, 305)
        Me.LabelValor.Name = "LabelValor"
        Me.LabelValor.Size = New System.Drawing.Size(51, 20)
        Me.LabelValor.TabIndex = 9
        Me.LabelValor.Text = "Valor"
        '
        'TextBoxValor
        '
        Me.TextBoxValor.Location = New System.Drawing.Point(80, 328)
        Me.TextBoxValor.Name = "TextBoxValor"
        Me.TextBoxValor.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxValor.TabIndex = 10
        '
        'ButtonDepositar
        '
        Me.ButtonDepositar.Location = New System.Drawing.Point(184, 303)
        Me.ButtonDepositar.Name = "ButtonDepositar"
        Me.ButtonDepositar.Size = New System.Drawing.Size(87, 27)
        Me.ButtonDepositar.TabIndex = 11
        Me.ButtonDepositar.Text = "Depositar"
        Me.ButtonDepositar.UseVisualStyleBackColor = True
        '
        'ButtonSacar
        '
        Me.ButtonSacar.Location = New System.Drawing.Point(184, 336)
        Me.ButtonSacar.Name = "ButtonSacar"
        Me.ButtonSacar.Size = New System.Drawing.Size(87, 27)
        Me.ButtonSacar.TabIndex = 12
        Me.ButtonSacar.Text = "Sacar"
        Me.ButtonSacar.UseVisualStyleBackColor = True
        '
        'LabelSaldo2
        '
        Me.LabelSaldo2.AutoSize = True
        Me.LabelSaldo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaldo2.Location = New System.Drawing.Point(303, 303)
        Me.LabelSaldo2.Name = "LabelSaldo2"
        Me.LabelSaldo2.Size = New System.Drawing.Size(55, 20)
        Me.LabelSaldo2.TabIndex = 13
        Me.LabelSaldo2.Text = "Saldo"
        '
        'TextBoxSaldo2
        '
        Me.TextBoxSaldo2.Location = New System.Drawing.Point(307, 336)
        Me.TextBoxSaldo2.Name = "TextBoxSaldo2"
        Me.TextBoxSaldo2.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxSaldo2.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(433, 450)
        Me.Controls.Add(Me.TextBoxSaldo2)
        Me.Controls.Add(Me.LabelSaldo2)
        Me.Controls.Add(Me.ButtonSacar)
        Me.Controls.Add(Me.ButtonDepositar)
        Me.Controls.Add(Me.TextBoxValor)
        Me.Controls.Add(Me.LabelValor)
        Me.Controls.Add(Me.ButtonCriar)
        Me.Controls.Add(Me.TextBoxAniversario)
        Me.Controls.Add(Me.TextBoxSaldo)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.TextBoxConta)
        Me.Controls.Add(Me.LabelAniversario)
        Me.Controls.Add(Me.LabelSaldo)
        Me.Controls.Add(Me.LabelCliente)
        Me.Controls.Add(Me.LabelConta)
        Me.Name = "Form1"
        Me.Text = "atv01"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelConta As Label
    Friend WithEvents LabelCliente As Label
    Friend WithEvents LabelSaldo As Label
    Friend WithEvents LabelAniversario As Label
    Friend WithEvents TextBoxConta As TextBox
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents TextBoxSaldo As TextBox
    Friend WithEvents TextBoxAniversario As TextBox
    Friend WithEvents ButtonCriar As Button
    Friend WithEvents LabelValor As Label
    Friend WithEvents TextBoxValor As TextBox
    Friend WithEvents ButtonDepositar As Button
    Friend WithEvents ButtonSacar As Button
    Friend WithEvents LabelSaldo2 As Label
    Friend WithEvents TextBoxSaldo2 As TextBox
End Class
