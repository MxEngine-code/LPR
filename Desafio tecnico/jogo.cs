using System;
using System.Numerics;

class Program
{
    string p1 = "Naruto";
    string p2 = "Sasuke";
    string origem = "Vila da folha";
    int p1forca = 5000;
    int p2forca = 4000;
    int p1Agi = 2000;
    int p2Agi = 1000;
    int p1Int = 1000;
    int p2Int = 2000;
    int vida = 500;
    string j1 = "Mychell";
    string j1exp = "Jutsu";
    string j2 = "Max";
    string j2exp = "Genjutsu";
    string jogador1;
    string jogador2;

    void Personagens()
    {
        Console.WriteLine($"Personagens:\n-{p1}\nOrigem: {origem}\nForça {p1forca}\nInteligência {p1Int}\nAgilidade {p1Agi}\nVida {vida}");
    }

    string jogadorveri(string personagem)
    {
        string r;
        if (jogador1 == personagem) r = "Mychell";
        else r = "Max";
        return r;
    }

    static void Main()
    {
        Program prog = new Program();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Simulação de batalha");
            prog.Personagens();
            Console.WriteLine("Jogador 1 escolha seu personagem (digite seu nome): ");
            prog.jogador1 = "";

            while (true)
            {
                prog.jogador1 = Console.ReadLine().ToLower();
                if (prog.jogador1 == "naruto" || prog.jogador1 == "sasuke") break;
                Console.WriteLine("Digite um nome de personagem válido (Naruto, Sasuke)");
            }

            if (prog.jogador1 == "naruto") prog.jogador2 = "sasuke";
            if (prog.jogador1 == "sasuke") prog.jogador2 = "naruto";

            Console.WriteLine($"Jogador 2 seu personagem será o {prog.jogador2}");

            if (prog.p1forca > prog.p2forca && prog.p1Agi > prog.p2Agi)
                Console.WriteLine($"O Naruto venceu a batalha vitória do jogador {prog.jogadorveri("Naruto")}");
        }
    }
}