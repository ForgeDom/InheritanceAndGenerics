using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory
{
    public class Product
    {
        public interface IChair
        {
            string HasLegs();
            string SitOn();
            string Color();
        }

        public abstract class Chair : IChair
        {
            public abstract string HasLegs();
            public abstract string SitOn();
            public abstract string Color();
        }

        public class ModernChair : Chair
        {
            public override string HasLegs()
            {
                return "Modern chair does not have legs.";
            }
            public override string SitOn()
            {
                return "You can sit on the modern chair comfortably.";
            }
            public override string Color()
            {
                return "Modern chair is White";
            }
        }

        public class VictorianChair : Chair
        {
            public override string HasLegs()
            {
                return "Victorian chair has elegant wooden legs.";
            }
            public override string SitOn()
            {
                return "You can sit on the Victorian chair with great comfort.";
            }
            public override string Color()
            {
                return "Victorian chair is brown";
            }
        }

        public interface ISofa
        {
            string HasLegs();
            string LayOn();
            string Color();
        }

        public abstract class Sofa : ISofa
        {
            public abstract string HasLegs();
            public abstract string LayOn();
            public abstract string Color();
        }

        public class ModernSofa : Sofa
        {
            public override string HasLegs()
            {
                return "Modern sofa does not have legs.";
            }
            public override string LayOn()
            {
                return "You can lay on the modern sofa comfortably.";
            }
            public override string Color()
            {
                return "Modern sofa is black";
            }
        }

        public class VictorianSofa : Sofa
        {
            public override string HasLegs()
            {
                return "Victorian sofa has sturdy wooden legs.";
            }
            public override string LayOn()
            {
                return "You can lay on the Victorian sofa with great comfort.";
            }
            public override string Color()
            {
                return "Victorian sofa is brown";
            }
        }

        public interface ICoffeeTable
        {
            string HasLegs();
            string PutOn();
            string Color();
        }

        public abstract class CoffeeTable : ICoffeeTable
        {
            public abstract string HasLegs();
            public abstract string PutOn();
            public abstract string Color();
        }

        public class ModernCoffeeTable : CoffeeTable
        {
            public override string HasLegs()
            {
                return "Modern coffee table has sleek metal legs.";
            }
            public override string PutOn()
            {
                return "You can put items on the modern coffee table without worry.";
            }
            public override string Color()
            {
                return "Modern coffee table is black";
            }
        }

        public class VictorianCoffeeTable : CoffeeTable
        {
            public override string HasLegs()
            {
                return "Victorian coffee table has ornate wooden legs.";
            }
            public override string PutOn()
            {
                return "You can put items on the Victorian coffee table with style.";
            }
            public override string Color()
            {
                return "Victorian coffee table is brown";
            }
        }
    }
}
