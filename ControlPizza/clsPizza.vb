Public Class clsPizza
    Private _tamanho As Integer
    Private _sabor1 As String
    Private _sabor2 As String
    Private _sabor3 As String
    Private _sabor4 As String
    Private _mediaSabores As Double
    Private _total As Double

    Public Property tamanho() As Integer
        Get
            Return _tamanho
        End Get
        Set(ByVal value As Integer)
            _tamanho = value
        End Set
    End Property

    Public Property sabor1() As String
        Get
            Return _sabor1
        End Get
        Set(ByVal value As String)
            _sabor1 = value
        End Set
    End Property

    Public Property sabor2() As String
        Get
            Return _sabor2
        End Get
        Set(ByVal value As String)
            _sabor2 = value
        End Set
    End Property

    Public Property sabor3() As String
        Get
            Return _sabor3
        End Get
        Set(ByVal value As String)
            _sabor3 = value
        End Set
    End Property

    Public Property sabor4() As String
        Get
            Return _sabor4
        End Get
        Set(ByVal value As String)
            _sabor4 = value
        End Set
    End Property

    Public Property mediaSabores() As Double
        Get
            Return _mediaSabores
        End Get
        Set(ByVal value As Double)
            _mediaSabores = value
        End Set
    End Property


    Public Property total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property
End Class

