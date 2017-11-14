using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Double m, p;
            Console.Write("Введите первое число M: ");
            m = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число P: ");
            p = double.Parse(Console.ReadLine());
            if (m%p == 0)
            {
                m = m / p;
                Console.WriteLine(m);
                return;
            }
            if (p == 0)
            {
                Console.WriteLine("Второе значение должно быть не равно 0");
                return;
            }
            Console.WriteLine("M не делится нацело на P");
        }
    }
}
