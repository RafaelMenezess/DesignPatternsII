using DesignPatternsII.Cap8;
using System;

namespace DesignPatternsII
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Rafael";
            cliente.Endereco = "Rua Jose Gregorio";
            cliente.DataDeNascimento = DateTime.Now;

            string xml = new GeradorXml().GeraXml(cliente);

            Console.WriteLine(xml);


            Console.ReadKey();
        }
    }
}
