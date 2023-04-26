namespace DesignPatterns;

public class pizza
{
    public string toppings { get; set; }

    public void display()
    {
        Console.WriteLine($"{toppings}");
    }
}

public class nepalipizzabuilder
{
    
    public pizza _pizza;
    
    public nepalipizzabuilder()
    {
        _pizza = new pizza();
    }
    public void addtoppings()
    {
        _pizza.toppings = "asd";
    }

    public pizza returnpizza()
    {
        return _pizza;
    }
  
}

public class pizzamaker
{
    public nepalipizzabuilder builder;
    
    public pizzamaker(nepalipizzabuilder xyz)
    {
        builder = xyz;
    }

    public void makepizza()
    {
        builder.addtoppings();
    }

    public pizza returnfood()
    {
        return builder.returnpizza();
    }
    

    
}