using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- CALCULADORA DE NOTAS ESCOLARES -----");
            Console.WriteLine("Insira o nome do aluno: ");
            string nomeAluno = Console.ReadLine()!;

            Console.WriteLine("Insira o nome da disciplina: ");
            string nomeDisciplina = Console.ReadLine()!;

            Console.WriteLine("Quantidade de faltas do aluno: ");
            int faltasAluno = Convert.ToInt32(Console.ReadLine()!);


            if (faltasAluno >= 20)
            {
                Console.WriteLine($"\nO aluno {nomeAluno} foi reprovado por excesso de faltas na disciplina {nomeDisciplina}.");
                return;
            }


            double nota1Aluno;
            while (true)
            {
                Console.WriteLine("Insira a 1ª nota do aluno (0 a 20): ");
                if (double.TryParse(Console.ReadLine(), out nota1Aluno) && nota1Aluno >= 0 && nota1Aluno <= 20)
                {
                    break;
                }
                Console.WriteLine(" Valor incorreto! Digite uma nota válida entre 0 e 20.");
            }


            Console.WriteLine("Insira a 2ª nota do aluno: ");
            double nota2Aluno = Convert.ToDouble(Console.ReadLine()!);

            Console.WriteLine("Insira a 3ª nota do aluno: ");
            double nota3Aluno = Convert.ToDouble(Console.ReadLine()!);



            Console.WriteLine($"\nO aluno está apto a receber a média na disciplina {nomeDisciplina}.");


            double mediaAluno = (nota1Aluno + nota2Aluno + nota3Aluno) / 3;
            Console.WriteLine($"A média do aluno {nomeAluno} na disciplina {nomeDisciplina} é: {mediaAluno:F2}.");


            if (mediaAluno >= 10)
            {
                Console.WriteLine($"O aluno {nomeAluno} foi aprovado na disciplina {nomeDisciplina} com média de {mediaAluno:F2}.");
            }
            else if (mediaAluno >= 7)
            {
                Console.WriteLine($"O aluno {nomeAluno} ficou de recuperação na disciplina {nomeDisciplina} com média de {mediaAluno:F2}.");
            }
            else
            {
                Console.WriteLine($"O aluno {nomeAluno} foi reprovado na disciplina {nomeDisciplina} com média de {mediaAluno:F2}.");
            }
        }
    }
}
