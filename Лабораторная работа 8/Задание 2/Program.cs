﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            Console.Write("Введите массив через пробeл: ");
            data = Console.ReadLine();
            string[] Arr = data.Split(' ');
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i] + " " + i);
            }
        }
    }
}
