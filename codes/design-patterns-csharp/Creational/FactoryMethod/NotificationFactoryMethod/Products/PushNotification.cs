using NotificationFactoryMethod.Abstractions;

namespace NotificationFactoryMethod.Products
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Enviando PUSH Notification: {message}");
        }
    }
}
