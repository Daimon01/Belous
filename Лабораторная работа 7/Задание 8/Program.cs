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
            int a, b;
            string c = "abcdefwxyz";
            Console.Write("Введите место символа: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите количество удаляемых символов: ");
            b = int.Parse(Console.ReadLine());
            if (a + b > c.Length)
            {
                Console.WriteLine("Сумма значений не должна превышать: " + c.Length);
                return;
            }
            if (a >= c.Length || a < 0)
            {
                Console.WriteLine("Первое значение должно быть в интервале от 0 до " + (c.Length - 1));
                return;
            }
            if (b < 0)
            {
                Console.WriteLine("Второе значение не должно быть отрицательным");
                return;
            }
            for (int i = 0; i < c.Length; i++)
            {
                if(i == a || i < a + b && i > a)
                {
                    continue;
                }
                Console.Write(c[i]);
            }
        }
    }
}
