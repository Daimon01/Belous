using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q;
            string a;
            Console.Write("Введите первое число: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            q = int.Parse(Console.ReadLine());
            Console.Write(" Введите массив через пробел: ");
            a = Console.ReadLine();
            int[] arr = a.Split(' ').Select(x => int.Parse(x)).ToArray();
            if (p < 0 || q < 0 || p > arr.Length - 1 || q > arr.Length - 1)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            if (p > q)
            {
                int c = 0;
                c = p;
                p = q;
                q = c;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == p)
                {
                    b = arr[i];
                    while (i < q)
                    {
                        if (b > arr[i + 1])
                        {
                            b = arr[i + 1];
                        }
                        i++;
                    }
                }
            }
            Console.WriteLine(b);
        }
    }
}
