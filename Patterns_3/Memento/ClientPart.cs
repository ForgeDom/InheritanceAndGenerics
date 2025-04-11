namespace Patterns_3.Memento;

public class ClientPart
{
    public static void Main(string[] args)
    {
        var origin = new Origin();
        var history = new History();

        try
        {
            origin.State = "Стан 1";
            history.AddMemento(origin.SaveState());

            origin.State = "Стан 2";
            history.AddMemento(origin.SaveState());

            origin.RestoreState(history.GetLastMemento());
            origin.RestoreState(history.GetLastMemento());
            
            origin.RestoreState(history.GetLastMemento());
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}