﻿using System;

namespace E11.EqualWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            firstWord = firstWord.ToLower();
            secondWord = secondWord.ToLower();
            if (firstWord == secondWord) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
