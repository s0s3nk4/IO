using System.Drawing;

public abstract class Porsche
{
    public abstract string GetDescription();
    public abstract decimal GetCost();
}
public class Seven18 : Porsche
{
    public override decimal GetCost()
    {
        return 287000m;
    }

    public override string GetDescription()
    {
        return "Porsche 718 Cayman";
    }
}
public class Nine11 : Porsche
{
    public override decimal GetCost()
    {
        return 611000m;
    }

    public override string GetDescription()
    {
        return "Porsche 911 Carrera";
    }
}

public class Cayenne : Porsche
{
    public override decimal GetCost()
    {
        return 447000m;
    }

    public override string GetDescription()
    {
        return "Porsche Cayenne";
    }
}

public class Macan : Porsche
{
    public override decimal GetCost()
    {
        return 298000m;
    }

    public override string GetDescription()
    {
        return "Porsche Macan";
    }
}

public class Panamera : Porsche
{
    public override decimal GetCost()
    {
        return 499000m;
    }

    public override string GetDescription()
    {
        return "Porsche Panamera";
    }
}

public class Taycan : Porsche
{
    public override decimal GetCost()
    {
        return 448000m;
    }

    public override string GetDescription()
    {
        return "Porsche Taycan";
    }
}

public abstract class PorscheConfig : Porsche
{
    protected Porsche _porsche;
    public PorscheConfig(Porsche porsche)
    {
        this._porsche = porsche;
    }
    public override string GetDescription()
    {
        if (this._porsche != null)
        {
            return this._porsche.GetDescription();
        }
        else
        {
            return string.Empty;
        }
    }
    public override decimal GetCost()
    {
        if (this._porsche != null)
        {
            return this._porsche.GetCost();
        }
        else
        {
            return 0m;
        }
    }
}
public class Package1 : PorscheConfig
{
    public Package1(Porsche porsche) : base(porsche)
    {
    }
    public override string GetDescription()
    {
        return $"{_porsche.GetDescription()} Exterior package with painted elements";
    }
    public override decimal GetCost()
    {
        return _porsche.GetCost() + 6672m;
    }
}

public class Package2 : PorscheConfig
{
    public Package2(Porsche porsche) : base(porsche)
    {
    }
    public override string GetDescription()
    {
        return $"{_porsche.GetDescription()} SportDesign Package";
    }
    public override decimal GetCost()
    {
        return _porsche.GetCost() + 12854m;
    }
}

public class Package3 : PorscheConfig
{
    public Package3(Porsche porsche) : base(porsche)
    {
    }
    public override string GetDescription()
    {
        return $"{_porsche.GetDescription()} SportDesign package with black painted elements (high gloss)";
    }
    public override decimal GetCost()
    {
        return _porsche.GetCost() + 15242m;
    }
}

public class Package4 : PorscheConfig
{
    public Package4(Porsche porsche) : base(porsche)
    {
    }
    public override string GetDescription()
    {
        return $"{_porsche.GetDescription()} Heritage Design Classic Package";
    }
    public override decimal GetCost()
    {
        return _porsche.GetCost() + 68588m;
    }
}

public class Package5 : PorscheConfig
{
    public Package5(Porsche porsche) : base(porsche)
    {
    }
    public override string GetDescription()
    {
        return $"{_porsche.GetDescription()} Heritage Design Pure Package";
    }
    public override decimal GetCost()
    {
        return _porsche.GetCost() + 68588m;
    }
}

public class Package6 : PorscheConfig
{
    public Package6(Porsche porsche) : base(porsche)
    {
    }
    public override string GetDescription()
    {
        return $"{_porsche.GetDescription()} Interior finished with Exclusive Manufaktur leather";
    }
    public override decimal GetCost()
    {
        return _porsche.GetCost() + 77892m;
    }
}

public class Package7 : PorscheConfig
{
    public Package7(Porsche porsche) : base(porsche)
    {
    }
    public override string GetDescription()
    {
        return $"{_porsche.GetDescription()} Off-road package with compass";
    }
    public override decimal GetCost()
    {
        return _porsche.GetCost() + 8821m;
    }
}

public class Package8 : PorscheConfig
{
    public Package8(Porsche porsche) : base(porsche)
    {
    }
    public override string GetDescription()
    {
        return $"{_porsche.GetDescription()} \"75 years\" package";
    }
    public override decimal GetCost()
    {
        return _porsche.GetCost() + 20799m;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("(Very)Simple Porsche Configurator\n");

        Porsche porsche = new Nine11();
        Console.WriteLine($"My first Porsche: {porsche.GetDescription()} - Cost: {porsche.GetCost():C}");

        Porsche porschePack3 = new Package3(new Macan());
        Console.WriteLine($"My second Porsche: {porschePack3.GetDescription()} - Cost: {porschePack3.GetCost():C}");

        Porsche porschePack5and7 = new Package7(new Package5(new Taycan()));
        Console.WriteLine($"My third Porsche: {porschePack5and7.GetDescription()} - Cost: {porschePack5and7.GetCost():C}");
    }
}