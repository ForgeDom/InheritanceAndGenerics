namespace Patterns_1.Prototype;

public interface IPrototype
{
    IPrototype Clone();
}

public abstract class Prototype : IPrototype
{
    public abstract IPrototype Clone();
}

public class TestObject : Prototype
{
    public string Name { get; set; }
    public int Age { get; set; }

    public TestObject(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override IPrototype Clone()
    {
        return new TestObject(Name, Age);
    }
}