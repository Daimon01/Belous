using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, w;
            Console.WriteLine("Введите номер теста: ");
            q = int.Parse(Console.ReadLine());
            string name = "../../task4488/test"+q+".txt";
            if (!File.Exists(name))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            using(StreamReader read = new StreamReader(name))
            {
                if (read.EndOfStream)
                {
                    Console.WriteLine("Файл пуст");
                    return;
                }
                string line = read.ReadLine();
                w = 0;
                while (!read.EndOfStream)
                {
                    read.ReadLine();
                    w++;
                }
                Console.WriteLine(line + " " + w);
            }
        }
    }
}
