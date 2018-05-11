
using System;


delegate int DT(int i);

class Del {
    private int val;
    public Del(int i) { val = i; }

    public static int f1(int i) {
		Console.WriteLine("f1 called, i={0}", i);
		return i + 10;
	}

	public static int f2(int i) {
		Console.WriteLine("f2 called, i={0}", i);
		return i*2;
	}

	public int instance(int i) {
		Console.WriteLine("Instance called: i= {0}, this.val={1}", i, this.val);
        return this.val-i;
	}
	
	
	public static void Main() {
		DT pipe = Del.f1;
		pipe += Del.f2;
		pipe += new Del(2).instance;
		
		int initial = 10;
		int r = pipe(initial);
		Console.WriteLine(r); // -8, nao funciona correctamente
		
		r = initial;
		foreach (DT del in pipe.GetInvocationList()) {
			r = del(r);
		}
		Console.WriteLine(r); // -38, OK
			
	}
}