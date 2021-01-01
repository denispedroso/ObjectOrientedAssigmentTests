Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class StudentConstructionTest

    <TestMethod()> Public Sub StudentConstruction()
        Dim student As Student

        student = New Student

        Assert.IsNotNull(student)

    End Sub

End Class