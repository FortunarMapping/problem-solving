using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input base value : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please input index value : ");
            int n = int.Parse(Console.ReadLine());
            int result = power(a, n);
            Console.WriteLine("Power {0} of {1} is {2}", a, n, result);
        }
        static int power(int a, int n)
        {
            int result;
            if (n == 0)
                result = 1;
            else
                result = a * power(a, n - 1);
            return result;
        }
    }
}
