using System;

class programa
{
    static void Main(string[] args)
    {
        string[] linha1 = Console.ReadLine().Split(' ');

        int h = int.Parse(linha1[0]);
        int p = int.Parse(linha1[1]);

        double media = (double) h / p;
        
        Console.WriteLine(media.ToString("f2"));
    }
}
