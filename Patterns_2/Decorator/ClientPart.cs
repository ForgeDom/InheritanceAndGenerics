using Patterns_2.Decorator.ConDecorator;
namespace Patterns_2.Decorator;

public class ClientPart
{
    public void NotificationService(List<IComponent> components, string message)
    {
        foreach (var component in components)
        {
            Console.WriteLine(component.SendNotification(message));
        }
        Console.WriteLine();
    }

    public void Main()
    {
        IComponent mobileNotify = new Notifier("MESSAGE");
        IComponent emailNotify = new WebNotifier("Cars.com");
        IComponent smsNotify = new SmsNotifier("3 shturmova");
        
        var forMobile = new List<IComponent>();
        forMobile.Add(new EmailDecorator(mobileNotify));
        var forWeb = new List<IComponent>();
        forWeb.Add(new FacebookDecorator(emailNotify));
        var forSms = new List<IComponent>();
        forSms.Add(new TwitterDecorator(smsNotify));
        
        NotificationService(forMobile, "Hello, Bob! Call me back, please.");
        NotificationService(forWeb, "Here are new sjoes for you!");
        NotificationService(forSms, "You have a new message from your friend.");
    }
}