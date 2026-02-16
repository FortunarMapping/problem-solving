using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InfixToPostfix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input infix-math expression : ");
            string data = Console.ReadLine();
            string result = infixToPostfix(data);
            Console.WriteLine("Result postfix-math expression : {0}", result);
        }
        static string infixToPostfix(string data)
        {
            Stack S new Stack();
            string result = "";
            for(int i= 0; i< data.Length; ++i)
            {
                if (data[i] == ')')
            }
        }
    }
}
