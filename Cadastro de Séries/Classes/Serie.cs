using System;

namespace Cadastro
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; }
        private string Titulo { get; }
        private string Descricao { get; }
        private int Ano { get; }
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero " + this.Genero + Environment.NewLine;
            retorno += "Titulo " + this.Titulo + Environment.NewLine;
            retorno += "Descrição " + this.Descricao + Environment.NewLine;
            retorno += "Ano " + this.Ano;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }
    }
}