

using DesignPattern;
using DesignPattern.Creational.AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        AbstractFactory factory = SuperFactory.getFactory("PLASTIC");

        Chair plasticChair = factory.CreateChair();
        plasticChair.create();
    }
}