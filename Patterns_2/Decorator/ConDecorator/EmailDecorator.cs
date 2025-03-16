namespace Patterns_2.Decorator.ConDecorator;

public class EmailDecorator: BaseDecorator
{
    public EmailDecorator(IComponent component) : base(component)
    {
        
    }
    public override string SendNotification(string message)
    {
        return $"{base.SendNotification(message)}\nEmail notification: {message}";
    }
}