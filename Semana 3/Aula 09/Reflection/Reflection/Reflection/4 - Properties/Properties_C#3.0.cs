using System;

namespace PropertiesCSharp3_0 {

	class Point {
		public Point() { X = 10; }

		public double X { get; } // Properties no C# 3.0. � criado automaticamente, pelo compilador, 
											  // um backing field associado � propriedade.
		public double Y { get; private set; }
		
		public double Phase { get; set; } // Coordenadas polares
				
		public double Abs 
		{
			get { return Math.Sqrt(X*X + Y*Y); }
			
			set {
				// Coordenadas polares
				double phase = Phase; // Phase: outra propriedade
//				X = value * Math.Cos(phase);
				Y = value * Math.Sin(phase);
			}
		}
	}


	public class Prog {
		public static void Main1() {
			Point p = new Point();
			p.Phase = Math.PI / 6; // � chamado o set de Phase passando no par�metro escondido value o valor 30 graus
			p.Abs = 10; // � chamado o set de Abs passando no par�metro escondido value o valor 10
			
			// p.Y = 10; // 
			
			Console.WriteLine("p.x = " + p.X);  
			Console.WriteLine("p.y = " + p.Y);  
			
			Console.WriteLine("p.Phase = " + p.Phase);  
			Console.WriteLine("p.Abs = " + p.Abs);  
		}
	}

}