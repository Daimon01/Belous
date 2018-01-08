using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, q = 0;
            string a;
            Console.Write("Введите число: ");
            k = int.Parse(Console.ReadLine());
            Console.Write("Введите массив через пробел: ");
            a = Console.ReadLine();
            int[] arr = a.Split(' ').Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                {
                    q++;
                }
            }
            Console.WriteLine(q);
        }
    }
}
