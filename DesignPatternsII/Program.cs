using DesignPatternsII.Cap6;
using System;

namespace DesignPatternsII
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemCliente("Victor");
            IEnviador enviador = new EnviaPorSms();
            mensagem.Enviador = enviador;
            mensagem.Envia();


            Console.ReadKey();
        }
    }
}
