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
            Double x, y, z;
            Console.Write("дите первое число: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("дите второе число: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("дите третье число: ");
            z = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                x = Math.Pow(x, 2);
            }
            if (y > 0)
            {
                y = Math.Pow(y, 2);
            }
            if (z > 0)
            {
                z = Math.Pow(z, 2);
            }
            Console.WriteLine(x + "; " + y + "; " + z);
        }
    }
}
