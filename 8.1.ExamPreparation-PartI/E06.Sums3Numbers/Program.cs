﻿using System;

namespace E06.Sums3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a+b==c)
            {
                if (a>b)
                {
                    Console.WriteLine($"{b}+{a}={c}");
                }
                else
                {
                    Console.WriteLine($"{a}+{b}={c}");
                }
            }
            else if (b+c==a) 
            {
                if (b > c)
                {
                    Console.WriteLine($"{c}+{b}={a}");
                }
                else
                {
                    Console.WriteLine($"{b}+{c}={a}");
                }
            }
            else if (a+c==b) 
            {
                if (a > c)
                {
                    Console.WriteLine($"{c}+{a}={b}");
                }
                else
                {
                    Console.WriteLine($"{a}+{c}={b}");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
