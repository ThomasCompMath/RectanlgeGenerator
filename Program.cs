// Unsure where I want this to go. I just want more practice with objects.

using System;

namespace OOP_Practice
{
	public class Rectangle
	{
		public double Width { get; private set; }
		public double Height { get; private set; }
		
		
		public Rectangle(double width, double height)
		{
			Width = width;
			Height = height;
		}
		
		public void Area()
		{
			Console.WriteLine("The area of the rectangle is: " + this.Width * this.Height);
		}
		
		public void Draw()
		{
			Console.WriteLine();
			string stars = "";
			for ( int i = 0; i < this.Width; i++ )
				{
					stars += "*";
				}
			for ( int j = 0; j < this.Height; j++ )
			{
				Console.WriteLine(stars);
			}
			Console.WriteLine();			
		}
	}
	public class Program
	{
		static void Main(string[] args)
		{
			var rectangle01 = new Rectangle(5, 6);
			rectangle01.Draw();
			rectangle01.Area();
		
			var rectangle02 = new Rectangle(3, 3);
			rectangle02.Draw();
			rectangle02.Area();
		}		
	}

}