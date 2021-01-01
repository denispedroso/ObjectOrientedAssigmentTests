Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class NumberIsAInputTest

    <TestMethod()> Public Sub NumberIsAInput()

        Dim input As Input

        input = New Number

        Assert.IsNotNull(input)
    End Sub

End Class