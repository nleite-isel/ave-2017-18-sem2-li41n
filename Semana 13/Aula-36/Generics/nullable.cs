
using System;
using System.Collections.Generic;


struct V { 
	public int val; 
}



class Test
{
	static void Main() {
	/*
		Nullable<int> a = null;
		Nullable<int> b = 3;

		int? c = null;
		int? d = 5;
		b += d;                // b <- 8
		d = a + b;             // d <- null   (porque a vale null)

		int e = (int)b;        // e <- 8
		//int f = (int)c;        // excepção    (porque c vale null)

		int g = c ?? -1;       // g <- -1     (porque c vale null)
		int h = a ?? c ?? 0;   // h <- 0 (porque a e c valem null)
		int h1 = (a ?? (c ?? 0));  // h <- 0 (porque a e c valem null)
	  
	  
		Console.WriteLine("a = " + a);
		Console.WriteLine("b = " + b);
		Console.WriteLine("c = " + c);
		Console.WriteLine("d = " + d);
		Console.WriteLine("e = " + e);
		Console.WriteLine("g = " + g);
		Console.WriteLine("h = " + h);
		Console.WriteLine("h1 = " + h1);

        if (b == null)
            Console.WriteLine("b is null");
        else
            Console.WriteLine("b is not null");
*/

		// Working with custom value types

        V? nullableV = null;
		object oV = nullableV;
		V v = (V)oV; // Excepção NullReferenceException
		Console.WriteLine(v.val);
		//////////////////////////////////////////////
		
		/*
		V? nv = new V();
		V v = (V)nv;
		v.val = 10;
        object o1 = nv;
		object o = v;
        
		Console.WriteLine(nv);
        Console.WriteLine(o);

        Console.WriteLine(o.GetType());
		
		V unboxV = (V)o;
		Console.WriteLine(unboxV.val);
		
		V unboxNullV = (V)o1;
		Console.WriteLine(unboxNullV.val);
	
		V? unboxNullV1 = (V?)o1;
		Console.WriteLine(unboxNullV1.Value.val);
		*/
	}
}