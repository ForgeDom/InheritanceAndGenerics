using Patterns_3.Observer.Interfaces;

namespace Patterns_3.Observer.Observers;

public class SmsSubscriber: IObserver
{
    private string _phoneNumber;
    
    public SmsSubscriber(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
    }
    
    public void Update(string message)
    {
        Console.WriteLine($"SMS sent to {_phoneNumber}: {message}");
    }
}