using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string t, l;
            int a = 0;
            Console.Write("Введите первый массив через пробел: ");
            t = Console.ReadLine();
            Console.Write("Введите второй массив через пробел: ");
            l = Console.ReadLine();
            if (t == string.Empty)
            {
                Console.WriteLine("Данные сверху отсутствуют");
                return;
            }
            if (l == string.Empty)
            {
                Console.WriteLine("Данные слева отсутствуют");
                return;
            }
            string[] top = t.Split(' ');
            string[] left = l.Split(' ');
            for (int i = 0; i < left.Length; i++)
            {
                for (int k = 0; k < top.Length; k++)
                {
                    if (left[i] == top[k])
                    {
                        a++;
                    }
                }
            }
            Console.WriteLine("Повторений: " + a);
        }
    }
}
