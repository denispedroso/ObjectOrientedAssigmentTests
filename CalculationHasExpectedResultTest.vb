Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationHasExpectedResultTest

    <TestMethod()> Public Sub CalculationHasExpectedResult()

        Dim calculation As Calculation

        calculation = New Calculation
        calculation.ExpectResult = New Number

        Dim testVariable As Number = New Number

        Assert.IsNotNull(calculation)
        Assert.IsInstanceOfType(calculation.ExpectResult, testVariable.GetType)
    End Sub

End Class