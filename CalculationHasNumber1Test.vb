Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationHasNumber1Test

    <TestMethod()> Public Sub CalculationHasNumber1()

        Dim calculation As Calculation

        calculation = New Calculation
        calculation.Number1 = New Number

        Dim testVariable As Number = New Number

        Assert.IsNotNull(calculation)
        Assert.IsInstanceOfType(calculation.Number1, testVariable.GetType)
    End Sub

End Class