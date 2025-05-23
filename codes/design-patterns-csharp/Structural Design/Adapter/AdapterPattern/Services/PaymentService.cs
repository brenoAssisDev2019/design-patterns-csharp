using AdapterPattern.Adapters;
using AdapterPattern.Models;

namespace AdapterPattern.Services
{
    public class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Checkout(Order order)
        {
            Console.WriteLine($"Iniciando checkout para pedido #{order.Id}...");
            _paymentProcessor.ProcessPayment(order.Total);
        }
    }
}
