using ContratosPrototype.Abstractions;

namespace ContratosPrototype.Models
{
    public class NdaAgreement : Contract
    {
        public NdaAgreement(string clientName) : base(clientName) { }

        public override IContractPrototype Clone()
        {
            return new NdaAgreement(ClientName)
            {
                CreatedAt = this.CreatedAt
            };
        }

        public override void Print()
        {
            Console.WriteLine($"Contrato de Confidencialidade (NDA) - Cliente: {ClientName} | Criado em: {CreatedAt}");
        }
    }
}
