Public Class Student
    Private _calculations As Dictionary(Of Integer, Calculation)
    Public Property Calculations() As Dictionary(Of Integer, Calculation)
        Get
            Return _calculations
        End Get

        Set(value As Dictionary(Of Integer, Calculation))
            _calculations = value
        End Set
    End Property

    Public Sub New()
        _calculations = New Dictionary(Of Integer, Calculation)
    End Sub

    Function CheckCalculation(calculation As Calculation) As Boolean

        calculation.Calculate()
        Dim key As Integer = Calculations.Count
        Calculations.Add(key + 1, calculation)

        Return calculation.IsCorrect
    End Function
End Class
