using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, c = 1, r = 1;
            string b;
            Console.WriteLine("Введите массив через пробел: ");
            b = Console.ReadLine();
            int[] arr = b.Split(' ').Select(x => int.Parse(x)).ToArray();
            while (c != 0)
            {
                c = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int k = 0;
                        k = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = k;
                        c++;
                    }
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    a++;
                }
            }
            int[] barr = new int[a];
            barr[0] = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    barr[r] = arr[i + 1];
                    r++;
                }
            }
            for (int i = 0; i < barr.Length; i++)
            {
                Console.Write(barr[i] + " ");
            }
        }
    }
}
