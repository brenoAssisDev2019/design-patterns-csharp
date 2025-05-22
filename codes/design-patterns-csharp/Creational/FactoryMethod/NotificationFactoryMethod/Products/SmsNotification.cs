using NotificationFactoryMethod.Abstractions;

namespace NotificationFactoryMethod.Products
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Enviando SMS: {message}");
        }
    }
}
