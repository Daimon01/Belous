using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double km, ft;
            Console.Write("Введите расстояние в километрах: ");
            km = double.Parse(Console.ReadLine());
            Console.Write("Введите расстояние в футах: ");
            ft = double.Parse(Console.ReadLine());
            if (km > 0)
            {
                if (ft > 0)
                {
                    ft = ft * 0.000305;
                    if (km > ft)
                    {
                        Console.WriteLine("Расстояние в футах меньше");
                    }
                    else
                    {
                        Console.WriteLine("Расстояние в километрах меньше");
                    }
                }
                else
                {
                    Console.WriteLine("Расстояние в футах должно быть положительным");
                }
            }
            else
            {
                Console.WriteLine("Расстояние в километрах должно быть положительным");
            }
        }
    }
}
