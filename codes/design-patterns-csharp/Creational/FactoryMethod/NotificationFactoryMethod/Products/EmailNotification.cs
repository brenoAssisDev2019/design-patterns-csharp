using NotificationFactoryMethod.Abstractions;

namespace NotificationFactoryMethod.Products
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Enviando E-MAIL: {message}");
        }
    }
}