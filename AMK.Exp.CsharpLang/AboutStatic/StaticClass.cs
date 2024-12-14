namespace AMK.Exp.CsharpLang.AboutStatic;

internal class StaticClass
{
    public static readonly int MyStaticValue;

    // Static constructor
    static StaticClass()
    {
        // No matter how many instances you create this will execute only once. when the first instance is created.
        MyStaticValue = 100; // Initialize static field
        Console.WriteLine("Static constructor called."); // print message when creating first instance or accessing static member like DisplayValue()
    }

    public StaticClass() : this(200)
    {
        Console.WriteLine("public constructor called");
    }

    private StaticClass(int value)
    {
        Console.WriteLine("private constructor called");
    }

    public static void DisplayValue()
    {
        Console.WriteLine($"Display Static Variable Value {MyStaticValue}");
    }
}
