//#define DISTANCE
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
#if DISTANCE
			Point A = new Point();
			//Point B = new Point();
			//Console.WriteLine($"X = {A.GetX()}\tY = {A.GetY()}");
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();

			A.X = 22;
			A.Y = 33;
			A.Print();
			//B.X = 67;
			//B.Y = 49;
			//B.Print();
			Point B = new Point(A); //CopyConstructor
			B.Print();

			Point C; //Это не объект, а ссылка на объект
			C = new Point (B); //Объект можно создать только при помощи оператора new
			C.Print();

			Console.WriteLine($"Расстояние от точки 'A' до точки 'B': " + A.Distance(B));
			Console.WriteLine($"Расстояние от точки 'B' до точки 'A': " + B.Distance(A));
			//Console.WriteLine($"Расстояние между точками 'A' и 'B': " + distance(A, B));
			//Console.WriteLine($"Расстояние между точками 'B' и 'A': " + distance(B, A));  
#endif
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			Point C = new Point(A + B);
			C.Print();
			Point D = new Point(A - B);
			D.Print();

			for(Point i = new Point(); i.X<10; i++)
			{
				i.Print();
			}
		}
	}
}
