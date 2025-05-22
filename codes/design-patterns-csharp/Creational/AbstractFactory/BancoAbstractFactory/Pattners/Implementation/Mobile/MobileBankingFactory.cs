using BancoAbstractFactory.Pattners.Interfaces;

namespace BancoAbstractFactory.Pattners.Implementation.Mobile
{
    public class MobileBankingFactory : IBancoFactory
    {
        public IContaCorrente CriarContaCorrente() => new MobileContaCorrente();
        public IContaPoupanca CriarContaPoupanca() => new MobileContaPoupanca();
    }
}
