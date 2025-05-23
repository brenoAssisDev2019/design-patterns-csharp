namespace AdapterPattern.Adapters
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly PayPalAPI _payPalAPI;

        public PayPalAdapter(PayPalAPI payPalAPI)
        {
            _payPalAPI = payPalAPI;
        }

        public void ProcessPayment(decimal amount)
        {
            _payPalAPI.MakePayment((double)amount);
        }
    }
}
