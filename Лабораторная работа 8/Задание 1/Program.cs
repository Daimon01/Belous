using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            int a;
            Console.Write("Введите ячейку массива: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите массив через пробыл: ");
            data = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Строка пуста");
                return;
            }
            string[] Arr = data.Split(' ');
            if(a<0 || Arr.Length <= a)
            {
                Console.WriteLine("Число A должно быть в интервале [0, размер массива)");
            }
            Console.WriteLine(Arr[a]);
        }
    }
}
