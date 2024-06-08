# Interview Questions

1. What are the advantages of OOPS?
   - Reuse of code through inheritance.
   - Flexibility Through polymorphism.
   - The principle of data hiding/ encapsulation helps the programmer to build secure programs.
   - OOP system can be easily upgraded from small to large systems.
   - Modularity for easier troubleshooting.

2. What are the limitations of OOPS?
   - disadvantages of OOPS is it is not suitable for small applications.

3. What are the different types of inheritance?
   - Single inheritance

   ```text

   [Derived class] -> [Base class]
   ```

   - Mutliple inhertiance

   ```text
   [Derived class] -> [Base class 1]
   [Derived class] -> [Base class 2] which is interface
   ```

   - Multi-level inheritance

   ```text
   [Derived class 2] -> [Derived class 1] -> [Base class]
   ```

   - Hierarchial Inheritance

   ```text
   [Derived class 1] -> [Base class]
   [Derived class 2] -> [Base class]
   [Derived class 3] -> [Base class]
   ```

4. How to prevent a class from being inherited?
   By using `sealed` keyword in class

   ```csharp
   sealed class BaseClass {}
   class DerivedClass : BaseClass {} //Invalid //Throws Complier Error
   ```

5. What is Polymorphism and what are its types?
   Polymorphism is the ability of a variable, object, or function to take on multiple forms.
   ✅ Compile Time Polymorphism is Overloading
   ✅ Runtime Polymorphism is Overriding

6. 