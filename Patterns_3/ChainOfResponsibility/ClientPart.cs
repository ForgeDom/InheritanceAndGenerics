using Patterns_3.Chain_Of_Responsibility;

namespace Patterns_3.ChainOfResponsibility;

public class ClientPart
{
    public void Main(string[] args)
    {
        Handler handler1 = new ConcreteHandler1();
        Handler handler2 = new ConcreteHandler2();
        Handler handler3 = new ConcreteHandler3();
        
        handler1.SetNextHandler(handler2);
        handler2.SetNextHandler(handler3);
        
        int[] requests = {2, 5, 14, 22, 18, 3, 27, 20};
        
        foreach (var request in requests)
        {
            handler1.HandleRequest(request);
        }
    }
}