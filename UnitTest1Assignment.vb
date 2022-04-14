Imports System.Text
Imports Calculator_App
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.ArithmeticException
<TestClass()> Public Class UnitTest1
    Dim calculatorEngine As New CalculatorEngine
    <TestMethod()> Public Sub usertestmethod()

        Dim userName As String = "prajwal.ghogare"

        Dim expectedResult = userName
        Dim actualResult = calculatorEngine.userCheck(userName)

        Assert.AreEqual(expectedResult, actualResult, "Both Are Matched")

    End Sub
    <TestMethod()> Public Sub passwordtestmethod()

        Dim passWord As String = "20220414"

        Dim expectedResult = passWord
        Dim actualResult = calculatorEngine.passwordCheck(passWord)

        Assert.AreEqual(expectedResult, actualResult, "Both Are Matched")

    End Sub

   
    End Sub
    <TestMethod()> Public Sub Addtion_of_two_negative_numbers()
        Dim num1 As Double = -12
        Dim num2 As Double = -8
        Dim expectedResult As Double = -20
        Dim actualResult = calculatorEngine.Addtion(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, "Addtion Are Matched")

    End Sub

     <TestMethod()> Public Sub Addtion_of_two_integer_numbers()
        Dim num1 As Double = 10
        Dim num2 As Double = 18
        Dim expectedResult As Double = 28
        Dim actualResult = calculatorEngine.Addtion(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, "Addtion Are Matched")
    End Sub

    <TestMethod()> Public Sub subtraction_of_two_integer_numbers()
        Dim num1 As Integer = 2
        Dim num2 As Integer = 6
        Dim expectedResult As Double = -4
        Dim actualResult = calculatorEngine.Subtraction(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, "Subtraction Are Matched")

    End Sub
    <TestMethod()> Public Sub Addtion_of_one_positive_and_one_negative_numbers()
        Dim num1 As Double = 14
        Dim num2 As Double = -4
        Dim expectedResult As Double = 10
        Dim actualResult = calculatorEngine.Addtion(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, "Addtion Are Matched")

    End Sub
    <TestMethod()> Public Sub subtraction_of_two_negative_numbers()
        Dim num1 As Double = -10
        Dim num2 As Double = -8
        Dim expectedResult As Double = 2
        Dim actualResult = calculatorEngine.Subtraction(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, "Subtraction Are Matched")

    End Sub
    <TestMethod()> Public Sub subtraction_of_one_positive_and_one_negative_numbers()
        Dim num1 As Double = 8
        Dim num2 As Double = -4
        Dim expectedResult As Double = 12
        Dim actualResult = calculatorEngine.Subtraction(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, "Subtraction Are Matched")

    End Sub
    <TestMethod()> Public Sub multiplication_of_two_integer_numbers()
        Dim num1 As Integer = 2
        Dim num2 As Integer = 4
        Dim expectedResult As Double = 8
        Dim actualResult = calculatorEngine.Multiplication(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, " Multiplication Are Matched")

    End Sub
    <TestMethod()> Public Sub multiplication_of_two_negative_numbers()
        Dim num1 As Double = -2
        Dim num2 As Double = -2
        Dim expectedResult As Double = 4
        Dim actualResult = calculatorEngine.Multiplication(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, " Multiplication Are Matched")

    End Sub
    <TestMethod()> Public Sub multiplication_of_one_positive_and_one_negative_numbers()
        Dim num1 As Double = 10
        Dim num2 As Double = -3
        Dim expectedResult As Double = -30
        Dim actualResult = calculatorEngine.Multiplication(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, " Multiplication Are Matched")

    End Sub
    <TestMethod()> Public Sub division_of_two_integer_numbers()
        Dim num1 As Integer = 6
        Dim num2 As Integer = 2
        Dim expectedResult As Double = 3
        Dim actualResult = calculatorEngine.Division(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, " Division Are Matched")

    End Sub
    <TestMethod()> Public Sub division_of_two_negative_numbers()
        Dim num1 As Double = -8
        Dim num2 As Double = -4
        Dim expectedResult As Double = 0.5
        Dim actualResult = calculatorEngine.Division(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, " Division Are Matched")

    End Sub
    <TestMethod()> Public Sub division_of_one_positive_and_one_negative_numbers()
        Dim num1 As Double = 14
        Dim num2 As Double = -8
        Dim expectedResult As Double = -3
        Dim actualResult = calculatorEngine.Division(num1, num2)

        Assert.AreEqual(expectedResult, actualResult, "Division Are Matched")

    End Sub

    <TestMethod()> Public Sub division_of_a_number_by_zero()

        Dim num1 As Double = 12
        Dim num2 As Double = 0

        Dim actualResult = calculatorEngine.Division(num1, num2)

    End Sub
End Class