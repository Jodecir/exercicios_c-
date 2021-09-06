using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Criar Aluno");
            Console.WriteLine("2 - Listar Aluno");
            Console.WriteLine("3 - Calcular Média Geral dos Alunos");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario.ToUpper() != "X") {
                switch (opcaoUsuario)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - Criar Aluno");
                Console.WriteLine("2 - Listar Aluno");
                Console.WriteLine("3 - Calcular Média Geral dos Alunos");
                Console.WriteLine("X - Sair");
                Console.WriteLine();
            }
        }
    }
}