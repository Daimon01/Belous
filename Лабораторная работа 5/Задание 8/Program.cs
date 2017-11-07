using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Введите число \"а\"");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число \"b\"");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число \"c\"");
            c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Уравнение не является квадратным");
                return;
            }
            d = (int)Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                Console.WriteLine("Уравнение " + a + "x^2+" + b + "x+" + c + " имеет два вещественных корня");
            }
            if (d == 0)
            {
                Console.WriteLine("Уравнение " + a + "x^2+" + b + "x+" + c + " имеет один корень");
            }
            else
            {
                Console.WriteLine("Уравнение " + a + "x^2+" + b + "x+" + c + " корней не имеет");
            }
        }
    }
}
