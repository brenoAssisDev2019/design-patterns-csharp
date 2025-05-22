using NotificationFactoryMethod.Abstractions;
using NotificationFactoryMethod.Products;

namespace NotificationFactoryMethod.Creators
{
    public class EmailNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification() => new EmailNotification();
    }
}
