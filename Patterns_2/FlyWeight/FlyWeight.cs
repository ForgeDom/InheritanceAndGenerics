namespace Patterns_2.FlyWeight;

public interface FlyWeight
{
    void Operation(string extrinsicState);
}

public class ConcreteFlyWeight : FlyWeight
{
    private string _intrinsicState;

    public ConcreteFlyWeight(string intrinsicState)
    {
        _intrinsicState = intrinsicState;
    }

    public void Operation(string extrinsicState)
    {
        Console.WriteLine($"ConcreteFlyWeight: {_intrinsicState} {extrinsicState}");
    }
}