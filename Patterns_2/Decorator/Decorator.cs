namespace Patterns_2.Decorator;

public abstract class BaseDecorator : IComponent
{
    protected IComponent _component;

    public BaseDecorator(IComponent component)
    {
        _component = component;
    }

    public virtual string SendNotification(string message)
    {
        return _component.SendNotification(message);
    }
}