using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            int sum = 0;
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 3);
            }
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==0)
                {
                    sum++;
                }
                else
                {
                    arr[i - sum] = arr[i];
                }
            }
            for (int i = arr.Length-sum; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }
    }
}
