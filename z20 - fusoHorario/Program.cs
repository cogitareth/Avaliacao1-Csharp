using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int S = int.Parse(input[0]);
        int T = int.Parse(input[1]);
        int F = int.Parse(input[2]);

        int hour = (S + T + F) % 24;

        if (hour < 0)
        {
            hour += 24;
        }

        Console.WriteLine(hour);
    }
}