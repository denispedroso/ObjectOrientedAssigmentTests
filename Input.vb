Public MustInherit Class Input
    Private _Valid As Boolean
    Protected Property Valid() As Boolean
        Get
            Return _Valid
        End Get

        Set(value As Boolean)
            _Valid = value
        End Set
    End Property

    Private _InputString As String
    Public Property InputString() As String
        Get
            Return _InputString
        End Get

        Set(value As String)
            _InputString = value
        End Set
    End Property

    Function Enter(inputValue)
        InputString = inputValue
        Return InputString
    End Function

    Public MustOverride Function Validate()

    Public Sub New()
    End Sub

    Public Sub New(inputValue)
        InputString = inputValue
    End Sub


End Class
