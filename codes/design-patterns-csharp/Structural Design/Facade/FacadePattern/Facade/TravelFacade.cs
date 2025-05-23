using FacadePattern.Models;
using FacadePattern.Subsystems;

namespace FacadePattern.Facade
{
    public class TravelFacade
    {
        private readonly FlightBookingService _flight;
        private readonly HotelBookingService _hotel;
        private readonly CarRentalService _car;

        public TravelFacade()
        {
            _flight = new FlightBookingService();
            _hotel = new HotelBookingService();
            _car = new CarRentalService();
        }

        public ReservationResult ReserveCompleteTrip(ReservationRequest request)
        {
            try
            {
                var flight = _flight.BookFlight(request.CustomerName, request.Destination, request.TravelDate);
                var hotel = _hotel.BookHotel(request.CustomerName, request.Destination);
                var car = _car.RentCar(request.CustomerName, request.Destination);

                return new ReservationResult
                {
                    Success = true,
                    Summary = $"{flight}\n{hotel}\n{car}"
                };
            }
            catch (Exception ex)
            {
                return new ReservationResult
                {
                    Success = false,
                    Summary = $"Erro na reserva: {ex.Message}"
                };
            }
        }
    }
}
