using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Введите массив через пробел: ");
            a = Console.ReadLine();
            string[] arr = a.Split(' ');
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
