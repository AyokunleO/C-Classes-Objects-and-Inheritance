using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3,4);

            Console.WriteLine($"The Perimeter of the Rectangle is {rectangle.Perimeter}");

            Console.WriteLine($"The Area of the Rectangle is {rectangle.Area}");

        }
    }
}
