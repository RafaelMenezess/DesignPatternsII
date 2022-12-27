using DesignPatternsII.Cap3;
using System;

namespace DesignPatternsII
{
    public class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now, "Rafael", TipoContrato.Novo);
            historico.Adiciona(c.SalvaStatus());

            Console.WriteLine(c.Tipo);

            c.Avanca();
            historico.Adiciona(c.SalvaStatus());

            c.Avanca();
            Console.WriteLine(c.Tipo);
            historico.Adiciona(c.SalvaStatus());


            Console.WriteLine(historico.GetStatus(2).Contrato.Tipo);
            Console.ReadKey();
        }
    }
}
