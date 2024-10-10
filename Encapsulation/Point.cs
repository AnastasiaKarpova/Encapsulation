using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Point
	{
		#region MyRegion
		//double x;
		//double y;
		//public double X //Property
		//{
		//	get
		//	{
		//		return x;
		//	}
		//	set
		//	{
		//		if (value > 200) value = 200;
		//		x = value; //ключевое слово value дает принимаемое значение
		//	}
		//}
		//public double Y 
		//{
		//	get
		//	{
		//		return y;
		//	}
		//	set
		//	{
		//		if (value > 150) value = 150;
		//		y = value; 
		//	}
		//}
		//public double GetX()
		//{ 
		//	return x; 
		//}
		//public double GetY() 
		//{ 
		//	return y; 
		//}
		//public void SetX(double x)
		//{ 
		//	if(x > 200) x = 200; 
		//	this.x = x; 
		//}
		//public void SetY(double y)
		//{
		//	if (y > 150) y = 150;
		//	this.y = y; 
		//} 
		#endregion

		public double X {  get; set; } //Автосвойства
		public double Y { get; set; }

		#region MyRegion
		//public Point(double x = 0, double y = 0)
		//{  X = x; Y = y; Console.WriteLine("Constructor"); }
		//public Point(Point other)
		//{
		//	this.X = other.X;
		//	this.Y = other.Y;
		//}
		//~Point()
		//{
		//	Console.WriteLine("Destructor");
		//} 
		#endregion
		public double Distance(Point dist)
		{
			double x_distance = this.X - dist.X;
			double y_distance = this.Y - dist.Y;
			double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
			return distance;
		}
		public static double distance(Point A, Point B)
		{
			double x_distance = A.X - B.X;
			double y_distance = A.Y - B.Y;
			double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
			return distance;
		}

		public void Print()
		{
			Console.WriteLine($"X = {X}\tY = {Y}");
			//Console.WriteLine($"X = {GetX()}\tY = {GetY()}");
		}
		
	}
	
}
