using CSharpHelpers.FuncAction;

namespace CSharpHelpers.Helpers
{
    public static class ActionFuncHelper
    {
        public static void TestAction()
        {
            Action<double,double> show = (double a, double b) => System.Console.WriteLine(a + b);
            

        }

        public static void TestFunc()
        {
            Func<int, int, int> add = FuncAction.FuncAction.Add;
            System.Console.WriteLine($"Addtion = {add(345, 5678)}");

            Func<int,int,int> mul = FuncAction.FuncAction.Mul;
            System.Console.WriteLine($"Mul = {mul(34, 4563)}");
            

            Func<int> two = FuncAction.FuncAction.Two;
            System.Console.WriteLine($"Two = {two()}");


            Func<int, int, int> addLambda = (int i, int j) => i + j;
            System.Console.WriteLine($"Addtion Lambda = {addLambda(345, 5678)}");

            Func<int, int, int> mulLambda = (int i, int j) => i * j;
            System.Console.WriteLine($"Mul Lambda = {mulLambda(345, 5678)}");

            Func<int> twoLambda = FuncAction.FuncAction.Two;
            System.Console.WriteLine($"Addtion = {twoLambda()}");
        }
    }
}