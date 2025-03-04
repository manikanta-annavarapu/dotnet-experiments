namespace DesignPatterns.ObjectRelations.Dependency;

internal class DependencyExample2 : Separator
{
    public new void Run()
    {
        Console.WriteLine("This is Dependency in a Method Parameter Example");
        Console.WriteLine("Here, the PaymentProcessor class depends on the PaymentGateway class to process payments. The dependency is established when the PaymentGateway instance is passed as a parameter to the ProcessPayment method.");
        var logger = new Logger();

        var gateway = new PaymentGateway();
        var processor = new PaymentProcessor();
        processor.ProcessPayment(gateway, 100);
        base.Run();
    }
}

public class PaymentGateway
{
    public void ProcessPayment(decimal amount)
    {
        // `:C` is a currency formatter based on the culture setting 
        // CultureInfo currentCulture = CultureInfo.CurrentCulture;
        // Console.WriteLine($"Current Culture: {currentCulture.Name}");
        // Console.WriteLine($"Currency Symbol: {currentCulture.NumberFormat.CurrencySymbol}");
        Console.WriteLine($"Processing payment of {amount:C}");
    }
}

public class PaymentProcessor
{
    public void ProcessPayment(PaymentGateway gateway, decimal amount)
    {
        gateway.ProcessPayment(amount);
    }
}

