using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FabricMethod
{
    public class ClientCode
    {
        public void Main()
        {
            var gamer = new Gamer();
            Console.WriteLine("App: Launched with the GamerOS.");
            ClientMethod(gamer);

            var office = new Office();
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the OfficeOS.");
            ClientMethod(office);
        }

        public void ClientMethod(Creator creator)
        {
            Console.WriteLine(creator.StartSystemOperation());
            Console.WriteLine(creator.PowerConsumptionOperation());
            Console.WriteLine(creator.PerformanceOperation());
        }
    }
}
