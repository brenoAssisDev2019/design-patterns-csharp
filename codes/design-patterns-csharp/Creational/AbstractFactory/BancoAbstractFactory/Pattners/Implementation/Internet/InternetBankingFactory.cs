using BancoAbstractFactory.Pattners.Interfaces;

namespace BancoAbstractFactory.Pattners.Implementation.Internet
{
    public class InternetBankingFactory : IBancoFactory
    {
        public IContaCorrente CriarContaCorrente() => new InternetContaCorrente();
        public IContaPoupanca CriarContaPoupanca() => new InternetContaPoupanca();
    }
}
