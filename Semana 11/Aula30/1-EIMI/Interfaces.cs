using System;

namespace MyInterfaces
{
    interface I
    {
        void M();
    }

    public class A : I
    {
        public void M() { Console.WriteLine("A:M"); }
        // .method public hidebysig newslot virtual final 
        //    instance void M()
    }

    public class B : A // 1
    // Cenario 1:
    // .class public auto ansi beforefieldinit MyInterfaces.B
    //   extends MyInterfaces.A
    //public class B : A, I  // 2
    // Cenario 2:
    //    .class public auto ansi beforefieldinit MyInterfaces.B
    //   extends MyInterfaces.A
    //   implements MyInterfaces.I
    { 
        public new void M() { Console.WriteLine("B:M"); }
        // Cenario 1:
        // .method public hidebysig instance void M() // NAO VIRTUAL
        // Cenario 2:
        // .method public hidebysig newslot virtual final instance void M()
    }

    public sealed class Program
    {
        public static void Main1()
        {
            I i = new B();
            i.M(); // Usando // 1 -> A:M, callvirt instance void MyInterfaces.I::M() 
            // Usando // 2 -> B:M, callvirt instance void MyInterfaces.I::M()

            A a = (A)i;
            a.M(); // A::M, callvirt instance void MyInterfaces.A::M()

            B b = (B)i;
            b.M(); // B::M, callvirt instance void MyInterfaces.B::M()

        }
    }
}
/*
Cenario 1
A:M
A:M
B:M

Cenario 2
B:M
A:M
B:M

*/ 