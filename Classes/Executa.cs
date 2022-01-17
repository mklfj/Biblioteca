using System;

namespace Biblioteca
{
    public static class Executa
    {
		public static void ExcluirUsuario(UsuarioRepositorio repoUsuarios)
		{
			Console.Write("Digite o id do usuario: ");
			int indiceUsuario = int.Parse(Console.ReadLine());

			repoUsuarios.Exclui(indiceUsuario);
		}

        public static void VisualizarUsuario(UsuarioRepositorio repoUsuarios)
		{
			Console.Write("Digite o id do usuario: ");
			int indiceUsuario = int.Parse(Console.ReadLine());

			var usuario = repoUsuarios.RetornaPorId(indiceUsuario);

			Console.WriteLine(usuario);
		}

        public static void AtualizarUsuario(UsuarioRepositorio repoUsuarios)
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
        public static void ListarUsuarios(UsuarioRepositorio repoUsuarios)
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

        public static void InserirUsuario(UsuarioRepositorio repoUsuarios)
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




        public static void ExcluirLivro(LivroRepositorio repoLivros)
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			repoLivros.Exclui(indiceLivro);
		}

        public static void VisualizarLivro(LivroRepositorio repoLivros)
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			var livro = repoLivros.RetornaPorId(indiceLivro);

			Console.WriteLine(livro);
		}

        public static void AtualizarLivro(LivroRepositorio repoLivros)
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

		public static void ListarLivros(LivroRepositorio repoLivros)
		{
			Console.WriteLine();

			var lista = repoLivros.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum livro cadastrado.");
				return;
			}

			foreach (var livro in lista)
			{
                var excluido = livro.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", livro.retornaId(), livro.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        public static void InserirLivro(LivroRepositorio repoLivros)
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
    }
}