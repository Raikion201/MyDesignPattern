using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class WoodFactory : AbstractFactory
    {
        public override Chair CreateChair()
        {
            return new WoodChair();
        }

        public override Table CreateTable()
        {
            return new WoodTable();

        }
    }
}
