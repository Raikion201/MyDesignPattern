using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class PlascticFactory : AbstractFactory
    {
        public override Chair CreateChair()
        {
            return new PlasticChair();
        }

        public override Table CreateTable()
        {
            return new PlasticTable();
        }
    }
}
