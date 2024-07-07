namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility.v1
{
    internal interface IHandler<T>
    {
        IHandler<T> SetNext(IHandler<T> handler);

        T? Handle(T? request);
    }
}
