namespace Patterns_2.FlyWeight;

public class ClientPart
{
    public void Main(string[] args)
    {
        FlyWeightFactory factory = new FlyWeightFactory();
        FlyWeight flyWeight1 = factory.GetFlyWeight("1");
        FlyWeight flyWeight2 = factory.GetFlyWeight("2");
        FlyWeight flyWeight3 = factory.GetFlyWeight("3");
        flyWeight1.Operation("Fisrt Call");
        flyWeight2.Operation("Second Call");
        flyWeight3.Operation("Third Call");
    }
}