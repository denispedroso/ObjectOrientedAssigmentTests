﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class NumberHasValidTest

    <TestMethod()> Public Sub NumberHasValid()

        Dim number As Input

        number = New Number(1)

        Dim testVariable As Boolean = True

        Assert.IsNotNull(number)
        Assert.AreEqual(testVariable, number.Validate())

    End Sub

End Class