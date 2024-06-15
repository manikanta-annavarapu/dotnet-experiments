
using System.ComponentModel;

namespace DesignPatterns.OOP
{
//    Abstraction is one of the fundamental principles of Object-Oriented Programming(OOP). It refers to the practice of hiding the complexity of a system and exposing only the essential features to the user.This helps in reducing complexity and increasing maintainability.
//In OOP, abstraction is achieved using abstract classes and interfaces.
//•	Abstract Classes: An abstract class is a class that cannot be instantiated and is always used as a base class. Abstract classes can have abstract methods(methods without a body) as well as non-abstract methods.
//•	Interfaces: An interface is a completely abstract class that contains only abstract methods.In C#, an interface can also include properties, events, and indexers.
//Here's an example to illustrate abstraction:

    internal class Abstraction
    {
    }

    public abstract class Animal
    {
        public abstract void MakeSound();

        public void Eat()
        {
            Console.WriteLine("The animal eats");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks");
        }
    }

    //In this example, Animal is an abstract class with an abstract method MakeSound(). The Dog class inherits from Animal and provides an implementation for MakeSound(). The complexity of how each animal makes a sound is hidden from the user, who only needs to call the MakeSound() method.This is abstraction.
}
