namespace Patterns_2.Decorator;

public interface IComponent
{   
    string SendNotification(string message);
}

public class Notifier : IComponent
{
    public string Name { get; set; }
    public Notifier(string name)
    {
        Name = name;
    }
    public string SendNotification(string message)
    {
        return $"Notifier {Name} notification: {message}";
    }
}

public class WebNotifier : IComponent
{
    public string Name { get; set; }
    
    public WebNotifier(string name)
    {
        Name = name;
    }
    public string SendNotification(string message)
    {
        return $"WebNotifier {Name} notification: {message}";
    }
}

public class SmsNotifier : IComponent
{
    public string Name { get; set; }
    
    public SmsNotifier(string name)
    {
        Name = name;
    }
    public string SendNotification(string message)
    {
        return $"SmsNotifier {Name} notification: {message}";
    }
}