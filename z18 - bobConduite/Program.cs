using System;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] raios = Console.ReadLine().Split(' ');
            int R1 = int.Parse(raios[0]);
            int R2 = int.Parse(raios[1]);

            int menorRaio = R1 + R2;

            Console.WriteLine(menorRaio);
        }
    }
}
