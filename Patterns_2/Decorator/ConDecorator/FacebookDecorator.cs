namespace Patterns_2.Decorator.ConDecorator;

public class FacebookDecorator: BaseDecorator
{
    public FacebookDecorator(IComponent component) : base(component)
    {
        
    }
    public override string SendNotification(string message)
    {
        return $"{base.SendNotification(message)}\nFacebook notification: {message}";
    }
}