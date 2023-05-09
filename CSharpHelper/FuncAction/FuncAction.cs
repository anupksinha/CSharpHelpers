using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelpers.FuncAction
{
    public static class FuncAction
    {
        public static int Add(int a, int b)
        {
            return a + b;
        } 
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Two()
        {
            return 2;
        }

        public static void Show()
        {
            System.Console.WriteLine("Write a Statement");
        }
    }
}
