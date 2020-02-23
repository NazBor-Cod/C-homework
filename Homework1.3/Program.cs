using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter A: ");
            str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            Console.WriteLine("Enter B: ");
            str = Console.ReadLine();
            int b = Convert.ToInt32(str);
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine("{0}",i);
                    }
                    //Console.WriteLine("\n");

                }
            }
            else
            {
                Console.WriteLine("a>b");
            }
            Console.ReadLine();
        }
    }
}
