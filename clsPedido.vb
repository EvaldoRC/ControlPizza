Public Class clsPedido
    Private _valorPizza As Double
    Private _valorTotal As Double


    Public Property valorPizza() As Double
        Get
            Return _valorPizza
        End Get
        Set(ByVal value As Double)
            _valorPizza = value
        End Set
    End Property

    Public Property valorTotal() As Double
        Get
            Return _valorTotal
        End Get
        Set(ByVal value As Double)
            _valorTotal = value
        End Set
    End Property

End Class
