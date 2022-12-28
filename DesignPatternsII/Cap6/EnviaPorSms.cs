using System;

namespace DesignPatternsII.Cap6
{
    class EnviaPorSms : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por sms");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
