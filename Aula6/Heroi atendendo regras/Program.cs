using System;

class Program
{
    static string[] nomes = new string[5];
    static string[] poderes = new string[5];
    static int[] pontuacoes = new int[5];
    static int heroisCadastrados = 0;

    static int[] equipeIndices = new int[3];
    static int membrosEquipe = 0;

    static void Main()
    {
        menuPrincipal();
    }

    static void menuPrincipal()
    {
        bool rodando = true;
        while (rodando)
        {
            Console.WriteLine("\n=== Seletor de Heróis Marvel ===");
            Console.WriteLine("1 - Cadastrar herói");
            Console.WriteLine("2 - Selecionar equipe");
            Console.WriteLine("3 - Exibir equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            string opc = Console.ReadLine();
            switch (opc)
            {
                case "1":
                    cadastrarHeroi();
                    break;
                case "2":
                    selecionarEquipe();
                    break;
                case "3":
                    exibirEquipe();
                    break;
                case "4":
                    Console.WriteLine("Programa finalizado.");
                    rodando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void cadastrarHeroi()
    {
        if (heroisCadastrados >= 5)
        {
            Console.WriteLine("Limite de 5 heróis atingido!");
            return;
        }

        Console.Write("Digite o nome do herói: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o poder do herói: ");
        string poder = Console.ReadLine();

        int pontuacao;
        while (true)
        {
            Console.Write("Digite a pontuação do herói: ");
            if (int.TryParse(Console.ReadLine(), out pontuacao))
                break;
            Console.WriteLine("Digite apenas números!");
        }

        nomes[heroisCadastrados] = nome;
        poderes[heroisCadastrados] = poder;
        pontuacoes[heroisCadastrados] = pontuacao;
        heroisCadastrados++;

        Console.WriteLine($"Herói {nome} cadastrado com sucesso!");
    }

    static void selecionarEquipe()
    {
        if (heroisCadastrados == 0)
        {
            Console.WriteLine("Nenhum herói cadastrado!");
            return;
        }

        membrosEquipe = 0;
        Console.WriteLine("Escolha até 3 heróis para sua equipe:");
        for (int i = 0; i < heroisCadastrados; i++)
        {
            Console.WriteLine($"{i + 1} - {nomes[i]} (Poder: {poderes[i]}, Pontuação: {pontuacoes[i]})");
        }

        while (membrosEquipe < 3)
        {
            Console.Write($"Digite o número do herói para adicionar à equipe ({membrosEquipe + 1}/3) ou 0 para terminar: ");
            int escolha;
            if (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 0 || escolha > heroisCadastrados)
            {
                Console.WriteLine("Número inválido!");
                continue;
            }
            if (escolha == 0) break;

            bool jaNaEquipe = false;
            for (int j = 0; j < membrosEquipe; j++)
            {
                if (equipeIndices[j] == escolha - 1)
                {
                    jaNaEquipe = true;
                    break;
                }
            }
            if (jaNaEquipe)
            {
                Console.WriteLine("Herói já está na equipe!");
                continue;
            }

            equipeIndices[membrosEquipe] = escolha - 1;
            membrosEquipe++;
            Console.WriteLine($"Herói {nomes[escolha - 1]} adicionado à equipe!");
        }
    }

    static int calcularPontuacaoTotal()
    {
        int total = 0;
        for (int i = 0; i < membrosEquipe; i++)
        {
            total += pontuacoes[equipeIndices[i]];
        }
        return total;
    }

    static void exibirEquipe()
    {
        if (membrosEquipe == 0)
        {
            Console.WriteLine("Equipe vazia!");
            return;
        }

        Console.WriteLine("Equipe atual");
        for (int i = 0; i < membrosEquipe; i++)
        {
            int idx = equipeIndices[i];
            Console.WriteLine($"- {nomes[idx]} (Poder: {poderes[idx]}, Pontuação: {pontuacoes[idx]})");
        }
        Console.WriteLine($"Pontuação total da equipe: {calcularPontuacaoTotal()}");
    }
}