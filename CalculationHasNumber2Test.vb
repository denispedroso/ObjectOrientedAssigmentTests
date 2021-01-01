Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationHasNumber2Test

    <TestMethod()> Public Sub CalculationHasNumber2()

        Dim calculation As Calculation

        calculation = New Calculation
        calculation.Number2 = New Number

        Dim testVariable As Number = New Number

        Assert.IsNotNull(calculation)
        Assert.IsInstanceOfType(calculation.Number2, testVariable.GetType)
    End Sub

End Class