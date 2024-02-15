using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_по_конкурентно_програмиране
{
    internal class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Main()
        {
            int a = 5, b = 10;
            Console.WriteLine(Sum(a, b));
            Console.WriteLine(Multiply(a, b));
            Console.ReadKey();
        }
    }
}
