using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_31
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b=0;
            Console.Write("Введите число: ");
            a = double.Parse(Console.ReadLine());
            if (a < 0 || a > 20)
            {
                Console.WriteLine("Значение должно быть от 0 до 20");
                return;
            }
            while (b <= 9)
            {
                for (int i = 1; i <= a; i++)
                {
                    Console.Write(b);
                }
                Console.Write("\n");
                b++;
            }
          
        }
    }
}
