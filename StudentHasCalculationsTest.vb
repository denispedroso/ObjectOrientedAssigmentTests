Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class StudentHasCalculationsTest

    <TestMethod()> Public Sub StudentHasCalculations()

        Dim student As Student
        student = New Student

        Dim testVariable = New Dictionary(Of Integer, Calculation)

        Assert.IsNotNull(student)
        Assert.IsInstanceOfType(student.Calculations, testVariable.GetType)
    End Sub

End Class