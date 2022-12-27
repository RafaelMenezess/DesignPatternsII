using System.Collections.Generic;

namespace DesignPatternsII.Cap3
{
    public class Historico
    {
        private IList<Status> Status = new List<Status>();

        public void Adiciona(Status status)
        {
            Status.Add(status);
        }
        public Status GetStatus(int indice)
        {
            return Status[indice];
        }
    }
}
