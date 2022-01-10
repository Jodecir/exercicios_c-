using System;
using Construtores.Models;

namespace Construtores
{
    internal static class Program
    {
        private static void Main()
        {
            Log log = Log.GetInstance();

            log.PropriedadeLog = "Teste Instância";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);

            Aluno aluno = new("Jodecir", "Neto", "Tecnologia", 9);
            aluno.Apresentar();

            // Pessoa p1 = new();
            // p1.Apresentar();
        }
    }
}
