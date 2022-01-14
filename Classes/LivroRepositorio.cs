using System;
using System.Collections.Generic;

namespace Biblioteca
{
	public class LivroRepositorio : IRepositorio<Livro>
	{
        private List<Livro> acervoLivro = new List<Livro>();

        
		public void Atualiza(int id, Livro objeto)
		{
			acervoLivro[id] = objeto;
		}

		public void Exclui(int id)
		{
			acervoLivro[id].Excluir();
		}

		public void Insere(Livro objeto)
		{
			acervoLivro.Add(objeto);
		}

		public List<Livro> Lista()
		{
			return acervoLivro;
		}

		public int ProximoId()
		{
			return acervoLivro.Count;
		}

		public Livro RetornaPorId(int id)
		{
			return acervoLivro[id];
		}
	}
}