public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Car(string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model} ({Color})";
    }
}

public class CarBuilder
{
    private string _make;
    private string _model;
    private int _year;
    private string _color;

    public CarBuilder SetMake(string make)
    {
        _make = make;
        return this;
    }

    public CarBuilder SetModel(string model)
    {
        _model = model;
        return this;
    }

    public CarBuilder SetYear(int year)
    {
        _year = year;
        return this;
    }

    public CarBuilder SetColor(string color)
    {
        _color = color;
        return this;
    }

    public Car Build()
    {
        return new Car(_make, _model, _year, _color);
    }
}