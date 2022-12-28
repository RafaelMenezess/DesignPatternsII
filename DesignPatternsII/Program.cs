using DesignPatternsII.Cap7;
using System;

namespace DesignPatternsII
{
    public class Program
    {
        static void Main(string[] args)
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Rafael", 100.0);
            Pedido pedido2 = new Pedido("Jose", 200.0);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();

            Console.ReadKey();
        }
    }
}
