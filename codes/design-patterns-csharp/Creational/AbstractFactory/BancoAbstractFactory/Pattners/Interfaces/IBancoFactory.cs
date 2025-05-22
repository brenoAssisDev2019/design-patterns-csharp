namespace BancoAbstractFactory.Pattners.Interfaces
{
    public interface IBancoFactory
    {
        IContaCorrente CriarContaCorrente();
        IContaPoupanca CriarContaPoupanca();
    }
}
