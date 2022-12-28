using DesignPatternsII.Cap4;
using DesignPatternsII.Cap5;
using System;

namespace DesignPatternsII
{
    public class Program
    {
        static void Main(string[] args)
        {
            //((1 + 10) + (20 - 10))
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);


            Console.ReadKey();
        }
    }
}
