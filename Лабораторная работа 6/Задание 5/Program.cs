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
            int i = 0, a;
            string b;
            Console.Write("Введите количество повторений: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите символ: ");
            b = Console.ReadLine();
            while (i < a)
            {
                Console.Write(b);
                i++;
            }

        }
    }
}
