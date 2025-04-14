namespace Patterns_3.Mediator;

public class ClientPart
{
    public void Main()
    {
        Mediator mediator = new Mediator();
        mediator.AddComponent("sushi", new ComponentSushiStore("Sushi Store"));
        mediator.AddComponent("pizza", new ComponentSushiStore.ComponentPizzaResto("Pizza Store"));
        mediator.AddComponent("burger", new ComponentSushiStore.ComponentBurgerResto("Burger Store"));
        string sender = "sushi";
        mediator.Notify(sender);
        mediator.RemoveComponent("pizza");
        sender = "pizza";
        mediator.Notify(sender);
    }
}