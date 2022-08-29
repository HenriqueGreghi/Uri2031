using System;

namespace Uri2031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com quantos testes pretende fazer :");
            int testes = int.Parse(Console.ReadLine());

            for (int i = 1; i < testes +1 ; i++)
            {
                Console.WriteLine("Escolha entre: ataque, pedra ou papel");
                Console.WriteLine("Jogador 1 :");
                string jogador1 = Console.ReadLine();
                Console.WriteLine("Jogador 2 :");
                string jogador2 = Console.ReadLine();

                Logica jogo = new Logica(jogador1,jogador2);

                jogo.Jogatadas();
                

                Console.WriteLine($"Teste #{i} =" + jogo.Imprimir());
                Console.WriteLine();
            }
        }
    }
}
