using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Введите число: ");
            a = double.Parse(Console.ReadLine());
            for (int i = 10; i <= 20; i++)
            {
                if (i == a)
                {
                    Console.WriteLine(i + "+");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
