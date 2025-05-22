using BancoAbstractFactory.Pattners.Interfaces;

namespace BancoAbstractFactory.Pattners.Implementation.Internet
{
    public class InternetContaCorrente : IContaCorrente
    {
        public void AbrirConta() => Console.WriteLine("Conta Corrente aberta via Internet Banking.");
        public void RealizarSaque(decimal valor) => Console.WriteLine($"Saque de {valor:C} realizado via Internet Banking.");
    }
}
