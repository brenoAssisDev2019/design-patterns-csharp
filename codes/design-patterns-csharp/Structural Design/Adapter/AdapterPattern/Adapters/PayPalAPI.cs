namespace AdapterPattern.Adapters
{
    public class PayPalAPI
    {
        public void MakePayment(double total)
        {
            Console.WriteLine($"[PayPal] Pagamento de USD {total} efetuado com sucesso.");
        }
    }
}
