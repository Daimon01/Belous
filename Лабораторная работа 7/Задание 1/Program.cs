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
            string a;
            Console.Write("Введите строку: ");
            a = Console.ReadLine();
            string b = "abcdefwxyz";
            if (b.Contains(a))
            {
                Console.WriteLine("Содержится");
            }
            else
            {
                Console.WriteLine("Не содержится");
            }
        }
    }
}
