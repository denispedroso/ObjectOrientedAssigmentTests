Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class NumberEnterInvalidStringTest

    <TestMethod()> Public Sub NumberEnterInvalidString()

        Dim number As Input

        number = New Number("a")

        Dim testVariableValid As Boolean
        testVariableValid = False

        Assert.IsNotNull(number)
        Assert.AreEqual(testVariableValid, number.Validate())
    End Sub

End Class