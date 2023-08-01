using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Chair CreateChair();
        public abstract Table CreateTable();

    }
}
