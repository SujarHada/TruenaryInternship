namespace DesignPatterns;

public abstract class Cake
{
    public abstract string getDescription();
    public abstract int price();

}

public class basecake : Cake
{
    public override string getDescription()
    {
        return "It's a Basic Cake";
    }

    public override int price()
    {
        return 500;
    }
}

public abstract class CakeDecorator : Cake
{

    protected Cake _cake;
    
    public CakeDecorator(Cake cake) {
        _cake = cake;
    }

    public override string getDescription() {
        return _cake.getDescription();
    }

    public override int price() {
        return _cake.price();
    }
}

public class chocolateCake : CakeDecorator
{
    public chocolateCake(Cake cake) : base(cake)
    {
        _cake = cake;
        
    }
    
    public override string getDescription() {
        
        return "chocolate cake";
    }

    public override int price() {
        return _cake.price() + 200;
    }
}