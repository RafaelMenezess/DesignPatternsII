namespace DesignPatternsII.Cap4
{
    class Subtracao : IExpressao
    {
        public IExpressao esquerda { get; }
        public IExpressao direita { get; }
        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }
        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
