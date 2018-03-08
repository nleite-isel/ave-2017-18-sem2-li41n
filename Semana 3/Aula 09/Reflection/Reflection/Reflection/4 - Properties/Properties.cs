
using System;

public class Point {
	private double _x;
	private double _y;
	public double X { get { return _x; } }
	public double Y { get { return _y; } }
	
	public double _phase; // Coordenadas polares
			
	public double Phase
	{
		get { return _phase; }
		
		set { _phase = value; }
	}
		
	// Erro: n�o posso definir outra propriedade com o mesmo nome
	// public char Phase
	// {
		// get { return 'c'; }
		
		// set { }
	// }
		
	public double Abs 
	{
		get { return Math.Sqrt(_x*_x + _y*_y); }
		
		set {
			// Coordenadas polares
			double phase = Phase; // Phase: outra propriedade
			_x = value * Math.Cos(phase);
			_y = value * Math.Sin(phase);
		}
	}
}


public class Prog {
	public static void Main1() {
		Point p = new Point();
		p.Phase = Math.PI / 6; // � chamado o set de Phase passando no par�metro escondido value o valor 30 graus
		p.Abs = 10; // � chamado o set de Abs passando no par�metro escondido value o valor 10
		
		Console.WriteLine("p.x = " + p.X);  
		Console.WriteLine("p.y = " + p.Y);  
		
		Console.WriteLine("p.Phase = " + p.Phase);  
		Console.WriteLine("p.Abs = " + p.Abs);  
	}
}