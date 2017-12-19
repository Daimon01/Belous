using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            int a, b;
            Console.Write("Введите первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите массив через пробыл: ");
            data = Console.ReadLine();
            string[] arr = data.Split(' ');
            if (a < 0 || arr.Length <= a)
            {
                Console.WriteLine("Число A должно быть в интервале [0, размер массива)");
            }
            if (b < 0 || arr.Length <= a)
            {
                Console.WriteLine("Число B должно быть в интервале [0, размер массива)");
            }
            if (a > b)
            {
                int i = 0;
                i = a;
                a = b;
                b = i;
            }
            for (int i = a; i <= b; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
