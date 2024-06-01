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
        }

        public void Run()
        {
            A a = new A();
            a.Test();
            B b = new B();
            b.Test();
            C c = new C();
            c.Test();

            a = new B();
            a.Test();

            b = new C();
            b.Test(); // 

        }
    }
}
