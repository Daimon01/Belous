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
            int a = 100, b = 0;
            while (a <= 500)
            {
                b = a + b;
                Console.Write(b+" ");
                a++;
            }
            Console.WriteLine("\nОтвет: " + b);
        }
    }
}
