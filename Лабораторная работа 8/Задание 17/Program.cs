using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i = 0;
            string b;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите массив через пробел: ");
            b = Console.ReadLine();
            int[] arr = b.Split(' ').Select(x => int.Parse(x)).ToArray();
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[a] > arr[k])
                {
                    i++;
                }
            }
            Console.WriteLine(i);
        }
    }
}
