using CSharpHelpers.Delegate;
using static Program;

internal static class DelegateHelpers
{

    private static void LocalArithmaticCalc(int firstNum, int secondNum, MathOperation math)
    {
        System.Console.WriteLine($"FirstNum = {firstNum} SeconNum = {secondNum}");
        math(firstNum, secondNum);
    }

    public static void TestDelegate()
    {
        MathOperation math = ArithmaticOperations.Add;
        math += ArithmaticOperations.Mul;

        math(45, 5);
        int firstNum = 67;
        int secondNum = 4;

        LocalArithmaticCalc(firstNum, secondNum, math);

    }

  
}