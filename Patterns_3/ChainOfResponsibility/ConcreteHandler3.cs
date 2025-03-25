namespace Patterns_3.Chain_Of_Responsibility;

public class ConcreteHandler3: Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20 && request < 30)
        {
            Console.WriteLine($"ConcreteHandler3 handled the request {request}");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}