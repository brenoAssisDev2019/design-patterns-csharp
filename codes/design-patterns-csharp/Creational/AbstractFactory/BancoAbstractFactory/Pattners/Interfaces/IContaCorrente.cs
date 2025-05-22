namespace BancoAbstractFactory.Pattners.Interfaces
{
    public interface IContaCorrente
    {
        void AbrirConta();
        void RealizarSaque(decimal valor);
    }
}
