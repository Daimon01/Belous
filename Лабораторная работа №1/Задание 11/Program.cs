using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            String cx, cy, r, fill;
            Console.Write("Введите 'cx'\n");
            cx = Console.ReadLine();
            Console.Write("Ввдите 'cy'\n");
            cy = Console.ReadLine();
            Console.Write("Введите 'r'\n");
            r = Console.ReadLine();
            Console.Write("Введите 'fill'\n");
            fill = Console.ReadLine();
            Console.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" fill=\"{3}\"/", cx, cy, r, fill);
        }
    }
}
