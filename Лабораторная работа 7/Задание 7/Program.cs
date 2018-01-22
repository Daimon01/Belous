using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Введите штрих код: ");
            a = Console.ReadLine();
            if (a.Length != 13)
            {
                Console.WriteLine("некорректная длина штрих кода!");
                return;
            }
            Console.Write("Код страны: " + a[0] + a[1] + "\n" +
                "Код изготовителя: " + a[3] + a[4] + a[5]+"\n" +
                "Код товара: " + a[7] + a[8] + a[9] + a[10]+"\n" +
                "Контрольное число: " + a[12]+"\n");

        }
    }
}
