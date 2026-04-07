using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

public class heroidata
{
    public string nome;
    public string poder;
    public int pontuacao;
}
class Program
{
    static List<heroidata> lista = new List<heroidata>();
    static List<heroidata> equipe = new List<heroidata>();

    static int calcularPontuacaoTotal(List<heroidata> equipe1)
    {
        int ptotal = 0;
        foreach (heroidata i in equipe1)
        {
            ptotal += i.pontuacao;
        }
        return ptotal;
    }
    static void ListarH(List<heroidata> lista1)
    {
        foreach (heroidata i in lista1)
        {
            escrever($"-Nome {i.nome}, Poder {i.poder}, Pontuação {i.pontuacao}");
        }
    }

    static void exibirEquipe()
    {
        escrever("Equipe atual:");
        if (equipe.Count == 0) escrever("Equipe vazia!");
        else {
            ListarH(equipe);
            escrever($"Pontuação total da equipe: {calcularPontuacaoTotal(equipe)}");
        }
    }
    static void escrever(string texto)
    {
        foreach (char c in texto){
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
    }

    static bool contemH(string nome, List<heroidata> lista1)
    {
        bool r = false;
        foreach (heroidata i in lista1)
        {
            if (i.nome == nome) {
                r = true;
            }
        }
        return r;
    }
    static void Main()
    {
        escrever("Bem-vindo(a) ao seletor de herói.");
        bool func = true;
        while (func)
        {
            int escolha;
            escrever("-1. Cadastrar herói.\n-2. Lista de herois.\n3-Selecionar equipe\n4-Remover herói\n5-Sair");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out escolha)) break;
                Console.WriteLine("Digite apenas números.");
            }
            switch (escolha)
            {
                case 1:
                    if (lista.Count == 5)
                    {
                        escrever("Limite de heróis atingido!");
                        break;
                    }
                    string nome, poder;
                    escrever("Digite o nome do herói: ");
                    while (true)
                    {
                        string inp = Console.ReadLine();
                        if (!string.IsNullOrEmpty(inp))
                        {
                            if (!contemH(inp, lista))
                            {
                                nome = inp;
                                break;
                            } else Console.WriteLine("Já existe um herói com esse nome.");
                        } else Console.WriteLine("O nome não pode ser vazio.");
                    }
                    escrever("Digite o poder do herói: ");
                    while (true)
                    {
                        string inp = Console.ReadLine();
                        if (!string.IsNullOrEmpty(inp))
                        {
                            poder = inp;
                            break;
                        } else Console.WriteLine("O poder não pode ser vazio.");
                    }
                    heroidata nh = new heroidata();
                    nh.nome = nome;
                    nh.poder = poder;
                    nh.pontuacao = 0;
                    lista.Add(nh);
                    break;
                case 2:
                    if (lista.Count == 0) escrever("Não existe nenhum herói ainda na lista!");
                    else
                    {
                        escrever("Lista de heróis:");
                        ListarH(lista);
                    }

                    break;
                case 3:
                    if (lista.Count == 0) {
                        escrever("Não existe nenhum herói para selecionar!");
                        break;
                    } else {
                        exibirEquipe();
                        if (equipe.Count >= 0)
                        {
                            
                            int escolha1;
                            escrever("Deseja editar sua equipe? 1-Sim, 2-Não: ");
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out escolha1) && (escolha1 == 1 || escolha1 == 2)) break;
                                Console.WriteLine("Digite apenas 1 ou 2.");
                            }
                            if (escolha1 == 1)
                            {
                                while (true) {
                                    Console.Clear();
                                    ListarH(lista);
                                    escrever("Digite o nome do herói que deseja adicionar ou remover da equipe: ");
                                    string inp;
                                    while (true)
                                    {
                                        inp = Console.ReadLine();
                                        if (!contemH(inp, lista)) Console.WriteLine("Escreva o nome de um herói existente!");
                                        else break;
                                    }

                                    if (contemH(inp, equipe))
                                    {
                                        heroidata heroi = null;
                                        
                                        foreach (heroidata i in equipe)
                                        {
                                            if (i.nome == inp)
                                            {
                                                heroi = i;
                                                break;
                                            }
                                        }

                                        equipe.Remove(heroi);
                                        escrever($"O herói {heroi.nome} foi removido da equipe!");
                                    } else {
                                        if (equipe.Count == 3)
                                        {
                                            escrever("Limite de 3 heróis na equipe atingido!");
                                            continue;
                                        }
                                        
                                        foreach (heroidata i in lista)
                                        {
                                            if (i.nome == inp)
                                            {
                                                equipe.Add(i);
                                                escrever($"O herói {i.nome} foi adicionado a equipe!");
                                                break;
                                            }
                                        }
                                    }

                                    escrever("Digite qualquer coisa para continuar a editar ou exit para finalizar: ");
                                    if (Console.ReadLine() == "exit") break;
                                    
                                }
                            }
                        }
                    }
                    break;
                case 4:
                    if (lista.Count == 0)
                    {
                        escrever("Não existe nenhum herói para remoção!");
                        break;
                    } else
                    {
                        Console.Clear();
                        ListarH(lista);
                        escrever("Digite o nome do herói que deseja remover da lista: ");
                        string inp;
                        while (true)
                        {
                            inp = Console.ReadLine();
                            if (contemH(inp, lista)) break;
                            Console.WriteLine("Escreva o nome de um herói existente!");
                        }
                        heroidata heroi = null;
                        foreach (heroidata i in lista)
                        {
                            if (i.nome == inp)
                            {
                                heroi = i;
                                break;
                            }
                        }
                        lista.Remove(heroi);
                        escrever($"O herói {heroi.nome} foi removido da lista!");
                    }
                    break;
                case 5:
                    escrever("Programa finalizado...");
                    func = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}