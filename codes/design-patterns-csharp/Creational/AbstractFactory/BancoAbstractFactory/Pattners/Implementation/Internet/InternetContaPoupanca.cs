using BancoAbstractFactory.Pattners.Interfaces;

namespace BancoAbstractFactory.Pattners.Implementation.Internet
{
    public class InternetContaPoupanca : IContaPoupanca
    {
        public void AbrirConta() => Console.WriteLine("Conta Poupança aberta via Internet Banking.");
        public void AplicarRendimento(decimal taxa) => Console.WriteLine($"Rendimento de {taxa:P} aplicado via Internet Banking.");
    }
}
