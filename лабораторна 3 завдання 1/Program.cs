using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабораторна_3_завдання_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input x");
            double x = Convert.ToDouble(Console.ReadLine());
            int i = 1;
            double sum = 0;
            while (i < n)
            {
                sum += Math.Pow(-1, i) * (2 * i - 1) / Math.Pow(x, i);
                i++;
            }
            Console.WriteLine($"Сума s = {sum}");
            Console.ReadKey();
        }
    }
}
