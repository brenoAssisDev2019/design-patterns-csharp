using BancoAbstractFactory.Pattners.Interfaces;

namespace BancoAbstractFactory.Pattners.Implementation.Mobile
{
    public class MobileContaPoupanca : IContaPoupanca
    {
        public void AbrirConta() => Console.WriteLine("Conta Poupança aberta via Mobile Banking.");
        public void AplicarRendimento(decimal taxa) => Console.WriteLine($"Rendimento de {taxa:P} aplicado via Mobile Banking.");
    }
}
