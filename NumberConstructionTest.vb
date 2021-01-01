Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class InputNumberConstructionTest

    <TestMethod()> Public Sub NumberConstruction()

        Dim number As Number

        number = New Number

        Assert.IsNotNull(number)
    End Sub

End Class