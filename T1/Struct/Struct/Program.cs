using System;

namespace Struct
{

    struct S {
        int i;
        //public S() { i = 1; }
        public S(int j) { i = j; }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            S s;
            S s1 = new S();
            S s2 = new S(10);
            //s.GetType();
            //s1.GetType();

        }
    }
}
