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
            int p, q, c = 0;
            string a;
            Console.Write("Введите первый индекс: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Введите второй индекс: ");
            q = int.Parse(Console.ReadLine());
            Console.Write("Введите массив через пробел: ");
            a = Console.ReadLine();
            int[] arr = a.Split(' ').Select(x => int.Parse(x)).ToArray();
            if (p < 0 || p >= arr.Length)
            {
                Console.WriteLine("Число P должно быть в интервале [0, размер массива)");
                return;
            }
            if (q < 0 || q >= arr.Length)
            {
                Console.WriteLine("Число Q должно быть в интервале [0, размер массива)");
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == p)
                {
                    c = arr[i];
                    arr[i] = arr[q];
                    continue;
                }
                if (i == q)
                {
                    arr[i] = c;
                    continue;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
