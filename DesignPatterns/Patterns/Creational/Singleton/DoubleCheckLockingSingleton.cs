namespace DesignPatterns.Patterns.Creational.Singleton;

internal sealed class DoubleCheckLockingSingleton
{
    private static DoubleCheckLockingSingleton? instance = null;
    private static readonly object _lockObject = new object();

    private DoubleCheckLockingSingleton() { }

    public static DoubleCheckLockingSingleton Instance
    {
        get
        {
            if (instance is null)
            {
                lock (_lockObject)
                {
                    if (instance is null)
                    {
                        instance = new DoubleCheckLockingSingleton();
                    }
                }
            }
            return instance;
        }
    }
}
