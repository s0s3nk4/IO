public interface IPart
{
    string GetName();
}
public interface IEngine : IPart { }
public interface IWheels : IPart { }
public interface IInterior : IPart { }
public interface ITurbo : IPart { }
public interface INitro : IPart { }

public class Engine : IEngine
{
    public string GetName()
    {
        return "Volvo 2.4 R5";
    }
}

public class Wheels : IWheels
{
    public string GetName()
    {
        return "BBS Super RS 20'";
    }
}

public class Interior : IInterior
{
    public string GetName()
    {
        return "R - Line";
    }
}

public class Turbo : ITurbo
{
    public string GetName()
    {
        return "Garrett 880707-5006S";
    }
}

public class Nitro : INitro
{
    public string GetName()
    {
        return "Mokry zestaw nitro NX";
    }
}

public class Car
{
    private List<IPart> _parts = new List<IPart>();

    public void AddPart(IPart part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i].GetName() + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "Car parts: " + str + "\n";
    }
}

public interface ICarBuilder
{
    void BuildEngine();
    void BuildWheels();
    void BuildInterior();
    void BuildTurbo();
    void BuildNitro();
}

public class SportsCarBuilder : ICarBuilder
{
    private Car _car = new Car();

    public void BuildEngine()
    {
        _car.AddPart(new Engine());
    }

    public void BuildWheels()
    {
        _car.AddPart(new Wheels());
    }

    public void BuildInterior()
    {
        _car.AddPart(new Interior());
    }

    public void BuildTurbo()
    {
        _car.AddPart(new Turbo());
    }

    public void BuildNitro()
    {
        _car.AddPart(new Nitro());
    }

    public Car GetCar()
    {
        Car result = _car;
        Reset();
        return result;
    }

    public void Reset()
    {
        _car = new Car();
    }
}

public class CarDirector
{
    private ICarBuilder _builder;

    public ICarBuilder Builder
    {
        set { _builder = value; }
    }

    public void BuildCar()
    {
        _builder.BuildEngine();
        _builder.BuildWheels();
        _builder.BuildInterior();
    }

    public void BuildFasterCar()
    {
        _builder.BuildEngine();
        _builder.BuildWheels();
        _builder.BuildInterior();
        _builder.BuildTurbo();
        _builder.BuildNitro();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var director = new CarDirector();
        var sportsCarBuilder = new SportsCarBuilder();
        director.Builder = sportsCarBuilder;

        Console.WriteLine("Building a Sports Car:");
        director.BuildCar();
        Console.WriteLine(sportsCarBuilder.GetCar().ListParts());
        Console.WriteLine("Building a faster Sports Car:");
        director.BuildFasterCar();
        Console.WriteLine(sportsCarBuilder.GetCar().ListParts());

        Console.WriteLine("Custom Sports Car:");
        sportsCarBuilder.BuildEngine();
        sportsCarBuilder.BuildWheels();
        sportsCarBuilder.BuildInterior();
        sportsCarBuilder.BuildTurbo();
        Console.WriteLine(sportsCarBuilder.GetCar().ListParts());
    }
}