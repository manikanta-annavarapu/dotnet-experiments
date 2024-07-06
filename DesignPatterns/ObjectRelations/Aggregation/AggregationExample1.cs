namespace DesignPatterns.ObjectRelations.Aggregation;

internal class AggregationExample1
{
    public void Run()
    {
        var car = new Car("Toyota", "Corolla"); // Container object
        car.AddWheel(new Wheel("Front Left")); // Wheel is Component object
        car.AddWheel(new Wheel("Front Right")); // Wheel is Component object
        car.AddWheel(new Wheel("Rear Left")); // Wheel is Component object
        car.AddWheel(new Wheel("Rear Right")); // Wheel is Component object

        car.DisplayCarInfo(); 
        // Make: Toyota, Model: Corolla
        // Wheel: Front Left
        // Wheel: Front Right
        // Wheel: Rear Left
        // Wheel: Rear Right
    }
}

internal class  Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public List<Wheel> Wheels { get; set; }

    public Car(string make, string model)
    {
        Make = make;
        Model = model;
        Wheels = new List<Wheel>();
    }

    public void AddWheel(Wheel wheel)
    {
        Wheels.Add(wheel);
    }

    public void DisplayCarInfo()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}");
        foreach (var wheel in Wheels)
        {
            Console.WriteLine($"Wheel: {wheel.Position}");
        }
    }
}

internal class Wheel
{
    public string Position { get; set; }

    public Wheel(string position)
    {
        Position = position;
    }
}

