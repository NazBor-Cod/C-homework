using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            while (n > 0)
            {
                res *= 10;
                res += n % 10;
                n /= 10;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
