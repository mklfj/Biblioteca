using System;

namespace Biblioteca
{
    public class Usuario : EntidadeBase
    {
        // Atributos
		private string Nome { get; set; }
        private int Idade { get; set; }
		private string Endereco { get; set; }
        private bool Excluido {get; set;}

        // Métodos
		public Usuario(int id, string nome, int idade, string endereco)
		{
			this.Id = id;
			this.Nome = nome;
            this.Idade = idade;
            this.Endereco = endereco;
            this.Excluido = false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Idade: " + this.Idade + Environment.NewLine;
            retorno += "Endereco: " + this.Endereco + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaNome()
		{
			return this.Nome;
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