namespace Patterns_3.MVVM;

public class ViewModel
{
    private readonly Model _model;
    public ViewModel(Model model) => _model = model;

    public string Data
    {
        get => _model.Data;
        set
        {
            _model.Data = value;
            Console.WriteLine($"ViewModel updated Model data to: {value}");
        }
    }
}