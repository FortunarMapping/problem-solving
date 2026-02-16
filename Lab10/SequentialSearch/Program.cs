using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.Write("Enter a number to search for: ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            bool found = SeqSearch(numbers, searchNumber);
            if (found)
                Console.WriteLine(searchNumber + " is in the array.");
            else
                Console.WriteLine(searchNumber + " is not in the array.");
            Console.WriteLine("Minimum is " + FindMin(numbers));
            Console.WriteLine("Minimum is " + numbers.Min());
            Console.WriteLine("Maximum is " + FindMax(numbers));
            Console.WriteLine("Maximum is " + numbers.Max());

        }
        static bool SeqSearch(int[] arr,int sValue)
        {
            for (int index = 0; index < arr.Length; index++)
                if (arr[index] == sValue)
                    return true;
            return false;
        }
        static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i< arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
    }
}
