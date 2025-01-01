namespace DesignPatterns.Patterns.Creational.FactoryPattern;

internal class NonFactoryPatternExample
{
    public void Run()
    {
        var margherita = new Pizza(
            "Margherita",
            "Thin Crust",
            new List<string> { "Tomato Sauce", "Cheese" }
        );
        var bbqChicken = new Pizza(
            "BBQ Chicken",
            "Pan Crust",
            new List<string> { "BBQ Sauce", "Chicken", "Onions", "Cheese" }
        );
    }
}

public class Pizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public List<string> Toppings { get; set; }

    public Pizza(string name, string dough, List<string> toppings)
    {
        Name = name;
        Dough = dough;
        Toppings = toppings;
    }
}
