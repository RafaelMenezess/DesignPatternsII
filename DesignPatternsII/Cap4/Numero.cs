using DesignPatternsII.Cap5;

namespace DesignPatternsII.Cap4
{
    class Numero : IExpressao
    {
        public int Valor { get; private set; }
        public Numero(int numero)
        {
            this.Valor = numero;
        }
        public int Avalia() 
        { 
            return this.Valor; 
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
