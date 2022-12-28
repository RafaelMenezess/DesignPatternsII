using DesignPatternsII.Cap5;

namespace DesignPatternsII.Cap4
{
    interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
