namespace DesignPatterns.ObjectRelations.Dependency;

internal class DependencyExample1 : Separator
{
    public new void Run()
    {
        Console.WriteLine("This is Dependency Example");
        Console.WriteLine("Here the Service class is depends on Logger class to log messages");
        var logger = new Logger();
        var service = new Service(logger);
        service.PerformOperation();
        // Operation performed.
        base.Run();
    }
}

public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class Service
{
    private readonly Logger _logger;

    public Service(Logger logger)
    {
        _logger = logger;
    }

    public void PerformOperation()
    {
        _logger.Log("Operation performed.");
    }
}
