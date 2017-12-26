using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string t, l;
            Console.Write("Введите первый массив через пробел: ");
            t = Console.ReadLine();
            Console.Write("Введите второй массив через пробел: ");
            l = Console.ReadLine();
            if (t == string.Empty)
            {
                Console.WriteLine("Данные сверху отсутствуют");
                return;
            }
            if (l == string.Empty)
            {
                Console.WriteLine("Данные слева отсутствуют");
                return;
            }
            string[] top = t.Split(' ');
            string[] left = l.Split(' ');
            Console.Write(" ");
            for (int i = 0; i < top.Length; i++)
            {
                Console.Write(top[i]);
            }
            Console.Write("\n");
            for (int i = 0; i < left.Length; i++)
            {
                Console.Write(left[i]);
                for (int k = 0; k < top.Length; k++)
                {
                    if (left[i] == top[k])
                    {
                        Console.Write("+");
                    }
                    Console.Write(" ");
                }
                Console.Write("|\n");
            }
            Console.Write(" ");
            for (int n = 0; n < top.Length; n++)
            {
                Console.Write("_");
            }
        }
    }
}
