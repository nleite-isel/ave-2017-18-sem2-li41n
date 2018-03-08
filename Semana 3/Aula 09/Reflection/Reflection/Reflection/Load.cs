﻿using System;
using System.Reflection;

namespace Reflection
{
	public sealed class Util {
		public static void UseType() {
			// get the type object
			Type type = typeof(Math);
			// get the underlying type handle
			RuntimeTypeHandle htype = type.TypeHandle;
			// recover the type object from the handle
			Type t2 = Type.GetTypeFromHandle(htype);
			// t2 and type now refer to the same System.Type object
			Console.WriteLine("type == t2: {0}", type == t2);

			// Show methods in Math class
			foreach (MethodInfo mi in type.GetMethods()) {
				Console.WriteLine(mi.Name);
			}

			// Print htype value (metadata token value)
			Console.WriteLine("htype: {0}", htype.Value);
		}


		public static void UseType1() {
			
			// load the assembly using implicit probing
			Assembly assm = Assembly.Load("mscorlib.dll");

			Type[] types = assm.GetTypes ();
			foreach (Type t in types) {
				Console.WriteLine (t.Name);
			}
				
			Console.WriteLine ();

			// get the type object
			Type type = assm.GetType("System.Math");
			// get the underlying type handle
			RuntimeTypeHandle htype = type.TypeHandle;
			// recover the type object from the handle
			Type t2 = Type.GetTypeFromHandle(htype);
			// t2 and type now refer to the same System.Type object
			Console.WriteLine("type == t2: {0}", type == t2);

			// Show methods in Math class
			foreach (MethodInfo mi in type.GetMethods()) {
				Console.WriteLine(mi.ToString());
			}

			// Print htype value (metadata token value)
			Console.WriteLine("htype: {0}", htype.Value);
			////////////////////////////////////////////////


			// load assembly from specific location
			Assembly assm1 = Assembly.LoadFrom("./Reflection.exe");

			Type[] typess = assm1.GetTypes ();
			foreach (Type t in typess) {
				Console.WriteLine (t.Name);
			}


		}

	}


	class MainClass
	{
		public static void Main1 (string[] args)
		{
			Util.UseType ();
//			Util.UseType1 ();

		}
	}

}


