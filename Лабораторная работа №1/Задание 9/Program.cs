﻿using System;
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
            String a;
            a = Console.ReadLine();
            Console.WriteLine("SELECT first_name, last_name, group\n" +
                "FROM students WHERE student_id = '" + a + "';");
        }
    }
}
