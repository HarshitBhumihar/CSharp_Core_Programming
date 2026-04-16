using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class linecomparision
    {
        static double CalculateLength(int x1,int y1,int x2,int y2)
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return length;
        }
        static void Main()
        {
            Console.WriteLine("Enter coordinate for line 1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coordinate for line 3:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            double length1 = CalculateLength(x1, y1, x2, y2);
            double length2 = CalculateLength(x3, y3, x4, y4);
            if (length1 == length2)
            {
                Console.WriteLine("both length are equal");
            }else if (length1 > length2)
            {
                Console.WriteLine("length1 is greater");
            }
            else
            {
                Console.WriteLine("length2 is greater");
            }
        }
    }
}
