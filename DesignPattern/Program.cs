

using DesignPattern;
using DesignPattern.AbstractFactory;


class Program
{
    static void Main(string[] args)
    {
        AbstractFactory factory = SuperFactory.getFactory("PLASTIC");

        Chair plasticChair = factory.CreateChair();
        plasticChair.create();
    }
}