using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            for (int i = 100; i <= 1000; i++)
            {
                if (i % 13 == 0)
                {
                    Console.Write(i + "+ ");
                    a++;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\nОтвет:" + a);
        }
    }
}
