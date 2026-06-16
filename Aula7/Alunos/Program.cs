using System;
class Program
{
    static string[] alunos = new string[10];
    static int[] notas = new int[10];

    static string ClassificarAluno(int nota)
    {
        string r;
        if (nota<60) r = "reprovado!";
        else if (nota>60 && nota<79) r = "em recuperação!";
        else r = "aprovado!";
        return r;
    }
    static void Main()
    {
        Console.WriteLine("Pedirei para que vc digite os numeros");
        for (int i = 0; i<alunos.Length; i++)
        {
            Console.Write($"Digite o nome do {i+1}* aluno: ");
            string inp = "";
            while (true)
            {
                inp = Console.ReadLine();
                if (inp != "") break;
                Console.WriteLine("Entrada inválida!");
                Console.Write(": ");
            }
            
            alunos[i] = inp;
            Console.Write($"Digite a nota: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out notas[i])) break;
                Console.WriteLine("Entrada inválida!");
                Console.Write(": ");
            }
        }

        for (int i = 0; i<alunos.Length; i++)
        {
            Console.WriteLine($"Aluno: {alunos[i]}, está {ClassificarAluno(notas[i])}");
        }
    }
}
