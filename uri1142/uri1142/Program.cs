﻿namespace uri1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int j = 1; 
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{j} {j+1} {j+2} PUM");
                j += 4; 
            }
        }
    }
}