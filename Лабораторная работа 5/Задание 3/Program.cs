using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double k;
            Console.Write("Введите число: ");
            k = double.Parse(Console.ReadLine());
            if (k > 0)
            {
                k = Math.Sqrt(k);
                Console.WriteLine("{0:F0}", k);
            }
            else
            {
                k = Math.Pow(k, 2);
                Console.WriteLine(k);
            }
        }
    }
}
