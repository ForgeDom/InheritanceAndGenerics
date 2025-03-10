namespace Patterns_1.Prototype;

public class ClientPart
{
    public void Main(string[] args)
    {
        var testObject = new TestObject("Test", 1);
        Console.WriteLine("Testing Object:");
        ClientMethod(testObject);
        var testObject2 = (TestObject)testObject.Clone();
        Console.WriteLine("Testing Cloned Object:");
        ClientMethod(testObject2);

    }

    public void ClientMethod(TestObject testObject)
    {
        Console.WriteLine(testObject.Name);
        Console.WriteLine(testObject.Age);
    }
}