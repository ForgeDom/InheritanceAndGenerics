namespace Patterns_1.Builder;

public interface IPcBuilder<T>
{
    T BuildСpu();
    T BuildRam();
    T BuildStorage();
    T BuildGpu();
    T BuildCoolingSystem();
    
    T DestroyСpu();
    T DestroyRam();
    T DestroyStorage();
    T DestroyGpu();
    T DestroyCoolingSystem();
}

public abstract class PcBuilder<T> : IPcBuilder<T>
{
    protected virtual void GetActionInfo(string action, string part)
    {
        Console.WriteLine($"{action} {part}");
    }

    public Product<T> Product { get; set; }

    public abstract T BuildСpu();
    public abstract T BuildRam();
    public abstract T BuildStorage();
    public abstract T BuildGpu();
    public abstract T BuildCoolingSystem();
    
    public abstract T DestroyСpu();
    public abstract T DestroyRam();
    public abstract T DestroyStorage();
    public abstract T DestroyGpu();
    public abstract T DestroyCoolingSystem();
}

public class ComputerBuilder: PcBuilder<string>{
    public ComputerBuilder()
    {
        Product = new Computer();
    }
    public override string BuildСpu()
    {
        GetActionInfo("Build", "CPU");
        Product.AddPart("CPU");
        return "CPU";
    }

    public override string BuildRam()
    {
        GetActionInfo("Build", "RAM");
        Product.AddPart("RAM");
        return "RAM";
    }

    public override string BuildStorage()
    {
        GetActionInfo("Build", "Storage");
        Product.AddPart("Storage");
        return "Storage";
    }

    public override string BuildGpu()
    {
        GetActionInfo("Build", "GPU");
        Product.AddPart("GPU");
        return "GPU";
    }

    public override string BuildCoolingSystem()
    {
        GetActionInfo("Build", "Cooling system");
        Product.AddPart("Cooling system");
        return "Cooling system";
    }

    public override string DestroyСpu()
    {
        GetActionInfo("Destroy", "CPU");
        Product.RemovePart("CPU");
        return "CPU";
    }

    public override string DestroyRam()
    {
        GetActionInfo("Destroy", "RAM");
        Product.RemovePart("RAM");
        return "RAM";
    }

    public override string DestroyStorage()
    {
        GetActionInfo("Destroy", "Storage");
        Product.RemovePart("Storage");
        return "Storage";
    }

    public override string DestroyGpu()
    {
        GetActionInfo("Destroy", "GPU");
        Product.RemovePart("GPU");
        return "GPU";
    }

    public override string DestroyCoolingSystem()
    {
        GetActionInfo("Destroy", "Cooling system");
        Product.RemovePart("Cooling system");
        return "Cooling system";
    }
}