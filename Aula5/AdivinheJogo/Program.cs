using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        while (true) {
            int numero = rand.Next(1, 101);
            int tent = 0;
            int palpite;

            Console.WriteLine("=== JOGO ADIVINHAÇÃO ===");
            Console.WriteLine("Eu pensei em um número de 1 a 100. Tente adivinhar!");

            do
            {
                Console.Write("\nDigite o seu palpite: ");
                tent++;
                while (!int.TryParse(Console.ReadLine(), out palpite))
                {
                    Console.WriteLine("Entrada inválida!");
                    Console.Write(": ");
                }   

                if (palpite < numero)
                {
                    Console.WriteLine("Muito baixo!");
                }
                else if (palpite > numero)
                {
                    Console.WriteLine("Muito alto!");
                }

            } while (palpite != numero);
            Console.WriteLine($"Você acertou! Em {tent} tentativas.");
            Console.WriteLine("Precione qualquer tecla para continuar ou exit para fechar");
            if (Console.ReadLine().ToLower() == "exit") break;
        }
        Console.WriteLine("Programa encerrado!");
    }
}
