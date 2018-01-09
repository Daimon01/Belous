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
            int a, b;
            Console.Write("Введите первый символ: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второй символ: ");
            b = int.Parse(Console.ReadLine());
            string c = "abcdefwxyz";
            if (a > b)
            {
                Console.WriteLine("Значение A должно быть меньше B");
                return;
            }
            if(a > c.Length || a < 0)
            {
                Console.WriteLine("Зачание а должно быть в интервале от 0 до " + c.Length);
                return;
            }
            if (b > c.Length || b < 0)
            {
                Console.WriteLine("Зачание b должно быть в интервале от 0 до " + c.Length);
                return;
            }
            for (int i = a; i <= b; i++)
            {
                Console.Write(c[i]);
            }
        }
    }
}
