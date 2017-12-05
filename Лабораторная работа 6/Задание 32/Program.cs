using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_32
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string c;
            Console.Write("Введите длину: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите символ: ");
            c = Console.ReadLine();
            if (a < 0)
            {
                Console.WriteLine("Высота должна быть положительной");
                return;
            }
            if (b < 0)
            {
                Console.WriteLine("Ширина должнна быть положительной");
                return;
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    for (int k = 0; k < a; k++)
                    {
                        Console.Write(c);
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
