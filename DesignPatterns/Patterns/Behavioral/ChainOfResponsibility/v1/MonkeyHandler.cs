namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility.v1;

internal class MonkeyHandler : AbstractHandler<string>
{
    public override string Handle(string? request)
    {
        if (request == "Banana")
        {
            return $"Monkey: I'll eat the {request}.";
        }
        else
        {
            return base.Handle(request);
        }
    }
}
