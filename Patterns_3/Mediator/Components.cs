namespace Patterns_3.Mediator;

public interface IComponents
{
    string Name { get; set; }
    void ReactOn(object args);
}

public class BaseComponents : IComponents
{
    public string Name { get; set; }
    public BaseComponents(string name)
    {
        this.Name = name;
    }
    public virtual void ReactOn(object args)
    {
        Console.WriteLine($"Component {this.Name} reacts on: {args}.");
    }
}

public class ComponentSushiStore : BaseComponents
{
    public ComponentSushiStore(string name) : base(name) { }
    public void MakeSushi()
    {
        Console.WriteLine($"Component {this.Name} makes sushi.");
    }
    public override void ReactOn(object args)
    {
        base.ReactOn(args);
        MakeSushi();
    }
    
    public class ComponentPizzaResto : BaseComponents
    {
        public ComponentPizzaResto(string name) : base(name)
        { }
        public void MakePizza()
        {
            Console.WriteLine($"Component {this.Name} makes pizza.");
        }
        public override void ReactOn(object args)
        {
            base.ReactOn(args);
            MakePizza();
        }
    }
    public class ComponentBurgerResto : BaseComponents
    {
        public ComponentBurgerResto(string name) : base(name)
        { }
        public void MakeBurger()
        {
            Console.WriteLine($"Component {this.Name} makes burger with french frise and a cup of Coca-Cola.");
        }
        public override void ReactOn(object args)
        {
            base.ReactOn(args);
            MakeBurger();
        }

    }
}