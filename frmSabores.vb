Public Class frmPrincipal


    Dim objPedido As New clsPedido
    Dim objPizza As New clsPizza
    Dim opcao As Integer = 2    'variável que controla se calcula pela mais cara ou pela média de sabores, 1=mais cara, 2=média
    Dim vetor(3) As Double  'vetor com 4 posições que irá guardar o valor dos sabores escolhidos

    Private Sub btnFecharPedido_Click(sender As Object, e As EventArgs) Handles btnFecharPedido.Click
        Dim formFinal As New frmPagamento(objPedido.valorTotal)
        formFinal.ShowDialog()
    End Sub

    ''Função que limpa os sabores escolhidos e os torna invísiveis
    Private Sub limpaSabores()
        btnSabor1.Text = ""
        btnSabor2.Text = ""
        btnSabor3.Text = ""
        btnSabor4.Text = ""
        btnDelSabor1.Visible = False
        btnDelSabor2.Visible = False
        btnDelSabor3.Visible = False
        btnDelSabor4.Visible = False
    End Sub

    Private Sub rdbPequena_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPequena.CheckedChanged
        limpaSabores()
        grpSalgados.Visible = True
        grpDoces.Visible = True
        grpSaboresEscolhidos.Visible = True
        objPizza.tamanho = 1
        objPedido.valorPizza = 10.0
        btnValorPizza.Text = Convert.ToString(objPedido.valorPizza)
        btnValorPizza.Visible = True
        lblSabor.Visible = True
        calculaSabores()
    End Sub

    Private Sub rdbMedia_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMedia.CheckedChanged
        limpaSabores()
        grpSalgados.Visible = True
        grpDoces.Visible = True
        grpSaboresEscolhidos.Visible = True
        objPizza.tamanho = 2
        objPedido.valorPizza = 15.0
        btnValorPizza.Text = Convert.ToString(objPedido.valorPizza)
        btnValorPizza.Visible = True
        lblSabor.Visible = True
        calculaSabores()
    End Sub

    Private Sub rdbGrande_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGrande.CheckedChanged
        limpaSabores()
        grpSalgados.Visible = True
        grpDoces.Visible = True
        grpSaboresEscolhidos.Visible = True
        objPizza.tamanho = 3
        objPedido.valorPizza = 20.0
        btnValorPizza.Text = Convert.ToString(objPedido.valorPizza)
        btnValorPizza.Visible = True
        lblSabor.Visible = True
        calculaSabores()
    End Sub

    Private Sub btn4Queijos_Click(sender As Object, e As EventArgs) Handles btn4Queijos.Click
        insereSabores("4 Queijos")
        calculaSabores()
    End Sub

    Private Sub btnMussarela_Click(sender As Object, e As EventArgs) Handles btnMussarela.Click
        insereSabores("Mussarela")
        calculaSabores()
    End Sub

    Private Sub btnCalabresa_Click(sender As Object, e As EventArgs) Handles btnCalabresa.Click
        insereSabores("Calabresa")
        calculaSabores()
    End Sub

    Private Sub btnCoracao_Click(sender As Object, e As EventArgs) Handles btnCoracao.Click
        insereSabores("Coração")
        calculaSabores()
    End Sub

    ''Função para verificar se algum sabor escolhido foi removido e desabilitar o botão Delete
    Private Sub verificarSabores()
        If (btnSabor1.Text = "") Then
            btnDelSabor1.Visible = False
        End If
        If (btnSabor2.Text = "") Then
            btnDelSabor2.Visible = False
        End If
        If (btnSabor3.Text = "") Then
            btnDelSabor3.Visible = False
        End If
        If (btnSabor4.Text = "") Then
            btnDelSabor4.Visible = False
        End If
    End Sub

    Private Sub btnDelSabor1_Click(sender As Object, e As EventArgs) Handles btnDelSabor1.Click
        btnSabor1.Text = btnSabor2.Text
        btnSabor2.Text = btnSabor3.Text
        btnSabor3.Text = btnSabor4.Text
        btnSabor4.Text = ""
        verificarSabores()
        calculaSabores()
    End Sub

    Private Sub btnDelSabor2_Click(sender As Object, e As EventArgs) Handles btnDelSabor2.Click
        btnSabor2.Text = btnSabor3.Text
        btnSabor3.Text = btnSabor4.Text
        btnDelSabor4.Visible = False
        btnSabor4.Text = ""
        verificarSabores()
        calculaSabores()
    End Sub

    Private Sub btnDelSabor3_Click(sender As Object, e As EventArgs) Handles btnDelSabor3.Click
        btnSabor3.Text = btnSabor4.Text
        btnDelSabor4.Visible = False
        btnSabor4.Text = ""
        verificarSabores()
        calculaSabores()
    End Sub

    Private Sub btnDelSabor4_Click(sender As Object, e As EventArgs) Handles btnDelSabor4.Click
        btnSabor4.Text = ""
        btnDelSabor4.Visible = False
        verificarSabores()
        calculaSabores()
    End Sub

    ''Componente para verificar se há pelo menos um sabor escolhido e habilitar o botão de fechar pedido
    Private Sub btnDelSabor1_VisibleChanged(sender As Object, e As EventArgs) Handles btnDelSabor1.VisibleChanged
        If (btnDelSabor1.Visible = False) Then
            btnFecharPedido.Visible = False
        Else
            btnFecharPedido.Visible = True
        End If
    End Sub

    Private Sub btnMMS_Click(sender As Object, e As EventArgs) Handles btnMMS.Click
        insereSabores("Mm's")
        calculaSabores()
    End Sub

    Private Sub btnCbranco_Click(sender As Object, e As EventArgs) Handles btnCbranco.Click
        insereSabores("Chocolate Branco")
        calculaSabores()
    End Sub

    Private Sub btnCpreto_Click(sender As Object, e As EventArgs) Handles btnCpreto.Click
        insereSabores("Chocolate Preto")
        calculaSabores()
    End Sub

    Private Sub btnPrestigio_Click(sender As Object, e As EventArgs) Handles btnPrestigio.Click
        insereSabores("Prestígio")
        calculaSabores()
    End Sub

    ''Função que pega por parâmetro o sabor escolhido e insere nos sabores escolhidos
    Private Function insereSabores(ByVal x As String)
        If (objPizza.tamanho = 1) Then
            If (btnSabor1.Text = "") Then
                btnSabor1.Text = x
                btnSabor1.Visible = True
                btnDelSabor1.Visible = True

            ElseIf (btnSabor2.Text = "") And (btnSabor1.Text <> x) Then
                btnSabor2.Text = x
                btnSabor2.Visible = True
                btnDelSabor2.Visible = True
            End If

        ElseIf (objPizza.tamanho = 2) Then
            If (btnSabor1.Text = "") Then
                btnSabor1.Text = x
                btnSabor1.Visible = True
                btnDelSabor1.Visible = True

            ElseIf (btnSabor2.Text = "") And (btnSabor1.Text <> x) Then
                btnSabor2.Text = x
                btnSabor2.Visible = True
                btnDelSabor2.Visible = True

            ElseIf (btnSabor3.Text = "") And (btnSabor1.Text <> x) And (btnSabor2.Text <> x) Then
                btnSabor3.Text = x
                btnSabor3.Visible = True
                btnDelSabor3.Visible = True
            End If

        ElseIf (objPizza.tamanho = 3) Then
            If (btnSabor1.Text = "") Then
                btnSabor1.Text = x
                btnSabor1.Visible = True
                btnDelSabor1.Visible = True

            ElseIf (btnSabor2.Text = "") And (btnSabor1.Text <> x) Then
                btnSabor2.Text = x
                btnSabor2.Visible = True
                btnDelSabor2.Visible = True

            ElseIf (btnSabor3.Text = "") And (btnSabor1.Text <> x) And (btnSabor2.Text <> x) Then
                btnSabor3.Text = x
                btnSabor3.Visible = True
                btnDelSabor3.Visible = True

            ElseIf (btnSabor4.Text = "") And (btnSabor1.Text <> x) And (btnSabor2.Text <> x) And (btnSabor3.Text <> x) Then
                btnSabor4.Text = x
                btnSabor4.Visible = True
                btnDelSabor4.Visible = True
            End If
        End If


        Return True


    End Function

    ''Função que calcula o valor dos sabores escolhidos, e já calcula o preço total a ser pago
    Private Sub calculaSabores()
        objPizza.mediaSabores = 0

        For x = 0 To 3    ''Zera o vetor
            vetor(x) = 0
        Next

        If (objPizza.mediaSabores = 0) Then
            btnValorSabores.Visible = False
        End If
        If (btnSabor1.Text <> "") Then
            If (btnSabor1.Text = "4 Queijos") Or (btnSabor1.Text = "Mussarela") Or (btnSabor1.Text = "Chocolate Branco") Or (btnSabor1.Text = "Chocolate Preto") Then
                vetor(0) = 7
            ElseIf (btnSabor1.Text = "Calabresa") Then
                vetor(0) = 6
            ElseIf (btnSabor1.Text = "Coração") Or (btnSabor1.Text = "Prestígio") Then
                vetor(0) = 8
            ElseIf (btnSabor1.Text = "Mm's") Then
                vetor(0) = 9
            End If
        End If

        If (btnSabor2.Text <> "") Then
            If (btnSabor2.Text = "4 Queijos") Or (btnSabor2.Text = "Mussarela") Or (btnSabor2.Text = "Chocolate Branco") Or (btnSabor2.Text = "Chocolate Preto") Then
                vetor(1) = 7
            ElseIf (btnSabor2.Text = "Calabresa") Then
                vetor(1) = 6
            ElseIf (btnSabor2.Text = "Coração") Or (btnSabor2.Text = "Prestígio") Then
                vetor(1) = 8
            ElseIf (btnSabor2.Text = "Mm's") Then
                vetor(1) = 9
            End If
        End If

        If (btnSabor3.Text <> "") Then
            If (btnSabor3.Text = "4 Queijos") Or (btnSabor3.Text = "Mussarela") Or (btnSabor3.Text = "Chocolate Branco") Or (btnSabor3.Text = "Chocolate Preto") Then
                vetor(2) = 7
            ElseIf (btnSabor3.Text = "Calabresa") Then
                vetor(2) = 6
            ElseIf (btnSabor3.Text = "Coração") Or (btnSabor3.Text = "Prestígio") Then
                vetor(2) = 8
            ElseIf (btnSabor3.Text = "Mm's") Then
                vetor(2) = 9
            End If
        End If

        If (btnSabor4.Text <> "") Then
            If (btnSabor4.Text = "4 Queijos") Or (btnSabor4.Text = "Mussarela") Or (btnSabor4.Text = "Chocolate Branco") Or (btnSabor4.Text = "Chocolate Preto") Then
                vetor(3) = 7
            ElseIf (btnSabor4.Text = "Calabresa") Then
                vetor(3) = 6
            ElseIf (btnSabor4.Text = "Coração") Or (btnSabor4.Text = "Prestígio") Then
                vetor(3) = 8
            ElseIf (btnSabor4.Text = "Mm's") Then
                vetor(3) = 9
            End If
        End If
        If (opcao = 2) Then
            Dim cont As Integer = 0
            For x = 0 To 3
                If (vetor(x) <> 0) Then
                    objPizza.mediaSabores = objPizza.mediaSabores + vetor(x)
                    cont = cont + 1
                End If
            Next
            objPizza.mediaSabores = objPizza.mediaSabores / cont
        Else

            objPizza.mediaSabores = vetor(0)
            For x = 1 To 3
                If (vetor(x) > objPizza.mediaSabores) Then
                    objPizza.mediaSabores = vetor(x)
                End If
            Next

        End If
        'Verificar se há algum sabor escolhido, e fazer cálculos do valor total a ser pago
        For x = 0 To 3
            If (vetor(x) <> 0) Then
                btnValorSabores.Visible = True
                btnValorTotal.Visible = True
                btnValorSabores.Text = Math.Round(objPizza.mediaSabores, 1) 'Ajustar o valor double para apenas uma casa após a vírgula
                objPedido.valorTotal = Convert.ToDouble(btnValorSabores.Text) + objPedido.valorPizza
                btnValorTotal.Text = objPedido.valorTotal
                Exit For
            Else
                btnValorTotal.Visible = False
                btnValorTotal.Text = ""
            End If
        Next
    End Sub

    ''Função para redirecionar para o perfil do sistema no Twitter
    Private Sub btnTwitter_Click(sender As Object, e As EventArgs) Handles btnTwitter.Click
        System.Diagnostics.Process.Start("https://twitter.com/search/realtime?q=controlpizza")
    End Sub

    ''Função para redirecionar para a página do sistema no Facebook
    Private Sub btnFacebook_Click(sender As Object, e As EventArgs) Handles btnFacebook.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/controlpizza")
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxMetodoDeCalculo.SelectedIndex = 0 'Desmarcar o ComboBox
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub cbxMetodoDeCalculo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxMetodoDeCalculo.KeyPress
        MessageBox.Show("Edição não permitida")
        e.Handled = True
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub txtPrecoPequena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecoPequena.KeyPress
        MessageBox.Show("Edição não permitida")
        e.Handled = True
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub txtPrecoMedia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecoMedia.KeyPress
        MessageBox.Show("Edição não permitida")
        e.Handled = True
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub txtPrecoGrande_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecoGrande.KeyPress
        MessageBox.Show("Edição não permitida")
        e.Handled = True
    End Sub

    Private Sub cbxMetodoDeCalculo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxMetodoDeCalculo.SelectionChangeCommitted
        If (cbxMetodoDeCalculo.SelectedIndex = 0) Then 'Se for selecionado a primeira opção, calcular pela média dos sabores
            opcao = 2 'Seta opção 2 para calcular pela média dos valores
        Else
            opcao = 1 'Seta opção 1 para calcular pelo preço mais caro
        End If
        calculaSabores()
    End Sub

    Private Sub frmPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        limpaSabores()
        grpSaboresEscolhidos.Visible = False
        calculaSabores()
        rdbPequena.Checked = False
        rdbMedia.Checked = False
        rdbGrande.Checked = False
        lblSabor.Visible = False
        btnValorPizza.Text = ""

    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub txtPrecoPequena_MouseDown(sender As Object, e As MouseEventArgs) Handles txtPrecoPequena.MouseDown
        Select Case e.Button
            Case MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub txtPrecoMedia_MouseDown(sender As Object, e As MouseEventArgs) Handles txtPrecoMedia.MouseDown
        Select Case e.Button
            Case MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub txtPrecoGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles txtPrecoGrande.MouseDown
        Select Case e.Button
            Case MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub cbxMetodoDeCalculo_MouseDown(sender As Object, e As MouseEventArgs) Handles cbxMetodoDeCalculo.MouseDown
        Select Case e.Button
            Case MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub txtPrecoPequena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecoPequena.KeyDown
        If e.KeyCode = Keys.Delete Then
            MessageBox.Show("Edição não permitida")
            e.Handled = True
        End If
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub txtPrecoMedia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecoMedia.KeyDown
        If e.KeyCode = Keys.Delete Then
            MessageBox.Show("Edição não permitida")
            e.Handled = True
        End If
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub txtPrecoGrande_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecoGrande.KeyDown
        If e.KeyCode = Keys.Delete Then
            MessageBox.Show("Edição não permitida")
            e.Handled = True
        End If
    End Sub

    ''Impossibilitar edição do componente pelo usuário
    Private Sub cbxMetodoDeCalculo_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxMetodoDeCalculo.KeyDown
        If e.KeyCode = Keys.Delete Then
            MessageBox.Show("Edição não permitida")
            e.Handled = True
        End If
    End Sub
End Class
