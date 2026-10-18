using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void AdicionarTarefa(List<string> tarefas)
        {
            Console.WriteLine("Digite a tarefa a ser adicionada: ");
            string tarefa = Console.ReadLine()!;
            tarefas.Add(tarefa);
        }
        static void ListarTarefas(List<string> tarefas)
        {
            Console.WriteLine("----- LISTA DE TAREFAS -----");
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i]}");
                }
            }
        }
        static void RemoverTarefa(List<string> tarefas)
        {
            Console.WriteLine("Digite o número da tarefa a ser removida: ");
            int numeroTarefa = int.Parse(Console.ReadLine()!);
            if (numeroTarefa < 1 || numeroTarefa > tarefas.Count)
            {
                Console.WriteLine("Número de tarefa inválido.");
            }
            else
            {
                tarefas.RemoveAt(numeroTarefa - 1);
                Console.WriteLine("Tarefa removida com sucesso.");
            }
        }
        static void Main(string[] args)
        {
            List<string> tarefas = new List<string>();
            while (true)
            {
                Console.WriteLine("----- GERENCIADOR DE TAREFAS");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Listar tarefas ");
                Console.WriteLine("3. Remover tarefa");
                Console.WriteLine("4. Sair");

                Console.WriteLine("Escolha uma opção: ");
                string opcao = Console.ReadLine()!;

                if (opcao == "1")
                { AdicionarTarefa(tarefas);
                } else if (opcao == "2") 
                { ListarTarefas(tarefas); 
                } else if (opcao == "3")
                { RemoverTarefa(tarefas);
                } else if (opcao == "4")
                {
                    break;
                }
                else
                { Console.WriteLine("Opção inválida. Tente novamente."); 
                }
            }
        }
    }
}
