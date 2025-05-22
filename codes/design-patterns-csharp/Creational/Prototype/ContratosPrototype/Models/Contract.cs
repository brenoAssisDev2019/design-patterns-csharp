using ContratosPrototype.Abstractions;

namespace ContratosPrototype.Models
{
    public abstract class Contract : IContractPrototype
    {
        public string ClientName { get; set; }
        public DateTime CreatedAt { get; set; }

        protected Contract(string clientName)
        {
            ClientName = clientName;
            CreatedAt = DateTime.Now;
        }

        public abstract IContractPrototype Clone();
        public abstract void Print();
    }
}
