using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patterns_1.AbstractFactory.Product;

namespace Patterns_1.AbstractFactory
{
    public interface IAbstrtactFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }

    public abstract class AbstrtactFactory : IAbstrtactFactory
    {
        public abstract IChair CreateChair();
        public abstract ISofa CreateSofa();
        public abstract ICoffeeTable CreateCoffeeTable();
    }

    public class ModernFurnitureFactory : AbstrtactFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }
        public override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        public override ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }

    public class VictorianFurnitureFactory : AbstrtactFactory
    {
        public override IChair CreateChair()
        {
            return new VictorianChair();
        }
        public override ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
        public override ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }

    public class ModernSofaFactory : AbstrtactFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }
        public override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        public override ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }

    public class VictorianSofaFactory : AbstrtactFactory
    {
        public override IChair CreateChair()
        {
            return new VictorianChair();
        }
        public override ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
        public override ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }

    public class ModernCoffeeTableFactory : AbstrtactFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }
        public override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        public override ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }

    public class VictorianCoffeeTableFactory : AbstrtactFactory
    {
        public override IChair CreateChair()
        {
            return new VictorianChair();
        }
        public override ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
        public override ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }
}
