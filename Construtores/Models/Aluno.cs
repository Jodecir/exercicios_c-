namespace Construtores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome, string disciplina, decimal nota) : base(nome, sobrenome)
        {
        }
    }
}