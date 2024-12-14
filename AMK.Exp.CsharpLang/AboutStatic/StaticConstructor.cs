namespace AMK.Exp.CsharpLang.AboutStatic;

internal class StaticConstructor
{
    public static readonly int MyStaticValue;

    // Static constructor
    static StaticConstructor()
    {
        MyStaticValue = 100; // Initialize static field
        Console.WriteLine("Static constructor called.");
    }

    public static void DisplayValue()
    {
        Console.WriteLine($"The static value is {MyStaticValue}");
    }
}
