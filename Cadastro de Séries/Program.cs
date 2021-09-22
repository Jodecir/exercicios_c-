using System;

namespace Cadastro
{
    internal static class Program
    {
        private static readonly SerieRepositorio repositorio = new();
        private static void Main()
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (!string.Equals(opcaoUsuario, "X", StringComparison.OrdinalIgnoreCase))
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        InserirSerie();
                        break;
                    case "2":
                        ListarSeries();
                        break;
                    case "3":
                        VisualizarSerie();
                        break;
                    case "4":
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

            static void InserirSerie()
            {
                Console.WriteLine("Inserir nova série");

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}- {1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.Write("Digite o Título da Série: ");
                string entradaTitulo = Console.ReadLine();

                Console.Write("Digite o Ano de Início da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                Serie novaSerie = new(id: repositorio.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            descricao: entradaDescricao,
                                            ano: entradaAno);

                repositorio.Insere(novaSerie);
		    }

            static void ListarSeries()
            {
                Console.WriteLine("Listar séries");

                var lista = repositorio.Lista();

                if (lista.Count == 0)
                {
                    Console.WriteLine("Nenhuma série cadastrada.");
                    return;
                }

                foreach (var serie in lista)
                {
                    var excluido = serie.RetornaExcluido();

                    Console.WriteLine("#ID {0}: - {1} {2}", serie.RetornaId(), serie.RetornaTitulo(), (excluido ? "*Excluído*" : ""));
                }
            }

            static void VisualizarSerie()
            {
                Console.Write("Digite o id da série: ");
                int indiceSerie = int.Parse(Console.ReadLine());

                var serie = repositorio.RetornaPorId(indiceSerie);

                Console.WriteLine(serie);
            }

            static string ObterOpcaoUsuario()
			{
				Console.WriteLine();
				Console.WriteLine("DIO Séries a seu dispor!!!");
				Console.WriteLine("Informe a opção desejada:");

				Console.WriteLine("1- Inserir nova série");
				Console.WriteLine("2- Listar séries");
				Console.WriteLine("3- Visualizar série");
				Console.WriteLine("4- Excluir série");
				Console.WriteLine("5- Atualizar série");
				Console.WriteLine("C- Limpar Tela");
				Console.WriteLine("X- Sair");
				Console.WriteLine();

				string opcaoUsuario = Console.ReadLine().ToUpper();
				Console.WriteLine();
				return opcaoUsuario;
			}
        }
    }
}
