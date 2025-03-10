namespace Patterns_1.Singleton;

public class ClientPart
{
    public static void Main(string[] args)
    {
        
        var singleton = Singleton.GetInstance();
        singleton.SomeBusinessLogic();
        
        var singleton2 = Singleton.GetInstance();
        singleton2.SomeBusinessLogic();

        if (singleton == singleton2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }
    }
}