using Newtonsoft.Json.Linq;
using FluentAssertions;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");

        var actual = new Actual();
        var expected = new Expected();
        var actualJT = JToken.FromObject(actual);
        var expectedJT = JToken.FromObject(expected);
        actualJT.Should().BeEquivalentTo(expectedJT);
    }


}

public class Actual
{
    public int Item1 { get; set; } = 1;
    public int Item2 { get; set; } = 2;

    public List<Subclass1> subclasses { get; set; } = new List<Subclass1> { new Subclass1() };
}

public class Subclass1
{
    public int Item1 { get; set; } = 1;
    public int Item2 { get; set; } = 2;
}

public class Expected
{
    public int Item1 { get; set; } = 1;
    public int Item2 { get; set; } = 2;
    public List<Subclass2> subclasses { get; set; } = new List<Subclass2> { new Subclass2() };

}

public class Subclass2
{
    public int Item1 { get; set; } = 1;
    //public int Item3 { get; set; } = 3;
}

