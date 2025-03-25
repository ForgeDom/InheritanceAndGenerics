namespace Patterns_3.MVVM;

public class View
{
    public ViewModel ViewModel { get; set; } = null!;

    public void UpdateView(string data)
    {
        ViewModel.Data = data;
        Console.WriteLine($"View is displaying: {data}");
    }
}