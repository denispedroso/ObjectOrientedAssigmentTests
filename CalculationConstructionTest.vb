Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CalculationConstructionTest

    <TestMethod()> Public Sub CalculationConstruction()

        Dim calculation As Calculation

        calculation = New Calculation

        Assert.IsNotNull(calculation)
    End Sub

End Class