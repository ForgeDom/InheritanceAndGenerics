namespace Patterns_2.Proxy;

public class RealSubject: ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}