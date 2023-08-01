using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public abstract class Table
    {
        public abstract void create();
    }

    public class PlasticTable : Table
    {
        public override void create()
        {
            Console.WriteLine("Plastic Table Created");
        }
    }

    public class WoodTable : Table
    {
        public override void create()
        {
            Console.WriteLine("Wood Table Created");
        }
    }
}
