using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a , b, sum = 0;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a > b)
            {
               
                while (b <= a)
                {
                    sum = Math.Pow(b, 2) + sum;
                    b++;
                }
                Console.WriteLine("\nОтвет: " + sum);
            }
            else
            {
              
                while (a <= b)
                {
                    sum = Math.Pow(a, 2) + sum;
                    a++;
                }
                Console.WriteLine("\nОтвет: " + sum);
            }
        }
    }
}
