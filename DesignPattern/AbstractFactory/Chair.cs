using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public abstract class Chair
    {
      public abstract void create();
    }


    public class PlasticChair : Chair
    {
        public override void create()
        {
            Console.WriteLine("Plastic Chair Created");
        }
    }

    public class WoodChair : Chair
    {
        public override void create()
        {
            Console.WriteLine("Wood Chair Created");
        }
    }
}
