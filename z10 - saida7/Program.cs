using System;

class programa
{
    static void Main(string[] args)
    {
        int a = 97;

        for (char c = 'a'; c <= 'z'; c++)
        {
            Console.WriteLine($"{a} e {c}");      
            a++;
        }
    }
}
