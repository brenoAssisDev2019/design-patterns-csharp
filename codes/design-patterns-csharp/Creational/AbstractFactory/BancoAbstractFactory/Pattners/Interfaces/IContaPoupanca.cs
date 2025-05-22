namespace BancoAbstractFactory.Pattners.Interfaces
{
    public interface IContaPoupanca
    {
        void AbrirConta();
        void AplicarRendimento(decimal taxa);
    }
}
