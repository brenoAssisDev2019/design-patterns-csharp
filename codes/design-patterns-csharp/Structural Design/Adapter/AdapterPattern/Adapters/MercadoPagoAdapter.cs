namespace AdapterPattern.Adapters
{
    public class MercadoPagoAdapter : IPaymentProcessor
    {
        private readonly MercadoPagoAPI _mercadoPagoAPI;

        public MercadoPagoAdapter(MercadoPagoAPI mercadoPagoAPI)
        {
            _mercadoPagoAPI = mercadoPagoAPI;
        }

        public void ProcessPayment(decimal amount)
        {
            _mercadoPagoAPI.Pagar(amount);
        }
    }
}
