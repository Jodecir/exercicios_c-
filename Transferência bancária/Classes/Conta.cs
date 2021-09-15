namespace Banco
{
    public class Conta
    {  
        private TipoConta TipoConta { get; set; } 
        public double Saldo { get; set; }  
        public double Credito { get; set; }
        public string Nome { get; set; }
    }
}