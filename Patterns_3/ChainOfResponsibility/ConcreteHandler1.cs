using Patterns_3.Chain_Of_Responsibility;

namespace Patterns_3;

public class ConcreteHandler1: Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 0 && request < 10)
        {
            Console.WriteLine($"{this.GetType().Name} handled request {request}");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}