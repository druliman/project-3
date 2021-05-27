using System;

namespace ConsoleApp11
{
		class Program
		{
			static void Main(string[] args)
			{
				Console.WriteLine("Hello World!");
			}
		}
		class Triangle : Figure
		{
			public Triangle(Point a, Point b, Point c)
			{
				arr = new Point[3];
				arr[0] = a;
				arr[1] = b;
				arr[2] = c;
			}
			public override void createfigura()
			{

			}
		public override void Perimeter()
		{
			double AC,AB,BC;//storona
			AC = Math.Sqrt(Math.Pow((arr[0].x - arr[2].x), 2) + Math.Pow((arr[0].y - arr[2].y), 2));
			AB = Math.Sqrt(Math.Pow((arr[0].x - arr[1].x), 2) + Math.Pow((arr[0].y - arr[1].y), 2));
			BC = Math.Sqrt(Math.Pow((arr[1].x - arr[2].x), 2) + Math.Pow((arr[1].y - arr[2].y), 2));
			double R = Math.Sqrt(Math.Pow((arr[0].x - arr[1].x), 2) + Math.Pow((arr[0].y - arr[1].y), 2));
			double perimeter = AB + AC + BC;
			Console.WriteLine(" perimeter = " + perimeter);
			double Ploshchad = perimeter + R;
			Console.WriteLine(" Ploshchad = " + Ploshchad);
		}
	}

		class Square : Figure
		{

			public Square(Point a, Point b, Point c, Point d)
			{
				arr = new Point[4];
				arr[0] = a;
				arr[1] = b;
				arr[2] = c;
				arr[3] = d;
			}
			public override void createfigura()
			{

			}
			public override void Perimeter()
			{
			 double A;//storona
			 A = Math.Sqrt(Math.Pow((arr[0].x - arr[1].x), 2) + Math.Pow((arr[0].y - arr[1].y), 2));
			 double perimeter = 4 * A;
			 Console.WriteLine(" perimeter = " + perimeter);
			 double Ploshchad = A * A;
			 Console.WriteLine(" Ploshchad = " + Ploshchad);
		}
		}

		class Oval : Figure
		{
			public Oval(Point center, int R, Point a, Point b, Point c, Point d)
			{
				arr = new Point[5];
				arr[0] = center;
				arr[1] = a;
				arr[2] = b;
				arr[3] = c;
				arr[4] = d;
			}
			public override void createfigura()
			{

			}
			public override void Perimeter()
			{
			double A,B, п = 3.14;//storona
				A = Math.Sqrt(Math.Pow((arr[0].x - arr[1].x), 2 )+ Math.Pow((arr[0].y - arr[1].y), 2));
				B = Math.Sqrt(Math.Pow((arr[0].x - arr[2].x), 2)+ Math.Pow((arr[0].y - arr[2].y), 2));
				double perimeter = 2* п*Math.Sqrt(Math.Pow((A+B),2)/2);
				Console.WriteLine(" perimeter = " + perimeter);
				double Ploshchad = п*A*B;
				Console.WriteLine(" Ploshchad = " + Ploshchad);
		}
	}

			class Circle : Figure
			{
				public Circle(Point center, Point point)
				{
					arr = new Point[1];
					arr[0] = center;
					arr[1] = point;
				}
				public override void createfigura()
				{

				}
			public override void Perimeter()
			{
				double п = 3.14;//storona
				double R = Math.Sqrt(Math.Pow((arr[0].x - arr[1].x), 2) + Math.Pow((arr[0].y - arr[1].y), 2));
				double perimeter = 2 * п * R;
				Console.WriteLine(" perimeter = " + perimeter);
			}	
	}

		class Figure
		{
			public Point[] arr;

			public Figure()
			{

			}
			public virtual void createfigura()
			{
				//аrchеr
			}
		public virtual void Perimeter()
		{
			//какое либо действие
		}
	}
		class Point
		{
			public double x, y;
			public Point(double x, double y)
			{
				this.x = x;
				this.x = y;
			}
		}
		class Line
		{
			public int width = 0,height = 0;
			public Line(int width, int height)
			{
				this.height = height;
				this.width = width;
			}
		}
}

	

