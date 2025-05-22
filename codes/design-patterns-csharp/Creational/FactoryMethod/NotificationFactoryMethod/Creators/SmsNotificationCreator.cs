using NotificationFactoryMethod.Abstractions;
using NotificationFactoryMethod.Products;

namespace NotificationFactoryMethod.Creators
{
    public class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification() => new SmsNotification();
    }
}
