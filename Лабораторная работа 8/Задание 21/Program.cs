using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string a;
            Console.Write("Введите первое число: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = int.Parse(Console.ReadLine());
            Console.Write(" Введите массив через пробел: ");
            a = Console.ReadLine();
            int[] arr = a.Split(' ').Select(o => int.Parse(o)).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    arr[i] = y;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
