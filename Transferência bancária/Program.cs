using System;
using System.Collections.Generic;

namespace Banco
{
    internal static class Program
    {
        static List<Conta> listContas = new List<Conta>();
        private static void Main(string[] args)
        {
            Conta minhaConta = new(TipoConta.PessoaFisica, 0, 0, "Jodecir");
            Console.WriteLine(minhaConta.ToString());
        }

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("SS-Bank Segurança e Simplicidade!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar contas");
			Console.WriteLine("2- Inserir nova conta");
			Console.WriteLine("3- Transferir");
			Console.WriteLine("4- Sacar");
			Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
        }
    }
}
