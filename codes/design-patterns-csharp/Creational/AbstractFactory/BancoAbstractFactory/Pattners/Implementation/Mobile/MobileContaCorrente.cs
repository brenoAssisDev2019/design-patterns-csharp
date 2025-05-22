using BancoAbstractFactory.Pattners.Interfaces;

namespace BancoAbstractFactory.Pattners.Implementation.Mobile
{
    public class MobileContaCorrente : IContaCorrente
    {
        public void AbrirConta() => Console.WriteLine("Conta Corrente aberta via Mobile Banking.");
        public void RealizarSaque(decimal valor) => Console.WriteLine($"Saque de {valor:C} realizado via Mobile Banking.");
    }
}
