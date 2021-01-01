Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationHasIsCorrectTest

    <TestMethod()> Public Sub CalculationHasIsCorrect()

        Dim calculation As Calculation

        calculation = New Calculation
        calculation.IsCorrect = True

        Dim testVariable As Boolean = True

        Assert.IsNotNull(calculation)
        Assert.AreEqual(testVariable, calculation.IsCorrect)
    End Sub

End Class