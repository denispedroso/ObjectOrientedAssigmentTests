Public Class Number

    Inherits Input

    Private _Number As Integer
    Public Property Number() As Integer
        Get
            Return _Number
        End Get

        Set(value As Integer)
            _Number = value
        End Set
    End Property

    Public Overrides Function Validate()
        If Int32.TryParse(InputString, Number) Then
            Number = Int32.Parse(InputString)
            Valid = True
        Else
            Valid = False
        End If
        Return Valid
    End Function

    Public Sub New(inputValue)
        MyBase.New(inputValue)
    End Sub

    Public Sub New()

    End Sub


End Class
