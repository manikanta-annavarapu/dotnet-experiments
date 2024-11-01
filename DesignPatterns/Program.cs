// See https://aka.ms/new-console-template for more information
using DesignPatterns.ObjectRelations.Aggregation;
using DesignPatterns.ObjectRelations.Composition;
using DesignPatterns.Patterns.Behavioral.ChainOfResponsibility.v1;

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

// Chain of Responsibility
ChainOfResponsibilityClient chainOfResponsibilityClient = new ChainOfResponsibilityClient();
chainOfResponsibilityClient.Run();