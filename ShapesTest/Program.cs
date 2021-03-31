using System;

namespace ShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value of X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(x,y);
            Square square = new Square(x,y);
            Cube cube = new Cube(x,y);
            Triangle triangle = new Triangle(x,y);

            Console.WriteLine($"The area of rectangle is {rectangle.Area()}");
            Console.WriteLine($"The area of square is {square.Area()}");
            Console.WriteLine($"The area of cube is {cube.Area()}");
            Console.WriteLine($"The area of traingle is {triangle.Area()}");


        }
    }
}
