using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, b;
            string a;
            Console.Write("Введите массив через пробел: ");
            a = Console.ReadLine();
            int[] arr = a.Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] barr = new int[arr.Length];
            while (i < arr.Length)
            {
                b = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        b++;
                    }
                }
                barr[i] = b;
                i++;
            }
            for (int k = 0; k < barr.Length; k++)
            {
                Console.Write(barr[k] + " ");
            }
        }
    }
}
