using System;

class programa
{
    static void Main(string[] args)
    {
        string[] copos = Console.ReadLine().Split(' ');
        int copo1 = int.Parse(copos[0]);
        int copo2 = int.Parse(copos[1]);
        int copo3 = int.Parse(copos[2]);
        int copo4 = int.Parse(copos[3]);

        if(copo1 == 1)
        {
            Console.WriteLine("1");
        }

        else if(copo2 == 1)
        {
            Console.WriteLine("2");
        }

        else if(copo3 == 1)
        {
            Console.WriteLine("3");
        }

        else
        {
            Console.WriteLine("4");
        }
    }
}