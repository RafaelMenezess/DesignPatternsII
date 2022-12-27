namespace DesignPatternsII.Cap4
{
    class Soma : IExpressao
    {
        public IExpressao esquerda { get; }
        public IExpressao direita { get; }
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }
        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda + valorDireita;
        }
    }
}
