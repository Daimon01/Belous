using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a;
            Console.Write("Введите координату a в интервале от -10 до 100: ");
            a = double.Parse(Console.ReadLine());
            if (a >= -10 && a <= 100)
            {
                if (a % 10 == 1 || a % 10 == 4 || a % 10 == 5 || a % 10 == 9 || a == 10 || a == 100 || a == -10)
                {
                    Console.WriteLine(a + "'ый");
                }
                if (a % 10 == 2 || a % 10 == 6 || a % 10 == 7 || a % 10 == 8 || a == 0 || a == 40)
                {
                    Console.WriteLine(a + "'ой");
                }
                if (a % 10 == 3)
                {
                    Console.WriteLine(a + "'ий");
                }
            }
            else
            {
                Console.WriteLine("Значение A должно быть в интервале [-10, 100]");
            }
        }
    }
}
