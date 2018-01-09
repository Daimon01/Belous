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
            String a;
            Console.Write("Введите символ: ");
            a = Console.ReadLine();
            if (a.Length <= 1 || a.Length >= 3)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 символа");
                return;
            }
            string b = "abcdacadbacdaabaadc";
            int c = b.IndexOf(a);
            while (c != -1)
            {
                Console.Write(b + " ");
                c = b.IndexOf(a, c + 1);
            }
        }
    }
}
