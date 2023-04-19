using System;

class program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] tempoProdutos = Console.ReadLine().Split(' ');
        int A = int.Parse(tempoProdutos[0]);
        int B = int.Parse(tempoProdutos[1]);

        if(A + B <= N)
        {
            Console.WriteLine("Farei hoje!");
        }

        else
        {
            Console.WriteLine("Deixa para amanha!");
        }
    }
}