using System;
using System.Collections.Generic;

namespace Biblioteca
{
	public class UsuarioRepositorio : IRepositorio<Usuario>
	{
        private List<Usuario> listaUsuario = new List<Usuario>();

        
		public void Atualiza(int id, Usuario objeto)
		{
			listaUsuario[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaUsuario[id].Excluir();
		}

		public void Insere(Usuario objeto)
		{
			listaUsuario.Add(objeto);
		}

		public List<Usuario> Lista()
		{
			return listaUsuario;
		}

		public int ProximoId()
		{
			return listaUsuario.Count;
		}

		public Usuario RetornaPorId(int id)
		{
			return listaUsuario[id];
		}
	}
}