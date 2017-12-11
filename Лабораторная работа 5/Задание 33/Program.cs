using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("Введите минуту в часе от 0 до 59");
            t = int.Parse(Console.ReadLine());
            if (t < 0 && t > 59)
            {
                Console.WriteLine("ВЫ ВВЕЛИ НЕ ВЕРНОЕ ЧИСЛО");
                return;
            }
            if (t % 10 == 0 || t % 10 == 1 || t % 10 == 2 || t % 10 == 5 || t % 10 == 6 || t % 10 == 7)
            {
                Console.WriteLine("Зеленый");
            }
            else
            {
                Console.WriteLine("Краcный");
            }
        }
    }
}
