namespace Patterns_2.Decorator.ConDecorator;

public class TwitterDecorator: BaseDecorator
{
    public TwitterDecorator(IComponent component) : base(component)
    {
        
    }
    public override string SendNotification(string message)
    {
        return $"{base.SendNotification(message)}\nTwitter notification: {message}";
    }
}