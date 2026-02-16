using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList(10);
            for (int i = 0; i<10; i++)
            {
                arrList.insert(i);
            }
            Console.WriteLine("ขนาดของ ArrayList: " + arrList.size());
            Console.WriteLine("ArrayList ว่างหรือไม่: " + arrList.isEmpty());
            Console.WriteLine("ArrayList เต็มหรือไม่" + arrList.isFull());
            Console.WriteLine("ลบ: " + arrList.remove() + " ออกจาก ArrayList");
        }
    }
}
