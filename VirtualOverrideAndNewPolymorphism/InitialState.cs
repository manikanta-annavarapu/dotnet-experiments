using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAndNewPolymorphism
{
    
    internal class InitialState
    {
        class A
        {
            public void Test() { Console.WriteLine("A::Test()"); }
        }

        class B : A { }
        class C : B { }

        public void Run()
        {
            A a = new A();
            a.Test();
            B b = new B();
            b.Test();
            C c = new C();
            c.Test();

        }
    }

    
}
