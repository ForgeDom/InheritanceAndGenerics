namespace Patterns_3.Chain_Of_Responsibility;

public class ConcreteHandler2: Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10 && request < 20)
        {
            Console.WriteLine($"ConcreteHandler2 handled the request {request}");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}