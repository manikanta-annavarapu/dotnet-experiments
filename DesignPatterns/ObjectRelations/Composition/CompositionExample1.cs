namespace DesignPatterns.ObjectRelations.Composition;

internal class CompositionExample1 : Separator
{
    public new void Run()
    {
        Console.WriteLine("This is Composition Example");
        var house = new House();
        house.AddRoom("Living Room");
        house.AddRoom("Kitchen");
        house.AddRoom("Bedroom");

        Console.WriteLine("Rooms in the house:");
        house.Rooms.ForEach(room => Console.WriteLine($"Room: {room.Name}"));
        // Room: Living Room
        // Room: Kitchen
        // Room: Bedroom

        // As house contains room, if the house object is deleted then the room objects will also be deleted.
        base.Run();
    }
}

public class House
{
    public List<Room> Rooms { get; set; }

    public House()
    {
        Rooms = new List<Room>();
    }

    public void AddRoom(string name)
    {
        Rooms.Add(new Room(name));
    }
}

public class Room
{
    public string Name { get; set; }

    public Room(string name)
    {
        Name = name;
    }
}

