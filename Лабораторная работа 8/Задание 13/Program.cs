using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string t, l;
            int a = 0;
            Console.Write("Введите первый массив через пробел: ");
            t = Console.ReadLine();
            string[] top = t.Split(' ');
            for (int i = 0; i < top.Length; i++)
            {
                for (int k = i+1; k < top.Length; k++)
                {
                    if (top[i] == top[k])
                    {
                        a++;
                    }
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Повторений нет");
            }
            else
            {
                Console.WriteLine("Повторения есть");
            }
        }
    }
}
