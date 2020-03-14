using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.Write("Enter A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter C: ");
            C = Convert.ToInt32(Console.ReadLine());
            if ((A < C) || (C > B))
            {
                Console.WriteLine("Error! A squere with side C cannot fit into the rectangle with the sides A and B");
            }
            else
            {
                int sum1 = A / C;
                int sum2 = B / C;
                Console.WriteLine(sum1 * sum2);
            }
            Console.ReadLine();
        }
    }
}
