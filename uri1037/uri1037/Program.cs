﻿using System.Xml;

namespace uri1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (num <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (num <= 50)
            {
                Console.WriteLine("Intervalo (25,50]"); 
            }
            else if (num <= 75)
            {
                Console.WriteLine("Intervalo (50, 75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75, 100]");
            }
            
        }
    }
}
