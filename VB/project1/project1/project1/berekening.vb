Public Class berekening
    Private _inuitgaven As String
    Private _bedrag As String
    Private _code As String
    Private _datum As Date

    Public Sub New(inuitgaven As String, bedrag As String, code As String, datum As Date)
        Me.inuitgaven = inuitgaven
        Me.bedrag = bedrag
        Me.code = code
        Me.datum = datum
    End Sub

    Public Property inuitgaven() As String
        Get
            Return _inuitgaven
        End Get
        Set(ByVal value As String)
            _inuitgaven = value
        End Set
    End Property


    Public Property bedrag() As String
        Get
            Return _bedrag
        End Get
        Set(ByVal value As String)
            _bedrag = value
        End Set
    End Property

    Public Property code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property

    Public Property datum() As Date
        Get
            Return _datum
        End Get
        Set(ByVal value As Date)
            _datum = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return inuitgaven & " , " & bedrag & " , " & code & " , " & datum
    End Function
End Class
