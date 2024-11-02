namespace DesignPatterns.Patterns.Creational.Singleton;

internal class SimpleThreadSafeSingleton
{
    private static SimpleThreadSafeSingleton? _instance = null;
    private static readonly object _lock = new object();

    private SimpleThreadSafeSingleton()
    {
    }

    public static SimpleThreadSafeSingleton Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SimpleThreadSafeSingleton();
                }
                return _instance;
            }
        }
    }
}
