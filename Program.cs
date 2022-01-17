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
			Telas Tela = new Telas();

            do
            {
                opcaoUsuario = Tela.MenuPrincipal();
                switch (opcaoUsuario)
                {
                    case "1":
                    Tela.TelaUsuario(repoUsuarios);
                    break;

                    case "2":
                    Tela.TelaLivro(repoLivros);
                    break;

                    case "X":
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
            } while (opcaoUsuario != "X");

        }

    }
}
