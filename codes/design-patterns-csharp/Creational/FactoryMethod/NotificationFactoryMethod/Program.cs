using NotificationFactoryMethod.Creators;

var email = new EmailNotificationCreator();
email.Notify("Fatura disponível no app!");

var sms = new SmsNotificationCreator();
sms.Notify("Código de verificação: 123456");

var push = new PushNotificationCreator();
push.Notify("Nova transação detectada!");
