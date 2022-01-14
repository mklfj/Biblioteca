using System;

namespace Biblioteca
{
    class Program
    {
		static UsuarioRepositorio repoUsuarios = new UsuarioRepositorio();
        static LivroRepositorio repoLivros = new LivroRepositorio();


        static void Main(string[] args)
        {
            string opcaoUsuario;

            do
            {
                opcaoUsuario = MenuPrincipal();
                switch (opcaoUsuario)
                {
                    case "1":
                    TelaUsuario();
                    break;

                    case "2":
                    TelaLivro();
                    break;

                    case "X":
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

            } while (opcaoUsuario != "X");

			Console.WriteLine("Aperte Enter para Fechar.");
			Console.ReadLine();
        }

		private static void TelaUsuario(){
            string opcaoUsuario;

            do
            {
                opcaoUsuario = MenuUsuario();
                switch (opcaoUsuario)
                {
					case "1":
					ListarUsuarios();
					break;

					case "2":
					InserirUsuario();
					break;

					case "3":
					AtualizarUsuario();
					break;

					case "4":
					ExcluirUsuario();
					break;

					case "5":
					VisualizarUsuario();
					break;

					case "C":
					Console.Clear();
					break;

                    case "X":
                    break;

					default:
					throw new ArgumentOutOfRangeException();
                }

            } while (opcaoUsuario != "X");
        }

        private static void TelaLivro(){
            string opcaoUsuario;

            do
            {
                opcaoUsuario = MenuLivro();
                switch (opcaoUsuario)
                {
					case "1":
					ListarLivros();
					break;

					case "2":
					InserirLivro();
					break;

					case "3":
					AtualizarLivro();
					break;

					case "4":
					ExcluirLivro();
					break;

					case "5":
					VisualizarLivro();
					break;

					case "C":
					Console.Clear();
					break;

                    case "X":
                    break;

					default:
					throw new ArgumentOutOfRangeException();
                }

            } while (opcaoUsuario != "X");
        }

        private static string MenuPrincipal()
		{
			Console.WriteLine();
            Console.WriteLine("==============================");
			Console.WriteLine("  Biblioteca - Menu Principal");
            Console.WriteLine("==============================");
            Console.WriteLine();

			Console.WriteLine("1- Menu Usuário");
			Console.WriteLine("2- Menu Livro");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

            Console.Write("Informe a opção desejada: ");
			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

		private static string MenuUsuario()
		{
			Console.WriteLine();
            Console.WriteLine("==============================");
			Console.WriteLine("         Menu Usuario");
            Console.WriteLine("==============================");
            Console.WriteLine();

			Console.WriteLine("1- Listar Usuarios");
			Console.WriteLine("2- Inserir Novo Usuario");
			Console.WriteLine("3- Atualizar Usuario");
			Console.WriteLine("4- Excluir Usuario");
			Console.WriteLine("5- Visualizar Usuario");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

            Console.Write("Informe a opção desejada: ");
			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

        private static string MenuLivro()
		{
			Console.WriteLine();
            Console.WriteLine("==============================");
			Console.WriteLine("          Menu Livro");
            Console.WriteLine("==============================");
            Console.WriteLine();

			Console.WriteLine("1- Listar Livros");
			Console.WriteLine("2- Inserir Novo Livro");
			Console.WriteLine("3- Atualizar Livro");
			Console.WriteLine("4- Excluir Livro");
			Console.WriteLine("5- Visualizar Livro");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

            Console.Write("Informe a opção desejada: ");
			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

        private static void ExcluirLivro()
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			repoLivros.Exclui(indiceLivro);
		}

        private static void VisualizarLivro()
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			var livro = repoLivros.RetornaPorId(indiceLivro);

			Console.WriteLine(livro);
		}

        private static void AtualizarLivro()
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			Console.Write("Digite o título do Livro: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o autor do Livro: ");
			string entradaAutor = Console.ReadLine();

			Livro atualizaLivro = new Livro(id: indiceLivro,
										titulo: entradaTitulo,
										autor: entradaAutor);

			repoLivros.Atualiza(indiceLivro, atualizaLivro);
		}
        private static void ListarLivros()
		{
			Console.WriteLine();

			var lista = repoLivros.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum livro cadastrado!");
				return;
			}

			foreach (var livro in lista)
			{
                var excluido = livro.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", livro.retornaId(), livro.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirLivro()
		{
			Console.Write("Digite o título do Livro: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o autor do Livro: ");
			string entradaAutor = Console.ReadLine();

			Livro novoLivro = new Livro(id: repoLivros.ProximoId(),
										titulo: entradaTitulo,
										autor: entradaAutor);

			repoLivros.Insere(novoLivro);
		}






		private static void ExcluirUsuario()
		{
			Console.Write("Digite o id do usuario: ");
			int indiceUsuario = int.Parse(Console.ReadLine());

			repoUsuarios.Exclui(indiceUsuario);
		}

        private static void VisualizarUsuario()
		{
			Console.Write("Digite o id do usuario: ");
			int indiceUsuario = int.Parse(Console.ReadLine());

			var usuario = repoUsuarios.RetornaPorId(indiceUsuario);

			Console.WriteLine(usuario);
		}

        private static void AtualizarUsuario()
		{
			Console.Write("Digite o id do usuario: ");
			int indiceUsuario = int.Parse(Console.ReadLine());

			Console.Write("Digite o nome do usuario: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite a idade do usuario: ");
			int entradaIdade = int.Parse(Console.ReadLine());

			Console.Write("Digite o endereço do usuario: ");
			string entradaEndereco = Console.ReadLine();

			Usuario atualizaUsuario = new Usuario(id: indiceUsuario,
										nome: entradaNome,
										idade: entradaIdade,
										endereco: entradaEndereco);

			repoUsuarios.Atualiza(indiceUsuario, atualizaUsuario);
		}
        private static void ListarUsuarios()
		{
			Console.WriteLine();

			var lista = repoUsuarios.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum usuario cadastrado.");
				return;
			}

			foreach (var usuario in lista)
			{
                var excluido = usuario.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", usuario.retornaId(), usuario.retornaNome(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirUsuario()
		{
			Console.Write("Digite o nome do usuario: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite a idade do usuario: ");
			int entradaIdade = int.Parse(Console.ReadLine());

			Console.Write("Digite o endereço do usuario: ");
			string entradaEndereco = Console.ReadLine();

			Usuario novoUsuario = new Usuario(id: repoUsuarios.ProximoId(),
										nome: entradaNome,
										idade: entradaIdade,
										endereco: entradaEndereco);

			repoUsuarios.Insere(novoUsuario);
		}

    }
}
