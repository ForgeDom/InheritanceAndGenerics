namespace Patterns_3.Observer.Observers;
using Patterns_3.Observer.Interfaces;

public class EmailSubscriber: IObserver
{
    private string _email;
    
    public EmailSubscriber(string email)
    {
        _email = email;
    }
    
    public void Update(string message)
    {
        Console.WriteLine($"Email sent to {_email}: {message}");
    }
}