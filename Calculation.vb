Public Class Calculation

    Private _Operation As String
    Public Property Operation() As String
        Get
            Return _Operation
        End Get

        Set(value As String)
            _Operation = value
        End Set
    End Property

    Private _Number1 As Number
    Public Property Number1() As Number
        Get
            Return _Number1
        End Get

        Set(value As Number)
            _Number1 = value
        End Set
    End Property

    Private _Number2 As Number
    Public Property Number2() As Number
        Get
            Return _Number2
        End Get

        Set(value As Number)
            _Number2 = value
        End Set
    End Property

    Private _ExpectResult As Number
    Public Property ExpectResult() As Number
        Get
            Return _ExpectResult
        End Get

        Set(value As Number)
            _ExpectResult = value
        End Set
    End Property

    Private _IsCorrect As Boolean
    Public Property IsCorrect() As Boolean
        Get
            Return _IsCorrect
        End Get

        Set(value As Boolean)
            _IsCorrect = value
        End Set
    End Property

    Function Calculate() As Double
        Dim result As Double
        Select Case Operation
            Case "+"
                result = Number1.Number + Number2.Number
                If ExpectResult.Number.Equals(result) Then
                    IsCorrect = True
                Else
                    IsCorrect = False
                End If
            Case "-"
                result = Number1.Number - Number2.Number
                If ExpectResult.Number.Equals(result) Then
                    IsCorrect = True
                Else
                    IsCorrect = False
                End If
            Case "*"
                result = Number1.Number * Number2.Number
                If ExpectResult.Number.Equals(result) Then
                    IsCorrect = True
                Else
                    IsCorrect = False
                End If
            Case "/"
                result = Number1.Number / Number2.Number
                If ExpectResult.Number.Equals(result) Then
                    IsCorrect = True
                Else
                    IsCorrect = False
                End If
        End Select
        Return result
    End Function

    Public Sub New()
        Operation = ""
        Number1 = New Number(0)
        Number2 = New Number(0)
        ExpectResult = New Number(0)
        IsCorrect = False
    End Sub

End Class
