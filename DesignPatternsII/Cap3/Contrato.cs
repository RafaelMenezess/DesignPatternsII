using System;

namespace DesignPatternsII.Cap3
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }
        public void Avanca()
        {
            if (this.Tipo == TipoContrato.Novo) this.Tipo = TipoContrato.EmAndamento;
            else if (this.Tipo == TipoContrato.EmAndamento) this.Tipo = TipoContrato.Acertado;
            else if (this.Tipo == TipoContrato.Acertado) this.Tipo = TipoContrato.Concluido;
        }
        public Status SalvaStatus()
        {
            return new Status(new Contrato(Data, Cliente, Tipo));
        }
    }
}
