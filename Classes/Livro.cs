using System;

namespace Biblioteca
{
    public class Livro : EntidadeBase
    {
        // Atributos
		private string Titulo { get; set; }
		private string Autor { get; set; }
        private bool Excluido {get; set;}

        // Métodos
		public Livro(int id, string titulo, string autor)
		{
			this.Id = id;
			this.Titulo = titulo;
            this.Autor = autor;
            this.Excluido = false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}