using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelpers.Delegate
{
    public static class ArithmaticOperations
    {
        public static void Add(int a, int b)
        {
            System.Console.WriteLine($"Addition = {a + b}");
        }
        public static  void Mul (int a, int b)
        {
            System.Console.WriteLine($"Multiplication = {a * b}");
        }
    }
}
