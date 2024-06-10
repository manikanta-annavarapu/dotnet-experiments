using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAndNewPolymorphism
{
    internal class WarningState
    {
        class A
        {
            public virtual void Test() { Console.WriteLine("A::Test()"); }
        }

        class B : A
        {
            // A warning will be shown here
            // 'WarningState.B.Test()' hides inherited member 'WarningState.A.Test()'. To make the current method override that implementation, add the override keyword. Otherwise add the new keyword.
            // irrespective of whether virtual keyword is used in the base class (or current class) or not.
            public virtual void Test() { Console.WriteLine("B::Test()"); }
        }

        class C : B
        {
            public virtual void Test() { Console.WriteLine("C::Test()"); }
        }

        class B2MethodHiding : A
        {
            
            public new void Test() { Console.WriteLine("B2MethodHiding::Test()"); }
        }

        class C2 : B2MethodHiding
        {
            //'WarningState.C2.Test()' : cannot override inherited member 'WarningState.B2.Test()' because it is not marked "virtual", "abstract", or "override"
            //public override void Test() { Console.WriteLine("C2::Test()"); }
        }

        class C3 : A
        {
            public override void Test() { Console.WriteLine("C3::Test()"); }
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
            a.Test(); // A::Test()

            b = new C();
            b.Test(); // B::Test()


            B2MethodHiding b2MethodHiding = new B2MethodHiding();
            b2MethodHiding.Test(); // B2MethodHiding::Test()

            a = new B2MethodHiding();
            a.Test(); // A::Test()
        }
    }
}
