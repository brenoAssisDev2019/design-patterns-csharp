using ContratosPrototype.Abstractions;

namespace ContratosPrototype.Models
{
    public class ServiceAgreement : Contract
    {
        public ServiceAgreement(string clientName) : base(clientName) { }

        public override IContractPrototype Clone()
        {
            return new ServiceAgreement(ClientName)
            {
                CreatedAt = this.CreatedAt
            };
        }

        public override void Print()
        {
            Console.WriteLine($"Contrato de Serviços - Cliente: {ClientName} | Criado em: {CreatedAt}");
        }
    }
}
