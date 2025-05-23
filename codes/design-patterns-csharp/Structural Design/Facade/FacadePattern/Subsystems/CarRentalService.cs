namespace FacadePattern.Subsystems
{
    public class CarRentalService
    {
        public string RentCar(string customer, string destination)
        {
            return $"Carro alugado para {customer} em {destination}";
        }
    }
}
