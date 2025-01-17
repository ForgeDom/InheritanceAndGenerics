using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FabricMethod
{
    public interface IOS
    {
        string StartSystem();
        string PowerConsumption();
        string Performance();
    }

    public abstract class OS: IOS
    {
        public abstract string StartSystem();
        public abstract string PowerConsumption();
        public abstract string Performance();
    }
    
    public class GamerOS: OS
    {
        public override string StartSystem()
        {
            return "GamerOS: Start system is fast";
        }
        public override string PowerConsumption()
        {
            return "GamerOS: Power consumption is rather high";
        }
        public override string Performance()
        {
            return "GamerOS: Performance is pretty good";
        }
    }

    public class OfficeOS : OS
    {
        public override string StartSystem()
        {
            return "OfficeOS: Start system is slow";
        }
        public override string PowerConsumption()
        {
            return "OfficeOS: Power consumption is low";
        }
        public override string Performance()
        {
            return "OfficeOS: Performance is not so good";
        }
    }
}
