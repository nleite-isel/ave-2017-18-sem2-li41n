using System;
using System.Collections.Generic;
using System.Text;

namespace Equals
{
    class Point2D
    {
        private int x, y;

		public Point2D(int x, int y) { this.x = x; this.y = y; }
		
        public override bool Equals(object obj)
        {
			Console.WriteLine("Point2D::Equals");
			
            if (obj == null) return false;

			Console.WriteLine("[Point2D] Testing if it's same object");
			// Se referem o mesmo objecto -> true
            // if (this == obj) return true; // Problema: se operator== está redefinido.
            if (Object.ReferenceEquals(this, obj)) return true;

			Console.WriteLine("[Point2D] They aren't the same object");
			
			Console.WriteLine("[Point2D] Testing if types are of the same type");
			Console.WriteLine("[Point2D] (obj.GetType() == this.GetType()) - " + obj.GetType() + " " + this.GetType() );
            //if (obj is Point2D) // Teste de compatibilidade - Não funciona sempre -> Ver Exemplo 2 abaixo
            if (obj.GetType() == typeof(Point2D)) // Errado, Não funciona com classes derivadas -> Ver Exemplo 2 abaixo. Deve ser substituído por:
			// if (obj.GetType() == this.GetType()) // OK, Testa o tipo exacto
            {
				
                Point2D p = (Point2D)obj;
                return x == p.x && y == p.y;
            }
            return false;
        }

        // Overload do operator==
        public static bool operator==(Point2D p, Object o)
        {            
			Console.WriteLine("[Point2D] calling operator==");
			return false;
        }
        public static bool operator !=(Point2D p, Object o)
        {
            return !(p == o);
        }
    }
	
	sealed class Point3D : Point2D // Esta classe é sealed, não admite derivações
    {
        private int z; // Adiciona 3ª dimensão
		
		public Point3D(int x, int y, int z) : base(x,y) { this.z = z; }
		
        public override bool Equals(object obj)
        {
			Console.WriteLine("Point3D::Equals");
			
            if (obj == null) return false;

			Console.WriteLine("[Point3D] Testing if it's same object");
			// Se referem o mesmo objecto -> true
            if (Object.ReferenceEquals(this, obj)) 
				return true;

			Console.WriteLine("[Point3D] Testing if inherited fields are equal");
			// Verificar se campos herdados são iguais
			if (!base.Equals(obj))
				return false;

			Console.WriteLine("[Point3D] Testing if types are compatible");
			Console.WriteLine("[Point3D] (obj.GetType() == this.GetType()) - " + obj.GetType() + " " + this.GetType() );
            // if (obj.GetType() == typeof(Point3D)) // Aqui pode usar typeof pois a classe Point3D é sealed
			if (obj.GetType() == this.GetType()) // OK
			// Poderia usar-se o operador as em alternativa.
            {
				Point3D p = (Point3D)obj;
                return z == p.z;
            }

            return false;
        }
	}
	
	

    class Program
    {
        static void Main1(string[] args)
        {
			///////////////////////////////////////////////////
			// Exemplo 1
			//
			Point2D pp = new Point2D(1, 2);
            // Console.WriteLine(pp.Equals(pp));
			// Point2D pp2 = new Point2D(1, 2);
            // Console.WriteLine(pp.Equals(pp2));
			// ==================
            Point3D p = new Point3D(1, 2, 3);
            // Console.WriteLine(p.Equals(p)); // Same object
			
			///////////////////////////////////////////////////
			// Exemplo 2
			//
			// PROBLEMA:
            Console.WriteLine("Exemplo 3");
			Console.WriteLine("Comparing Point2D with Point3 with equal common content");
			Console.WriteLine(pp.Equals(p)); // Comparing Point2D with Point3 with equal common content
			// Operator is fails
			
			Console.WriteLine("Comparing Point2D with Point3 with equal common content -> reverse order");
			Console.WriteLine(p.Equals(pp)); // Comparing Point2D with Point3 with equal common content

            ///////////////////////////////////////////////////
            // Exemplo 3
            //
            // PROBLEMA:
            Console.WriteLine("Exemplo 3");
            Point3D p2 = new Point3D(1, 2, 3);
            Console.WriteLine(p.Equals(p2)); // different objects with same content

            // Point3D p2 = new Point3D(1, 1, 3);
            // Console.WriteLine(p.Equals(p2)); // different objects with different content

            // Console.WriteLine();
            // Console.WriteLine("p.Equals(new object())");
            // Console.WriteLine(p.Equals(new object()));

            // Console.WriteLine();
            // Console.WriteLine("new object().Equals(p)");
            // Console.WriteLine(new object().Equals(p));

			
			
        }
    }
}
