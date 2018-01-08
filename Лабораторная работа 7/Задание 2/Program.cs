using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.Write("Введите символ: ");
            a = Console.ReadLine();
            string b = "abcdefwxyz";
            int c = b.IndexOf(a);
            c = b.Length - (c + 1);
            if (c == 10)
            {
                Console.WriteLine("Значение отсутствует в строке");
                return;
            }
            Console.WriteLine(c);
        }
    }
}
