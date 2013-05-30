Public Class frmPagamento

    
    Dim _valor As Double
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(valor As Double)
        InitializeComponent()
        _valor = valor
        btnValorTotal.Text = valor
    End Sub

    Private Sub cbxNumPessoas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxNumPessoas.SelectedValueChanged
        Dim qPessoas As Double
        If (cbxNumPessoas.SelectedIndex >= 0) Then
            qPessoas = _valor / CInt(cbxNumPessoas.Text)
        End If
        btnValorPorPessoa.Text = Math.Round(qPessoas, 2)
        btnValorTotal.Text = _valor.ToString()
        cbxNumPessoas.Enabled = False
    End Sub

    Private Sub btnValorPorPessoa_TextChanged(sender As Object, e As EventArgs) Handles btnValorPorPessoa.TextChanged
        lblPedidoFinalizado.Visible = True
        btnPedidoFinalizado.Visible = True
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub cbxNumPessoas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxNumPessoas.KeyPress
        MessageBox.Show("Edição não permitida")
        e.Handled = True
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub cbxNumPessoas_MouseDown(sender As Object, e As MouseEventArgs) Handles cbxNumPessoas.MouseDown
        Select Case e.Button
            Case MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub

    Private Sub btnPedidoFinalizado_Click(sender As Object, e As EventArgs) Handles btnPedidoFinalizado.Click
        Close()
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub cbxNumPessoas_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxNumPessoas.KeyDown
        If e.KeyCode = Keys.Delete Then
            MessageBox.Show("Edição não permitida")
            e.Handled = True
        End If
    End Sub
End Class