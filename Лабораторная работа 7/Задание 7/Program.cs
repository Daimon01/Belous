using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Введите штрих код: ");
            a = Console.ReadLine();
            Console.Write("Код страны: " + a[0] + a[1]);

        }
    }
}
