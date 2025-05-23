namespace AdapterPattern.Adapters
{
    public class MercadoPagoAPI
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"[MercadoPago] Pagamento de R$ {valor} processado com sucesso.");
        }
    }
}
