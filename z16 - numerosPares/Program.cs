﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        for (int n = 1; n <= 100; n++)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n);
            }
        }
    }
}