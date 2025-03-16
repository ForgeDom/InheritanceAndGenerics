namespace Patterns_2.Proxy;

public class ClientPart
{
    public void Main(string[] args)
    {
        ISubject proxy = new Proxy();
        Console.Write("Client: Making first request...\n");
        proxy.Request();
        Console.Write("Client: Making second request...\n");
        proxy.Request();
    }
}