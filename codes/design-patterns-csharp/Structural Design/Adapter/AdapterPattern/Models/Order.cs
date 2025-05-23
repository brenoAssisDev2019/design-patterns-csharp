namespace AdapterPattern.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }

        public Order(int id, decimal total)
        {
            Id = id;
            Total = total;
        }
    }
}
