using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FabricMethod
{
    public abstract class Creator
    {
        public abstract OS FactoryMethod();

        public string StartSystemOperation()
        {
            var product = FactoryMethod();
            string result = "Creator: The same creator's code has just worked with " + product.StartSystem();
            return result;
        }

        public string PowerConsumptionOperation()
        {
            var product = FactoryMethod();
            string result = "Creator: The same creator's code has just worked with " + product.PowerConsumption();
            return result;
        }

        public string PerformanceOperation()
        {
            var product = FactoryMethod();
            string result = "Creator: The same creator's code has just worked with " + product.Performance();
            return result;
        }
    }

    public class Gamer : Creator
    {
        public override OS FactoryMethod()
        {
            return new GamerOS();
        }
    }

    public class Office : Creator
    {
        public override OS FactoryMethod()
        {
            return new OfficeOS();
        }
    }
}
