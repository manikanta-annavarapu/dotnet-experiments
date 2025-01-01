namespace DesignPatterns.Patterns.Creational.FactoryPattern;

internal class FactoryPattern
{
    

    public void Run()
    {
        Client client = new Client(new TransportFactory());
        var roadShipmentDetails = new ShipmentDetails { NumberOfShipmentToDeliver = 2, PlacesToVisit = new List<string> { "Hyderabad", "Bangalore" } };
        var seaShipmentDetails = new ShipmentDetails { NumberOfShipmentToDeliver = 1, PlacesToVisit = new List<string> { "Dubai" } };
        var airShipmentDetails = new ShipmentDetails { NumberOfShipmentToDeliver = 3, PlacesToVisit = new List<string> { "London", "Sweden", "New York" } };
        var railShipmentDetails = new ShipmentDetails { NumberOfShipmentToDeliver = 1, PlacesToVisit = new List<string> { "Mumbai" } };

        client.TransportShipment(TransportType.Truck, roadShipmentDetails);
        client.TransportShipment(TransportType.Ship, seaShipmentDetails);
        client.TransportShipment(TransportType.Plane, airShipmentDetails);
        client.TransportShipment(TransportType.Train, railShipmentDetails);
    }
}

public enum TransportType
{
    Truck,
    Ship,
    Plane,
    Train
}

public class Client
{
    private readonly TransportFactory _transportFactory;

    public Client(TransportFactory transportFactory)
    {
        _transportFactory = transportFactory;
    }

    public void TransportShipment(TransportType transportType, ShipmentDetails shipmentDetails)
    {
        Transport transport = _transportFactory.CreateTransport(transportType, shipmentDetails);
        transport.DeliverShipment();
    }
}

public abstract class Transport
{
    protected int _NumberOfShipmentToDeliver { get; }
    protected readonly List<string> _PlacesToVisit;

    public Transport(int numberOfShipmentToDeliver, List<string> placesToVisit)
    {
        _NumberOfShipmentToDeliver = numberOfShipmentToDeliver;
        _PlacesToVisit = placesToVisit;
    }

    public abstract void DeliverShipment();
}

public class ShipmentDetails
{
    public int NumberOfShipmentToDeliver { get; set; }
    public List<string> PlacesToVisit { get; set; }
}

public class Truck : Transport
{
    private readonly string _RoadMapDetails;

    public Truck(int numberOfShipmentToDeliver, List<string> placesToVisit, string roadMapDetails) : base(numberOfShipmentToDeliver, placesToVisit)
    {
        _RoadMapDetails = roadMapDetails;
    }

    public override void DeliverShipment()
    {
        // Implementation for delivering shipment by truck
        Console.WriteLine($"Delivering {_NumberOfShipmentToDeliver} shipments by truck to {string.Join(", ", _PlacesToVisit)} using {_RoadMapDetails}");
    }
}

public class Ship : Transport
{
    private readonly string _SeaMapDetails;

    public Ship(int numberOfShipmentToDeliver, List<string> placesToVisit, string seaMapDetails) : base(numberOfShipmentToDeliver, placesToVisit)
    {
        _SeaMapDetails = seaMapDetails;
    }

    public override void DeliverShipment()
    {
        // Implementation for delivering shipment by truck
        Console.WriteLine($"Delivering {_NumberOfShipmentToDeliver} shipments by ship to {string.Join(", ", _PlacesToVisit)} using {_SeaMapDetails}");
    }
}

public class Plane : Transport
{
    private readonly string _AirMapDetails;

    public Plane(int numberOfShipmentToDeliver, List<string> placesToVisit, string airMapDetails) : base(numberOfShipmentToDeliver, placesToVisit)
    {
        _AirMapDetails = airMapDetails;
    }

    public override void DeliverShipment()
    {
        // Implementation for delivering shipment by truck
        Console.WriteLine($"Delivering {_NumberOfShipmentToDeliver} shipments by plane to {string.Join(", ", _PlacesToVisit)} using {_AirMapDetails}");
    }
}

public class Train : Transport
{
    private readonly string _RailMapDetails;

    public Train(int numberOfShipmentToDeliver, List<string> placesToVisit, string railMapDetails) : base(numberOfShipmentToDeliver, placesToVisit)
    {
        _RailMapDetails = railMapDetails;
    }

    public override void DeliverShipment()
    {
        // Implementation for delivering shipment by truck
        Console.WriteLine($"Delivering {_NumberOfShipmentToDeliver} shipments by train to {string.Join(", ", _PlacesToVisit)} using {_RailMapDetails}");
    }
}

public class TransportFactory
{
    public Transport CreateTransport(TransportType transportType, ShipmentDetails shipmentDetails)
    {
        return transportType switch
        {
            TransportType.Truck => new Truck(shipmentDetails.NumberOfShipmentToDeliver, shipmentDetails.PlacesToVisit, "Road Route"),
            TransportType.Ship => new Ship(shipmentDetails.NumberOfShipmentToDeliver, shipmentDetails.PlacesToVisit, "Sea Route"),
            TransportType.Plane => new Plane(shipmentDetails.NumberOfShipmentToDeliver, shipmentDetails.PlacesToVisit, "Air Route"),
            TransportType.Train => new Train(shipmentDetails.NumberOfShipmentToDeliver, shipmentDetails.PlacesToVisit, "Rail Route"),
            _ => throw new ArgumentException("Invalid transport type")
        };
    }
}
