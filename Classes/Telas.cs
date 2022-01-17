using System;

namespace Biblioteca
{
    public class Telas
    {
        public string MenuPrincipal()
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

		public void TelaUsuario(UsuarioRepositorio repoUsuarios){
            string opcaoUsuario;

            do
            {
                opcaoUsuario = MenuUsuario();
                switch (opcaoUsuario)
                {
					case "1":
					Executa.ListarUsuarios(repoUsuarios);
					break;

					case "2":
					Executa.InserirUsuario(repoUsuarios);
					break;

					case "3":
					Executa.AtualizarUsuario(repoUsuarios);
					break;

					case "4":
					Executa.ExcluirUsuario(repoUsuarios);
					break;

					case "5":
					Executa.VisualizarUsuario(repoUsuarios);
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

        public void TelaLivro(LivroRepositorio repoLivros){
            string opcaoUsuario;

            do
            {
                opcaoUsuario = MenuLivro();
                switch (opcaoUsuario)
                {
					case "1":
					Executa.ListarLivros(repoLivros);
					break;

					case "2":
					Executa.InserirLivro(repoLivros);
					break;

					case "3":
					Executa.AtualizarLivro(repoLivros);
					break;

					case "4":
					Executa.ExcluirLivro(repoLivros);
					break;

					case "5":
					Executa.VisualizarLivro(repoLivros);
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

		private string MenuUsuario()
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

        private string MenuLivro()
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

    }
}