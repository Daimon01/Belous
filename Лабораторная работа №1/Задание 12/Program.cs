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
            String user, pass, host, port, db;
            Console.Write("Введите имя пользователя \n");
            user = Console.ReadLine();
            Console.Write("Ввдите пароль\n");
            pass = Console.ReadLine();
            Console.Write("Введите 'host'\n");
            host = Console.ReadLine();
            Console.Write("Введите номер порта \n");
            port = Console.ReadLine();
            Console.Write("Введите 'db' \n");
            db = Console.ReadLine();
            Console.WriteLine("User ID={0};\n Password={1};\n Host={2};\n Port={3};\n Database={4};", user, pass, host, port, db);
        }
    }
}
