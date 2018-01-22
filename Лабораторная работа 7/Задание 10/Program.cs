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
            string a = "abcdacadbacdaabaadc", b;
            Console.Write("Введите 2 символа: ");
            b = Console.ReadLine();
            if(b.Length <2 || b.Length > 2)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 сивола");
                return;
            }
            int c = b.IndexOf(a);
            a[c] = " ";
        }
    }
}
