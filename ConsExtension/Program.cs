﻿using System;
using System.Linq;

namespace ConsExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "monkey", "bear", "rabbit", "wolf" };
            var fourLetterAnimals = animals
                                        .Where(a => a.Length == 4)
                                        .OrderByDescending( a => a);
            foreach(string animal in fourLetterAnimals)
            {
                Console.WriteLine($"{animal} has 4 letters.");
            }
            Console.ReadKey();
        }
    }
}
