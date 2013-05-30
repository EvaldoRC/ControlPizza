<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagamento))
        Me.lblInforme = New System.Windows.Forms.Label()
        Me.cbxNumPessoas = New System.Windows.Forms.ComboBox()
        Me.btnValorTotal = New System.Windows.Forms.Button()
        Me.lblValorT = New System.Windows.Forms.Label()
        Me.lblValorAserPago = New System.Windows.Forms.Label()
        Me.btnValorPorPessoa = New System.Windows.Forms.Button()
        Me.lblPedidoFinalizado = New System.Windows.Forms.Label()
        Me.btnPedidoFinalizado = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInforme
        '
        Me.lblInforme.AutoSize = True
        Me.lblInforme.BackColor = System.Drawing.Color.Transparent
        Me.lblInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInforme.ForeColor = System.Drawing.Color.White
        Me.lblInforme.Location = New System.Drawing.Point(12, 84)
        Me.lblInforme.Name = "lblInforme"
        Me.lblInforme.Size = New System.Drawing.Size(340, 20)
        Me.lblInforme.TabIndex = 1
        Me.lblInforme.Text = "Número de pessoas para rateio da conta:"
        '
        'cbxNumPessoas
        '
        Me.cbxNumPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxNumPessoas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNumPessoas.FormattingEnabled = True
        Me.cbxNumPessoas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbxNumPessoas.Location = New System.Drawing.Point(358, 81)
        Me.cbxNumPessoas.Name = "cbxNumPessoas"
        Me.cbxNumPessoas.Size = New System.Drawing.Size(73, 28)
        Me.cbxNumPessoas.TabIndex = 3
        '
        'btnValorTotal
        '
        Me.btnValorTotal.Enabled = False
        Me.btnValorTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValorTotal.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnValorTotal.Location = New System.Drawing.Point(237, 23)
        Me.btnValorTotal.Name = "btnValorTotal"
        Me.btnValorTotal.Size = New System.Drawing.Size(172, 33)
        Me.btnValorTotal.TabIndex = 4
        Me.btnValorTotal.UseVisualStyleBackColor = True
        '
        'lblValorT
        '
        Me.lblValorT.AutoSize = True
        Me.lblValorT.BackColor = System.Drawing.Color.Transparent
        Me.lblValorT.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorT.ForeColor = System.Drawing.Color.White
        Me.lblValorT.Location = New System.Drawing.Point(35, 23)
        Me.lblValorT.Name = "lblValorT"
        Me.lblValorT.Size = New System.Drawing.Size(178, 29)
        Me.lblValorT.TabIndex = 5
        Me.lblValorT.Text = "Valor Total:  R$"
        '
        'lblValorAserPago
        '
        Me.lblValorAserPago.AutoSize = True
        Me.lblValorAserPago.BackColor = System.Drawing.Color.Transparent
        Me.lblValorAserPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorAserPago.ForeColor = System.Drawing.Color.White
        Me.lblValorAserPago.Location = New System.Drawing.Point(10, 127)
        Me.lblValorAserPago.Name = "lblValorAserPago"
        Me.lblValorAserPago.Size = New System.Drawing.Size(435, 36)
        Me.lblValorAserPago.TabIndex = 6
        Me.lblValorAserPago.Text = "Valor a ser pago por pessoa: "
        '
        'btnValorPorPessoa
        '
        Me.btnValorPorPessoa.BackColor = System.Drawing.Color.Transparent
        Me.btnValorPorPessoa.Enabled = False
        Me.btnValorPorPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValorPorPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValorPorPessoa.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnValorPorPessoa.Location = New System.Drawing.Point(152, 187)
        Me.btnValorPorPessoa.Name = "btnValorPorPessoa"
        Me.btnValorPorPessoa.Size = New System.Drawing.Size(172, 60)
        Me.btnValorPorPessoa.TabIndex = 7
        Me.btnValorPorPessoa.UseVisualStyleBackColor = False
        '
        'lblPedidoFinalizado
        '
        Me.lblPedidoFinalizado.AutoSize = True
        Me.lblPedidoFinalizado.BackColor = System.Drawing.Color.Transparent
        Me.lblPedidoFinalizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedidoFinalizado.Location = New System.Drawing.Point(82, 333)
        Me.lblPedidoFinalizado.Name = "lblPedidoFinalizado"
        Me.lblPedidoFinalizado.Size = New System.Drawing.Size(327, 39)
        Me.lblPedidoFinalizado.TabIndex = 8
        Me.lblPedidoFinalizado.Text = "Pedido Finalizado!!"
        Me.lblPedidoFinalizado.Visible = False
        '
        'btnPedidoFinalizado
        '
        Me.btnPedidoFinalizado.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPedidoFinalizado.BackgroundImage = CType(resources.GetObject("btnPedidoFinalizado.BackgroundImage"), System.Drawing.Image)
        Me.btnPedidoFinalizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPedidoFinalizado.FlatAppearance.BorderSize = 0
        Me.btnPedidoFinalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedidoFinalizado.Location = New System.Drawing.Point(191, 375)
        Me.btnPedidoFinalizado.Name = "btnPedidoFinalizado"
        Me.btnPedidoFinalizado.Size = New System.Drawing.Size(116, 109)
        Me.btnPedidoFinalizado.TabIndex = 9
        Me.btnPedidoFinalizado.UseVisualStyleBackColor = False
        Me.btnPedidoFinalizado.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(70, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 36)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "R$:"
        '
        'frmPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(491, 544)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPedidoFinalizado)
        Me.Controls.Add(Me.lblPedidoFinalizado)
        Me.Controls.Add(Me.btnValorPorPessoa)
        Me.Controls.Add(Me.lblValorAserPago)
        Me.Controls.Add(Me.lblValorT)
        Me.Controls.Add(Me.btnValorTotal)
        Me.Controls.Add(Me.cbxNumPessoas)
        Me.Controls.Add(Me.lblInforme)
        Me.Name = "frmPagamento"
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInforme As System.Windows.Forms.Label
    Friend WithEvents cbxNumPessoas As System.Windows.Forms.ComboBox
    Friend WithEvents btnValorTotal As System.Windows.Forms.Button
    Friend WithEvents lblValorT As System.Windows.Forms.Label
    Friend WithEvents lblValorAserPago As System.Windows.Forms.Label
    Friend WithEvents btnValorPorPessoa As System.Windows.Forms.Button
    Friend WithEvents lblPedidoFinalizado As System.Windows.Forms.Label
    Friend WithEvents btnPedidoFinalizado As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
