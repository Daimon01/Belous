using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Введите номер теста: ");
            i = int.Parse(Console.ReadLine());
            string filename = "../../task6175/test" + i + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            using (StreamReader reader = new StreamReader(filename))
            {
                if (reader.EndOfStream)
                {
                    Console.WriteLine("Файл пуст");
                    return;
                }
                else
                {
                    string line = reader.ReadLine();
                    Console.Write(line);
                    line = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        Console.Write(", " + line);
                    }
                    Console.WriteLine("\n");

                }
            }
        }
    }
}
