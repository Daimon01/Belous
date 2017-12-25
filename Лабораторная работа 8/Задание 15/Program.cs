using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            string b;
            Console.Write("Введите массив чисел через пробел: ");
            b = Console.ReadLine();
            if (b == string.Empty)
            {
                Console.WriteLine(a);
                return;
            }
            int[] arr = b.Split(' ').Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                a = a + arr[i];
            }
            a = a / arr.Length;
            Console.WriteLine(a);
        }
    }
}
