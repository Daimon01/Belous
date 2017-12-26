using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            String a;
            Console.Write("Введите массив: ");
            a = Console.ReadLine();
            int[] arr = a.Split(' ').Select(x => int.Parse(x)).ToArray();
            c = arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    c = arr[i + 1];
                }
            }
            Console.WriteLine(c);
        }
    }
}
