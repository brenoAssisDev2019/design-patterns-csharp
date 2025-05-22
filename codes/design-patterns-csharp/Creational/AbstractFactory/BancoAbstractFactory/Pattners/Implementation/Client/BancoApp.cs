using BancoAbstractFactory.Pattners.Interfaces;

namespace BancoAbstractFactory.Pattners.Implementation.Client
{
    public class BancoApp
    {
        private readonly IContaCorrente _contaCorrente;
        private readonly IContaPoupanca _contaPoupanca;

        public BancoApp(IBancoFactory factory)
        {
            _contaCorrente = factory.CriarContaCorrente();
            _contaPoupanca = factory.CriarContaPoupanca();
        }

        public void Operar()
        {
            _contaCorrente.AbrirConta();
            _contaCorrente.RealizarSaque(500);

            _contaPoupanca.AbrirConta();
            _contaPoupanca.AplicarRendimento(0.05m);
        }
    }
}
