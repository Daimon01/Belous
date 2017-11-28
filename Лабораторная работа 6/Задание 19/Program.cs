using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, i = 0, k = 0;
            a = int.Parse(Console.ReadLine());
            if (a > 83 && a < 199)
            {
                Console.WriteLine("Количество чисел слева: 0, Количество чисел справа: 0");
                return;
            }
            while (a <= 83 || a >= 199)
            {
                if (a <= 83)
                {
                    i++;
                }
                else
                {
                    k++;
                }
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Количество чисел слева: {0:F0}, количество чисел справа: {1:F0}", i, k);
        }
    }
}
