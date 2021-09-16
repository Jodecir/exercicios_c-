using System;

namespace Banco
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Conta minhaConta = new(TipoConta.PessoaFisica, 0, 0, "Jodecir");
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
