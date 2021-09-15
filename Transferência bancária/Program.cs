using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta();
            minhaConta.Nome = "Jodecir";

            Console.WriteLine(minhaConta);
        }
    }
}
