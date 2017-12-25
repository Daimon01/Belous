using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.Write("Введите первый массив: ");
            a = Console.ReadLine();
            Console.Write("Введите второй массив такой же длины как и первый: ");
            b = Console.ReadLine();
            int[] aarr = a.Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] barr = b.Split(' ').Select(x => int.Parse(x)).ToArray();
            if (aarr.Length != barr.Length)
            {
                Console.WriteLine("Массивы должны быть одинаковой длины!");
                return;
            }
            int[] carr = new int [aarr.Length];
            for (int i = 0; i < aarr.Length; i++)
            {
                carr[i] = aarr[i] * barr[i];
            }
            for (int i = 0; i < carr.Length; i++)
            {
                Console.Write(carr[i] + " ");
            }
        }
    }
}
