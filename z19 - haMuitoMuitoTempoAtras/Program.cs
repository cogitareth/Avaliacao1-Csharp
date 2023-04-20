using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < N; i++)
        {
            int T = int.Parse(Console.ReadLine()); 
            int A = 2015 - T; 

            if (A <= 0)
            {
                A = Math.Abs(A) + 1;
                Console.WriteLine($"{A} A.C.");
            }
            else
            {
                Console.WriteLine($"{A} D.C.");
            }
        }
    }
}