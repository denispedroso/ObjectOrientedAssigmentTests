Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationCalculateTest

    <TestMethod()> Public Sub CalculationCalculate()

        Dim calculation As Calculation

        calculation = New Calculation
        calculation.Number1 = New Number(1)
        calculation.Number1.Validate()
        calculation.Number2 = New Number(1)
        calculation.Number2.Validate()
        calculation.ExpectResult = New Number(2)
        calculation.ExpectResult.Validate()
        calculation.Operation = "+"

        Dim testVariableOperation As String = "+"
        Dim testVariableNumber1 As Integer = 1
        Dim testVariableNumber2 As Integer = 1
        Dim testVariableExpectedResult As Integer = 2
        Dim testVariableResult As Double = 2

        Assert.IsNotNull(calculation)
        Assert.AreEqual(testVariableOperation, calculation.Operation)
        Assert.AreEqual(testVariableNumber1, calculation.Number1.Number)
        Assert.AreEqual(testVariableNumber2, calculation.Number2.Number)
        Assert.AreEqual(testVariableExpectedResult, calculation.ExpectResult.Number)
        Assert.AreEqual(testVariableResult, calculation.Calculate())

    End Sub

End Class