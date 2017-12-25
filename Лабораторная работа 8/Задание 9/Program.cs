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
            string a;
            Console.Write("Введите букву: ");
            a = Console.ReadLine();
            string[] arr = "a b c d e f g h".Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if(a == arr[i])
                {
                    Console.WriteLine(a + "+");
                    continue;
                }
                Console.WriteLine(arr[i]);
            }
        }
    }
}
