namespace FacadePattern.Subsystems
{
    public class FlightBookingService
    {
        public string BookFlight(string customer, string destination, DateTime date)
        {
            return $"Voo reservado para {customer} com destino a {destination} em {date.ToShortDateString()}";
        }
    }
}
