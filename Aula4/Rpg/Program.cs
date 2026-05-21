using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("ESCOLHA SUA CLASSE");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Mago");
            Console.WriteLine("3 - Arqueiro");
            Console.WriteLine("4 - Assassino");
            Console.Write("Digite o número da classe: ");

            int classe;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out classe))
                    break;

                Console.WriteLine("Entrada inválida!");
                Console.Write(": ");
            }

            Console.WriteLine();

            switch (classe)
            {
                case 1:
                    Console.WriteLine("Classe: Guerreiro");
                    Console.WriteLine("Habilidades:");
                    Console.WriteLine("- Golpe Pesado");
                    Console.WriteLine("- Defesa Total");
                    Console.WriteLine("- Fúria de Batalha");
                    break;

                case 2:
                    Console.WriteLine("Classe: Mago");
                    Console.WriteLine("Habilidades:");
                    Console.WriteLine("- Bola de Fogo");
                    Console.WriteLine("- Teletransporte");
                    Console.WriteLine("- Tempestade Arcana");
                    break;

                case 3:
                    Console.WriteLine("Classe: Arqueiro");
                    Console.WriteLine("Habilidades:");
                    Console.WriteLine("- Flecha Explosiva");
                    Console.WriteLine("- Mira Precisa");
                    Console.WriteLine("- Chuva de Flechas");
                    break;

                case 4:
                    Console.WriteLine("Classe: Assassino");
                    Console.WriteLine("Habilidades:");
                    Console.WriteLine("- Ataque Furtivo");
                    Console.WriteLine("- Invisibilidade");
                    Console.WriteLine("- Golpe Mortal");
                    break;

                default:
                    Console.WriteLine("Classe inválida!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar ou digite exit para sair:");

            if (Console.ReadLine().ToLower() == "exit") break;
        }
    }
}