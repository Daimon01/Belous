using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b="s", c="U";
            Console.Write("Введите строку: ");
            a = Console.ReadLine();
            if(a[0] == b[0])
            {
                Console.WriteLine(a.ToLower());
                return;
            }
            if (a[0] == c[0])
            {
                Console.WriteLine(a.ToUpper());
                return;
            }
            Console.WriteLine(a);
        }
    }
}
