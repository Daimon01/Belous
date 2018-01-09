using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b;
            Console.Write("Введите первый символ: ");
            a = Console.ReadLine();
            Console.Write("Введите второй символ: ");
            b = Console.ReadLine();
            string c = "abcdefwxyz";
            int e = c.IndexOf(a);
            if (e == -1)
            {
                Console.WriteLine("Первое значение отсутствует в строке");
                return;
            }
            int f = c.IndexOf(b);
            if (f == -1)
            {
                Console.WriteLine("Второе значение отсутствует в строке");
                return;
            }
            if (e > f)
            {
                int z;
                z = e;
                e = f;
                f = z;
            }
            for (int i = e; i < f-1; i++)
            {
                Console.Write(c[i+1]);
            }
        }
    }
}
