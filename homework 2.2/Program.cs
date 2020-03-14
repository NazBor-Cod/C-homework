using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rend = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rend.Next(-9, 10);
            }
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
