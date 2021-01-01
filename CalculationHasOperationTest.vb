Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationHasOperationTest

    <TestMethod()> Public Sub CalculationHasOperation()

        Dim calculation As Calculation

        calculation = New Calculation
        calculation.Operation = "-"

        Dim testVariable As String = "-"

        Assert.IsNotNull(calculation)

        Assert.AreEqual(testVariable, calculation.Operation)
    End Sub

End Class