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
            string x;
            Console.WriteLine("Введите букву от a до h");
            x = Console.ReadLine();
            switch (x)
            {
                case "a":
                    Console.WriteLine(" a+\n b\n c\n d\n e\n f\n g\n h\n");
                    break;
                case "b":
                    Console.WriteLine(" a\n b+\n c\n d\n e\n f\n g\n h\n");
                    break;
                case "c":
                    Console.WriteLine(" a\n b\n c+\n d\n e\n f\n g\n h\n");
                    break;
                case "d":
                    Console.WriteLine(" a\n b\n c\n d+\n e\n f\n g\n h\n");
                    break;
                case "e":
                    Console.WriteLine(" a\n b\n c\n d\n e+\n f\n g\n h\n");
                    break;
                case "f":
                    Console.WriteLine(" a\n b\n c\n d\n e\n f+\n g\n h\n");
                    break;
                case "g":
                    Console.WriteLine(" a\n b\n c\n d\n e\n f\n g+\n h\n");
                    break;
                case "h":
                    Console.WriteLine(" a\n b\n c\n d\n e\n f\n g\n h+\n");
                    break;
                default:
                    Console.WriteLine("вы нажали неверную букву");
                    break;
            }
        }
    }
}
