Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class NumberHasNumberTest

    <TestMethod()> Public Sub NumberHasNumber()

        Dim number As Number

        number = New Number
        number.Number = 1

        Dim testVariable As Integer = 1

        Assert.IsNotNull(number)
        Assert.AreEqual(testVariable, number.Number)

        '1. A variable defined of type {ClassName} And now with the code to construct it as well. 
        '   A test value variable matching the type of the attribute. Remember if there Is a relationship on the diagram the type Is that other class.

        '3. Assert.IsNotNull() on the variable, can keep this here to make sure your setup Is correct. 
        '   Use Assert.AreEqual to compare your testVariable with what Is in {ClassName}.{Attribute}

        '2. Assign a value to {ClassName}.{Attribute}
    End Sub

End Class