using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.Write("Введите слово: ");
            a = Console.ReadLine();
            Console.WriteLine("Программирование это " + a + "!");
            Console.Write("Программирование это ");
            Console.Write(a);
            Console.WriteLine("!");
            Console.WriteLine("Программирование это {0}!", a);
        }
    }
}
