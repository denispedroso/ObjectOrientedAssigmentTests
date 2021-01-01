Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationCalculateWhenExpectedResultDoesNotMatchTest

    <TestMethod()> Public Sub CalculationCalculateWhenExpectedResultDoesNotMatch()

        Dim student As Student = New Student

        Dim calculation As Calculation

        calculation = New Calculation
        calculation.Number1 = New Number(2)
        calculation.Number1.Validate()
        calculation.Number2 = New Number(2)
        calculation.Number2.Validate()
        calculation.ExpectResult = New Number(5)
        calculation.ExpectResult.Validate()
        calculation.Operation = "+"

        Dim testVariableOperation As String = "+"
        Dim testVariableNumber1 As Integer = 2
        Dim testVariableNumber2 As Integer = 2
        Dim testVariableExpectedResult As Integer = 5
        Dim testVariableResult As Double = 4
        Dim testVariableIsCorrect = False

        Dim testVariableIsMatch As Boolean = student.CheckCalculation(calculation)
        Dim key As Integer = student.Calculations.Count

        Assert.IsNotNull(calculation)
        Assert.AreEqual(testVariableOperation, calculation.Operation)
        Assert.AreEqual(testVariableNumber1, calculation.Number1.Number)
        Assert.AreEqual(testVariableNumber2, calculation.Number2.Number)
        Assert.AreEqual(testVariableExpectedResult, calculation.ExpectResult.Number)
        Assert.AreEqual(testVariableResult, calculation.Calculate())
        Assert.AreEqual(testVariableIsCorrect, student.Calculations.Item(key).IsCorrect)
        Assert.AreEqual(False, testVariableIsMatch)
    End Sub

End Class