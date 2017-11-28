using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i = 1, sum = 0;
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Сумма чисел: 0, Количество чисел: 1");
                return;
            }
            while (a != 0)
            {
                sum = a + sum;
                a = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Сумма чисел: {0:F0}, количество чисел: {1:F0}", sum, i);
        }
    }
}
