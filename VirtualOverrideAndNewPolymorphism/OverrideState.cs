using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAndNewPolymorphism
{
    internal class OverrideState
    {
        class A
        {
            public virtual void Test() { Console.WriteLine("A::Test()"); }
        }

        class B : A
        {
            public override void Test() { Console.WriteLine("B::Test()"); }
        }

        class C : B
        {
            public override void Test() { Console.WriteLine("C::Test()"); }
            public void Test2() { Console.WriteLine("C::Test2()"); }
        }

        public void Run()
        {
            A a = new A();
            a.Test(); // A::Test()
            B b = new B();
            b.Test(); // B::Test()
            C c = new C();
            c.Test(); // C::Test()

            a = new B();
            a.Test(); // B::Test()

            b = new C();
            b.Test(); // C::Test()

            a = new C();
            a.Test(); // C::Test()

            a = new C();
            //a.Test2(); // Compile error class does not contain a definition of Test2  and has not extensible method of Test2 which takes A as a first argument.

        }
    }
}
