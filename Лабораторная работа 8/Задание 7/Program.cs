using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, c = 0;
            string a;
            Console.Write("Введите число: ");
            s = int.Parse(Console.ReadLine());
            Console.Write("Введите массив через пробел: ");
            a = Console.ReadLine();
            string[] arr = a.Split(' ');
            if (s < 0)
            {
                s = s * -2 + 1;
            }
            for (int i = 1; i < s; i++)
            {
                c++;
                if (c >= arr.Length)
                {
                    c = 1;
                }
            }
            for (int i = arr.Length-c; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < arr.Length-c; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
