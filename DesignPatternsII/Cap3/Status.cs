namespace DesignPatternsII.Cap3
{
    public class Status
    {
        public Contrato Contrato { get; set; }
        public Status(Contrato contrato)
        {
            Contrato = contrato;
        }
    }
}
