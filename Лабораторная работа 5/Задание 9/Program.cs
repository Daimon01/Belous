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
            double Sc, Ss;
            Console.Write("Введите площадь круга: ");
            Sc = double.Parse(Console.ReadLine());
            Console.Write("Введите площадь квадрата: ");
            Ss = double.Parse(Console.ReadLine());
            if (Sc <= 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной");
                return;
            }
            if (Ss <= 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной");
                return;
            }
            Sc = 2 * Math.Sqrt(Sc / Math.PI);
            Ss = Math.Sqrt(Ss);
            if (Sc > Ss)
            {
                Console.WriteLine("Круг не поместится в квадрате");
            }
            else
            {
                Console.WriteLine("Круг уместится в квадрат");
            }
        }
    }
}
