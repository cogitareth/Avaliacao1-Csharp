using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura do número de crianças
        int N = Convert.ToInt32(Console.ReadLine());

        int carrinhos = 0;
        int bonecas = 0;

        // Loop para ler as informações das crianças
        for (int i = 0; i < N; i++)
        {
            // Leitura do nome e gênero da criança
            string[] linha = Console.ReadLine().Split(' ');
            string nome = linha[0];
            string genero = linha[1];

            // Verificação do gênero e incremento dos contadores
            if (genero == "M")
            {
                carrinhos++;
            }
            else if (genero == "F")
            {
                bonecas++;
            }
        }

        // Impressão dos resultados
        Console.WriteLine(carrinhos + " carrinhos");
        Console.WriteLine(bonecas + " bonecas");
    }
}