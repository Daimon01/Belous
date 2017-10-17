using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.Write("Введите первое слово: ");
            a = Console.ReadLine();
            String b;
            Console.Write("Введите второе слово: ");
            b = Console.ReadLine();
            Console.WriteLine(b + " " + a);
            Console.Write(b);
            Console.Write(" ");
            Console.WriteLine(a);
            Console.WriteLine("{1} {0}", a, b);
        }
    }
}
