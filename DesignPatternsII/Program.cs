using DesignPatternsII.Cap4;
using System;

namespace DesignPatternsII
{
    public class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            Console.ReadKey();
        }
    }
}
