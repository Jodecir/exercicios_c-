using System;
using System.Collections.Generic;

namespace Banco
{
	internal static class Program
	{
		private static readonly List<Conta> listContas = new();
		private static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						InserirConta();
						break;
					case "2":
            ListarContas();
						break;
					case "3":
            Sacar();
						break;
					case "4":
						Depositar();
						break;
					case "5":
						break;
          case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
    }
    private static void InserirConta()
		{
			Console.WriteLine("Inserir nova conta");

			Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
			int entradaTipoConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o nome do cliente: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o saldo inicial: ");
			double entradaSaldo = double.Parse(Console.ReadLine());

			Console.Write("Digite o crédito: ");
			double entradaCredito = double.Parse(Console.ReadLine());

			Conta novaConta = new(tipoConta: (TipoConta)entradaTipoConta,
														saldo: entradaSaldo,
														credito: entradaCredito,
														nome: entradaNome);

			listContas.Add(novaConta);
		}
    private static void ListarContas()
		{
			Console.WriteLine("Listar contas");

			if (listContas.Count == 0)
			{
				Console.WriteLine("Nenhuma conta cadastrada.");
				return;
			}

			for (int i = 0; i < listContas.Count; i++)
			{
				Conta conta = listContas[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(conta);
			}
		}
    private static void Sacar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser sacado: ");
			double valorSaque = double.Parse(Console.ReadLine());

      listContas[indiceConta].Sacar(valorSaque);
		}
		private static void Depositar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser depositado: ");
			double valorDeposito = double.Parse(Console.ReadLine());

      listContas[indiceConta].Depositar(valorDeposito);
		}
    private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("SS-Bank Segurança e Simplicidade!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Inserir nova conta");
			Console.WriteLine("2- Listar contas");
			Console.WriteLine("3- Sacar");
			Console.WriteLine("4- Depositar");
			Console.WriteLine("5- Transferir");
      Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
    }
  }
}
