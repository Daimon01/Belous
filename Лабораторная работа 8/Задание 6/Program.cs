using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Введите массив через пробел: ");
            a = Console.ReadLine();
            string[] arr = a.Split(' ');
            Console.Write(arr[arr.Length - 1] + " ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
