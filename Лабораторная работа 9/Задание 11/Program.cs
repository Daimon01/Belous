using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite nomer testa ");
            int n = int.Parse(Console.ReadLine());

            if (!File.Exists("..\\..\\test" + n + ".css")) //проверяет наличие файла
            {
                Console.Write("oshibka fail ne sushestvuet");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\test" + n + ".css"); //читает файл
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }
            String text;
            int x;
            while (!reader.EndOfStream)
            {
                x = 0;
                String line = reader.ReadLine(); //читает первую строку
                int L = line.Length;
                x = line.IndexOf("{");
                if (x > 0)
                {
                    Console.WriteLine(text = line.Substring(0, x));
                }
            }
        }
    }
}
