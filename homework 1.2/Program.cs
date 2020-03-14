using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int percent;
            int sum = 10000;
            int month_sum = 0;
            Console.Write("Enter percent: ");
            percent = Convert.ToInt32(Console.ReadLine());
            if (percent < 1 || percent > 26)
            {
                Console.WriteLine("Not correct percent");
            }
            else
            {
                while (sum<11000)
                {
                    int tmp;
                    tmp = percent * sum / 100;

                }
            }
        }
    }
}
