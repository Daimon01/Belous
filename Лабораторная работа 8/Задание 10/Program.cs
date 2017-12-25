using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            int[] arr = { 11, 13, 17, 19, 10, 12, 14, 15, 16, 18, 20 };
            for (int i = 0; i < arr.Length; i++)
            {
                if(a == arr[i])
                {
                    Console.WriteLine(arr[i] + "+");
                    continue;
                }
                Console.WriteLine(arr[i]);
            }
        }
    }
}
