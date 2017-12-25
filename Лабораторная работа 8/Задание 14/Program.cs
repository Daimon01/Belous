using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string b;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите массив через пробел: ");
            b = Console.ReadLine();
            int[] arr = b.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] * a + " ");
            }
        }
    }
}
