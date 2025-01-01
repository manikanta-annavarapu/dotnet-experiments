namespace DesignPatterns.Patterns.Creational.FactoryPattern;

internal class FactoryPatternExample
{
    public void Run()
    {
        CrustPizza margherita = PizzaFactory.CreatePizza("margherita");
        margherita.Prepare();
        CrustPizza bbqChicken = PizzaFactory.CreatePizza("bbqchicken");
        bbqChicken.Prepare();
    }
}

public class PizzaFactory
{
    public static CrustPizza CreatePizza(string type)
    {
        return type.ToLower() switch
        {
            "margherita" => new MargheritaPizza(),
            "bbqchicken" => new BbqChickenPizza(),
            _ => throw new ArgumentException("Invalid pizza type")
        };
    }
}


public abstract class CrustPizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public List<string> Toppings { get; set; }

    public abstract void Prepare();
}

public class MargheritaPizza : CrustPizza
{
    public MargheritaPizza()
    {
        Name = "Margherita";
        Dough = "Thin Crust";
        Toppings = new List<string> { "Tomato Sauce", "Cheese" };
    }

    public override void Prepare() => Console.WriteLine($"Preparing {Name} with {string.Join(", ", Toppings)}");
}

public class BbqChickenPizza : CrustPizza
{
    public BbqChickenPizza()
    {
        Name = "BBQ Chicken";
        Dough = "Pan Crust";
        Toppings = new List<string> { "BBQ Sauce", "Chicken", "Onions", "Cheese" };
    }

    public override void Prepare() => Console.WriteLine($"Preparing {Name} with {string.Join(", ", Toppings)}");
}
