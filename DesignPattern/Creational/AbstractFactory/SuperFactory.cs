using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class SuperFactory
    {
        private SuperFactory() { }
        public static AbstractFactory getFactory(string materialType)
        {
            switch (materialType)
            {
                case "PLASTIC":
                    return new PlascticFactory();
                case "WOOD":
                    return new WoodFactory();
                default:
                    throw new ArgumentException("No type");
            }
        }
    }
}
