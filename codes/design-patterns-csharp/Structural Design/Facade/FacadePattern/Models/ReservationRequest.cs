namespace FacadePattern.Models
{
    public class ReservationRequest
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public DateTime TravelDate { get; set; }
    }
}
