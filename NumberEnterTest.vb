Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class NumberEnterTest

    <TestMethod()> Public Sub NumberEnter()

        Dim number As Number

        number = New Number(1)

        Dim testVariable As Integer
        testVariable = 1

        number.Validate()

        Assert.IsNotNull(number)
        Assert.AreEqual(number.Number, testVariable)

    End Sub

End Class