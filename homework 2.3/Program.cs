using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            int N, sum = 0;

            Console.Write("Enter N: ");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            foreach (var i in arr)
            {
                if (i==N)
                {
                    sum++;
                }
            }
            Console.WriteLine($"number N in thr arr occurs {sum} times");
            Console.ReadLine();
        }
    }
}
