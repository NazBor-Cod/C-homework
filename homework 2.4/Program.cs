using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int Rows, Cols;
            int M, N;
            Console.WriteLine("Enter Rows and Cols:");
            Rows = Convert.ToInt32(Console.ReadLine());
            Cols = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    arr[i, j] = rand.Next(10);
                }
            }
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Enter M and N: ");
            M = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Cols; i++)
            {
                int tmp = arr[i, M];
                arr[i, M] = arr[i, N];
                arr[i, N] = tmp;
            }
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
