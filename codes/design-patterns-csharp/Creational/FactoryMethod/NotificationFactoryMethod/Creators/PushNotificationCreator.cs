using NotificationFactoryMethod.Abstractions;
using NotificationFactoryMethod.Products;

namespace NotificationFactoryMethod.Creators
{
    public class PushNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification() => new PushNotification();
    }
}
