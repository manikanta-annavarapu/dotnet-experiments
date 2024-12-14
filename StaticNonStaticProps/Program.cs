using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create instances of MyClass
        var obj1 = new DummyClass("Object1");
        var obj2 = new DummyClass("Object2");

        // Output the current object count
        Console.WriteLine($"Current object count: {MyClass.ObjectCount}"); // Output: 2

        // Output the names of all objects
        Console.WriteLine("Names of all objects:");
        foreach (var name in MyClass.Names)
        {
            Console.WriteLine(name);
        }

        // Dispose of one instance
        obj1 = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        // Output the current object count
        Console.WriteLine($"Current object count: {MyClass.ObjectCount}"); // Output: 1

        // Output the names of all objects
        Console.WriteLine("Names of all objects:");
        foreach (var name in MyClass.Names)
        {
            Console.WriteLine(name);
        }

    }

    public class Obbb
    {
        public int Prop1 { get; set; }
        public List<int> ArrProp1 { get; set; }

        public override string ToString()
        {
            string arr = "";
            ArrProp1.ForEach((x) => arr = arr + $"{x}, ");
            return $"Prop1: {Prop1} | ArrProp1: " + arr;
        }
    }

    public class DummyClass : MyClass
    {

        public DummyClass(string name) : base(name) { }
    }

    public abstract class MyClass
    {
        // Static field to maintain the object count
        private static int _objectCount = 0;

        // Static list to store the names of all objects
        private static List<string> _names = new List<string>();

        // Static property to get the current object count
        public static int ObjectCount => _objectCount;

        // Static property to get the list of names
        public static IReadOnlyList<string> Names => _names.AsReadOnly();

        // Property to store the name of the object
        public string Name { get; }

        // Constructor
        public MyClass(string name)
        {
            Name = name;
            _objectCount++;
            _names.Add(name);
        }

        // Destructor to decrement the object count and remove the name when an instance is destroyed
        ~MyClass()
        {
            _objectCount--;
            _names.Remove(Name);
        }
    }

}