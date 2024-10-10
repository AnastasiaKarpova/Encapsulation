using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();
			Point B = new Point();
			//Console.WriteLine($"X = {A.GetX()}\tY = {A.GetY()}");
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();

			A.X = 22;
			A.Y = 33;
			A.Print();
			B.X = 67;
			B.Y = 49;
			B.Print();

			Console.WriteLine($"Расстояние от точки 'A' до точки 'B': " + A.Distance(B));
			Console.WriteLine($"Расстояние от точки 'B' до точки 'A': " + B.Distance(A));
			//Console.WriteLine($"Расстояние между точками 'A' и 'B': " + distance(A, B));
			//Console.WriteLine($"Расстояние между точками 'B' и 'A': " + distance(B, A));
		}
	}
}
