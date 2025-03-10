namespace Patterns_1.Builder;

public class Director
{
    private IPcBuilder<string> _builder;
    public Director(IPcBuilder<string> builder)
    {
        _builder = builder;
    }
    public void BuildMinimalPc()
    {
        _builder.BuildСpu();
        _builder.BuildRam();
        _builder.BuildStorage();
    }
    public void BuildGamingPc()
    {
        _builder.BuildСpu();
        _builder.BuildRam();
        _builder.BuildStorage();
        _builder.BuildGpu();
        _builder.BuildCoolingSystem();
    }
    public void DestroyMinimalPc()
    {
        _builder.DestroyСpu();
        _builder.DestroyRam();
        _builder.DestroyStorage();
    }
    public void DestroyGamingPc()
    {
        _builder.DestroyСpu();
        _builder.DestroyRam();
        _builder.DestroyStorage();
        _builder.DestroyGpu();
        _builder.DestroyCoolingSystem();
    }
}