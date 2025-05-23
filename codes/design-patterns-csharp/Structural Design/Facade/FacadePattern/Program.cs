using FacadePattern.Facade;
using FacadePattern.Models;

Console.WriteLine("=== Sistema de Reservas de Viagem ===");

var request = new ReservationRequest
{
    CustomerName = "Carlos Silva",
    Destination = "Fortaleza",
    TravelDate = new DateTime(2025, 6, 15)
};

var facade = new TravelFacade();
var result = facade.ReserveCompleteTrip(request);

Console.WriteLine(result.Summary);