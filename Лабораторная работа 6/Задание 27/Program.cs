using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_27
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sum = 0;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                while (a <= b)
                {
                    if (a % 7 == 0)
                    {
                        sum = a + sum;
                        a++;
                    }
                    else
                    {
                        a++;
                    }
                }
                Console.WriteLine("Ответ: " + sum);
            }
            else
            {
                while (b <= a)
                {
                    if (b % 7 == 0)
                    {
                        sum = b + sum;
                        b++;
                    }
                    else
                    {
                        b++;
                    }
                }
                Console.WriteLine("Ответ: " + sum);
            }
        }
    }
}
