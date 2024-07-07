using DesignPatterns.ObjectRelations;

namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility.v1;

internal class ChainOfResponsibilityClient : Separator
{
    public new void Run()
    {
        var monkeyHandler = new MonkeyHandler();
        var squirrelHandler = new SquirrelHandler();

        monkeyHandler.SetNext(squirrelHandler);

        Console.WriteLine(monkeyHandler.Handle("Banana"));
        Console.WriteLine(monkeyHandler.Handle("Nut"));

        base.Run();
    }
}
