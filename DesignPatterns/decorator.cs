namespace DesignPatterns;

// Component interface
public interface IBeverage
{
    string Description { get; }
    decimal Cost();
}

// Concrete component
public class Espresso : IBeverage
{
    public string Description { get; } = "Espresso";

    public decimal Cost() => 1.99m;
}

// Decorator abstract class
public abstract class CondimentDecorator : IBeverage
{
    protected IBeverage _beverage;

    public CondimentDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public abstract string Description { get; }

    public abstract decimal Cost();
}

// Concrete decorator
public class Milk : CondimentDecorator
{
    public Milk(IBeverage beverage) : base(beverage) { }

    public override string Description => _beverage.Description + ", Milk";

    public override decimal Cost() => _beverage.Cost() + 0.50m;
}
