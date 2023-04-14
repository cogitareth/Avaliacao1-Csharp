using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int i = 1;
        for (int j = 60; j >= 0; j -= 5)
        {
            Console.WriteLine("I={0} J={1}", i, j);
            i += 3;
        }
    }
}