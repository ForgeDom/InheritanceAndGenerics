namespace Patterns_2.Facade;

public class ClientPart
{
    public void Main(string[] args)
    {
        ISubSystem subSystem1 = new SubSystem1();
        ISubSystem subSystem2 = new SubSystem2();
        ISubSystem subSystem3 = new SubSystem3();
        Facade facade = new Facade(subSystem1, subSystem2, subSystem3);
        Console.WriteLine(facade.Operation1());
        Console.WriteLine(facade.Operation2());
    }
}