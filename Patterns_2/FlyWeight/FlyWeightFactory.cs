namespace Patterns_2.FlyWeight;

public class FlyWeightFactory
{
    private Dictionary<string, FlyWeight> _flyWeights = new Dictionary<string, FlyWeight>();
    
    public FlyWeight GetFlyWeight(string key)
    {
        if (_flyWeights.ContainsKey(key))
        {
            Console.WriteLine("Reusing existing flyweight");
            return _flyWeights[key];
        }
        else
        {
            Console.WriteLine("Creating new flyweight");
            var flyWeight = new ConcreteFlyWeight(key);
            _flyWeights[key] = flyWeight;
            return flyWeight;
        }
    }
    public void ListFlyWeights()
    {
        Console.WriteLine($"There are {_flyWeights.Count} flyweights:");
        foreach (var key in _flyWeights.Keys)
        {
            Console.WriteLine(key);
        }
    }
}