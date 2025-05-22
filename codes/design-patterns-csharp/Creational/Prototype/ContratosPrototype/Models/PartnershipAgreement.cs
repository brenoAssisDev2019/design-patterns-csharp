using ContratosPrototype.Abstractions;

namespace ContratosPrototype.Models
{
    public class PartnershipAgreement : Contract
    {
        public PartnershipAgreement(string clientName) : base(clientName) { }

        public override IContractPrototype Clone()
        {
            return new PartnershipAgreement(ClientName)
            {
                CreatedAt = this.CreatedAt
            };
        }

        public override void Print()
        {
            Console.WriteLine($"Contrato de Parceria - Cliente: {ClientName} | Criado em: {CreatedAt}");
        }
    }
}
