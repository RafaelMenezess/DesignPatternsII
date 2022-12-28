namespace DesignPatternsII.Cap7
{
    class PagaPedido : IComando
    {
        private Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            System.Console.WriteLine("Pagando pedido do cliente {0}", pedido.Cliente);
            pedido.Paga();
        }
    }
}
