using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Введите число от 0 до 15: ");
            a = double.Parse(Console.ReadLine());
            if (a < 0 || a > 15)
            {
                Console.WriteLine("Значение должно быть в интервале от 0 до 15");
            }
            for (int i = 0; i < 15; i++)
            {
                if (i < a)
                {
                    Console.Write("#");
                    
                }
                else
                {
                    Console.Write(".");
                    
                }
            }
            Console.WriteLine("\n");
        }
    }
}
