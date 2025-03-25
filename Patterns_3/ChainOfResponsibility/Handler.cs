namespace Patterns_3.Chain_Of_Responsibility;

public abstract class Handler
{
    protected Handler _nextHandler;
    
    public void SetNextHandler(Handler nextHandler)
    {
        _nextHandler = nextHandler;
    }
    
    public abstract void HandleRequest(int request);
}