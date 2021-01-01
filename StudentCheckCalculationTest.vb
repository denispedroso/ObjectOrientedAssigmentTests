Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class StudentCheckCalculationTest

    <TestMethod()> Public Sub StudentCheckCalculation()

        Dim student As Student
        student = New Student

        Dim calculation As Calculation = New Calculation
        calculation.Number1 = New Number(2)
        calculation.Number1.Validate()
        calculation.Number2 = New Number(2)
        calculation.Number2.Validate()
        calculation.ExpectResult = New Number(4)
        calculation.ExpectResult.Validate()
        calculation.Operation = "+"

        Dim testVariableStudent As Student = New Student
        Dim testVariableCalc As Calculation = New Calculation
        testVariableCalc.Number1 = New Number(2)
        testVariableCalc.Number1.Validate()
        testVariableCalc.Number2 = New Number(2)
        testVariableCalc.Number2.Validate()
        testVariableCalc.ExpectResult = New Number(4)
        testVariableCalc.ExpectResult.Validate()
        testVariableCalc.Operation = "+"

        Dim testVariableCheckCalculation As Boolean
        testVariableCheckCalculation = testVariableStudent.CheckCalculation(testVariableCalc)

        Dim checkCalculation As Boolean
        checkCalculation = student.CheckCalculation(calculation)

        Assert.IsNotNull(student)
        Assert.IsNotNull(calculation)

        Assert.AreEqual(testVariableCheckCalculation, checkCalculation)
        Assert.AreEqual(testVariableStudent.Calculations.Count(), student.Calculations.Count())
    End Sub

End Class