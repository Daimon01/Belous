using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, i = 1;
            a = int.Parse(Console.ReadLine());
            while (a < 1000)
            {
                a = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Результат: {0:F0}", i);
        }
    }
}
