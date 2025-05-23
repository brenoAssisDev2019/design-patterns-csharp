namespace FacadePattern.Subsystems
{
    public class HotelBookingService
    {
        public string BookHotel(string customer, string destination)
        {
            return $"Hotel reservado para {customer} em {destination}";
        }
    }
}
