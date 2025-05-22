namespace NotificationFactoryMethod.Abstractions
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void Notify(string message)
        {
            var notification = CreateNotification();
            notification.Send(message);
        }
    }
}
