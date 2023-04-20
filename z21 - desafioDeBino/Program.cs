using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[] numeros = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int multiplosDe2 = 0;
        int multiplosDe3 = 0;
        int multiplosDe4 = 0;
        int multiplosDe5 = 0;

        for (int i = 0; i < N; i++)
        {
            if (numeros[i] % 2 == 0)
                multiplosDe2++;

            if (numeros[i] % 3 == 0)
                multiplosDe3++;

            if (numeros[i] % 4 == 0)
                multiplosDe4++;

            if (numeros[i] % 5 == 0)
                multiplosDe5++;
        }

        Console.WriteLine("{0} Multiplo(s) de 2", multiplosDe2);
        Console.WriteLine("{0} Multiplo(s) de 3", multiplosDe3);
        Console.WriteLine("{0} Multiplo(s) de 4", multiplosDe4);
        Console.WriteLine("{0} Multiplo(s) de 5", multiplosDe5);
    }
}