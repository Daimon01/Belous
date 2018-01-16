using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, w = 0;
            Console.WriteLine("Введите номер теста: ");
            q = int.Parse(Console.ReadLine());
            string name = "../../task4954/test" + q + ".txt", a;
            Console.WriteLine("Введите символ: ");
            a = Console.ReadLine();
            if (!File.Exists(name))
            {
                Console.WriteLine("Такого файла не существует");
                return;
            }
            using (StreamReader read = new StreamReader(name))
            {
                if (read.EndOfStream)
                {
                    Console.WriteLine("Файл пуст");
                    return;
                }
                while (!read.EndOfStream)
                {
                    string line = read.ReadLine();
                    if (line.IndexOf(a) != -1)
                    {
                        w++;
                    }
                }
                Console.WriteLine(w);
            }
        }
    }
}
