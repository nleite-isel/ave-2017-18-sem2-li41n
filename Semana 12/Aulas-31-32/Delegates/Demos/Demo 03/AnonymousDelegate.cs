
//using System;
//using System.Windows.Forms;
//using System.IO;


//internal delegate void Feedback(Int32 value);


//public sealed class Program {

//	int i;
	
//	// Se mudar o metodo para static o metodo anonimo passa a ser static
//	// e nao pode aceder (capturar) campos de instancia
//    //private void AnonymousDelegateDemo()
//	private static void AnonymousDelegateDemo() {
//		Console.WriteLine("----- Anonymous Delegate Demo -----");

//		// Sem captura de variaveis
//		Counter(1, 3, delegate(int value) {
//			Console.WriteLine("Item = " + value.ToString());
//		});
		
//        // Descomentar se usar metodo de instancia
//        // Captura de variaveis de instancia
//        //
//		// Counter(1, 3, delegate(int value) {
//			// Console.WriteLine("i = " + i + ", Item = " + value.ToString());
//		// });
		
//		Console.WriteLine();
//		/*
//		//Ou:
//		Feedback anonymous = delegate(int value) {
//			Console.WriteLine("Item = " + value);
//		};
		
//		Counter(1, 3, anonymous);
//		Console.WriteLine();
//		*/
//	}
	
//	// Se mudar o metodo para static, o metodo anonimo passa a ser static
//	// e nao pode aceder (capturar) campos de instancia
//	private static void AnonymousDelegateDemo(int parameter) {
//		Console.WriteLine("----- Anonymous Delegate Demo -----");
		
//		int loc = 10;
		
//		// Sem captura de variaveis de instancia
//		Counter(1, 3, delegate(int value) {
//			Console.WriteLine("Item = " + value.ToString());
//			Console.WriteLine(loc);
//			Console.WriteLine(parameter);
//		});
//	}
	
//	private static void Counter(Int32 from, Int32 to, Feedback fb) {
//		if (fb == null) return;
			
//		// If any callbacks are specified, call them
//		for (Int32 val = from; val <= to; val++)
//			fb(val); 
//			// fb.Invoke(val);
//	}
	

	
//    public static void Main1() {
//		// Program p = new Program();
//		// p.AnonymousDelegateDemo();
		
//		// Caso o metodo seja static
//		Program.AnonymousDelegateDemo();
//		Program.AnonymousDelegateDemo(99);
//	}
//}




