using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1, c = 1;
            string a;
            Console.Write("Введите массив через пробел: ");
            a = Console.ReadLine();
            int[] arr = a.Split(' ').Select(x => int.Parse(x)).ToArray();
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
                    b++;
                }
            }
            Console.WriteLine(b);
        }
    }
}
