namespace Patterns_3.Mediator;

public class Mediator:IMediator
{
    private Dictionary<String, BaseComponents> Components { get; set; }
    public Mediator()
    {
        Components = new Dictionary<string, BaseComponents>();
    }
    public void AddComponent(string key, BaseComponents component)
    {
        Components.Add(key, component);
    }

    public void RemoveComponent(string key)
    {
        Components.Remove(key);
    }
    public void Notify(object sender)
    {
        string key = sender.ToString();
        try
        {
            Components[key].ReactOn(sender);
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}