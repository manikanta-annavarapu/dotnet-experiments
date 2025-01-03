﻿// See https://aka.ms/new-console-template for more information
using DesignPatterns.ObjectRelations;
using DesignPatterns.ObjectRelations.Aggregation;
using DesignPatterns.ObjectRelations.Composition;
using DesignPatterns.ObjectRelations.Dependency;
using DesignPatterns.Patterns.Behavioral.ChainOfResponsibility.v1;
using DesignPatterns.Patterns.Creational.FactoryPattern;
using DesignPatterns.Patterns.Creational.Singleton;

// Object Relations

// Aggregation
AggregationExample1 aggregationExample1 = new AggregationExample1();
aggregationExample1.Run();

// Association
AssociationExample1 associationExample1 = new AssociationExample1();
associationExample1.Run();

// Composition
CompositionExample1 compositionExample1 = new CompositionExample1();
compositionExample1.Run();

// Composition
DependencyExample1 dependencyExample1 = new DependencyExample1();
dependencyExample1.Run();

DependencyExample2 dependencyAsMethodParameterExample = new DependencyExample2();
dependencyAsMethodParameterExample.Run();

// Chain of Responsibility
ChainOfResponsibilityClient chainOfResponsibilityClient = new ChainOfResponsibilityClient();
chainOfResponsibilityClient.Run();

// Singleton Pattern
NotThreadSafeSingleton notThreadSafeSingleton1 = NotThreadSafeSingleton.Instance;
NotThreadSafeSingleton notThreadSafeSingleton2 = NotThreadSafeSingleton.Instance;

if (notThreadSafeSingleton1 == notThreadSafeSingleton2)
{
    Console.WriteLine("NotThreadSafeSingleton is a Singleton.");
}
else
{
    Console.WriteLine("NotThreadSafeSingleton is not a Singleton.");
}

new Separator().Run();

SimpleThreadSafeSingleton simpleThreadSafeSingleton1 = SimpleThreadSafeSingleton.Instance;
SimpleThreadSafeSingleton simpleThreadSafeSingleton2 = SimpleThreadSafeSingleton.Instance;

if (notThreadSafeSingleton1 == notThreadSafeSingleton2)
{
    Console.WriteLine("SimpleThreadSafeSingleton is a Singleton.");
}
else
{
    Console.WriteLine("SimpleThreadSafeSingleton is not a Singleton.");
}

new Separator().Run();

DoubleCheckLockingSingleton doubleCheckLockingSingleton1 = DoubleCheckLockingSingleton.Instance;
DoubleCheckLockingSingleton doubleCheckLockingSingleton2 = DoubleCheckLockingSingleton.Instance;

if (notThreadSafeSingleton1 == notThreadSafeSingleton2)
{
    Console.WriteLine("DoubleCheckLockingSingleton is a Singleton.");
}
else
{
    Console.WriteLine("DoubleCheckLockingSingleton is not a Singleton.");
}

new Separator().Run();

//Console.WriteLine(StaticSingleton.Counter); //observe the console output, when this line executes. It proofs this is not a lazy initialization.
//StaticSingleton staticSingleton1 = StaticSingleton.Instance;
//StaticSingleton staticSingleton2 = StaticSingleton.Instance;

//if (staticSingleton1 == staticSingleton2)
//{
//    Console.WriteLine("StaticSingleton is a Singleton.");
//}
//else
//{
//    Console.WriteLine("StaticSingleton is not a Singleton.");
//}

new Separator().Run();

// Factory Pattern Example

var factoryPattern = new FactoryPattern();
factoryPattern.Run();
