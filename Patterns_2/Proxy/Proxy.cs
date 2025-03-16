namespace Patterns_2.Proxy;

public class Proxy: ISubject
{
    private RealSubject _realSubject;
    public void Request()
    {
        if (_realSubject == null)
        {
            Console.WriteLine("Proxy: initializing RealSubject");
            _realSubject = new RealSubject();
        }
        Console.WriteLine("Proxy: forwarding request to RealSubject");
        _realSubject.Request();
        Console.WriteLine("Proxy: request forwarded");
    }
}