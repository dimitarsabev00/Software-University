﻿using System;

namespace E01.GenericBoxString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());
            for (int i = 0; i < qty; i++)
                Console.WriteLine(new Box<string>(Console.ReadLine()));
        }
    }
}
