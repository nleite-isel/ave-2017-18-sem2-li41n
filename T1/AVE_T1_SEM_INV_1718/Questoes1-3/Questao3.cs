using System;
using System.Reflection;

namespace AVE_T1_SEM_INV_1718.Questoes13
{
    class Sammy : Attribute
    {
        public int Nr { get; set; }
    }

    class Game
    {
        [Sammy(Nr = 71)]
        public static int count;

        [Sammy(Nr = 67)]
        public int nr;
        //...
        //int Foo() { return 10; }
        public static int Foo() { return 10; }

    }


    public class Questao3
    {
        public static void Main1() 
        {
            // 3-(a)
            int nr = typeof(Game).GetField("count").GetCustomAttribute<Sammy>().Nr;
            Console.WriteLine("nr = " + nr);

            // 3-(b)
            int nr1 = typeof(Game).GetField("nr").GetCustomAttribute<Sammy>().Nr;
            Console.WriteLine("nr1 = " + nr1);

            // 3-(c)
            //[Sammy(Nr = Foo()] static int count;

            // 3-(d)
            //[Sammy(Nr = Foo()] int nr;
           
            // Even if it's static, an error is issued because
            // the call Game.Foo() is not resolved 
            // in compile time
            //[Sammy(Nr = Game.Foo()] int nr;

        }
    }
}
