


class Program
{
    static void Main(string[] args)
    {
        var car = new CarBuilder()
                .SetMake("Honda")
                .SetModel("Civic")
                .SetYear(2022)
                .SetColor("Red")
                .Build();
    }
}